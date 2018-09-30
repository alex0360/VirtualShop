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
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).BeginInit();
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
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            resources.ApplyResources(this.BGuardar, "BGuardar");
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LTitulo
            // 
            resources.ApplyResources(this.LTitulo, "LTitulo");
            // 
            // BImprimir
            // 
            resources.ApplyResources(this.BImprimir, "BImprimir");
            // 
            // tabCon
            // 
            resources.ApplyResources(this.tabCon, "tabCon");
            // 
            // LTotalRegistro
            // 
            resources.ApplyResources(this.LTotalRegistro, "LTotalRegistro");
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BBuscar_fecha);
            this.tabPage1.Controls.Add(this.LFecha_Final);
            this.tabPage1.Controls.Add(this.DTPFecha_Final);
            this.tabPage1.Controls.Add(this.LFecha_Inicial);
            this.tabPage1.Controls.Add(this.DTPFecha_inicio);
            this.tabPage1.Controls.Add(this.DGVListado);
            resources.ApplyResources(this.tabPage1, "tabPage1");
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
            resources.ApplyResources(this.GBMatenimiento, "GBMatenimiento");
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
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            resources.ApplyResources(this.TBBuscar, "TBBuscar");
            // 
            // LBuscar
            // 
            resources.ApplyResources(this.LBuscar, "LBuscar");
            // 
            // CBEliminar
            // 
            resources.ApplyResources(this.CBEliminar, "CBEliminar");
            this.CBEliminar.CheckedChanged += new System.EventHandler(this.CBEliminar_CheckedChanged);
            // 
            // PBTitulo
            // 
            resources.ApplyResources(this.PBTitulo, "PBTitulo");
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.BackgroundColor = System.Drawing.Color.White;
            this.DGVListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DGVListado.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.DGVListado, "DGVListado");
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.LNumero.Name = "LNumero";
            // 
            // DTPFecha_inicio
            // 
            this.DTPFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DTPFecha_inicio, "DTPFecha_inicio");
            this.DTPFecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_inicio.Name = "DTPFecha_inicio";
            this.DTPFecha_inicio.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 217);
            // 
            // LFecha_Inicial
            // 
            resources.ApplyResources(this.LFecha_Inicial, "LFecha_Inicial");
            this.LFecha_Inicial.Name = "LFecha_Inicial";
            // 
            // DTPFecha_Final
            // 
            this.DTPFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DTPFecha_Final, "DTPFecha_Final");
            this.DTPFecha_Final.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Final.Name = "DTPFecha_Final";
            this.DTPFecha_Final.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 221);
            // 
            // LFecha_Final
            // 
            resources.ApplyResources(this.LFecha_Final, "LFecha_Final");
            this.LFecha_Final.Name = "LFecha_Final";
            // 
            // PBuscarProvedor
            // 
            this.PBuscarProvedor.Controls.Add(this.BBuscarProveedor);
            this.PBuscarProvedor.Controls.Add(this.TBProveedor);
            this.PBuscarProvedor.Controls.Add(this.lProveedor);
            resources.ApplyResources(this.PBuscarProvedor, "PBuscarProvedor");
            this.PBuscarProvedor.Name = "PBuscarProvedor";
            // 
            // BBuscarProveedor
            // 
            this.BBuscarProveedor.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            resources.ApplyResources(this.BBuscarProveedor, "BBuscarProveedor");
            this.BBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BBuscarProveedor.Name = "BBuscarProveedor";
            this.BBuscarProveedor.UseVisualStyleBackColor = true;
            this.BBuscarProveedor.Click += new System.EventHandler(this.BBuscarProveedor_Click);
            // 
            // TBProveedor
            // 
            this.TBProveedor.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBProveedor, "TBProveedor");
            this.TBProveedor.Name = "TBProveedor";
            // 
            // lProveedor
            // 
            resources.ApplyResources(this.lProveedor, "lProveedor");
            this.lProveedor.Name = "lProveedor";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DTPFecha, "DTPFecha");
            this.DTPFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 241);
            // 
            // LFecha
            // 
            resources.ApplyResources(this.LFecha, "LFecha");
            this.LFecha.Name = "LFecha";
            // 
            // CBComprobante
            // 
            this.CBComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.CBComprobante.FormattingEnabled = true;
            resources.ApplyResources(this.CBComprobante, "CBComprobante");
            this.CBComprobante.Name = "CBComprobante";
            // 
            // TBSerie
            // 
            this.TBSerie.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBSerie, "TBSerie");
            this.TBSerie.Name = "TBSerie";
            // 
            // TBCorrelativo
            // 
            this.TBCorrelativo.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBCorrelativo, "TBCorrelativo");
            this.TBCorrelativo.Name = "TBCorrelativo";
            // 
            // LIvg
            // 
            resources.ApplyResources(this.LIvg, "LIvg");
            this.LIvg.Name = "LIvg";
            // 
            // TBIgv
            // 
            this.TBIgv.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBIgv, "TBIgv");
            this.TBIgv.Name = "TBIgv";
            // 
            // LComprobante
            // 
            resources.ApplyResources(this.LComprobante, "LComprobante");
            this.LComprobante.Name = "LComprobante";
            // 
            // PComprobante
            // 
            this.PComprobante.Controls.Add(this.LComprobante);
            this.PComprobante.Controls.Add(this.LNumero);
            this.PComprobante.Controls.Add(this.CBComprobante);
            this.PComprobante.Controls.Add(this.TBSerie);
            this.PComprobante.Controls.Add(this.TBCorrelativo);
            resources.ApplyResources(this.PComprobante, "PComprobante");
            this.PComprobante.Name = "PComprobante";
            // 
            // GBArticulo
            // 
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
            resources.ApplyResources(this.GBArticulo, "GBArticulo");
            this.GBArticulo.Name = "GBArticulo";
            this.GBArticulo.TabStop = false;
            // 
            // BAdd
            // 
            this.BAdd.BackgroundImage = global::Precentacion.Properties.Resources.add;
            resources.ApplyResources(this.BAdd, "BAdd");
            this.BAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BAdd.Name = "BAdd";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BDelete
            // 
            this.BDelete.BackgroundImage = global::Precentacion.Properties.Resources.delete2;
            resources.ApplyResources(this.BDelete, "BDelete");
            this.BDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BDelete.Name = "BDelete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // LPrecio_compra
            // 
            resources.ApplyResources(this.LPrecio_compra, "LPrecio_compra");
            this.LPrecio_compra.Name = "LPrecio_compra";
            // 
            // DTPFecha_Vencimiento
            // 
            this.DTPFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DTPFecha_Vencimiento, "DTPFecha_Vencimiento");
            this.DTPFecha_Vencimiento.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Vencimiento.Name = "DTPFecha_Vencimiento";
            this.DTPFecha_Vencimiento.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 282);
            // 
            // DTPFecha_Produccion
            // 
            this.DTPFecha_Produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.DTPFecha_Produccion, "DTPFecha_Produccion");
            this.DTPFecha_Produccion.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Produccion.Name = "DTPFecha_Produccion";
            this.DTPFecha_Produccion.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 285);
            // 
            // TBPrecio_compra
            // 
            this.TBPrecio_compra.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBPrecio_compra, "TBPrecio_compra");
            this.TBPrecio_compra.Name = "TBPrecio_compra";
            // 
            // LPrecio_venta
            // 
            resources.ApplyResources(this.LPrecio_venta, "LPrecio_venta");
            this.LPrecio_venta.Name = "LPrecio_venta";
            // 
            // TBPrecio_venta
            // 
            this.TBPrecio_venta.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBPrecio_venta, "TBPrecio_venta");
            this.TBPrecio_venta.Name = "TBPrecio_venta";
            // 
            // LFecha_Vencimiento
            // 
            resources.ApplyResources(this.LFecha_Vencimiento, "LFecha_Vencimiento");
            this.LFecha_Vencimiento.Name = "LFecha_Vencimiento";
            // 
            // LStock_inicial
            // 
            resources.ApplyResources(this.LStock_inicial, "LStock_inicial");
            this.LStock_inicial.Name = "LStock_inicial";
            // 
            // LFecha_Produccion
            // 
            resources.ApplyResources(this.LFecha_Produccion, "LFecha_Produccion");
            this.LFecha_Produccion.Name = "LFecha_Produccion";
            // 
            // TBStock
            // 
            this.TBStock.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBStock, "TBStock");
            this.TBStock.Name = "TBStock";
            // 
            // PBuscarArticulo
            // 
            this.PBuscarArticulo.Controls.Add(this.BuscarArticulo);
            this.PBuscarArticulo.Controls.Add(this.TBArticulo);
            this.PBuscarArticulo.Controls.Add(this.LArticulo);
            resources.ApplyResources(this.PBuscarArticulo, "PBuscarArticulo");
            this.PBuscarArticulo.Name = "PBuscarArticulo";
            // 
            // BuscarArticulo
            // 
            this.BuscarArticulo.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            resources.ApplyResources(this.BuscarArticulo, "BuscarArticulo");
            this.BuscarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BuscarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BuscarArticulo.Name = "BuscarArticulo";
            this.BuscarArticulo.UseVisualStyleBackColor = true;
            this.BuscarArticulo.Click += new System.EventHandler(this.BuscarArticulo_Click);
            // 
            // TBArticulo
            // 
            this.TBArticulo.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.TBArticulo, "TBArticulo");
            this.TBArticulo.Name = "TBArticulo";
            // 
            // LArticulo
            // 
            resources.ApplyResources(this.LArticulo, "LArticulo");
            this.LArticulo.Name = "LArticulo";
            // 
            // DGVListados_detalles
            // 
            this.DGVListados_detalles.AllowUserToAddRows = false;
            this.DGVListados_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DGVListados_detalles, "DGVListados_detalles");
            this.DGVListados_detalles.Name = "DGVListados_detalles";
            this.DGVListados_detalles.RowTemplate.Height = 24;
            // 
            // LTotal
            // 
            resources.ApplyResources(this.LTotal, "LTotal");
            this.LTotal.Name = "LTotal";
            // 
            // LTotal_Pagado
            // 
            resources.ApplyResources(this.LTotal_Pagado, "LTotal_Pagado");
            this.LTotal_Pagado.Name = "LTotal_Pagado";
            // 
            // BBuscar_fecha
            // 
            this.BBuscar_fecha.BackgroundImage = global::Precentacion.Properties.Resources.Play;
            resources.ApplyResources(this.BBuscar_fecha, "BBuscar_fecha");
            this.BBuscar_fecha.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscar_fecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscar_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BBuscar_fecha.Name = "BBuscar_fecha";
            this.BBuscar_fecha.UseVisualStyleBackColor = true;
            this.BBuscar_fecha.Click += new System.EventHandler(this.BBuscar_fecha_Click);
            // 
            // FormIngreso
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "FormIngreso";
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
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).EndInit();
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
