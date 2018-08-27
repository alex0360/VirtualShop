namespace Precentacion
{
    partial class FormTrabajador
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
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CBTipo_documento = new System.Windows.Forms.ComboBox();
            this.TBNum_documento = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBApellidos = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.lNum_documento = new System.Windows.Forms.Label();
            this.LTipo_documento = new System.Windows.Forms.Label();
            this.DTPFecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.LSexo = new System.Windows.Forms.Label();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LFecha_nacimiento = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellidos = new System.Windows.Forms.Label();
            this.PCuanta = new System.Windows.Forms.Panel();
            this.LAcesso = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.CBAcesso = new System.Windows.Forms.ComboBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.PCuanta.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(520, 231);
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(337, 231);
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Size = new System.Drawing.Size(155, 31);
            this.LTitulo.Text = "Trabajador";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVListado);
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
            this.GBMatenimiento.Controls.Add(this.PCuanta);
            this.GBMatenimiento.Controls.Add(this.LApellidos);
            this.GBMatenimiento.Controls.Add(this.DTPFecha_nacimiento);
            this.GBMatenimiento.Controls.Add(this.CBSexo);
            this.GBMatenimiento.Controls.Add(this.LSexo);
            this.GBMatenimiento.Controls.Add(this.TBDireccion);
            this.GBMatenimiento.Controls.Add(this.TBTelefono);
            this.GBMatenimiento.Controls.Add(this.TBNombre);
            this.GBMatenimiento.Controls.Add(this.LFecha_nacimiento);
            this.GBMatenimiento.Controls.Add(this.LDireccion);
            this.GBMatenimiento.Controls.Add(this.LTelefono);
            this.GBMatenimiento.Controls.Add(this.LNombre);
            this.GBMatenimiento.Controls.Add(this.CBTipo_documento);
            this.GBMatenimiento.Controls.Add(this.TBNum_documento);
            this.GBMatenimiento.Controls.Add(this.TBEmail);
            this.GBMatenimiento.Controls.Add(this.TBApellidos);
            this.GBMatenimiento.Controls.Add(this.LEmail);
            this.GBMatenimiento.Controls.Add(this.lNum_documento);
            this.GBMatenimiento.Controls.Add(this.LTipo_documento);
            this.GBMatenimiento.Size = new System.Drawing.Size(737, 309);
            this.GBMatenimiento.Text = "Trabajador";
            this.GBMatenimiento.Controls.SetChildIndex(this.BGuardar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.BCancelar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTipo_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.lNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBApellidos, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBTipo_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LNombre, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LFecha_nacimiento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBNombre, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LSexo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBSexo, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.DTPFecha_nacimiento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LApellidos, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.PCuanta, 0);
            // 
            // BEliminar
            // 
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
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
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DGVListado.Location = new System.Drawing.Point(15, 106);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(745, 202);
            this.DGVListado.TabIndex = 9;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.DoubleClick += new System.EventHandler(this.DGVListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // CBTipo_documento
            // 
            this.CBTipo_documento.BackColor = System.Drawing.SystemColors.Control;
            this.CBTipo_documento.FormattingEnabled = true;
            this.CBTipo_documento.ItemHeight = 16;
            this.CBTipo_documento.Location = new System.Drawing.Point(256, 94);
            this.CBTipo_documento.Name = "CBTipo_documento";
            this.CBTipo_documento.Size = new System.Drawing.Size(209, 24);
            this.CBTipo_documento.TabIndex = 13;
            // 
            // TBNum_documento
            // 
            this.TBNum_documento.BackColor = System.Drawing.SystemColors.Control;
            this.TBNum_documento.Location = new System.Drawing.Point(256, 143);
            this.TBNum_documento.Margin = new System.Windows.Forms.Padding(1);
            this.TBNum_documento.Name = "TBNum_documento";
            this.TBNum_documento.Size = new System.Drawing.Size(209, 22);
            this.TBNum_documento.TabIndex = 14;
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TBEmail.Location = new System.Drawing.Point(256, 185);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(209, 22);
            this.TBEmail.TabIndex = 15;
            // 
            // TBApellidos
            // 
            this.TBApellidos.BackColor = System.Drawing.SystemColors.Control;
            this.TBApellidos.Location = new System.Drawing.Point(256, 45);
            this.TBApellidos.Margin = new System.Windows.Forms.Padding(1);
            this.TBApellidos.Name = "TBApellidos";
            this.TBApellidos.Size = new System.Drawing.Size(209, 22);
            this.TBApellidos.TabIndex = 12;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(253, 167);
            this.LEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(46, 17);
            this.LEmail.TabIndex = 9;
            this.LEmail.Text = "Email:";
            // 
            // lNum_documento
            // 
            this.lNum_documento.AutoSize = true;
            this.lNum_documento.Location = new System.Drawing.Point(253, 121);
            this.lNum_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lNum_documento.Name = "lNum_documento";
            this.lNum_documento.Size = new System.Drawing.Size(158, 17);
            this.lNum_documento.TabIndex = 10;
            this.lNum_documento.Text = "Numero de Documento:";
            // 
            // LTipo_documento
            // 
            this.LTipo_documento.AutoSize = true;
            this.LTipo_documento.Location = new System.Drawing.Point(253, 74);
            this.LTipo_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTipo_documento.Name = "LTipo_documento";
            this.LTipo_documento.Size = new System.Drawing.Size(36, 17);
            this.LTipo_documento.TabIndex = 11;
            this.LTipo_documento.Text = "Tipo";
            // 
            // DTPFecha_nacimiento
            // 
            this.DTPFecha_nacimiento.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.DTPFecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_nacimiento.Location = new System.Drawing.Point(14, 140);
            this.DTPFecha_nacimiento.Name = "DTPFecha_nacimiento";
            this.DTPFecha_nacimiento.Size = new System.Drawing.Size(116, 22);
            this.DTPFecha_nacimiento.TabIndex = 31;
            // 
            // CBSexo
            // 
            this.CBSexo.BackColor = System.Drawing.SystemColors.Control;
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.ItemHeight = 16;
            this.CBSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBSexo.Location = new System.Drawing.Point(143, 91);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(51, 24);
            this.CBSexo.TabIndex = 28;
            this.CBSexo.Text = "F";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Location = new System.Drawing.Point(145, 74);
            this.LSexo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(39, 17);
            this.LSexo.TabIndex = 30;
            this.LSexo.Text = "Sexo";
            // 
            // TBDireccion
            // 
            this.TBDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TBDireccion.Location = new System.Drawing.Point(13, 185);
            this.TBDireccion.Margin = new System.Windows.Forms.Padding(1);
            this.TBDireccion.Multiline = true;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(180, 66);
            this.TBDireccion.TabIndex = 29;
            // 
            // TBTelefono
            // 
            this.TBTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.TBTelefono.Location = new System.Drawing.Point(14, 91);
            this.TBTelefono.Margin = new System.Windows.Forms.Padding(1);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(115, 22);
            this.TBTelefono.TabIndex = 27;
            // 
            // TBNombre
            // 
            this.TBNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TBNombre.Location = new System.Drawing.Point(13, 45);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(1);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(183, 22);
            this.TBNombre.TabIndex = 26;
            // 
            // LFecha_nacimiento
            // 
            this.LFecha_nacimiento.AutoSize = true;
            this.LFecha_nacimiento.Location = new System.Drawing.Point(11, 121);
            this.LFecha_nacimiento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LFecha_nacimiento.Name = "LFecha_nacimiento";
            this.LFecha_nacimiento.Size = new System.Drawing.Size(143, 17);
            this.LFecha_nacimiento.TabIndex = 22;
            this.LFecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Location = new System.Drawing.Point(11, 167);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(71, 17);
            this.LDireccion.TabIndex = 23;
            this.LDireccion.Text = "Direccion:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(10, 74);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(68, 17);
            this.LTelefono.TabIndex = 24;
            this.LTelefono.Text = "Telefono:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(10, 28);
            this.LNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 17);
            this.LNombre.TabIndex = 25;
            this.LNombre.Text = "Nombre";
            // 
            // LApellidos
            // 
            this.LApellidos.AutoSize = true;
            this.LApellidos.Location = new System.Drawing.Point(253, 28);
            this.LApellidos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LApellidos.Name = "LApellidos";
            this.LApellidos.Size = new System.Drawing.Size(65, 17);
            this.LApellidos.TabIndex = 32;
            this.LApellidos.Text = "Apellidos";
            // 
            // PCuanta
            // 
            this.PCuanta.Controls.Add(this.TBPassword);
            this.PCuanta.Controls.Add(this.TBUsuario);
            this.PCuanta.Controls.Add(this.CBAcesso);
            this.PCuanta.Controls.Add(this.LPassword);
            this.PCuanta.Controls.Add(this.LUsuario);
            this.PCuanta.Controls.Add(this.LAcesso);
            this.PCuanta.Location = new System.Drawing.Point(488, 45);
            this.PCuanta.Name = "PCuanta";
            this.PCuanta.Size = new System.Drawing.Size(232, 162);
            this.PCuanta.TabIndex = 33;
            // 
            // LAcesso
            // 
            this.LAcesso.AutoSize = true;
            this.LAcesso.Location = new System.Drawing.Point(18, 22);
            this.LAcesso.Name = "LAcesso";
            this.LAcesso.Size = new System.Drawing.Size(58, 17);
            this.LAcesso.TabIndex = 0;
            this.LAcesso.Text = "Acesso:";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(15, 73);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(61, 17);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(10, 118);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(73, 17);
            this.LPassword.TabIndex = 0;
            this.LPassword.Text = "Password:";
            // 
            // CBAcesso
            // 
            this.CBAcesso.BackColor = System.Drawing.SystemColors.Control;
            this.CBAcesso.FormattingEnabled = true;
            this.CBAcesso.Location = new System.Drawing.Point(82, 22);
            this.CBAcesso.Name = "CBAcesso";
            this.CBAcesso.Size = new System.Drawing.Size(136, 24);
            this.CBAcesso.TabIndex = 1;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.TBUsuario.Location = new System.Drawing.Point(82, 73);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(136, 22);
            this.TBUsuario.TabIndex = 2;
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TBPassword.Location = new System.Drawing.Point(82, 115);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(136, 22);
            this.TBPassword.TabIndex = 2;
            // 
            // FormTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(857, 491);
            this.Name = "FormTrabajador";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.FormTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.PCuanta.ResumeLayout(false);
            this.PCuanta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ComboBox CBTipo_documento;
        private System.Windows.Forms.TextBox TBNum_documento;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBApellidos;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label lNum_documento;
        private System.Windows.Forms.Label LTipo_documento;
        private System.Windows.Forms.DateTimePicker DTPFecha_nacimiento;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LFecha_nacimiento;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellidos;
        private System.Windows.Forms.Panel PCuanta;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LAcesso;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.ComboBox CBAcesso;
    }
}
