using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinidadDb;
using Trinidad.Auditoria;

namespace Tornado
{
    public class Auditoria
    {

        #region atributos

        /// <summary>
        /// Identificador del registro de auditoría.-
        /// </summary>
        private int id;

        /// <summary>
        /// Fecha de inicio registrada en la auditoría.-
        /// </summary>
        private DateTime fechaInicio;

        /// <summary>
        /// Fecha de finalización registrada en la auditoría.-
        /// </summary>
        private DateTime fechaFin;

        /// <summary>
        /// Duración (en minutos) de la ejecución.-
        /// </summary>
        private int duracion;

        /// <summary>
        /// Cantidad de Registros Procesados.-
        /// </summary>
        private int cantidadDeRegistros;

        /// <summary>
        /// Nombre del archivo CSV generado.-
        /// </summary>
        private string archivo;

        #endregion

        #region propiedades
        
        /// <summary>
        /// Obtiene el identificador del registro de auditoría.-
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Obtiene la fecha de inicio registrada en la auditoría.-
        /// </summary>
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        /// <summary>
        /// Obtiene la fecha de finalización registrada en la auditoría.-
        /// </summary>
        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        /// <summary>
        /// Obtiene la duración (en minutos) de la ejecución registrada en la auditoría.-
        /// </summary>
        public int Duracion
        {
            get { return duracion; }
        }

        /// <summary>
        /// Obtiene la cantidad de registros procesados por la ejecución registrada en la auditoría.-
        /// </summary>
        public int CantidadDeRegistros
        {
            get { return cantidadDeRegistros; }
        }

        /// <summary>
        /// Obtiene el nombre del archivo generado durante la ejecución registrada en la auditoría.-
        /// </summary>
        public string Archivo
        {
            get { return archivo; }
        }

        #endregion


        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "Tornado";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Auditoría";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBuscado"></param>
        /// <exception cref="IdNoValidoException"></exception>
        /// <exception cref="Exception"></exception>
        /// <exception cref="PedidoNoEncontradoException"></exception>
        public Auditoria(int idBuscado)
        {
            string iSQL = "*Ninguna";
            string mensaje = "";
            DataTable registroBuscado;
            Connection cn;

            //Valida que el id recibido sea válido.-
            if (idBuscado <= 0)
                throw new IdNoValidoException("El identificador de auditoría informado no es válido");

            try
            {
                cn = new Connection();
                cn.ConnectionStringBuilder();
                cn.Open();

                iSQL = "SELECT * FROM SSIS_Auditoria ";
                iSQL += "WHERE idAuditoria = " + idBuscado;
                registroBuscado = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar el reigstro de auditoría con el identificador " + idBuscado.ToString() + ". Mensajes posteriores pueden contener mayor información.-";
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

            if (registroBuscado.Rows.Count != 0)
            {
                this.id = registroBuscado.Rows[0].Field<int>("idAuditoria");
                this.fechaInicio = registroBuscado.Rows[0].Field<DateTime>("fecha");
                this.duracion = registroBuscado.Rows[0].Field<int>("DuracionMinutos");
                this.archivo = registroBuscado.Rows[0].Field<string>("archivo");

                if (registroBuscado.Rows[0].Field<object>("registros") is null)
                    this.cantidadDeRegistros = 0;
                else
                    this.cantidadDeRegistros = registroBuscado.Rows[0].Field<int>("registros");

                if (registroBuscado.Rows[0].Field<object>("registros") is null)
                    this.fechaFin = new DateTime(1900,1,1,0,0,0);
                else
                    this.fechaFin = registroBuscado.Rows[0].Field<DateTime>("FechaFin");

            }
            else
            {
                mensaje = "No se ha encontrado un eigstro de auditoría con el identificador especificado (" + idBuscado.ToString() + ")";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
                throw new PedidoNoEncontradoException(mensaje);
            }
        }

        /// <summary>
        /// Obtiene los últimos 15 registros de auditoría para la interfase.-
        /// </summary>
        /// <returns></returns>
        public static List<Auditoria> Obtener()
        {
            List<Auditoria> listaParaDevolver = new List<Auditoria>();

            string iSQL = "SELECT TOP(15) * FROM SSIS_Auditoria ";
            iSQL += "WHERE idInterfaz = 125 ";
            iSQL += "AND cliente = 'ST JUDE' ";
            iSQL += "ORDER BY idAuditoria DESC";

            listaParaDevolver = obtener(iSQL);

            return listaParaDevolver;
        }

        /// <summary>
        /// Obtiene el último registro de auditoría existente en la base de datos.-
        /// </summary>
        /// <returns></returns>
        public static Auditoria ObtenerUltima()
        {
            string iSQL = "SELECT TOP(1) * FROM SSIS_Auditoria ";
            iSQL += "WHERE idInterfaz = 125 ";
            iSQL += "AND cliente = 'ST JUDE' ";
            iSQL += "ORDER BY idAuditoria DESC";

            return Auditoria.obtener(iSQL)[0];
        }

        /// <summary>
        /// Ejecuta la instrucción SQL recibida y devuelve una lista de registros de auditoría.-
        /// </summary>
        /// <param name="iSQL">Instrucción SQL para ejecutar.-</param>
        /// <returns></returns>
        private static List<Auditoria> obtener(string iSQL)
        {
            List<Auditoria> listaParaDevolver = new List<Auditoria>();

            string mensaje = "";
            DataTable auditoriasEncontradas = null;
            Connection cn;

            try
            {
                cn = new Connection();
                cn.ConnectionStringBuilder();
                cn.Open();
                auditoriasEncontradas = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se han podido recuperar los registros de auditoría. Mensajes posteriores pueden contener mayor información.-";
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


            foreach (DataRow r in auditoriasEncontradas.Rows)
            {
                Auditoria a = new Auditoria(r.Field<int>("idAuditoria"));
                a.fechaInicio = a.fechaInicio.AddHours(-3);
                a.fechaFin = a.fechaFin.AddHours(-3);
                listaParaDevolver.Add(a); 
            }

            return listaParaDevolver;
        }
    }
}
