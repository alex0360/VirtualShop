namespace Precentacion
{
    partial class FormProveedor
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
            this.TBRazon = new System.Windows.Forms.TextBox();
            this.LRazon = new System.Windows.Forms.Label();
            this.LSector_comercial = new System.Windows.Forms.Label();
            this.LTipo_documento = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.lNum_documento = new System.Windows.Forms.Label();
            this.TBNum_documento = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.lUrl = new System.Windows.Forms.Label();
            this.TBUrl = new System.Windows.Forms.TextBox();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CBSector_comercial = new System.Windows.Forms.ComboBox();
            this.CBTipo_documento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(232, 216);
            this.BCancelar.Size = new System.Drawing.Size(83, 29);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(140, 216);
            this.BGuardar.Size = new System.Drawing.Size(83, 29);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(10, 9);
            this.LTitulo.Size = new System.Drawing.Size(153, 26);
            this.LTitulo.Text = "Proveedores:";
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(385, 12);
            this.BImprimir.Size = new System.Drawing.Size(66, 27);
            // 
            // tabCon
            // 
            this.tabCon.Location = new System.Drawing.Point(10, 54);
            this.tabCon.Size = new System.Drawing.Size(382, 314);
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.Location = new System.Drawing.Point(8, 262);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Size = new System.Drawing.Size(374, 288);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Size = new System.Drawing.Size(374, 288);
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
            this.GBMatenimiento.Controls.Add(this.CBTipo_documento);
            this.GBMatenimiento.Controls.Add(this.CBSector_comercial);
            this.GBMatenimiento.Controls.Add(this.TBDireccion);
            this.GBMatenimiento.Controls.Add(this.TBNum_documento);
            this.GBMatenimiento.Controls.Add(this.TBUrl);
            this.GBMatenimiento.Controls.Add(this.TBEmail);
            this.GBMatenimiento.Controls.Add(this.TBTelefono);
            this.GBMatenimiento.Controls.Add(this.TBRazon);
            this.GBMatenimiento.Controls.Add(this.lUrl);
            this.GBMatenimiento.Controls.Add(this.LDireccion);
            this.GBMatenimiento.Controls.Add(this.LEmail);
            this.GBMatenimiento.Controls.Add(this.lNum_documento);
            this.GBMatenimiento.Controls.Add(this.LTelefono);
            this.GBMatenimiento.Controls.Add(this.LTipo_documento);
            this.GBMatenimiento.Controls.Add(this.LSector_comercial);
            this.GBMatenimiento.Controls.Add(this.LRazon);
            this.GBMatenimiento.Size = new System.Drawing.Size(336, 259);
            this.GBMatenimiento.Text = "Proveedor";
            this.GBMatenimiento.Controls.SetChildIndex(this.BGuardar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.BCancelar, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LRazon, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LSector_comercial, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTipo_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.lNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.LDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.lUrl, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBRazon, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBTelefono, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBEmail, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBUrl, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBNum_documento, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.TBDireccion, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBSector_comercial, 0);
            this.GBMatenimiento.Controls.SetChildIndex(this.CBTipo_documento, 0);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(286, 12);
            this.BEliminar.Size = new System.Drawing.Size(64, 27);
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(64, 16);
            this.TBBuscar.Size = new System.Drawing.Size(176, 19);
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // CBEliminar
            // 
            this.CBEliminar.Location = new System.Drawing.Point(11, 50);
            this.CBEliminar.CheckedChanged += new System.EventHandler(this.CBEliminar_CheckedChanged);
            // 
            // TBRazon
            // 
            this.TBRazon.BackColor = System.Drawing.SystemColors.Control;
            this.TBRazon.Location = new System.Drawing.Point(4, 37);
            this.TBRazon.Margin = new System.Windows.Forms.Padding(1);
            this.TBRazon.Name = "TBRazon";
            this.TBRazon.Size = new System.Drawing.Size(177, 19);
            this.TBRazon.TabIndex = 1;
            // 
            // LRazon
            // 
            this.LRazon.AutoSize = true;
            this.LRazon.Location = new System.Drawing.Point(2, 23);
            this.LRazon.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LRazon.Name = "LRazon";
            this.LRazon.Size = new System.Drawing.Size(73, 13);
            this.LRazon.TabIndex = 0;
            this.LRazon.Text = "Razon Social:";
            // 
            // LSector_comercial
            // 
            this.LSector_comercial.AutoSize = true;
            this.LSector_comercial.Location = new System.Drawing.Point(197, 23);
            this.LSector_comercial.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LSector_comercial.Name = "LSector_comercial";
            this.LSector_comercial.Size = new System.Drawing.Size(90, 13);
            this.LSector_comercial.TabIndex = 0;
            this.LSector_comercial.Text = "Sector Comercial:";
            // 
            // LTipo_documento
            // 
            this.LTipo_documento.AutoSize = true;
            this.LTipo_documento.Location = new System.Drawing.Point(4, 72);
            this.LTipo_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTipo_documento.Name = "LTipo_documento";
            this.LTipo_documento.Size = new System.Drawing.Size(104, 13);
            this.LTipo_documento.TabIndex = 0;
            this.LTipo_documento.Text = "Tipo de Documento:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Location = new System.Drawing.Point(4, 115);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(55, 13);
            this.LDireccion.TabIndex = 0;
            this.LDireccion.Text = "Direccion:";
            // 
            // TBDireccion
            // 
            this.TBDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TBDireccion.Location = new System.Drawing.Point(7, 132);
            this.TBDireccion.Margin = new System.Windows.Forms.Padding(1);
            this.TBDireccion.Multiline = true;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(177, 34);
            this.TBDireccion.TabIndex = 5;
            // 
            // lNum_documento
            // 
            this.lNum_documento.AutoSize = true;
            this.lNum_documento.Location = new System.Drawing.Point(137, 73);
            this.lNum_documento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lNum_documento.Name = "lNum_documento";
            this.lNum_documento.Size = new System.Drawing.Size(120, 13);
            this.lNum_documento.TabIndex = 0;
            this.lNum_documento.Text = "Numero de Documento:";
            // 
            // TBNum_documento
            // 
            this.TBNum_documento.BackColor = System.Drawing.SystemColors.Control;
            this.TBNum_documento.Location = new System.Drawing.Point(140, 91);
            this.TBNum_documento.Margin = new System.Windows.Forms.Padding(1);
            this.TBNum_documento.Name = "TBNum_documento";
            this.TBNum_documento.Size = new System.Drawing.Size(177, 19);
            this.TBNum_documento.TabIndex = 4;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(4, 175);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 0;
            this.LTelefono.Text = "Telefono:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.TBTelefono.Location = new System.Drawing.Point(7, 188);
            this.TBTelefono.Margin = new System.Windows.Forms.Padding(1);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(177, 19);
            this.TBTelefono.TabIndex = 7;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(196, 133);
            this.LEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(35, 13);
            this.LEmail.TabIndex = 0;
            this.LEmail.Text = "Email:";
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TBEmail.Location = new System.Drawing.Point(200, 147);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(117, 19);
            this.TBEmail.TabIndex = 6;
            // 
            // lUrl
            // 
            this.lUrl.AutoSize = true;
            this.lUrl.Location = new System.Drawing.Point(196, 175);
            this.lUrl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lUrl.Name = "lUrl";
            this.lUrl.Size = new System.Drawing.Size(32, 13);
            this.lUrl.TabIndex = 0;
            this.lUrl.Text = "URL:";
            // 
            // TBUrl
            // 
            this.TBUrl.BackColor = System.Drawing.SystemColors.Control;
            this.TBUrl.Location = new System.Drawing.Point(199, 188);
            this.TBUrl.Margin = new System.Windows.Forms.Padding(1);
            this.TBUrl.Name = "TBUrl";
            this.TBUrl.Size = new System.Drawing.Size(118, 19);
            this.TBUrl.TabIndex = 8;
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DGVListado.Location = new System.Drawing.Point(11, 79);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(351, 164);
            this.DGVListado.TabIndex = 7;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.DoubleClick += new System.EventHandler(this.DGVListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // CBSector_comercial
            // 
            this.CBSector_comercial.BackColor = System.Drawing.SystemColors.Control;
            this.CBSector_comercial.FormattingEnabled = true;
            this.CBSector_comercial.Location = new System.Drawing.Point(200, 37);
            this.CBSector_comercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBSector_comercial.Name = "CBSector_comercial";
            this.CBSector_comercial.Size = new System.Drawing.Size(88, 21);
            this.CBSector_comercial.TabIndex = 2;
            // 
            // CBTipo_documento
            // 
            this.CBTipo_documento.BackColor = System.Drawing.SystemColors.Control;
            this.CBTipo_documento.FormattingEnabled = true;
            this.CBTipo_documento.Location = new System.Drawing.Point(7, 89);
            this.CBTipo_documento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBTipo_documento.Name = "CBTipo_documento";
            this.CBTipo_documento.Size = new System.Drawing.Size(88, 21);
            this.CBTipo_documento.TabIndex = 3;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 378);
            this.Name = "FormProveedor";
            this.Text = ".:Proveedor:.";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.Resize += new System.EventHandler(this._Resize);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBRazon;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBNum_documento;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBUrl;
        private System.Windows.Forms.Label lUrl;
        private System.Windows.Forms.Label LSector_comercial;
        private System.Windows.Forms.Label LRazon;
        private System.Windows.Forms.Label LTipo_documento;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label lNum_documento;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ComboBox CBTipo_documento;
        private System.Windows.Forms.ComboBox CBSector_comercial;
    }
}