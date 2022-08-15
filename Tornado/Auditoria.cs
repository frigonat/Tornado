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
        private int id;

        private DateTime fechaInicio;

        private DateTime fechaFin;

        private int duracion;

        private int cantidadDeRegistros;

        private string archivo;

        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public int CantidadDeRegistros
        {
            get { return cantidadDeRegistros; }
        }

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

        public static List<Auditoria> Obtener()
        {
            List<Auditoria> listaParaDevolver = new List<Auditoria>();

            string iSQL = "SELECT TOP(10) * FROM SSIS_Auditoria ";
            iSQL += "WHERE idInterfaz = 125 ";
            iSQL += "AND cliente = 'ST JUDE' ";
            iSQL += "ORDER BY idAuditoria DESC";

            listaParaDevolver = obtener(iSQL);

            return listaParaDevolver;
        }

        public static Auditoria ObtenerUltima()
        {
            string iSQL = "SELECT TOP(1) * FROM SSIS_Auditoria ";
            iSQL += "WHERE idInterfaz = 125 ";
            iSQL += "AND cliente = 'ST JUDE' ";
            iSQL += "ORDER BY idAuditoria DESC";

            return Auditoria.obtener(iSQL)[0];
        }

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
                listaParaDevolver.Add(a);
            }

            return listaParaDevolver;
        }
    }
}
