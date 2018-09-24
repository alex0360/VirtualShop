namespace Precentacion
{
    partial class FormIngreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LNumero = new System.Windows.Forms.Label();
            this.DTPFecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.LFecha_Inicial = new System.Windows.Forms.Label();
            this.DTPFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.LFecha_Final = new System.Windows.Forms.Label();
            this.PBuscarProvedor = new System.Windows.Forms.Panel();
            this.BBuscarProveedor = new System.Windows.Forms.Button();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.lProveedor = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.LFecha = new System.Windows.Forms.Label();
            this.CBComprobante = new System.Windows.Forms.ComboBox();
            this.TBSerie = new System.Windows.Forms.TextBox();
            this.TBCorrelativo = new System.Windows.Forms.TextBox();
            this.LIvg = new System.Windows.Forms.Label();
            this.TBIgv = new System.Windows.Forms.TextBox();
            this.LComprobante = new System.Windows.Forms.Label();
            this.PComprobante = new System.Windows.Forms.Panel();
            this.GBArticulo = new System.Windows.Forms.GroupBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.LPrecio_compra = new System.Windows.Forms.Label();
            this.DTPFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.DTPFecha_Produccion = new System.Windows.Forms.DateTimePicker();
            this.TBPrecio_compra = new System.Windows.Forms.TextBox();
            this.LPrecio_venta = new System.Windows.Forms.Label();
            this.TBPrecio_venta = new System.Windows.Forms.TextBox();
            this.LFecha_Vencimiento = new System.Windows.Forms.Label();
            this.LStock_inicial = new System.Windows.Forms.Label();
            this.LFecha_Produccion = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.PBuscarArticulo = new System.Windows.Forms.Panel();
            this.BuscarArticulo = new System.Windows.Forms.Button();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.LArticulo = new System.Windows.Forms.Label();
            this.DGVListados_detalles = new System.Windows.Forms.DataGridView();
            this.LTotal = new System.Windows.Forms.Label();
            this.LTotal_Pagado = new System.Windows.Forms.Label();
            this.BBuscar_fecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.PBuscarProvedor.SuspendLayout();
            this.PComprobante.SuspendLayout();
            this.GBArticulo.SuspendLayout();
            this.PBuscarArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            resources.ApplyResources(this.BCancelar, "BCancelar");
            this.EPErrorIcono.SetError(this.BCancelar, resources.GetString("BCancelar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.BCancelar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BCancelar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BCancelar, ((int)(resources.GetObject("BCancelar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.BCancelar, resources.GetString("BCancelar.ToolTip"));
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            resources.ApplyResources(this.BGuardar, "BGuardar");
            this.EPErrorIcono.SetError(this.BGuardar, resources.GetString("BGuardar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.BGuardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BGuardar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BGuardar, ((int)(resources.GetObject("BGuardar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.BGuardar, resources.GetString("BGuardar.ToolTip"));
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // EPErrorIcono
            // 
            resources.ApplyResources(this.EPErrorIcono, "EPErrorIcono");
            // 
            // LTitulo
            // 
            resources.ApplyResources(this.LTitulo, "LTitulo");
            this.EPErrorIcono.SetError(this.LTitulo, resources.GetString("LTitulo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LTitulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LTitulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LTitulo, ((int)(resources.GetObject("LTitulo.IconPadding"))));
            this.TTMensaje.SetToolTip(this.LTitulo, resources.GetString("LTitulo.ToolTip"));
            // 
            // BImprimir
            // 
            resources.ApplyResources(this.BImprimir, "BImprimir");
            this.EPErrorIcono.SetError(this.BImprimir, resources.GetString("BImprimir.Error"));
            this.EPErrorIcono.SetIconAlignment(this.BImprimir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BImprimir.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BImprimir, ((int)(resources.GetObject("BImprimir.IconPadding"))));
            this.TTMensaje.SetToolTip(this.BImprimir, resources.GetString("BImprimir.ToolTip"));
            // 
            // tabCon
            // 
            resources.ApplyResources(this.tabCon, "tabCon");
            this.EPErrorIcono.SetError(this.tabCon, resources.GetString("tabCon.Error"));
            this.EPErrorIcono.SetIconAlignment(this.tabCon, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabCon.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.tabCon, ((int)(resources.GetObject("tabCon.IconPadding"))));
            this.TTMensaje.SetToolTip(this.tabCon, resources.GetString("tabCon.ToolTip"));
            // 
            // LTotalRegistro
            // 
            resources.ApplyResources(this.LTotalRegistro, "LTotalRegistro");
            this.EPErrorIcono.SetError(this.LTotalRegistro, resources.GetString("LTotalRegistro.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LTotalRegistro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LTotalRegistro.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LTotalRegistro, ((int)(resources.GetObject("LTotalRegistro.IconPadding"))));
            this.TTMensaje.SetToolTip(this.LTotalRegistro, resources.GetString("LTotalRegistro.ToolTip"));
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.EPErrorIcono.SetError(this.tabPage2, resources.GetString("tabPage2.Error"));
            this.EPErrorIcono.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding"))));
            this.TTMensaje.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.BBuscar_fecha);
            this.tabPage1.Controls.Add(this.LFecha_Final);
            this.tabPage1.Controls.Add(this.DTPFecha_Final);
            this.tabPage1.Controls.Add(this.LFecha_Inicial);
            this.tabPage1.Controls.Add(this.DTPFecha_inicio);
            this.tabPage1.Controls.Add(this.DGVListado);
            this.EPErrorIcono.SetError(this.tabPage1, resources.GetString("tabPage1.Error"));
            this.EPErrorIcono.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding"))));
            this.TTMensaje.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BImprimir, 0);
            this.tabPage1.Controls.SetChildIndex(this.CBEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LTotalRegistro, 0);
            this.tabPage1.Controls.SetChildIndex(this.DGVListado, 0);
            this.tabPage1.Controls.SetChildIndex(this.DTPFecha_inicio, 0);
            this.tabPage1.Controls.SetChildIndex(this.LFecha_Inicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.DTPFecha_Final, 0);
            this.tabPage1.Controls.SetChildIndex(this.LFecha_Final, 0);
            this.tabPage1.Controls.SetChildIndex(this.BBuscar_fecha, 0);
            // 
            // GBMatenimiento
            // 
            resources.ApplyResources(this.GBMatenimiento, "GBMatenimiento");
            this.GBMatenimiento.Controls.Add(this.LTotal_Pagado);
            this.GBMatenimiento.Controls.Add(this.LTotal);
            this.GBMatenimiento.Controls.Add(this.DGVListados_detalles);
            this.GBMatenimiento.Controls.Add(this.GBArticulo);
            this.GBMatenimiento.Controls.Add(this.DTPFecha);
            this.GBMatenimiento.Controls.Add(this.PComprobante);
            this.GBMatenimiento.Controls.Add(this.PBuscarProvedor);
            this.GBMatenimiento.Controls.Add(this.TBIgv);
            this.GBMatenimiento.Controls.Add(this.LIvg);
            this.GBMatenimiento.Controls.Add(this.LFecha);
            this.EPErrorIcono.SetError(this.GBMatenimiento, resources.GetString("GBMatenimiento.Error"));
            this.EPErrorIcono.SetIconAlignment(this.GBMatenimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("GBMatenimiento.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.GBMatenimiento, ((int)(resources.GetObject("GBMatenimiento.IconPadding"))));
            this.TTMensaje.SetToolTip(this.GBMatenimiento, resources.GetString("GBMatenimiento.ToolTip"));
            this.GBMatenimiento.Controls.SetChildIndex(this.BGuardar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.BCancelar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LFecha, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LIvg, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBIgv, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.PBuscarProvedor, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.PComprobante, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DTPFecha, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.GBArticulo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DGVListados_detalles, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTotal, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTotal_Pagado, 0);
            // 
            // BEliminar
            // 
            resources.ApplyResources(this.BEliminar, "BEliminar");
            this.EPErrorIcono.SetError(this.BEliminar, resources.GetString("BEliminar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.BEliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BEliminar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BEliminar, ((int)(resources.GetObject("BEliminar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.BEliminar, resources.GetString("BEliminar.ToolTip"));
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            resources.ApplyResources(this.TBBuscar, "TBBuscar");
            this.EPErrorIcono.SetError(this.TBBuscar, resources.GetString("TBBuscar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBBuscar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBBuscar, ((int)(resources.GetObject("TBBuscar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.TBBuscar, resources.GetString("TBBuscar.ToolTip"));
            // 
            // LBuscar
            // 
            resources.ApplyResources(this.LBuscar, "LBuscar");
            this.EPErrorIcono.SetError(this.LBuscar, resources.GetString("LBuscar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LBuscar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LBuscar, ((int)(resources.GetObject("LBuscar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.LBuscar, resources.GetString("LBuscar.ToolTip"));
            // 
            // CBEliminar
            // 
            resources.ApplyResources(this.CBEliminar, "CBEliminar");
            this.EPErrorIcono.SetError(this.CBEliminar, resources.GetString("CBEliminar.Error"));
            this.EPErrorIcono.SetIconAlignment(this.CBEliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CBEliminar.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.CBEliminar, ((int)(resources.GetObject("CBEliminar.IconPadding"))));
            this.TTMensaje.SetToolTip(this.CBEliminar, resources.GetString("CBEliminar.ToolTip"));
            this.CBEliminar.CheckedChanged += new System.EventHandler(this.CBEliminar_CheckedChanged);
            // 
            // DGVListado
            // 
            resources.ApplyResources(this.DGVListado, "DGVListado");
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.BackgroundColor = System.Drawing.Color.White;
            this.DGVListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.EPErrorIcono.SetError(this.DGVListado, resources.GetString("DGVListado.Error"));
            this.DGVListado.GridColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetIconAlignment(this.DGVListado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DGVListado.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DGVListado, ((int)(resources.GetObject("DGVListado.IconPadding"))));
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TTMensaje.SetToolTip(this.DGVListado, resources.GetString("DGVListado.ToolTip"));
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagListado_CellContentClick);
            this.DGVListado.DoubleClick += new System.EventHandler(this.DGVListado_DoubleClick);
            // 
            // Eliminar
            // 
            resources.ApplyResources(this.Eliminar, "Eliminar");
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // LNumero
            // 
            resources.ApplyResources(this.LNumero, "LNumero");
            this.EPErrorIcono.SetError(this.LNumero, resources.GetString("LNumero.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LNumero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LNumero.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LNumero, ((int)(resources.GetObject("LNumero.IconPadding"))));
            this.LNumero.Name = "LNumero";
            this.TTMensaje.SetToolTip(this.LNumero, resources.GetString("LNumero.ToolTip"));
            // 
            // DTPFecha_inicio
            // 
            resources.ApplyResources(this.DTPFecha_inicio, "DTPFecha_inicio");
            this.EPErrorIcono.SetError(this.DTPFecha_inicio, resources.GetString("DTPFecha_inicio.Error"));
            this.DTPFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EPErrorIcono.SetIconAlignment(this.DTPFecha_inicio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DTPFecha_inicio.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DTPFecha_inicio, ((int)(resources.GetObject("DTPFecha_inicio.IconPadding"))));
            this.DTPFecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_inicio.Name = "DTPFecha_inicio";
            this.TTMensaje.SetToolTip(this.DTPFecha_inicio, resources.GetString("DTPFecha_inicio.ToolTip"));
            this.DTPFecha_inicio.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 217);
            // 
            // LFecha_Inicial
            // 
            resources.ApplyResources(this.LFecha_Inicial, "LFecha_Inicial");
            this.EPErrorIcono.SetError(this.LFecha_Inicial, resources.GetString("LFecha_Inicial.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LFecha_Inicial, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LFecha_Inicial.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LFecha_Inicial, ((int)(resources.GetObject("LFecha_Inicial.IconPadding"))));
            this.LFecha_Inicial.Name = "LFecha_Inicial";
            this.TTMensaje.SetToolTip(this.LFecha_Inicial, resources.GetString("LFecha_Inicial.ToolTip"));
            // 
            // DTPFecha_Final
            // 
            resources.ApplyResources(this.DTPFecha_Final, "DTPFecha_Final");
            this.EPErrorIcono.SetError(this.DTPFecha_Final, resources.GetString("DTPFecha_Final.Error"));
            this.DTPFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EPErrorIcono.SetIconAlignment(this.DTPFecha_Final, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DTPFecha_Final.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DTPFecha_Final, ((int)(resources.GetObject("DTPFecha_Final.IconPadding"))));
            this.DTPFecha_Final.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Final.Name = "DTPFecha_Final";
            this.TTMensaje.SetToolTip(this.DTPFecha_Final, resources.GetString("DTPFecha_Final.ToolTip"));
            this.DTPFecha_Final.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 221);
            // 
            // LFecha_Final
            // 
            resources.ApplyResources(this.LFecha_Final, "LFecha_Final");
            this.EPErrorIcono.SetError(this.LFecha_Final, resources.GetString("LFecha_Final.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LFecha_Final, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LFecha_Final.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LFecha_Final, ((int)(resources.GetObject("LFecha_Final.IconPadding"))));
            this.LFecha_Final.Name = "LFecha_Final";
            this.TTMensaje.SetToolTip(this.LFecha_Final, resources.GetString("LFecha_Final.ToolTip"));
            // 
            // PBuscarProvedor
            // 
            resources.ApplyResources(this.PBuscarProvedor, "PBuscarProvedor");
            this.PBuscarProvedor.Controls.Add(this.BBuscarProveedor);
            this.PBuscarProvedor.Controls.Add(this.TBProveedor);
            this.PBuscarProvedor.Controls.Add(this.lProveedor);
            this.EPErrorIcono.SetError(this.PBuscarProvedor, resources.GetString("PBuscarProvedor.Error"));
            this.EPErrorIcono.SetIconAlignment(this.PBuscarProvedor, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PBuscarProvedor.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.PBuscarProvedor, ((int)(resources.GetObject("PBuscarProvedor.IconPadding"))));
            this.PBuscarProvedor.Name = "PBuscarProvedor";
            this.TTMensaje.SetToolTip(this.PBuscarProvedor, resources.GetString("PBuscarProvedor.ToolTip"));
            // 
            // BBuscarProveedor
            // 
            resources.ApplyResources(this.BBuscarProveedor, "BBuscarProveedor");
            this.BBuscarProveedor.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.EPErrorIcono.SetError(this.BBuscarProveedor, resources.GetString("BBuscarProveedor.Error"));
            this.BBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EPErrorIcono.SetIconAlignment(this.BBuscarProveedor, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BBuscarProveedor.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BBuscarProveedor, ((int)(resources.GetObject("BBuscarProveedor.IconPadding"))));
            this.BBuscarProveedor.Name = "BBuscarProveedor";
            this.TTMensaje.SetToolTip(this.BBuscarProveedor, resources.GetString("BBuscarProveedor.ToolTip"));
            this.BBuscarProveedor.UseVisualStyleBackColor = true;
            this.BBuscarProveedor.Click += new System.EventHandler(this.BBuscarProveedor_Click);
            // 
            // TBProveedor
            // 
            resources.ApplyResources(this.TBProveedor, "TBProveedor");
            this.TBProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBProveedor, resources.GetString("TBProveedor.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBProveedor, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBProveedor.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBProveedor, ((int)(resources.GetObject("TBProveedor.IconPadding"))));
            this.TBProveedor.Name = "TBProveedor";
            this.TTMensaje.SetToolTip(this.TBProveedor, resources.GetString("TBProveedor.ToolTip"));
            // 
            // lProveedor
            // 
            resources.ApplyResources(this.lProveedor, "lProveedor");
            this.EPErrorIcono.SetError(this.lProveedor, resources.GetString("lProveedor.Error"));
            this.EPErrorIcono.SetIconAlignment(this.lProveedor, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lProveedor.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.lProveedor, ((int)(resources.GetObject("lProveedor.IconPadding"))));
            this.lProveedor.Name = "lProveedor";
            this.TTMensaje.SetToolTip(this.lProveedor, resources.GetString("lProveedor.ToolTip"));
            // 
            // DTPFecha
            // 
            resources.ApplyResources(this.DTPFecha, "DTPFecha");
            this.EPErrorIcono.SetError(this.DTPFecha, resources.GetString("DTPFecha.Error"));
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EPErrorIcono.SetIconAlignment(this.DTPFecha, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DTPFecha.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DTPFecha, ((int)(resources.GetObject("DTPFecha.IconPadding"))));
            this.DTPFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.TTMensaje.SetToolTip(this.DTPFecha, resources.GetString("DTPFecha.ToolTip"));
            this.DTPFecha.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 241);
            // 
            // LFecha
            // 
            resources.ApplyResources(this.LFecha, "LFecha");
            this.EPErrorIcono.SetError(this.LFecha, resources.GetString("LFecha.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LFecha, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LFecha.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LFecha, ((int)(resources.GetObject("LFecha.IconPadding"))));
            this.LFecha.Name = "LFecha";
            this.TTMensaje.SetToolTip(this.LFecha, resources.GetString("LFecha.ToolTip"));
            // 
            // CBComprobante
            // 
            resources.ApplyResources(this.CBComprobante, "CBComprobante");
            this.CBComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.CBComprobante, resources.GetString("CBComprobante.Error"));
            this.CBComprobante.FormattingEnabled = true;
            this.EPErrorIcono.SetIconAlignment(this.CBComprobante, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CBComprobante.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.CBComprobante, ((int)(resources.GetObject("CBComprobante.IconPadding"))));
            this.CBComprobante.Name = "CBComprobante";
            this.TTMensaje.SetToolTip(this.CBComprobante, resources.GetString("CBComprobante.ToolTip"));
            // 
            // TBSerie
            // 
            resources.ApplyResources(this.TBSerie, "TBSerie");
            this.TBSerie.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBSerie, resources.GetString("TBSerie.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBSerie, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBSerie.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBSerie, ((int)(resources.GetObject("TBSerie.IconPadding"))));
            this.TBSerie.Name = "TBSerie";
            this.TTMensaje.SetToolTip(this.TBSerie, resources.GetString("TBSerie.ToolTip"));
            // 
            // TBCorrelativo
            // 
            resources.ApplyResources(this.TBCorrelativo, "TBCorrelativo");
            this.TBCorrelativo.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBCorrelativo, resources.GetString("TBCorrelativo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBCorrelativo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBCorrelativo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBCorrelativo, ((int)(resources.GetObject("TBCorrelativo.IconPadding"))));
            this.TBCorrelativo.Name = "TBCorrelativo";
            this.TTMensaje.SetToolTip(this.TBCorrelativo, resources.GetString("TBCorrelativo.ToolTip"));
            // 
            // LIvg
            // 
            resources.ApplyResources(this.LIvg, "LIvg");
            this.EPErrorIcono.SetError(this.LIvg, resources.GetString("LIvg.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LIvg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LIvg.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LIvg, ((int)(resources.GetObject("LIvg.IconPadding"))));
            this.LIvg.Name = "LIvg";
            this.TTMensaje.SetToolTip(this.LIvg, resources.GetString("LIvg.ToolTip"));
            // 
            // TBIgv
            // 
            resources.ApplyResources(this.TBIgv, "TBIgv");
            this.TBIgv.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBIgv, resources.GetString("TBIgv.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBIgv, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBIgv.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBIgv, ((int)(resources.GetObject("TBIgv.IconPadding"))));
            this.TBIgv.Name = "TBIgv";
            this.TTMensaje.SetToolTip(this.TBIgv, resources.GetString("TBIgv.ToolTip"));
            // 
            // LComprobante
            // 
            resources.ApplyResources(this.LComprobante, "LComprobante");
            this.EPErrorIcono.SetError(this.LComprobante, resources.GetString("LComprobante.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LComprobante, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LComprobante.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LComprobante, ((int)(resources.GetObject("LComprobante.IconPadding"))));
            this.LComprobante.Name = "LComprobante";
            this.TTMensaje.SetToolTip(this.LComprobante, resources.GetString("LComprobante.ToolTip"));
            // 
            // PComprobante
            // 
            resources.ApplyResources(this.PComprobante, "PComprobante");
            this.PComprobante.Controls.Add(this.LComprobante);
            this.PComprobante.Controls.Add(this.LNumero);
            this.PComprobante.Controls.Add(this.CBComprobante);
            this.PComprobante.Controls.Add(this.TBSerie);
            this.PComprobante.Controls.Add(this.TBCorrelativo);
            this.EPErrorIcono.SetError(this.PComprobante, resources.GetString("PComprobante.Error"));
            this.EPErrorIcono.SetIconAlignment(this.PComprobante, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PComprobante.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.PComprobante, ((int)(resources.GetObject("PComprobante.IconPadding"))));
            this.PComprobante.Name = "PComprobante";
            this.TTMensaje.SetToolTip(this.PComprobante, resources.GetString("PComprobante.ToolTip"));
            // 
            // GBArticulo
            // 
            resources.ApplyResources(this.GBArticulo, "GBArticulo");
            this.GBArticulo.Controls.Add(this.BAdd);
            this.GBArticulo.Controls.Add(this.BDelete);
            this.GBArticulo.Controls.Add(this.LPrecio_compra);
            this.GBArticulo.Controls.Add(this.DTPFecha_Vencimiento);
            this.GBArticulo.Controls.Add(this.DTPFecha_Produccion);
            this.GBArticulo.Controls.Add(this.TBPrecio_compra);
            this.GBArticulo.Controls.Add(this.LPrecio_venta);
            this.GBArticulo.Controls.Add(this.TBPrecio_venta);
            this.GBArticulo.Controls.Add(this.LFecha_Vencimiento);
            this.GBArticulo.Controls.Add(this.LStock_inicial);
            this.GBArticulo.Controls.Add(this.LFecha_Produccion);
            this.GBArticulo.Controls.Add(this.TBStock);
            this.GBArticulo.Controls.Add(this.PBuscarArticulo);
            this.EPErrorIcono.SetError(this.GBArticulo, resources.GetString("GBArticulo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.GBArticulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("GBArticulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.GBArticulo, ((int)(resources.GetObject("GBArticulo.IconPadding"))));
            this.GBArticulo.Name = "GBArticulo";
            this.GBArticulo.TabStop = false;
            this.TTMensaje.SetToolTip(this.GBArticulo, resources.GetString("GBArticulo.ToolTip"));
            // 
            // BAdd
            // 
            resources.ApplyResources(this.BAdd, "BAdd");
            this.BAdd.BackgroundImage = global::Precentacion.Properties.Resources.add;
            this.EPErrorIcono.SetError(this.BAdd, resources.GetString("BAdd.Error"));
            this.BAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EPErrorIcono.SetIconAlignment(this.BAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BAdd.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BAdd, ((int)(resources.GetObject("BAdd.IconPadding"))));
            this.BAdd.Name = "BAdd";
            this.TTMensaje.SetToolTip(this.BAdd, resources.GetString("BAdd.ToolTip"));
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BDelete
            // 
            resources.ApplyResources(this.BDelete, "BDelete");
            this.BDelete.BackgroundImage = global::Precentacion.Properties.Resources.delete2;
            this.EPErrorIcono.SetError(this.BDelete, resources.GetString("BDelete.Error"));
            this.BDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EPErrorIcono.SetIconAlignment(this.BDelete, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BDelete.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BDelete, ((int)(resources.GetObject("BDelete.IconPadding"))));
            this.BDelete.Name = "BDelete";
            this.TTMensaje.SetToolTip(this.BDelete, resources.GetString("BDelete.ToolTip"));
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // LPrecio_compra
            // 
            resources.ApplyResources(this.LPrecio_compra, "LPrecio_compra");
            this.EPErrorIcono.SetError(this.LPrecio_compra, resources.GetString("LPrecio_compra.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LPrecio_compra, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LPrecio_compra.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LPrecio_compra, ((int)(resources.GetObject("LPrecio_compra.IconPadding"))));
            this.LPrecio_compra.Name = "LPrecio_compra";
            this.TTMensaje.SetToolTip(this.LPrecio_compra, resources.GetString("LPrecio_compra.ToolTip"));
            // 
            // DTPFecha_Vencimiento
            // 
            resources.ApplyResources(this.DTPFecha_Vencimiento, "DTPFecha_Vencimiento");
            this.EPErrorIcono.SetError(this.DTPFecha_Vencimiento, resources.GetString("DTPFecha_Vencimiento.Error"));
            this.DTPFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EPErrorIcono.SetIconAlignment(this.DTPFecha_Vencimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DTPFecha_Vencimiento.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DTPFecha_Vencimiento, ((int)(resources.GetObject("DTPFecha_Vencimiento.IconPadding"))));
            this.DTPFecha_Vencimiento.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Vencimiento.Name = "DTPFecha_Vencimiento";
            this.TTMensaje.SetToolTip(this.DTPFecha_Vencimiento, resources.GetString("DTPFecha_Vencimiento.ToolTip"));
            this.DTPFecha_Vencimiento.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 282);
            // 
            // DTPFecha_Produccion
            // 
            resources.ApplyResources(this.DTPFecha_Produccion, "DTPFecha_Produccion");
            this.EPErrorIcono.SetError(this.DTPFecha_Produccion, resources.GetString("DTPFecha_Produccion.Error"));
            this.DTPFecha_Produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EPErrorIcono.SetIconAlignment(this.DTPFecha_Produccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DTPFecha_Produccion.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DTPFecha_Produccion, ((int)(resources.GetObject("DTPFecha_Produccion.IconPadding"))));
            this.DTPFecha_Produccion.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Produccion.Name = "DTPFecha_Produccion";
            this.TTMensaje.SetToolTip(this.DTPFecha_Produccion, resources.GetString("DTPFecha_Produccion.ToolTip"));
            this.DTPFecha_Produccion.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 285);
            // 
            // TBPrecio_compra
            // 
            resources.ApplyResources(this.TBPrecio_compra, "TBPrecio_compra");
            this.TBPrecio_compra.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBPrecio_compra, resources.GetString("TBPrecio_compra.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBPrecio_compra, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBPrecio_compra.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBPrecio_compra, ((int)(resources.GetObject("TBPrecio_compra.IconPadding"))));
            this.TBPrecio_compra.Name = "TBPrecio_compra";
            this.TTMensaje.SetToolTip(this.TBPrecio_compra, resources.GetString("TBPrecio_compra.ToolTip"));
            // 
            // LPrecio_venta
            // 
            resources.ApplyResources(this.LPrecio_venta, "LPrecio_venta");
            this.EPErrorIcono.SetError(this.LPrecio_venta, resources.GetString("LPrecio_venta.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LPrecio_venta, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LPrecio_venta.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LPrecio_venta, ((int)(resources.GetObject("LPrecio_venta.IconPadding"))));
            this.LPrecio_venta.Name = "LPrecio_venta";
            this.TTMensaje.SetToolTip(this.LPrecio_venta, resources.GetString("LPrecio_venta.ToolTip"));
            // 
            // TBPrecio_venta
            // 
            resources.ApplyResources(this.TBPrecio_venta, "TBPrecio_venta");
            this.TBPrecio_venta.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBPrecio_venta, resources.GetString("TBPrecio_venta.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBPrecio_venta, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBPrecio_venta.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBPrecio_venta, ((int)(resources.GetObject("TBPrecio_venta.IconPadding"))));
            this.TBPrecio_venta.Name = "TBPrecio_venta";
            this.TTMensaje.SetToolTip(this.TBPrecio_venta, resources.GetString("TBPrecio_venta.ToolTip"));
            // 
            // LFecha_Vencimiento
            // 
            resources.ApplyResources(this.LFecha_Vencimiento, "LFecha_Vencimiento");
            this.EPErrorIcono.SetError(this.LFecha_Vencimiento, resources.GetString("LFecha_Vencimiento.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LFecha_Vencimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LFecha_Vencimiento.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LFecha_Vencimiento, ((int)(resources.GetObject("LFecha_Vencimiento.IconPadding"))));
            this.LFecha_Vencimiento.Name = "LFecha_Vencimiento";
            this.TTMensaje.SetToolTip(this.LFecha_Vencimiento, resources.GetString("LFecha_Vencimiento.ToolTip"));
            // 
            // LStock_inicial
            // 
            resources.ApplyResources(this.LStock_inicial, "LStock_inicial");
            this.EPErrorIcono.SetError(this.LStock_inicial, resources.GetString("LStock_inicial.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LStock_inicial, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LStock_inicial.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LStock_inicial, ((int)(resources.GetObject("LStock_inicial.IconPadding"))));
            this.LStock_inicial.Name = "LStock_inicial";
            this.TTMensaje.SetToolTip(this.LStock_inicial, resources.GetString("LStock_inicial.ToolTip"));
            // 
            // LFecha_Produccion
            // 
            resources.ApplyResources(this.LFecha_Produccion, "LFecha_Produccion");
            this.EPErrorIcono.SetError(this.LFecha_Produccion, resources.GetString("LFecha_Produccion.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LFecha_Produccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LFecha_Produccion.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LFecha_Produccion, ((int)(resources.GetObject("LFecha_Produccion.IconPadding"))));
            this.LFecha_Produccion.Name = "LFecha_Produccion";
            this.TTMensaje.SetToolTip(this.LFecha_Produccion, resources.GetString("LFecha_Produccion.ToolTip"));
            // 
            // TBStock
            // 
            resources.ApplyResources(this.TBStock, "TBStock");
            this.TBStock.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBStock, resources.GetString("TBStock.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBStock, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBStock.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBStock, ((int)(resources.GetObject("TBStock.IconPadding"))));
            this.TBStock.Name = "TBStock";
            this.TTMensaje.SetToolTip(this.TBStock, resources.GetString("TBStock.ToolTip"));
            // 
            // PBuscarArticulo
            // 
            resources.ApplyResources(this.PBuscarArticulo, "PBuscarArticulo");
            this.PBuscarArticulo.Controls.Add(this.BuscarArticulo);
            this.PBuscarArticulo.Controls.Add(this.TBArticulo);
            this.PBuscarArticulo.Controls.Add(this.LArticulo);
            this.EPErrorIcono.SetError(this.PBuscarArticulo, resources.GetString("PBuscarArticulo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.PBuscarArticulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PBuscarArticulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.PBuscarArticulo, ((int)(resources.GetObject("PBuscarArticulo.IconPadding"))));
            this.PBuscarArticulo.Name = "PBuscarArticulo";
            this.TTMensaje.SetToolTip(this.PBuscarArticulo, resources.GetString("PBuscarArticulo.ToolTip"));
            // 
            // BuscarArticulo
            // 
            resources.ApplyResources(this.BuscarArticulo, "BuscarArticulo");
            this.BuscarArticulo.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.EPErrorIcono.SetError(this.BuscarArticulo, resources.GetString("BuscarArticulo.Error"));
            this.BuscarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BuscarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EPErrorIcono.SetIconAlignment(this.BuscarArticulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BuscarArticulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BuscarArticulo, ((int)(resources.GetObject("BuscarArticulo.IconPadding"))));
            this.BuscarArticulo.Name = "BuscarArticulo";
            this.TTMensaje.SetToolTip(this.BuscarArticulo, resources.GetString("BuscarArticulo.ToolTip"));
            this.BuscarArticulo.UseVisualStyleBackColor = true;
            this.BuscarArticulo.Click += new System.EventHandler(this.BuscarArticulo_Click);
            // 
            // TBArticulo
            // 
            resources.ApplyResources(this.TBArticulo, "TBArticulo");
            this.TBArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.EPErrorIcono.SetError(this.TBArticulo, resources.GetString("TBArticulo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.TBArticulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TBArticulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.TBArticulo, ((int)(resources.GetObject("TBArticulo.IconPadding"))));
            this.TBArticulo.Name = "TBArticulo";
            this.TTMensaje.SetToolTip(this.TBArticulo, resources.GetString("TBArticulo.ToolTip"));
            // 
            // LArticulo
            // 
            resources.ApplyResources(this.LArticulo, "LArticulo");
            this.EPErrorIcono.SetError(this.LArticulo, resources.GetString("LArticulo.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LArticulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LArticulo.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LArticulo, ((int)(resources.GetObject("LArticulo.IconPadding"))));
            this.LArticulo.Name = "LArticulo";
            this.TTMensaje.SetToolTip(this.LArticulo, resources.GetString("LArticulo.ToolTip"));
            // 
            // DGVListados_detalles
            // 
            resources.ApplyResources(this.DGVListados_detalles, "DGVListados_detalles");
            this.DGVListados_detalles.AllowUserToAddRows = false;
            this.DGVListados_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EPErrorIcono.SetError(this.DGVListados_detalles, resources.GetString("DGVListados_detalles.Error"));
            this.EPErrorIcono.SetIconAlignment(this.DGVListados_detalles, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DGVListados_detalles.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.DGVListados_detalles, ((int)(resources.GetObject("DGVListados_detalles.IconPadding"))));
            this.DGVListados_detalles.Name = "DGVListados_detalles";
            this.DGVListados_detalles.RowTemplate.Height = 24;
            this.TTMensaje.SetToolTip(this.DGVListados_detalles, resources.GetString("DGVListados_detalles.ToolTip"));
            // 
            // LTotal
            // 
            resources.ApplyResources(this.LTotal, "LTotal");
            this.EPErrorIcono.SetError(this.LTotal, resources.GetString("LTotal.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LTotal.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LTotal, ((int)(resources.GetObject("LTotal.IconPadding"))));
            this.LTotal.Name = "LTotal";
            this.TTMensaje.SetToolTip(this.LTotal, resources.GetString("LTotal.ToolTip"));
            // 
            // LTotal_Pagado
            // 
            resources.ApplyResources(this.LTotal_Pagado, "LTotal_Pagado");
            this.EPErrorIcono.SetError(this.LTotal_Pagado, resources.GetString("LTotal_Pagado.Error"));
            this.EPErrorIcono.SetIconAlignment(this.LTotal_Pagado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LTotal_Pagado.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.LTotal_Pagado, ((int)(resources.GetObject("LTotal_Pagado.IconPadding"))));
            this.LTotal_Pagado.Name = "LTotal_Pagado";
            this.TTMensaje.SetToolTip(this.LTotal_Pagado, resources.GetString("LTotal_Pagado.ToolTip"));
            // 
            // BBuscar_fecha
            // 
            resources.ApplyResources(this.BBuscar_fecha, "BBuscar_fecha");
            this.BBuscar_fecha.BackgroundImage = global::Precentacion.Properties.Resources.Play;
            this.EPErrorIcono.SetError(this.BBuscar_fecha, resources.GetString("BBuscar_fecha.Error"));
            this.BBuscar_fecha.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscar_fecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscar_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EPErrorIcono.SetIconAlignment(this.BBuscar_fecha, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BBuscar_fecha.IconAlignment"))));
            this.EPErrorIcono.SetIconPadding(this.BBuscar_fecha, ((int)(resources.GetObject("BBuscar_fecha.IconPadding"))));
            this.BBuscar_fecha.Name = "BBuscar_fecha";
            this.TTMensaje.SetToolTip(this.BBuscar_fecha, resources.GetString("BBuscar_fecha.ToolTip"));
            this.BBuscar_fecha.UseVisualStyleBackColor = true;
            this.BBuscar_fecha.Click += new System.EventHandler(this.BBuscar_fecha_Click);
            // 
            // FormIngreso
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "FormIngreso";
            this.TTMensaje.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.Resize += new System.EventHandler(this._Resize);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.PBuscarProvedor.ResumeLayout(false);
            this.PBuscarProvedor.PerformLayout();
            this.PComprobante.ResumeLayout(false);
            this.PComprobante.PerformLayout();
            this.GBArticulo.ResumeLayout(false);
            this.GBArticulo.PerformLayout();
            this.PBuscarArticulo.ResumeLayout(false);
            this.PBuscarArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label LFecha_Final;
        private System.Windows.Forms.DateTimePicker DTPFecha_Final;
        private System.Windows.Forms.Label LFecha_Inicial;
        private System.Windows.Forms.DateTimePicker DTPFecha_inicio;
        private System.Windows.Forms.Panel PBuscarProvedor;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Button BBuscarProveedor;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LNumero;
        private System.Windows.Forms.ComboBox CBComprobante;
        private System.Windows.Forms.TextBox TBCorrelativo;
        private System.Windows.Forms.TextBox TBIgv;
        private System.Windows.Forms.TextBox TBSerie;
        private System.Windows.Forms.Label LIvg;
        private System.Windows.Forms.Panel PComprobante;
        private System.Windows.Forms.Label LComprobante;
        private System.Windows.Forms.GroupBox GBArticulo;
        private System.Windows.Forms.Panel PBuscarArticulo;
        private System.Windows.Forms.Button BuscarArticulo;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.Label LArticulo;
        private System.Windows.Forms.Label LPrecio_compra;
        private System.Windows.Forms.DateTimePicker DTPFecha_Vencimiento;
        private System.Windows.Forms.DateTimePicker DTPFecha_Produccion;
        private System.Windows.Forms.TextBox TBPrecio_compra;
        private System.Windows.Forms.Label LPrecio_venta;
        private System.Windows.Forms.TextBox TBPrecio_venta;
        private System.Windows.Forms.Label LFecha_Vencimiento;
        private System.Windows.Forms.Label LStock_inicial;
        private System.Windows.Forms.Label LFecha_Produccion;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Label LTotal_Pagado;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.DataGridView DGVListados_detalles;
        private System.Windows.Forms.Button BBuscar_fecha;
    }
}
