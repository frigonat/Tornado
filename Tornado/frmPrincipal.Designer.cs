namespace Tornado
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFechaUltimoProceso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCantidadPedidosPendientes = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAuditorias = new System.Windows.Forms.DataGridView();
            this.colIdAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaArchivoGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaCantidadDeRegistros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefrescar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(731, 650);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(306, 155);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTiempoTranscurrido);
            this.groupBox4.Location = new System.Drawing.Point(493, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempo Transcurrido";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(16, 45);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(38, 15);
            this.lblTiempoTranscurrido.TabIndex = 0;
            this.lblTiempoTranscurrido.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFechaUltimoProceso);
            this.groupBox3.Location = new System.Drawing.Point(249, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha Ultimo Registro Procesado";
            // 
            // lblFechaUltimoProceso
            // 
            this.lblFechaUltimoProceso.AutoSize = true;
            this.lblFechaUltimoProceso.Location = new System.Drawing.Point(6, 45);
            this.lblFechaUltimoProceso.Name = "lblFechaUltimoProceso";
            this.lblFechaUltimoProceso.Size = new System.Drawing.Size(38, 15);
            this.lblFechaUltimoProceso.TabIndex = 0;
            this.lblFechaUltimoProceso.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCantidadPedidosPendientes);
            this.groupBox2.Location = new System.Drawing.Point(10, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "cantidad de Registros Pendientes";
            // 
            // lblCantidadPedidosPendientes
            // 
            this.lblCantidadPedidosPendientes.AutoSize = true;
            this.lblCantidadPedidosPendientes.Location = new System.Drawing.Point(6, 45);
            this.lblCantidadPedidosPendientes.Name = "lblCantidadPedidosPendientes";
            this.lblCantidadPedidosPendientes.Size = new System.Drawing.Size(38, 15);
            this.lblCantidadPedidosPendientes.TabIndex = 1;
            this.lblCantidadPedidosPendientes.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos Pendientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroPedido,
            this.colPropietario,
            this.colEstado,
            this.colNroOrden,
            this.colCodigoAlmacen});
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 6);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowTemplate.Height = 25;
            this.dgvPedidos.Size = new System.Drawing.Size(704, 365);
            this.dgvPedidos.TabIndex = 0;
            // 
            // colNroPedido
            // 
            this.colNroPedido.HeaderText = "Nro.Pedido";
            this.colNroPedido.Name = "colNroPedido";
            // 
            // colPropietario
            // 
            this.colPropietario.HeaderText = "Propietario";
            this.colPropietario.Name = "colPropietario";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colNroOrden
            // 
            this.colNroOrden.HeaderText = "Nro.Orden";
            this.colNroOrden.Name = "colNroOrden";
            // 
            // colCodigoAlmacen
            // 
            this.colCodigoAlmacen.HeaderText = "Almacén";
            this.colCodigoAlmacen.Name = "colCodigoAlmacen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAuditorias);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejecuciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAuditorias
            // 
            this.dgvAuditorias.AllowUserToAddRows = false;
            this.dgvAuditorias.AllowUserToDeleteRows = false;
            this.dgvAuditorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAuditoria,
            this.colAuditoriaFechaInicio,
            this.colAuditoriaFechaFin,
            this.colAuditoriaDuracion,
            this.colAuditoriaArchivoGenerado,
            this.colAuditoriaCantidadDeRegistros});
            this.dgvAuditorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAuditorias.Location = new System.Drawing.Point(6, 6);
            this.dgvAuditorias.Name = "dgvAuditorias";
            this.dgvAuditorias.RowTemplate.Height = 25;
            this.dgvAuditorias.Size = new System.Drawing.Size(701, 365);
            this.dgvAuditorias.TabIndex = 0;
            // 
            // colIdAuditoria
            // 
            this.colIdAuditoria.HeaderText = "Id";
            this.colIdAuditoria.Name = "colIdAuditoria";
            // 
            // colAuditoriaFechaInicio
            // 
            this.colAuditoriaFechaInicio.HeaderText = "Fecha Inicio";
            this.colAuditoriaFechaInicio.Name = "colAuditoriaFechaInicio";
            // 
            // colAuditoriaFechaFin
            // 
            this.colAuditoriaFechaFin.HeaderText = "Fecha Finalización";
            this.colAuditoriaFechaFin.Name = "colAuditoriaFechaFin";
            this.colAuditoriaFechaFin.Width = 135;
            // 
            // colAuditoriaDuracion
            // 
            this.colAuditoriaDuracion.HeaderText = "Duración";
            this.colAuditoriaDuracion.Name = "colAuditoriaDuracion";
            // 
            // colAuditoriaArchivoGenerado
            // 
            this.colAuditoriaArchivoGenerado.HeaderText = "Archivo";
            this.colAuditoriaArchivoGenerado.Name = "colAuditoriaArchivoGenerado";
            // 
            // colAuditoriaCantidadDeRegistros
            // 
            this.colAuditoriaCantidadDeRegistros.HeaderText = "Registros";
            this.colAuditoriaCantidadDeRegistros.Name = "colAuditoriaCantidadDeRegistros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 721);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Tornado - v.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dgvPedidos;
        private GroupBox groupBox4;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridViewTextBoxColumn colNroPedido;
        private DataGridViewTextBoxColumn colPropietario;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colNroOrden;
        private DataGridViewTextBoxColumn colCodigoAlmacen;
        private Button btnRefrescar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvAuditorias;
        private DataGridViewTextBoxColumn colIdAuditoria;
        private DataGridViewTextBoxColumn colAuditoriaFechaInicio;
        private DataGridViewTextBoxColumn colAuditoriaFechaFin;
        private DataGridViewTextBoxColumn colAuditoriaDuracion;
        private DataGridViewTextBoxColumn colAuditoriaArchivoGenerado;
        private DataGridViewTextBoxColumn colAuditoriaCantidadDeRegistros;
        private Label lblTiempoTranscurrido;
        private Label lblFechaUltimoProceso;
        private Label lblCantidadPedidosPendientes;
    }
}