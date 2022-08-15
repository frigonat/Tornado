using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tornado
{
    public partial class frmPrincipal : Form
    {
       
        public DateTime fechaNula = new DateTime(1900, 1, 1, 0, 0, 0);

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            List<Auditoria> lista = new List<Auditoria>();

            lista = Auditoria.Obtener();

            //Se muestra el tiempo Transcurrido
            if (lista[0].FechaFin == fechaNula)
            {
                lblFechaUltimoProceso.Text = lista[0].FechaInicio.ToString();
                TimeSpan ts = DateTime.Now - lista[0].FechaInicio;
                lblTiempoTranscurrido.Text = ts.ToString("hh\\:mm\\:ss");
            }
            else
            {
                lblFechaUltimoProceso.Text = lista[0].FechaFin.ToString();
                TimeSpan ts = DateTime.Now - lista[0].FechaFin;
                lblTiempoTranscurrido.Text = ts.ToString("hh\\:mm\\:ss");
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
            pedidos = Pedido.ObtenerPendientes();
            lblCantidadPedidosPendientes.Text = pedidos.Count.ToString();

            foreach (Pedido p in pedidos)
            {
                valores[0] = p.Numero;
                valores[1] = p.Propietario;
                valores[2] = p.Estado;
                //valores[3] = p.
                //valores[4] = p..Archivo;
                dgvPedidos.Rows.Add(valores);
            }
        }
    }
}
