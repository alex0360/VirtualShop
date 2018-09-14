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
            this.datagListado = new System.Windows.Forms.DataGridView();
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
            this.CBComprovante = new System.Windows.Forms.ComboBox();
            this.TBSerial = new System.Windows.Forms.TextBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PBuscarArticulo = new System.Windows.Forms.Panel();
            this.BuscarArticulo = new System.Windows.Forms.Button();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.LArticulo = new System.Windows.Forms.Label();
            this.DGVListados_detalles = new System.Windows.Forms.DataGridView();
            this.LTotal = new System.Windows.Forms.Label();
            this.LTotal_Pagado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.PBuscarProvedor.SuspendLayout();
            this.PComprobante.SuspendLayout();
            this.GBArticulo.SuspendLayout();
            this.PBuscarArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListados_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(484, 292);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(376, 292);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(25, 15);
            this.LTitulo.Size = new System.Drawing.Size(224, 26);
            this.LTitulo.Text = "Ingreso en Almacen";
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(487, 15);
            // 
            // tabCon
            // 
            this.tabCon.Size = new System.Drawing.Size(622, 384);
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.Location = new System.Drawing.Point(5, 333);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Size = new System.Drawing.Size(614, 358);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LFecha_Final);
            this.tabPage1.Controls.Add(this.DTPFecha_Final);
            this.tabPage1.Controls.Add(this.LFecha_Inicial);
            this.tabPage1.Controls.Add(this.DTPFecha_inicio);
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Size = new System.Drawing.Size(614, 358);
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BImprimir, 0);
            this.tabPage1.Controls.SetChildIndex(this.CBEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LTotalRegistro, 0);
            this.tabPage1.Controls.SetChildIndex(this.datagListado, 0);
            this.tabPage1.Controls.SetChildIndex(this.DTPFecha_inicio, 0);
            this.tabPage1.Controls.SetChildIndex(this.LFecha_Inicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.DTPFecha_Final, 0);
            this.tabPage1.Controls.SetChildIndex(this.LFecha_Final, 0);
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
            this.GBMatenimiento.Size = new System.Drawing.Size(588, 332);
            this.GBMatenimiento.Text = "Ingreso";
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
            this.BEliminar.Text = "&Anular";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Enabled = false;
            this.TBBuscar.Location = new System.Drawing.Point(609, 1);
            this.TBBuscar.Visible = false;
            // 
            // LBuscar
            // 
            this.LBuscar.Enabled = false;
            this.LBuscar.Location = new System.Drawing.Point(614, 2);
            this.LBuscar.Visible = false;
            // 
            // CBEliminar
            // 
            this.CBEliminar.Location = new System.Drawing.Point(11, 61);
            this.CBEliminar.Size = new System.Drawing.Size(56, 17);
            this.CBEliminar.Text = "Anular";
            // 
            // datagListado
            // 
            this.datagListado.AllowUserToAddRows = false;
            this.datagListado.AllowUserToDeleteRows = false;
            this.datagListado.AllowUserToOrderColumns = true;
            this.datagListado.BackgroundColor = System.Drawing.Color.White;
            this.datagListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datagListado.GridColor = System.Drawing.SystemColors.Control;
            this.datagListado.Location = new System.Drawing.Point(11, 81);
            this.datagListado.Margin = new System.Windows.Forms.Padding(2);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(588, 249);
            this.datagListado.TabIndex = 7;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // LNumero
            // 
            this.LNumero.AutoSize = true;
            this.LNumero.Location = new System.Drawing.Point(28, 45);
            this.LNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNumero.Name = "LNumero";
            this.LNumero.Size = new System.Drawing.Size(47, 13);
            this.LNumero.TabIndex = 12;
            this.LNumero.Text = "Numero:";
            // 
            // DTPFecha_inicio
            // 
            this.DTPFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_inicio.Location = new System.Drawing.Point(8, 31);
            this.DTPFecha_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_inicio.Name = "DTPFecha_inicio";
            this.DTPFecha_inicio.Size = new System.Drawing.Size(74, 19);
            this.DTPFecha_inicio.TabIndex = 8;
            this.DTPFecha_inicio.Value = new System.DateTime(2018, 9, 13, 0, 0, 0, 0);
            // 
            // LFecha_Inicial
            // 
            this.LFecha_Inicial.AutoSize = true;
            this.LFecha_Inicial.Location = new System.Drawing.Point(8, 12);
            this.LFecha_Inicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Inicial.Name = "LFecha_Inicial";
            this.LFecha_Inicial.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Inicial.TabIndex = 9;
            this.LFecha_Inicial.Text = "Fecha Inicial";
            // 
            // DTPFecha_Final
            // 
            this.DTPFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Final.Location = new System.Drawing.Point(106, 31);
            this.DTPFecha_Final.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Final.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Final.Name = "DTPFecha_Final";
            this.DTPFecha_Final.Size = new System.Drawing.Size(74, 19);
            this.DTPFecha_Final.TabIndex = 8;
            this.DTPFecha_Final.Value = new System.DateTime(2018, 9, 13, 0, 0, 0, 0);
            // 
            // LFecha_Final
            // 
            this.LFecha_Final.AutoSize = true;
            this.LFecha_Final.Location = new System.Drawing.Point(107, 12);
            this.LFecha_Final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Final.Name = "LFecha_Final";
            this.LFecha_Final.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Final.TabIndex = 9;
            this.LFecha_Final.Text = "Fecha Inicial";
            // 
            // PBuscarProvedor
            // 
            this.PBuscarProvedor.Controls.Add(this.BBuscarProveedor);
            this.PBuscarProvedor.Controls.Add(this.TBProveedor);
            this.PBuscarProvedor.Controls.Add(this.lProveedor);
            this.PBuscarProvedor.Location = new System.Drawing.Point(314, 24);
            this.PBuscarProvedor.Margin = new System.Windows.Forms.Padding(2);
            this.PBuscarProvedor.Name = "PBuscarProvedor";
            this.PBuscarProvedor.Size = new System.Drawing.Size(220, 42);
            this.PBuscarProvedor.TabIndex = 18;
            // 
            // BBuscarProveedor
            // 
            this.BBuscarProveedor.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.BBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProveedor.Location = new System.Drawing.Point(179, 4);
            this.BBuscarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.BBuscarProveedor.Name = "BBuscarProveedor";
            this.BBuscarProveedor.Size = new System.Drawing.Size(26, 24);
            this.BBuscarProveedor.TabIndex = 8;
            this.BBuscarProveedor.UseVisualStyleBackColor = true;
            this.BBuscarProveedor.Click += new System.EventHandler(this.BBuscarProveedor_Click);
            // 
            // TBProveedor
            // 
            this.TBProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.TBProveedor.Location = new System.Drawing.Point(62, 5);
            this.TBProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(114, 19);
            this.TBProveedor.TabIndex = 2;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Location = new System.Drawing.Point(2, 7);
            this.lProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(59, 13);
            this.lProveedor.TabIndex = 1;
            this.lProveedor.Text = "Proveedor:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha.Location = new System.Drawing.Point(482, 79);
            this.DTPFecha.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(87, 19);
            this.DTPFecha.TabIndex = 9;
            this.DTPFecha.Value = new System.DateTime(2018, 9, 13, 0, 0, 0, 0);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(439, 81);
            this.LFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 1;
            this.LFecha.Text = "Fecha:";
            // 
            // CBComprovante
            // 
            this.CBComprovante.BackColor = System.Drawing.SystemColors.Control;
            this.CBComprovante.FormattingEnabled = true;
            this.CBComprovante.Location = new System.Drawing.Point(80, 12);
            this.CBComprovante.Margin = new System.Windows.Forms.Padding(2);
            this.CBComprovante.Name = "CBComprovante";
            this.CBComprovante.Size = new System.Drawing.Size(197, 21);
            this.CBComprovante.TabIndex = 19;
            // 
            // TBSerial
            // 
            this.TBSerial.BackColor = System.Drawing.SystemColors.Control;
            this.TBSerial.Location = new System.Drawing.Point(80, 42);
            this.TBSerial.Margin = new System.Windows.Forms.Padding(2);
            this.TBSerial.Name = "TBSerial";
            this.TBSerial.Size = new System.Drawing.Size(58, 19);
            this.TBSerial.TabIndex = 13;
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
            // LIvg
            // 
            this.LIvg.AutoSize = true;
            this.LIvg.Location = new System.Drawing.Point(312, 79);
            this.LIvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LIvg.Name = "LIvg";
            this.LIvg.Size = new System.Drawing.Size(51, 13);
            this.LIvg.TabIndex = 12;
            this.LIvg.Text = "IGV(Itbs):";
            // 
            // TBIgv
            // 
            this.TBIgv.BackColor = System.Drawing.SystemColors.Control;
            this.TBIgv.Location = new System.Drawing.Point(367, 79);
            this.TBIgv.Margin = new System.Windows.Forms.Padding(2);
            this.TBIgv.Name = "TBIgv";
            this.TBIgv.Size = new System.Drawing.Size(58, 19);
            this.TBIgv.TabIndex = 13;
            // 
            // LComprobante
            // 
            this.LComprobante.AutoSize = true;
            this.LComprobante.Location = new System.Drawing.Point(2, 15);
            this.LComprobante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LComprobante.Name = "LComprobante";
            this.LComprobante.Size = new System.Drawing.Size(73, 13);
            this.LComprobante.TabIndex = 20;
            this.LComprobante.Text = "Comprobante:";
            // 
            // PComprobante
            // 
            this.PComprobante.Controls.Add(this.LComprobante);
            this.PComprobante.Controls.Add(this.LNumero);
            this.PComprobante.Controls.Add(this.CBComprovante);
            this.PComprobante.Controls.Add(this.TBSerial);
            this.PComprobante.Controls.Add(this.TBCorrelativo);
            this.PComprobante.Location = new System.Drawing.Point(3, 24);
            this.PComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.PComprobante.Name = "PComprobante";
            this.PComprobante.Size = new System.Drawing.Size(284, 68);
            this.PComprobante.TabIndex = 21;
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
            this.GBArticulo.Controls.Add(this.textBox1);
            this.GBArticulo.Controls.Add(this.PBuscarArticulo);
            this.GBArticulo.Location = new System.Drawing.Point(8, 102);
            this.GBArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.GBArticulo.Name = "GBArticulo";
            this.GBArticulo.Padding = new System.Windows.Forms.Padding(2);
            this.GBArticulo.Size = new System.Drawing.Size(578, 94);
            this.GBArticulo.TabIndex = 22;
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
            this.BAdd.Location = new System.Drawing.Point(534, 27);
            this.BAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(22, 21);
            this.BAdd.TabIndex = 20;
            this.BAdd.UseVisualStyleBackColor = true;
            // 
            // BDelete
            // 
            this.BDelete.BackgroundImage = global::Precentacion.Properties.Resources.delete2;
            this.BDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDelete.Location = new System.Drawing.Point(534, 67);
            this.BDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(22, 20);
            this.BDelete.TabIndex = 21;
            this.BDelete.UseVisualStyleBackColor = true;
            // 
            // LPrecio_compra
            // 
            this.LPrecio_compra.AutoSize = true;
            this.LPrecio_compra.Location = new System.Drawing.Point(214, 21);
            this.LPrecio_compra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPrecio_compra.Name = "LPrecio_compra";
            this.LPrecio_compra.Size = new System.Drawing.Size(94, 13);
            this.LPrecio_compra.TabIndex = 19;
            this.LPrecio_compra.Text = "Precio de Compra:";
            // 
            // DTPFecha_Vencimiento
            // 
            this.DTPFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Vencimiento.Location = new System.Drawing.Point(420, 70);
            this.DTPFecha_Vencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Vencimiento.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Vencimiento.Name = "DTPFecha_Vencimiento";
            this.DTPFecha_Vencimiento.Size = new System.Drawing.Size(87, 19);
            this.DTPFecha_Vencimiento.TabIndex = 9;
            this.DTPFecha_Vencimiento.Value = new System.DateTime(2018, 9, 13, 0, 0, 0, 0);
            // 
            // DTPFecha_Produccion
            // 
            this.DTPFecha_Produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Produccion.Location = new System.Drawing.Point(420, 33);
            this.DTPFecha_Produccion.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Produccion.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Produccion.Name = "DTPFecha_Produccion";
            this.DTPFecha_Produccion.Size = new System.Drawing.Size(87, 19);
            this.DTPFecha_Produccion.TabIndex = 9;
            this.DTPFecha_Produccion.Value = new System.DateTime(2018, 9, 13, 0, 0, 0, 0);
            // 
            // TBPrecio_compra
            // 
            this.TBPrecio_compra.BackColor = System.Drawing.SystemColors.Control;
            this.TBPrecio_compra.Location = new System.Drawing.Point(311, 21);
            this.TBPrecio_compra.Margin = new System.Windows.Forms.Padding(2);
            this.TBPrecio_compra.Name = "TBPrecio_compra";
            this.TBPrecio_compra.Size = new System.Drawing.Size(79, 19);
            this.TBPrecio_compra.TabIndex = 2;
            // 
            // LPrecio_venta
            // 
            this.LPrecio_venta.AutoSize = true;
            this.LPrecio_venta.Location = new System.Drawing.Point(214, 51);
            this.LPrecio_venta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPrecio_venta.Name = "LPrecio_venta";
            this.LPrecio_venta.Size = new System.Drawing.Size(86, 13);
            this.LPrecio_venta.TabIndex = 19;
            this.LPrecio_venta.Text = "Precio de Venta:";
            // 
            // TBPrecio_venta
            // 
            this.TBPrecio_venta.BackColor = System.Drawing.SystemColors.Control;
            this.TBPrecio_venta.Location = new System.Drawing.Point(311, 51);
            this.TBPrecio_venta.Margin = new System.Windows.Forms.Padding(2);
            this.TBPrecio_venta.Name = "TBPrecio_venta";
            this.TBPrecio_venta.Size = new System.Drawing.Size(79, 19);
            this.TBPrecio_venta.TabIndex = 2;
            // 
            // LFecha_Vencimiento
            // 
            this.LFecha_Vencimiento.AutoSize = true;
            this.LFecha_Vencimiento.Location = new System.Drawing.Point(418, 54);
            this.LFecha_Vencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Vencimiento.Name = "LFecha_Vencimiento";
            this.LFecha_Vencimiento.Size = new System.Drawing.Size(101, 13);
            this.LFecha_Vencimiento.TabIndex = 1;
            this.LFecha_Vencimiento.Text = "Fecha Vencimiento:";
            // 
            // LStock_inicial
            // 
            this.LStock_inicial.AutoSize = true;
            this.LStock_inicial.Location = new System.Drawing.Point(7, 69);
            this.LStock_inicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LStock_inicial.Name = "LStock_inicial";
            this.LStock_inicial.Size = new System.Drawing.Size(68, 13);
            this.LStock_inicial.TabIndex = 19;
            this.LStock_inicial.Text = "Stock Inicial:";
            // 
            // LFecha_Produccion
            // 
            this.LFecha_Produccion.AutoSize = true;
            this.LFecha_Produccion.Location = new System.Drawing.Point(418, 15);
            this.LFecha_Produccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Produccion.Name = "LFecha_Produccion";
            this.LFecha_Produccion.Size = new System.Drawing.Size(97, 13);
            this.LFecha_Produccion.TabIndex = 1;
            this.LFecha_Produccion.Text = "Fecha Produccion:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(73, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 19);
            this.textBox1.TabIndex = 2;
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
            this.LArticulo.Location = new System.Drawing.Point(2, 10);
            this.LArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LArticulo.Name = "LArticulo";
            this.LArticulo.Size = new System.Drawing.Size(45, 13);
            this.LArticulo.TabIndex = 1;
            this.LArticulo.Text = "Articulo:";
            // 
            // DGVListados_detalles
            // 
            this.DGVListados_detalles.AllowUserToAddRows = false;
            this.DGVListados_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListados_detalles.Location = new System.Drawing.Point(8, 201);
            this.DGVListados_detalles.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListados_detalles.Name = "DGVListados_detalles";
            this.DGVListados_detalles.RowTemplate.Height = 24;
            this.DGVListados_detalles.Size = new System.Drawing.Size(573, 89);
            this.DGVListados_detalles.TabIndex = 23;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(8, 307);
            this.LTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(67, 13);
            this.LTotal.TabIndex = 24;
            this.LTotal.Text = "Total Pagas:";
            // 
            // LTotal_Pagado
            // 
            this.LTotal_Pagado.AutoSize = true;
            this.LTotal_Pagado.Location = new System.Drawing.Point(71, 307);
            this.LTotal_Pagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTotal_Pagado.Name = "LTotal_Pagado";
            this.LTotal_Pagado.Size = new System.Drawing.Size(22, 13);
            this.LTotal_Pagado.TabIndex = 25;
            this.LTotal_Pagado.Text = "0.0";
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(679, 459);
            this.Name = "FormIngreso";
            this.Text = "Ingreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
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

        private System.Windows.Forms.DataGridView datagListado;
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
        private System.Windows.Forms.ComboBox CBComprovante;
        private System.Windows.Forms.TextBox TBCorrelativo;
        private System.Windows.Forms.TextBox TBIgv;
        private System.Windows.Forms.TextBox TBSerial;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Label LTotal_Pagado;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.DataGridView DGVListados_detalles;
    }
}
