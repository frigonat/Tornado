using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConfigClassLibrary;

namespace Tornado
{
    public partial class frmPrincipal : Form
    {
        private AppConfig myConfig;
        private Assembly myAssembly;
        private string rutaConfig;
        private string archivoConfig;
        private ContextMenuStrip cmPedidos;
        private ContextMenuStrip cmEjecuciones;
        public DateTime fechaNula = new DateTime(1900, 1, 1, 0, 0, 0);
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;   
            List<Auditoria> lista = new List<Auditoria>();
            TimeSpan ts;

            lista = Auditoria.Obtener();

            //Se muestra el tiempo Transcurrido
            if (lista[0].FechaFin == fechaNula)
            {
                lblFechaUltimoProceso.Text = lista[0].FechaInicio.ToString("dd.MM.yyyy HH:mm:ss");
                ts = DateTime.Now - lista[0].FechaInicio;
                lblTiempoTranscurrido.Text = ts.ToString("hh\\:mm\\:ss");
            }
            else
            {
                lblFechaUltimoProceso.Text = lista[0].FechaFin.ToString("dd.MM.yyyy HH:mm:ss");
                ts = DateTime.Now - lista[0].FechaFin;
                lblTiempoTranscurrido.Text = ts.ToString("hh\\:mm\\:ss");
            }

            int minutos = (int) ts.TotalMinutes;

            switch (minutos)
            {
                case >= 15:
                    lblTiempoTranscurrido.ForeColor = Color.Red;
                    break;
                case >= 5:
                    lblTiempoTranscurrido.ForeColor = Color.Gold;
                    break;
                default:
                    lblTiempoTranscurrido.ForeColor = Color.Green;
                    break;
            }


            dgvAuditorias.Rows.Clear();
            object[] valores = new object[7];
            foreach (Auditoria a in lista)
            {
                valores[0] = a.Id;
                valores[1] = a.FechaInicio.ToString();
                valores[2] = a.FechaFin.ToString();
                valores[3] = a.Duracion;
                valores[4] = a.Archivo;
                valores[5] = a.CantidadDeRegistros;
                dgvAuditorias.Rows.Add(valores);
            }

            List<Pedido> pedidos = new List<Pedido>();
            DateTime fechaLimite = new DateTime(2022, 08, 25);

            pedidos = Pedido.ObtenerPendientes();
            pedidos.RemoveAll(x => x.FechaDeAlta <= fechaLimite);
            lblCantidadPedidosPendientes.Text = pedidos.Count.ToString();

            dgvPedidos.Rows.Clear();
            foreach (Pedido p in pedidos)
            {
                valores[0] = p.Numero;
                valores[1] = p.Propietario;
                valores[2] = p.Estado;
                valores[3] = p.Almacen;
                valores[4] = p.CantidadDeLineas;
                valores[5] = p.FechaDeAlta.ToString("dd/MM/yyyy");
                dgvPedidos.Rows.Add(valores);
            }

            this.Cursor = Cursors.Default;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblCantidadPedidosPendientes.Text = "-";
            lblFechaUltimoProceso.Text = "-";
            lblTiempoTranscurrido.Text = "-";

            //Se configuran la ruta y el nombre del archivo de configuración.- 
            myAssembly = Assembly.GetExecutingAssembly();
            rutaConfig = Path.GetDirectoryName(myAssembly.Location);
            archivoConfig = "Tornado.ini";

            //Se configura el tamaño y posición del formulario.-
            setFormSizeAndLocation();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFormSizeAndLocation();
        }

        private void frmPrincipal_LocationChanged(object sender, EventArgs e)
        {
            updateFormSizeAndLocationData();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            updateFormSizeAndLocationData();
        }

        /*----------------------*/

        /// <summary>
        /// Sets the form size and location.-
        /// </summary>
        private void setFormSizeAndLocation()
        {
            FormWindowState WindowSate;
            string Width = "";
            string Height = "";
            string X = "";
            string Y = "";
            string splitterDistance = "";
            try
            {
                myConfig = new AppConfig(rutaConfig, archivoConfig, AppConfig.Formatos.ArchivoINI);
                Width = myConfig.DevolverValor(this.Name, "Width");
                Height = myConfig.DevolverValor(this.Name, "Height");
                X = myConfig.DevolverValor(this.Name, "X");
                Y = myConfig.DevolverValor(this.Name, "Y");
                //splitterDistance = myConfig.DevolverValor(this.Name, "SplitterDistance");

                Enum.TryParse(myConfig.DevolverValor(this.Name, "WindowState"), out WindowSate);

                this.WindowState = WindowSate;
                this.Size = new Size(System.Convert.ToInt32(Width), System.Convert.ToInt32(Height));
                this.Location = new Point(System.Convert.ToInt32(X), System.Convert.ToInt32(Y));
                this.splitContainer1.SplitterDistance = System.Convert.ToInt32(splitterDistance);
            }
            catch (Exception ex)
            {
                //do nothing.-
            }
        }

        /// <summary>
        /// Saves the form size and location.-
        /// </summary>
        private void saveFormSizeAndLocation()
        {
            myConfig = new AppConfig(rutaConfig, archivoConfig, AppConfig.Formatos.ArchivoINI);

            string clave = "";
            string valor = "";
            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        clave = "WindowState";
                        valor = this.WindowState.ToString();
                        break;
                    case 2:
                        clave = "Width";
                        valor = this.Width.ToString();
                        break;
                    case 3:
                        clave = "Height";
                        valor = this.Height.ToString();
                        break;
                    case 4:
                        clave = "X";
                        valor = this.Location.X.ToString();
                        break;
                    case 5:
                        clave = "Y";
                        valor = this.Location.Y.ToString();
                        break;
                    case 6:
                        clave = "SplitterDistance";
                        valor = this.splitContainer1.SplitterDistance.ToString();
                        break;
                    default:
                        break;
                }

                try
                {
                    myConfig.GuardarValor(this.Name, clave, valor);
                    myConfig.Grabar();
                }
                catch (AppConfigClassLibrary.ClaveNoEncontradaException)
                {
                    myConfig.AgregarLinea(this.Name, clave, valor);
                    myConfig.Grabar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar los datos de tamaño y posición del formulario.-", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Actualiza en la barra de estado los datos de ubicación y tamaño del formulario.-
        /// </summary>
        private void updateFormSizeAndLocationData()
        {
            tslFormSizeAndLocation.Text = "Size: " + this.Size.Width.ToString() + ", " + this.Size.Height.ToString();
            tslFormSizeAndLocation.Text += " | Location: " + this.Location.X.ToString() + ", " + this.Location.Y.ToString();
            tslFormSizeAndLocation.Text += " | " + this.splitContainer1.SplitterDistance.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
