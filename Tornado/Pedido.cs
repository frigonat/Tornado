using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using TrinidadDb;
using Trinidad.Auditoria;

namespace Tornado
{

    /// <summary>
    /// Modela un pedido de St.Jude para que su confirmación pueda re-procesarse según el estado.-
    /// </summary>
    public class Pedido
    {

        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "clases";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Pedido";

        private string rutaArchivoIni;

        private string nombreArchivoIni = "TrinidadDb_SCE.ini";

        #region atributos

        /// <summary>
        /// Número del pedido.-
        /// </summary>
        private string numero;

        /// <summary>
        /// Propietario del pedido.-
        /// </summary>
        private string propietario;

        /// <summary>
        /// Estado del pedido.-
        /// </summary>
        private EstadosDePedido estado;

        /// <summary>
        /// Usuario de alta del pedido.-
        /// </summary>
        private string usuarioDeAlta;

        /// <summary>
        /// Fecha de alta del pedido.-
        /// </summary>
        private DateTime fechaDeAlta;

        /// <summary>
        /// Nro. de Corrida de la interfase que envió el pedido al cliente.-
        /// </summary>
        private string nroCorrida;

        /// <summary>
        /// Fecha en la que se ejecutó la corrida de la interfase.-
        /// </summary>
        private DateTime fechaCorrida;

		private int cantidadDeIntentos;
		
		private string codigoAlmacen;
		
		private string numeroDeOrden;
		

        /// <summary>
        /// Líneas del pedido.-
        /// </summary>
        private List<LineaDePedido> lineas;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número del pedido.-
        /// </summary>
        public string Numero 
        { 
            get { return this.numero; } 
        }

        /// <summary>
        /// Obtiene el propietario del pedido.-
        /// </summary>
        public string Propietario
        {
            get { return this.propietario; }
        }

        /// <summary>
        /// Obtiene el estado del pedido.-
        /// </summary>
        public EstadosDePedido Estado
        {
            get { return this.estado; }
        }

        /// <summary>
        /// Obtiene el usuario de alta del pedido.-
        /// </summary>
        public string UsuarioDeAlta
        {
            get { return this.usuarioDeAlta; }
        }

        /// <summary>
        /// Obtiene la fecha de alta del pedido.-
        /// </summary>
        public DateTime FechaDeAlta
        {
            get { return this.fechaDeAlta; }
        }

        /// <summary>
        /// Obtiene el número de corrida de la interfase que procesó el pedido.-
        /// </summary>
        public string NumeroDeCorrida
        {
            get { return this.nroCorrida; }
        }

        /// <summary>
        /// Obtiene la fecha de la corrida de la interfase.-
        /// </summary>
        public DateTime FechaDeCorrida
        {
            get { return this.fechaCorrida; }
        }

        #endregion

        /// <summary>
        /// Cosntructor. Genera una nueva instancia de la clase según el número recibido como parámetro.-
        /// </summary>
        /// <param name="numeroBuscado">Número del pedido que se desea recuperar.</param>
        /// <exception cref="IdNoValidoException">Excepción que se arroja cuando se detecta que el id recibido no es válido.</exception>
        /// <exception cref="PedidoNoEncontradoException"></exception>
        /// <exception cref="Exception">Excepción genérica que ocurre si no puede recuperarse el pedido.-</exception>
        public Pedido(string numeroBuscado)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            rutaArchivoIni = Path.GetDirectoryName(myAssembly.Location) + "\\";
            nombreArchivoIni = nombreArchivoIni;

            string iSQL = "*Ninguna";
            string mensaje = "";
            DataTable pedidoBuscado;
            Connection cn;

            //Valida que el id recibido sea válido.-
            if (numeroBuscado.Length <=0 )
                throw new IdNoValidoException("El número de pedido informado no es válido");

            try
            {
                cn = new Connection(nombreArchivoIni, rutaArchivoIni);
                //cn.ConnectionStringBuilder();
                cn.Open();

                iSQL = "SELECT * FROM [INTERFACES_LPFAD].[dbo].[125_ConfirmacionDePicking] ";
                iSQL += "WHERE PAP_WHSEID = 'wmwhse1' AND PAP_STORERKEY = 'ST JUDE' AND PAP_EXTERNORDERKEY = '" + numeroBuscado + "'";
                pedidoBuscado = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar el pedido con el número " + numeroBuscado.ToString() + ". Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = excepcionActual.InnerException;
                }

