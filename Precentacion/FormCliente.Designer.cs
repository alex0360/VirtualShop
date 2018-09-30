namespace Precentacion
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.CBTipo_documento = new System.Windows.Forms.ComboBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBNum_documento = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.lNum_documento = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LTipo_documento = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LApellidos = new System.Windows.Forms.Label();
            this.TBApellidos = new System.Windows.Forms.TextBox();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.LSexo = new System.Windows.Forms.Label();
            this.LFecha_nacimiento = new System.Windows.Forms.Label();
            this.DTPFecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(328, 184);
            this.BCancelar.Size = new System.Drawing.Size(62, 29);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(212, 184);
            this.BGuardar.Size = new System.Drawing.Size(68, 29);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(14, 21);
            this.LTitulo.Size = new System.Drawing.Size(106, 26);
            this.LTitulo.Text = "Clientes:";
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(366, 13);
            // 
            // tabCon
            // 
            this.tabCon.Location = new System.Drawing.Point(10, 62);
            this.tabCon.Size = new System.Drawing.Size(548, 327);
            // 
            // tabPage2
            // 
            this.tabPage2.Size = new System.Drawing.Size(540, 301);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Size = new System.Drawing.Size(540, 301);
            this.tabPage1.Controls.SetChildIndex(this.LBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.BImprimir, 0);
            this.tabPage1.Controls.SetChildIndex(this.CBEliminar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LTotalRegistro, 0);
            this.tabPage1.Controls.SetChildIndex(this.DGVListado, 0);
            // 
            // GBMatenimiento
            // 
            this.GBMatenimiento.Controls.Add(this.DTPFecha_nacimiento);
            this.GBMatenimiento.Controls.Add(this.CBSexo);
            this.GBMatenimiento.Controls.Add(this.LSexo);
            this.GBMatenimiento.Controls.Add(this.CBTipo_documento);
            this.GBMatenimiento.Controls.Add(this.TBDireccion);
            this.GBMatenimiento.Controls.Add(this.TBNum_documento);
            this.GBMatenimiento.Controls.Add(this.TBEmail);
            this.GBMatenimiento.Controls.Add(this.TBTelefono);
            this.GBMatenimiento.Controls.Add(this.TBApellidos);
            this.GBMatenimiento.Controls.Add(this.TBNombre);
            this.GBMatenimiento.Controls.Add(this.LFecha_nacimiento);
            this.GBMatenimiento.Controls.Add(this.LDireccion);
            this.GBMatenimiento.Controls.Add(this.LEmail);
            this.GBMatenimiento.Controls.Add(this.lNum_documento);
            this.GBMatenimiento.Controls.Add(this.LTelefono);
            this.GBMatenimiento.Controls.Add(this.LApellidos);
            this.GBMatenimiento.Controls.Add(this.LTipo_documento);
            this.GBMatenimiento.Controls.Add(this.LNombre);
            this.GBMatenimiento.Location = new System.Drawing.Point(18, 26);
            this.GBMatenimiento.Size = new System.Drawing.Size(426, 234);
            this.GBMatenimiento.Text = "Cliente";
            this.GBMatenimiento.Controls.SetChildIndex(this.BGuardar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.BCancelar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LNombre, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTipo_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LApellidos, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.lNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LFecha_nacimiento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBNombre, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBApellidos, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBTipo_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LSexo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBSexo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DTPFecha_nacimiento, 0);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(261, 13);
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Size = new System.Drawing.Size(150, 19);
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // CBEliminar
            // 
            this.CBEliminar.CheckedChanged += new System.EventHandler(this.CBEliminar_CheckedChanged);
            // 
            // PBTitulo
            // 
            this.PBTitulo.Image = ((System.Drawing.Image)(resources.GetObject("PBTitulo.Image")));
            this.PBTitulo.Location = new System.Drawing.Point(407, 6);
            // 
            // CBTipo_documento
            // 
            this.CBTipo_documento.BackColor = System.Drawing.SystemColors.Control;
            this.CBTipo_documento.FormattingEnabled = true;
            this.CBTipo_documento.ItemHeight = 13;
            this.CBTipo_documento.Location = new System.Drawing.Point(212, 73);
            this.CBTipo_documento.Margin = new System.Windows.Forms.Padding(2);
            this.CBTipo_documento.Name = "CBTipo_documento";
            this.CBTipo_documento.Size = new System.Drawing.Size(69, 21);
            this.CBTipo_documento.TabIndex = 6;
            // 
            // TBDireccion
            // 
            this.TBDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TBDireccion.Location = new System.Drawing.Point(16, 159);
            this.TBDireccion.Margin = new System.Windows.Forms.Padding(1);
            this.TBDireccion.Multiline = true;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(136, 54);
            this.TBDireccion.TabIndex = 5;
            // 
            // TBNum_documento
            // 
            this.TBNum_documento.BackColor = System.Drawing.SystemColors.Control;
            this.TBNum_documento.Location = new System.Drawing.Point(286, 75);
            this.TBNum_documento.Margin = new System.Windows.Forms.Padding(1);
            this.TBNum_documento.Name = "TBNum_documento";
            this.TBNum_documento.Size = new System.Drawing.Size(103, 19);
            this.TBNum_documento.TabIndex = 7;
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TBEmail.Location = new System.Drawing.Point(212, 116);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(177, 19);
            this.TBEmail.TabIndex = 8;
            // 
            // TBTelefono
            // 
            this.TBTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.TBTelefono.Location = new System.Drawing.Point(17, 71);
            this.TBTelefono.Margin = new System.Windows.Forms.Padding(1);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(87, 19);
            this.TBTelefono.TabIndex = 3;
            // 
            // TBNombre
            // 
            this.TBNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TBNombre.Location = new System.Drawing.Point(16, 33);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(1);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(138, 19);
            this.TBNombre.TabIndex = 1;
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Location = new System.Drawing.Point(15, 145);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(55, 13);
            this.LDireccion.TabIndex = 0;
            this.LDireccion.Text = "Direccion:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(210, 102);
            this.LEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(35, 13);
            this.LEmail.TabIndex = 0;
            this.LEmail.Text = "Email:";
            // 
            // lNum_documento
            // 
            this.lNum_documento.AutoSize = true;
            this.lNum_documento.Location = new System.Drawing.Point(271, 57);
            this.lNum_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lNum_documento.Name = "lNum_documento";
            this.lNum_documento.Size = new System.Drawing.Size(120, 13);
            this.lNum_documento.TabIndex = 0;
            this.lNum_documento.Text = "Numero de Documento:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(14, 57);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 0;
            this.LTelefono.Text = "Telefono:";
            // 
            // LTipo_documento
            // 
            this.LTipo_documento.AutoSize = true;
            this.LTipo_documento.Location = new System.Drawing.Point(210, 57);
            this.LTipo_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTipo_documento.Name = "LTipo_documento";
            this.LTipo_documento.Size = new System.Drawing.Size(28, 13);
            this.LTipo_documento.TabIndex = 0;
            this.LTipo_documento.Text = "Tipo";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(14, 20);
            this.LNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DGVListado.Location = new System.Drawing.Point(10, 84);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(468, 164);
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
            // LApellidos
            // 
            this.LApellidos.AutoSize = true;
            this.LApellidos.Location = new System.Drawing.Point(210, 20);
            this.LApellidos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LApellidos.Name = "LApellidos";
            this.LApellidos.Size = new System.Drawing.Size(49, 13);
            this.LApellidos.TabIndex = 0;
            this.LApellidos.Text = "Apellidos";
            // 
            // TBApellidos
            // 
            this.TBApellidos.BackColor = System.Drawing.SystemColors.Control;
            this.TBApellidos.Location = new System.Drawing.Point(212, 33);
            this.TBApellidos.Margin = new System.Windows.Forms.Padding(1);
            this.TBApellidos.Name = "TBApellidos";
            this.TBApellidos.Size = new System.Drawing.Size(177, 19);
            this.TBApellidos.TabIndex = 2;
            // 
            // CBSexo
            // 
            this.CBSexo.BackColor = System.Drawing.SystemColors.Control;
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.ItemHeight = 13;
            this.CBSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBSexo.Location = new System.Drawing.Point(114, 71);
            this.CBSexo.Margin = new System.Windows.Forms.Padding(2);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(39, 21);
            this.CBSexo.TabIndex = 4;
            this.CBSexo.Text = "F";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Location = new System.Drawing.Point(116, 57);
            this.LSexo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(31, 13);
            this.LSexo.TabIndex = 20;
            this.LSexo.Text = "Sexo";
            // 
            // LFecha_nacimiento
            // 
            this.LFecha_nacimiento.AutoSize = true;
            this.LFecha_nacimiento.Location = new System.Drawing.Point(15, 102);
            this.LFecha_nacimiento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LFecha_nacimiento.Name = "LFecha_nacimiento";
            this.LFecha_nacimiento.Size = new System.Drawing.Size(109, 13);
            this.LFecha_nacimiento.TabIndex = 0;
            this.LFecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // DTPFecha_nacimiento
            // 
            this.DTPFecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_nacimiento.Location = new System.Drawing.Point(17, 117);
            this.DTPFecha_nacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_nacimiento.Name = "DTPFecha_nacimiento";
            this.DTPFecha_nacimiento.Size = new System.Drawing.Size(88, 19);
            this.DTPFecha_nacimiento.TabIndex = 21;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(568, 399);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTipo_documento;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBNum_documento;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label lNum_documento;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTipo_documento;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox TBApellidos;
        private System.Windows.Forms.Label LApellidos;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.DateTimePicker DTPFecha_nacimiento;
        private System.Windows.Forms.Label LFecha_nacimiento;
    }
}
