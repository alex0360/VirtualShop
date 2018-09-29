namespace Precentacion
{
    partial class FormVenta
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
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BBuscar_fecha = new System.Windows.Forms.Button();
            this.LFecha_Final = new System.Windows.Forms.Label();
            this.DTPFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.LFecha_Inicial = new System.Windows.Forms.Label();
            this.DTPFecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.DGVListados_detalles = new System.Windows.Forms.DataGridView();
            this.GBArticulo = new System.Windows.Forms.GroupBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.DTPFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.LPrecio_venta = new System.Windows.Forms.Label();
            this.TBPrecio_venta = new System.Windows.Forms.TextBox();
            this.LFecha_Vencimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LStockActual = new System.Windows.Forms.Label();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBStockActual = new System.Windows.Forms.TextBox();
            this.PBuscarArticulo = new System.Windows.Forms.Panel();
            this.BuscarArticulo = new System.Windows.Forms.Button();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.LArticulo = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.PComprobante = new System.Windows.Forms.Panel();
            this.LComprobante = new System.Windows.Forms.Label();
            this.LNumero = new System.Windows.Forms.Label();
            this.CBComprobante = new System.Windows.Forms.ComboBox();
            this.TBSerie = new System.Windows.Forms.TextBox();
            this.TBCorrelativo = new System.Windows.Forms.TextBox();
            this.PBuscarCliente = new System.Windows.Forms.Panel();
            this.BBuscarCliente = new System.Windows.Forms.Button();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.TBIgv = new System.Windows.Forms.TextBox();
            this.LIvg = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LTotal_Pagado = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.MUDCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados_detalles)).BeginInit();
            this.GBArticulo.SuspendLayout();
            this.PBuscarArticulo.SuspendLayout();
            this.PComprobante.SuspendLayout();
            this.PBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(453, 284);
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(315, 284);
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(10, 9);
            this.LTitulo.Size = new System.Drawing.Size(86, 26);
            this.LTitulo.Text = "Ventas";
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(425, 26);
            // 
            // tabCon
            // 
            this.tabCon.Location = new System.Drawing.Point(16, 41);
            this.tabCon.Size = new System.Drawing.Size(671, 402);
            this.tabCon.Resize += new System.EventHandler(this._Resize);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Size = new System.Drawing.Size(663, 376);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BBuscar_fecha);
            this.tabPage1.Controls.Add(this.LFecha_Final);
            this.tabPage1.Controls.Add(this.DTPFecha_Final);
            this.tabPage1.Controls.Add(this.LFecha_Inicial);
            this.tabPage1.Controls.Add(this.DTPFecha_inicio);
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Size = new System.Drawing.Size(663, 376);
            this.tabPage1.Controls.SetChildIndex(this.LBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
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
            this.GBMatenimiento.Controls.Add(this.PBuscarCliente);
            this.GBMatenimiento.Controls.Add(this.TBIgv);
            this.GBMatenimiento.Controls.Add(this.LIvg);
            this.GBMatenimiento.Controls.Add(this.LFecha);
            this.GBMatenimiento.Size = new System.Drawing.Size(602, 335);
            this.GBMatenimiento.Text = "Ventas";
            this.GBMatenimiento.Controls.SetChildIndex(this.BGuardar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.BCancelar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LFecha, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LIvg, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBIgv, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.PBuscarCliente, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.PComprobante, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DTPFecha, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.GBArticulo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DGVListados_detalles, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTotal, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTotal_Pagado, 0);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(307, 26);
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(425, 63);
            this.TBBuscar.Size = new System.Drawing.Size(191, 19);
            this.TBBuscar.Visible = false;
            // 
            // LBuscar
            // 
            this.LBuscar.Location = new System.Drawing.Point(360, 66);
            this.LBuscar.Visible = false;
            // 
            // CBEliminar
            // 
            this.CBEliminar.CheckedChanged += new System.EventHandler(this.CBEliminar_CheckedChanged);
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
            this.DGVListado.Location = new System.Drawing.Point(15, 85);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(631, 249);
            this.DGVListado.TabIndex = 8;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.DoubleClick += new System.EventHandler(this.DGVListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // BBuscar_fecha
            // 
            this.BBuscar_fecha.BackgroundImage = global::Precentacion.Properties.Resources.Play;
            this.BBuscar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBuscar_fecha.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscar_fecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscar_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BBuscar_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BBuscar_fecha.Location = new System.Drawing.Point(189, 32);
            this.BBuscar_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.BBuscar_fecha.Name = "BBuscar_fecha";
            this.BBuscar_fecha.Size = new System.Drawing.Size(22, 21);
            this.BBuscar_fecha.TabIndex = 26;
            this.BBuscar_fecha.UseVisualStyleBackColor = true;
            this.BBuscar_fecha.Click += new System.EventHandler(this.BBuscar_fecha_Click);
            // 
            // LFecha_Final
            // 
            this.LFecha_Final.AutoSize = true;
            this.LFecha_Final.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha_Final.Location = new System.Drawing.Point(112, 15);
            this.LFecha_Final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Final.Name = "LFecha_Final";
            this.LFecha_Final.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Final.TabIndex = 24;
            this.LFecha_Final.Text = "Fecha Inicial";
            // 
            // DTPFecha_Final
            // 
            this.DTPFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Final.Location = new System.Drawing.Point(111, 34);
            this.DTPFecha_Final.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Final.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Final.Name = "DTPFecha_Final";
            this.DTPFecha_Final.Size = new System.Drawing.Size(74, 19);
            this.DTPFecha_Final.TabIndex = 22;
            this.DTPFecha_Final.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 221);
            // 
            // LFecha_Inicial
            // 
            this.LFecha_Inicial.AutoSize = true;
            this.LFecha_Inicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha_Inicial.Location = new System.Drawing.Point(13, 15);
            this.LFecha_Inicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Inicial.Name = "LFecha_Inicial";
            this.LFecha_Inicial.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Inicial.TabIndex = 25;
            this.LFecha_Inicial.Text = "Fecha Inicial";
            // 
            // DTPFecha_inicio
            // 
            this.DTPFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_inicio.Location = new System.Drawing.Point(13, 34);
            this.DTPFecha_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_inicio.Name = "DTPFecha_inicio";
            this.DTPFecha_inicio.Size = new System.Drawing.Size(74, 19);
            this.DTPFecha_inicio.TabIndex = 23;
            this.DTPFecha_inicio.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 217);
            // 
            // DGVListados_detalles
            // 
            this.DGVListados_detalles.AllowUserToAddRows = false;
            this.DGVListados_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListados_detalles.Location = new System.Drawing.Point(8, 192);
            this.DGVListados_detalles.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListados_detalles.Name = "DGVListados_detalles";
            this.DGVListados_detalles.RowTemplate.Height = 24;
            this.DGVListados_detalles.Size = new System.Drawing.Size(573, 89);
            this.DGVListados_detalles.TabIndex = 31;
            // 
            // GBArticulo
            // 
            this.GBArticulo.Controls.Add(this.MUDCantidad);
            this.GBArticulo.Controls.Add(this.BAdd);
            this.GBArticulo.Controls.Add(this.BDelete);
            this.GBArticulo.Controls.Add(this.DTPFecha_Vencimiento);
            this.GBArticulo.Controls.Add(this.LPrecio_venta);
            this.GBArticulo.Controls.Add(this.TBPrecio_venta);
            this.GBArticulo.Controls.Add(this.LFecha_Vencimiento);
            this.GBArticulo.Controls.Add(this.label1);
            this.GBArticulo.Controls.Add(this.LStockActual);
            this.GBArticulo.Controls.Add(this.TBDescuento);
            this.GBArticulo.Controls.Add(this.LCantidad);
            this.GBArticulo.Controls.Add(this.TBStockActual);
            this.GBArticulo.Controls.Add(this.PBuscarArticulo);
            this.GBArticulo.Location = new System.Drawing.Point(3, 94);
            this.GBArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.GBArticulo.Name = "GBArticulo";
            this.GBArticulo.Padding = new System.Windows.Forms.Padding(2);
            this.GBArticulo.Size = new System.Drawing.Size(582, 94);
            this.GBArticulo.TabIndex = 30;
            this.GBArticulo.TabStop = false;
            // 
            // BAdd
            // 
            this.BAdd.BackgroundImage = global::Precentacion.Properties.Resources.add;
            this.BAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BAdd.Location = new System.Drawing.Point(534, 27);
            this.BAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(22, 21);
            this.BAdd.TabIndex = 20;
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BDelete
            // 
            this.BDelete.BackgroundImage = global::Precentacion.Properties.Resources.delete2;
            this.BDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BDelete.Location = new System.Drawing.Point(534, 67);
            this.BDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(22, 20);
            this.BDelete.TabIndex = 21;
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // DTPFecha_Vencimiento
            // 
            this.DTPFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Vencimiento.Location = new System.Drawing.Point(417, 36);
            this.DTPFecha_Vencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Vencimiento.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Vencimiento.Name = "DTPFecha_Vencimiento";
            this.DTPFecha_Vencimiento.Size = new System.Drawing.Size(78, 19);
            this.DTPFecha_Vencimiento.TabIndex = 9;
            this.DTPFecha_Vencimiento.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 282);
            // 
            // LPrecio_venta
            // 
            this.LPrecio_venta.AutoSize = true;
            this.LPrecio_venta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LPrecio_venta.Location = new System.Drawing.Point(222, 24);
            this.LPrecio_venta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPrecio_venta.Name = "LPrecio_venta";
            this.LPrecio_venta.Size = new System.Drawing.Size(86, 13);
            this.LPrecio_venta.TabIndex = 19;
            this.LPrecio_venta.Text = "Precio de Venta:";
            // 
            // TBPrecio_venta
            // 
            this.TBPrecio_venta.BackColor = System.Drawing.SystemColors.Control;
            this.TBPrecio_venta.Location = new System.Drawing.Point(312, 21);
            this.TBPrecio_venta.Margin = new System.Windows.Forms.Padding(2);
            this.TBPrecio_venta.Name = "TBPrecio_venta";
            this.TBPrecio_venta.Size = new System.Drawing.Size(79, 19);
            this.TBPrecio_venta.TabIndex = 2;
            // 
            // LFecha_Vencimiento
            // 
            this.LFecha_Vencimiento.AutoSize = true;
            this.LFecha_Vencimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha_Vencimiento.Location = new System.Drawing.Point(405, 21);
            this.LFecha_Vencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Vencimiento.Name = "LFecha_Vencimiento";
            this.LFecha_Vencimiento.Size = new System.Drawing.Size(101, 13);
            this.LFecha_Vencimiento.TabIndex = 1;
            this.LFecha_Vencimiento.Text = "Fecha Vencimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(265, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descuento:";
            // 
            // LStockActual
            // 
            this.LStockActual.AutoSize = true;
            this.LStockActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LStockActual.Location = new System.Drawing.Point(120, 67);
            this.LStockActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LStockActual.Name = "LStockActual";
            this.LStockActual.Size = new System.Drawing.Size(71, 13);
            this.LStockActual.TabIndex = 19;
            this.LStockActual.Text = "Stock Actual:";
            // 
            // TBDescuento
            // 
            this.TBDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.TBDescuento.Location = new System.Drawing.Point(331, 64);
            this.TBDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(60, 19);
            this.TBDescuento.TabIndex = 2;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LCantidad.Location = new System.Drawing.Point(7, 69);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(52, 13);
            this.LCantidad.TabIndex = 19;
            this.LCantidad.Text = "Cantidad:";
            // 
            // TBStockActual
            // 
            this.TBStockActual.BackColor = System.Drawing.SystemColors.Control;
            this.TBStockActual.Location = new System.Drawing.Point(192, 63);
            this.TBStockActual.Margin = new System.Windows.Forms.Padding(2);
            this.TBStockActual.Name = "TBStockActual";
            this.TBStockActual.Size = new System.Drawing.Size(49, 19);
            this.TBStockActual.TabIndex = 2;
            // 
            // PBuscarArticulo
            // 
            this.PBuscarArticulo.Controls.Add(this.BuscarArticulo);
            this.PBuscarArticulo.Controls.Add(this.TBArticulo);
            this.PBuscarArticulo.Controls.Add(this.LArticulo);
            this.PBuscarArticulo.Location = new System.Drawing.Point(4, 17);
            this.PBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.PBuscarArticulo.Name = "PBuscarArticulo";
            this.PBuscarArticulo.Size = new System.Drawing.Size(204, 34);
            this.PBuscarArticulo.TabIndex = 18;
            // 
            // BuscarArticulo
            // 
            this.BuscarArticulo.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.BuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuscarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BuscarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarArticulo.Location = new System.Drawing.Point(169, 4);
            this.BuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarArticulo.Name = "BuscarArticulo";
            this.BuscarArticulo.Size = new System.Drawing.Size(26, 24);
            this.BuscarArticulo.TabIndex = 8;
            this.BuscarArticulo.UseVisualStyleBackColor = true;
            this.BuscarArticulo.Click += new System.EventHandler(this.BuscarArticulo_Click);
            // 
            // TBArticulo
            // 
            this.TBArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.TBArticulo.Location = new System.Drawing.Point(51, 7);
            this.TBArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.Size = new System.Drawing.Size(114, 19);
            this.TBArticulo.TabIndex = 2;
            // 
            // LArticulo
            // 
            this.LArticulo.AutoSize = true;
            this.LArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LArticulo.Location = new System.Drawing.Point(2, 10);
            this.LArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LArticulo.Name = "LArticulo";
            this.LArticulo.Size = new System.Drawing.Size(45, 13);
            this.LArticulo.TabIndex = 1;
            this.LArticulo.Text = "Articulo:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha.Location = new System.Drawing.Point(482, 70);
            this.DTPFecha.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(87, 19);
            this.DTPFecha.TabIndex = 25;
            this.DTPFecha.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 241);
            // 
            // PComprobante
            // 
            this.PComprobante.Controls.Add(this.LComprobante);
            this.PComprobante.Controls.Add(this.LNumero);
            this.PComprobante.Controls.Add(this.CBComprobante);
            this.PComprobante.Controls.Add(this.TBSerie);
            this.PComprobante.Controls.Add(this.TBCorrelativo);
            this.PComprobante.Location = new System.Drawing.Point(3, 15);
            this.PComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.PComprobante.Name = "PComprobante";
            this.PComprobante.Size = new System.Drawing.Size(284, 68);
            this.PComprobante.TabIndex = 29;
            // 
            // LComprobante
            // 
            this.LComprobante.AutoSize = true;
            this.LComprobante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LComprobante.Location = new System.Drawing.Point(2, 15);
            this.LComprobante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LComprobante.Name = "LComprobante";
            this.LComprobante.Size = new System.Drawing.Size(73, 13);
            this.LComprobante.TabIndex = 20;
            this.LComprobante.Text = "Comprobante:";
            // 
            // LNumero
            // 
            this.LNumero.AutoSize = true;
            this.LNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LNumero.Location = new System.Drawing.Point(28, 45);
            this.LNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNumero.Name = "LNumero";
            this.LNumero.Size = new System.Drawing.Size(47, 13);
            this.LNumero.TabIndex = 12;
            this.LNumero.Text = "Numero:";
            // 
            // CBComprobante
            // 
            this.CBComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.CBComprobante.FormattingEnabled = true;
            this.CBComprobante.Location = new System.Drawing.Point(80, 12);
            this.CBComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.CBComprobante.Name = "CBComprobante";
            this.CBComprobante.Size = new System.Drawing.Size(197, 21);
            this.CBComprobante.TabIndex = 19;
            // 
            // TBSerie
            // 
            this.TBSerie.BackColor = System.Drawing.SystemColors.Control;
            this.TBSerie.Location = new System.Drawing.Point(80, 42);
            this.TBSerie.Margin = new System.Windows.Forms.Padding(2);
            this.TBSerie.Name = "TBSerie";
            this.TBSerie.Size = new System.Drawing.Size(58, 19);
            this.TBSerie.TabIndex = 13;
            // 
            // TBCorrelativo
            // 
            this.TBCorrelativo.BackColor = System.Drawing.SystemColors.Control;
            this.TBCorrelativo.Location = new System.Drawing.Point(141, 42);
            this.TBCorrelativo.Margin = new System.Windows.Forms.Padding(2);
            this.TBCorrelativo.Name = "TBCorrelativo";
            this.TBCorrelativo.Size = new System.Drawing.Size(58, 19);
            this.TBCorrelativo.TabIndex = 13;
            // 
            // PBuscarCliente
            // 
            this.PBuscarCliente.Controls.Add(this.BBuscarCliente);
            this.PBuscarCliente.Controls.Add(this.TBCliente);
            this.PBuscarCliente.Controls.Add(this.lCliente);
            this.PBuscarCliente.Location = new System.Drawing.Point(334, 15);
            this.PBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.PBuscarCliente.Name = "PBuscarCliente";
            this.PBuscarCliente.Size = new System.Drawing.Size(225, 33);
            this.PBuscarCliente.TabIndex = 28;
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.BBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BBuscarCliente.Location = new System.Drawing.Point(180, 4);
            this.BBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(26, 24);
            this.BBuscarCliente.TabIndex = 8;
            this.BBuscarCliente.UseVisualStyleBackColor = true;
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // TBCliente
            // 
            this.TBCliente.BackColor = System.Drawing.SystemColors.Control;
            this.TBCliente.Location = new System.Drawing.Point(53, 7);
            this.TBCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(123, 19);
            this.TBCliente.TabIndex = 2;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lCliente.Location = new System.Drawing.Point(10, 10);
            this.lCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(39, 13);
            this.lCliente.TabIndex = 1;
            this.lCliente.Text = "Cliente";
            // 
            // TBIgv
            // 
            this.TBIgv.BackColor = System.Drawing.SystemColors.Control;
            this.TBIgv.Location = new System.Drawing.Point(367, 70);
            this.TBIgv.Margin = new System.Windows.Forms.Padding(2);
            this.TBIgv.Name = "TBIgv";
            this.TBIgv.Size = new System.Drawing.Size(58, 19);
            this.TBIgv.TabIndex = 27;
            // 
            // LIvg
            // 
            this.LIvg.AutoSize = true;
            this.LIvg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LIvg.Location = new System.Drawing.Point(312, 70);
            this.LIvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LIvg.Name = "LIvg";
            this.LIvg.Size = new System.Drawing.Size(51, 13);
            this.LIvg.TabIndex = 26;
            this.LIvg.Text = "IGV(Itbs):";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha.Location = new System.Drawing.Point(439, 72);
            this.LFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 24;
            this.LFecha.Text = "Fecha:";
            // 
            // LTotal_Pagado
            // 
            this.LTotal_Pagado.AutoSize = true;
            this.LTotal_Pagado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LTotal_Pagado.Location = new System.Drawing.Point(94, 296);
            this.LTotal_Pagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTotal_Pagado.Name = "LTotal_Pagado";
            this.LTotal_Pagado.Size = new System.Drawing.Size(22, 13);
            this.LTotal_Pagado.TabIndex = 33;
            this.LTotal_Pagado.Text = "0.0";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LTotal.Location = new System.Drawing.Point(23, 296);
            this.LTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(67, 13);
            this.LTotal.TabIndex = 32;
            this.LTotal.Text = "Total Pagas:";
            // 
            // MUDCantidad
            // 
            this.MUDCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.MUDCantidad.Location = new System.Drawing.Point(57, 65);
            this.MUDCantidad.Name = "MUDCantidad";
            this.MUDCantidad.Size = new System.Drawing.Size(58, 19);
            this.MUDCantidad.TabIndex = 22;
            this.MUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 468);
            this.Name = "FormVenta";
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVentas_FormClosing);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.Resize += new System.EventHandler(this._Resize);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados_detalles)).EndInit();
            this.GBArticulo.ResumeLayout(false);
            this.GBArticulo.PerformLayout();
            this.PBuscarArticulo.ResumeLayout(false);
            this.PBuscarArticulo.PerformLayout();
            this.PComprobante.ResumeLayout(false);
            this.PComprobante.PerformLayout();
            this.PBuscarCliente.ResumeLayout(false);
            this.PBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button BBuscar_fecha;
        private System.Windows.Forms.Label LFecha_Final;
        private System.Windows.Forms.DateTimePicker DTPFecha_Final;
        private System.Windows.Forms.Label LFecha_Inicial;
        private System.Windows.Forms.DateTimePicker DTPFecha_inicio;
        private System.Windows.Forms.DataGridView DGVListados_detalles;
        private System.Windows.Forms.GroupBox GBArticulo;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.DateTimePicker DTPFecha_Vencimiento;
        private System.Windows.Forms.Label LPrecio_venta;
        private System.Windows.Forms.TextBox TBPrecio_venta;
        private System.Windows.Forms.Label LFecha_Vencimiento;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Panel PBuscarArticulo;
        private System.Windows.Forms.Button BuscarArticulo;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.Label LArticulo;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Panel PComprobante;
        private System.Windows.Forms.Label LComprobante;
        private System.Windows.Forms.Label LNumero;
        private System.Windows.Forms.ComboBox CBComprobante;
        private System.Windows.Forms.TextBox TBSerie;
        private System.Windows.Forms.TextBox TBCorrelativo;
        private System.Windows.Forms.Panel PBuscarCliente;
        private System.Windows.Forms.Button BBuscarCliente;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.TextBox TBIgv;
        private System.Windows.Forms.Label LIvg;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LTotal_Pagado;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LStockActual;
        private System.Windows.Forms.TextBox TBDescuento;
        private System.Windows.Forms.TextBox TBStockActual;
        private System.Windows.Forms.NumericUpDown MUDCantidad;
    }
}