                //Se arroja la excepción para que la procese el método llamador.-
                throw new Exception(ex.Message);
            }

            if (pedidoBuscado.Rows.Count != 0)
            {
                this.numero = pedidoBuscado.Rows[0].Field<string>("PAP_EXTERNORDERKEY");
                this.propietario = pedidoBuscado.Rows[0].Field<string>("PAP_STORERKEY");
                this.usuarioDeAlta = pedidoBuscado.Rows[0].Field<string>("ADDWHO");
                this.fechaDeAlta = pedidoBuscado.Rows[0].Field<DateTime>("ADDDATE");

                if (pedidoBuscado.Rows[0]["NroCorrida"] is DBNull)
                {
                    this.nroCorrida = "";
                    this.fechaCorrida = new DateTime(0);
                }
                else
                {
                    this.nroCorrida = pedidoBuscado.Rows[0].Field<Guid>("NroCorrida").ToString();
                    this.fechaCorrida = pedidoBuscado.Rows[0].Field<DateTime>("FechaInterfaz");
                }


                EstadosDePedido estadoActual;
                if (Enum.TryParse(pedidoBuscado.Rows[0].Field<int>("PAP_PROCESS").ToString(), out estadoActual))
                {
                    if (Enum.IsDefined(typeof(EstadosDePedido), estadoActual))
                    {
                        this.estado = estadoActual;
                    }
                    else
                    {
                        mensaje = "No se puede determinar el estado del pedido " + this.Numero;
                        Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                        throw new PedidoNoValidoException(mensaje);
                    }
                }

                //Creación de las líneas.-
                this.lineas = new List<LineaDePedido>();
                
                foreach (DataRow dr in pedidoBuscado.Rows)
                {
                    int xLinea = System.Convert.ToInt32(dr.Field<string>("PAP_DLINENO"));
                    string xSKU = dr.Field<string>("PAP_DSKU");
                    decimal xCantidad = dr.Field<decimal>("PAP_DOPENQTY");
                    LineaDePedido nuevaLinea = null; 
                    if (dr.Field<string>("PAP_DLOTTABLE02") != "")
                    {
                        nuevaLinea = new LineaDePedido(xLinea, xSKU, xCantidad, dr.Field<string>("PAP_DUOM"), dr.Field<string>("PAP_DLOTTABLE02"), dr.Field<string>("PAP_DLOTTABLE03"), new DateTime(1900, 1, 1, 0, 0, 0));
                    }
                    else
                    {
                        nuevaLinea = new LineaDePedido(xLinea, xSKU, xCantidad, dr.Field<string>("PAP_DUOM"), dr.Field<string>("PAP_DLOTTABLE02"), dr.Field<string>("PAP_DLOTTABLE03"), dr.Field<DateTime>("PAP_DLOTTABLE05"));
                    }
                    this.lineas.Add(nuevaLinea);
                }
            }
            else
            {
                mensaje = "No se ha encontrado un pedido con el ID especificado (" + numeroBuscado.ToString() + ")";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
                throw new PedidoNoEncontradoException(mensaje);
            }
        }

        /// <summary>
        /// Retorna una lista con las líneas del pedido.-
        /// </summary>
        /// <returns></returns>
        public List<LineaDePedido> ObtenerLineas()
        {
            return this.lineas;
        }

        /// <summary>
        /// LIbera el pedido para que pueda ser procesado nuevamente por la interfaz.-
        /// </summary>
        public void LiberarPedido()
        {
            string iSQL = "";
            string mensaje = "";

            //Se arma la instrucción SQL a ejecutar.-
            iSQL = "update [INTERFACES_LPFAD].[dbo].[125_ConfirmacionDePicking] ";
            iSQL += "set PAP_PROCESS = 9, NroCorrida = NULL, FechaInterfaz = '1900-01-01 0:00:00' ";
            iSQL += "where PAP_EXTERNORDERKEY = '" + this.Numero + "' ";
            iSQL += "and PAP_WHSEID = 'wmwhse1' ";
            iSQL += "and PAP_STORERKEY = 'ST JUDE'";

            try
            {
                liberar(iSQL);
                liberarSeries();
                this.nroCorrida = "";
                this.fechaCorrida = new DateTime(0);
                this.estado = EstadosDePedido.Pendiente;
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido liberar el pedido " + this.Numero + ". Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                //Se arroja la excepción para que la procese el método llamador.-
                throw new PedidoNoActualizadoException(mensaje, ex);
            }

            mensaje = "Se ha liberado el pedido " + this.Numero + " satisfactoriamente.";
            Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
        }

        /// <summary>
        /// Libera las series del pedido.-
        /// </summary>
        private void liberarSeries()
        {
            string iSQL = "";
            string mensaje = "";

            //Se arma la instrucción SQL a ejecutar.-
            iSQL = "update [INTERFACES_LPFAD].[dbo].[125_ConfirmacionDePickingSeries] ";
            iSQL += "set PAP_PROCESS = 9, NroCorrida = NULL, FechaInterfaz = '1900-01-01 0:00:00' ";
            iSQL += "where PAP_EXTERNORDERKEY = '" + this.Numero + "' ";
            iSQL += "and PAP_WHSEID = 'wmwhse1' ";
            iSQL += "and PAP_STORERKEY = 'ST JUDE'";

            try
            {
                liberar(iSQL);
                this.nroCorrida = "";
                this.fechaCorrida = new DateTime(0);
                this.estado = EstadosDePedido.Pendiente;
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido liberar el pedido " + this.Numero + ". Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                //Se arroja la excepción para que la procese el método llamador.-
                throw new PedidoNoActualizadoException(mensaje, ex);
            }

            mensaje = "Se ha liberado el pedido " + this.Numero + " satisfactoriamente.";
            Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
        }

        /// <summary>
        /// Ejecuta la instrucción SQL recibida para liberar tanto la cabecera/líneas del pedido y/o las series del mismo.-
        /// </summary>
        /// <param name="iSQL"></param>
        private void liberar(string iSQL)
        {
            Connection cn;
            string mensaje = "";

            try
            {
                cn = new Connection();
                cn.ConnectionStringBuilder();
                cn.Open();
                cn.ExecuteNonQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido actualizar la base de datos. Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = excepcionActual.InnerException;
                }

                //Se arroja la excepción para que la procese el método llamador.-
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los pedidos pendientes de procesar. Si no los hubiese, devuelve la lista vacía.-
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> ObtenerPendientes()
        {
            List<Pedido> listaParaDevolver = new List<Pedido>();
            Assembly myAssembly = Assembly.GetExecutingAssembly();  
            string rutaArchivoIni = Path.GetDirectoryName(myAssembly.Location) + "\\";
            string nombreArchivoIni = "TrinidadDb_SCE.ini";

            string iSQL = "";
            string mensaje = "";
            DataTable pedidosBuscados = null;
            Connection cn;
            
            iSQL = "select * from [INTERFACES_LPFAD].[dbo].[125_ConfirmacionDePicking] ";
            iSQL += "where PAP_WHSEID = 'wmwhse1' ";
            iSQL += "and PAP_STORERKEY = 'ST JUDE'  ";
            iSQL += "and PAP_PROCESS = " + (int)EstadosDePedido.Pendiente;

            try
            {
                cn = new Connection(nombreArchivoIni, rutaArchivoIni);
                cn.Open();
                pedidosBuscados = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se han podido recuperar los pedidos pendientes. Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = excepcionActual.InnerException;
                }
            }

            foreach (DataRow r in pedidosBuscados.Rows)
            {
                if (r.Field<string>("PAP_EXTERNORDERKEY") is null)
                {
                    //do nothing
                }
                else
                {
                    Pedido p = new Pedido(r.Field<string>("PAP_EXTERNORDERKEY"));
                    listaParaDevolver.Add(p);
                }
            }

            return listaParaDevolver;
        }

    }
}
