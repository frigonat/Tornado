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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslAmbiente = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFormSizeAndLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.fraTiempoTranscurrido = new System.Windows.Forms.GroupBox();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.fraUltimoRegistroProcesado = new System.Windows.Forms.GroupBox();
            this.lblFechaUltimoProceso = new System.Windows.Forms.Label();
            this.fraCantidadDeRegistrosPendientes = new System.Windows.Forms.GroupBox();
            this.lblCantidadPedidosPendientes = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDeLineas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAuditorias = new System.Windows.Forms.DataGridView();
            this.colIdAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaArchivoGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditoriaCantidadDeRegistros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fraTiempoTranscurrido.SuspendLayout();
            this.fraUltimoRegistroProcesado.SuspendLayout();
            this.fraCantidadDeRegistrosPendientes.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslAmbiente,
            this.toolStripStatusLabel3,
            this.tslFormSizeAndLocation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // tslAmbiente
            // 
            this.tslAmbiente.AutoSize = false;
            this.tslAmbiente.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslAmbiente.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslAmbiente.Name = "tslAmbiente";
            this.tslAmbiente.Size = new System.Drawing.Size(122, 19);
            this.tslAmbiente.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // tslFormSizeAndLocation
            // 
            this.tslFormSizeAndLocation.AutoSize = false;
            this.tslFormSizeAndLocation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslFormSizeAndLocation.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslFormSizeAndLocation.Name = "tslFormSizeAndLocation";
            this.tslFormSizeAndLocation.Size = new System.Drawing.Size(290, 19);
            this.tslFormSizeAndLocation.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
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
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.fraTiempoTranscurrido);
            this.splitContainer1.Panel1.Controls.Add(this.fraUltimoRegistroProcesado);
            this.splitContainer1.Panel1.Controls.Add(this.fraCantidadDeRegistrosPendientes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(718, 648);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(304, 141);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(87, 34);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // fraTiempoTranscurrido
            // 
            this.fraTiempoTranscurrido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fraTiempoTranscurrido.Controls.Add(this.lblTiempoTranscurrido);
            this.fraTiempoTranscurrido.Location = new System.Drawing.Point(485, 26);
            this.fraTiempoTranscurrido.Name = "fraTiempoTranscurrido";
            this.fraTiempoTranscurrido.Size = new System.Drawing.Size(224, 100);
            this.fraTiempoTranscurrido.TabIndex = 3;
            this.fraTiempoTranscurrido.TabStop = false;
            this.fraTiempoTranscurrido.Text = "Tiempo Transcurrido";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempoTranscurrido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(3, 19);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(218, 78);
            this.lblTiempoTranscurrido.TabIndex = 0;
            this.lblTiempoTranscurrido.Text = "label2";
            this.lblTiempoTranscurrido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fraUltimoRegistroProcesado
            // 
            this.fraUltimoRegistroProcesado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraUltimoRegistroProcesado.Controls.Add(this.lblFechaUltimoProceso);
            this.fraUltimoRegistroProcesado.Location = new System.Drawing.Point(217, 26);
            this.fraUltimoRegistroProcesado.Name = "fraUltimoRegistroProcesado";
            this.fraUltimoRegistroProcesado.Size = new System.Drawing.Size(257, 100);
            this.fraUltimoRegistroProcesado.TabIndex = 2;
            this.fraUltimoRegistroProcesado.TabStop = false;
            this.fraUltimoRegistroProcesado.Text = "Fecha Ultimo Registro Procesado";
            // 
            // lblFechaUltimoProceso
            // 
            this.lblFechaUltimoProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaUltimoProceso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaUltimoProceso.ForeColor = System.Drawing.Color.Purple;
            this.lblFechaUltimoProceso.Location = new System.Drawing.Point(3, 19);
            this.lblFechaUltimoProceso.Name = "lblFechaUltimoProceso";
            this.lblFechaUltimoProceso.Size = new System.Drawing.Size(251, 78);
            this.lblFechaUltimoProceso.TabIndex = 0;
            this.lblFechaUltimoProceso.Text = "label1";
            this.lblFechaUltimoProceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fraCantidadDeRegistrosPendientes
            // 
            this.fraCantidadDeRegistrosPendientes.Controls.Add(this.lblCantidadPedidosPendientes);
            this.fraCantidadDeRegistrosPendientes.Location = new System.Drawing.Point(10, 26);
            this.fraCantidadDeRegistrosPendientes.Name = "fraCantidadDeRegistrosPendientes";
            this.fraCantidadDeRegistrosPendientes.Size = new System.Drawing.Size(201, 100);
            this.fraCantidadDeRegistrosPendientes.TabIndex = 1;
            this.fraCantidadDeRegistrosPendientes.TabStop = false;
            this.fraCantidadDeRegistrosPendientes.Text = "Cantidad de Registros Pendientes";
            // 
            // lblCantidadPedidosPendientes
            // 
            this.lblCantidadPedidosPendientes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadPedidosPendientes.ForeColor = System.Drawing.Color.Blue;
            this.lblCantidadPedidosPendientes.Location = new System.Drawing.Point(13, 35);
            this.lblCantidadPedidosPendientes.Name = "lblCantidadPedidosPendientes";
            this.lblCantidadPedidosPendientes.Size = new System.Drawing.Size(172, 36);
            this.lblCantidadPedidosPendientes.TabIndex = 1;
            this.lblCantidadPedidosPendientes.Text = "label1";
            this.lblCantidadPedidosPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 419);
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
            this.colCodigoAlmacen,
            this.colCantidadDeLineas,
            this.colFechaPedido});
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 3);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowTemplate.Height = 25;
            this.dgvPedidos.Size = new System.Drawing.Size(700, 413);
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
            // colCodigoAlmacen
            // 
            this.colCodigoAlmacen.HeaderText = "Almacén";
            this.colCodigoAlmacen.Name = "colCodigoAlmacen";
            // 
            // colCantidadDeLineas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.colCantidadDeLineas.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCantidadDeLineas.HeaderText = "# Líneas";
            this.colCantidadDeLineas.Name = "colCantidadDeLineas";
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFechaPedido.HeaderText = "Fecha";
            this.colFechaPedido.Name = "colFechaPedido";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAuditorias);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 419);
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
            this.dgvAuditorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAuditorias.Location = new System.Drawing.Point(3, 3);
            this.dgvAuditorias.Name = "dgvAuditorias";
            this.dgvAuditorias.RowTemplate.Height = 25;
            this.dgvAuditorias.Size = new System.Drawing.Size(700, 413);
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
            this.colAuditoriaCantidadDeRegistros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.colAuditoriaCantidadDeRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAuditoriaCantidadDeRegistros.HeaderText = "Registros";
            this.colAuditoriaCantidadDeRegistros.Name = "colAuditoriaCantidadDeRegistros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 721);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Tornado - v.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.LocationChanged += new System.EventHandler(this.frmPrincipal_LocationChanged);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fraTiempoTranscurrido.ResumeLayout(false);
            this.fraUltimoRegistroProcesado.ResumeLayout(false);
            this.fraCantidadDeRegistrosPendientes.ResumeLayout(false);
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
        private GroupBox fraUltimoRegistroProcesado;
        private GroupBox fraCantidadDeRegistrosPendientes;
        private DataGridView dgvPedidos;
        private GroupBox fraTiempoTranscurrido;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnRefrescar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvAuditorias;
        private Label lblTiempoTranscurrido;
        private Label lblFechaUltimoProceso;
        private Label lblCantidadPedidosPendientes;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tslAmbiente;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel tslFormSizeAndLocation;
        private DataGridViewTextBoxColumn colNroPedido;
        private DataGridViewTextBoxColumn colPropietario;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colCodigoAlmacen;
        private DataGridViewTextBoxColumn colCantidadDeLineas;
        private DataGridViewTextBoxColumn colFechaPedido;
        private DataGridViewTextBoxColumn colIdAuditoria;
        private DataGridViewTextBoxColumn colAuditoriaFechaInicio;
        private DataGridViewTextBoxColumn colAuditoriaFechaFin;
        private DataGridViewTextBoxColumn colAuditoriaDuracion;
        private DataGridViewTextBoxColumn colAuditoriaArchivoGenerado;
        private DataGridViewTextBoxColumn colAuditoriaCantidadDeRegistros;
    }
}