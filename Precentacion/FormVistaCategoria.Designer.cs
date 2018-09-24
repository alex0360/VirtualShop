namespace Precentacion
{
    partial class FormVistaCategoria
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
            this.TCListado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LMostratCantidad = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.TCListado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TCListado
            // 
            this.TCListado.Controls.Add(this.tabPage1);
            this.TCListado.Location = new System.Drawing.Point(12, 40);
            this.TCListado.Margin = new System.Windows.Forms.Padding(2);
            this.TCListado.Name = "TCListado";
            this.TCListado.SelectedIndex = 0;
            this.TCListado.Size = new System.Drawing.Size(323, 320);
            this.TCListado.TabIndex = 7;
            this.TCListado.Resize += new System.EventHandler(this._Resize);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Controls.Add(this.LMostratCantidad);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Controls.Add(this.LNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(315, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.datagListado.Location = new System.Drawing.Point(28, 85);
            this.datagListado.Margin = new System.Windows.Forms.Padding(2);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(250, 184);
            this.datagListado.TabIndex = 8;
            this.datagListado.DoubleClick += new System.EventHandler(this.DatagListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // LMostratCantidad
            // 
            this.LMostratCantidad.AutoSize = true;
            this.LMostratCantidad.Location = new System.Drawing.Point(25, 70);
            this.LMostratCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMostratCantidad.Name = "LMostratCantidad";
            this.LMostratCantidad.Size = new System.Drawing.Size(13, 13);
            this.LMostratCantidad.TabIndex = 4;
            this.LMostratCantidad.Text = "0";
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(76, 17);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(167, 20);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged_1);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(25, 20);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.LTitulo.Location = new System.Drawing.Point(12, 12);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(127, 26);
            this.LTitulo.TabIndex = 6;
            this.LTitulo.Text = "Categorias";
            // 
            // FormVistaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 373);
            this.Controls.Add(this.TCListado);
            this.Controls.Add(this.LTitulo);
            this.Name = "FormVistaCategoria";
            this.Text = "FormVistaCategoria";
            this.Load += new System.EventHandler(this.FormVistaCategoria_Load);
            this.Resize += new System.EventHandler(this._Resize);
            this.TCListado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl TCListado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LMostratCantidad;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label LNombre;
        public System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.DataGridView datagListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}