namespace Precentacion
{
    partial class FormVistaCategoria_Articulo
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
            this.tabConCategoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labMostrarTotal = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lMatenimCategoria = new System.Windows.Forms.Label();
            this.lTituloCategoria = new System.Windows.Forms.Label();
            this.BAddDataBase = new System.Windows.Forms.Button();
            this.tabConCategoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConCategoria
            // 
            this.tabConCategoria.Controls.Add(this.tabPage1);
            this.tabConCategoria.Location = new System.Drawing.Point(12, 45);
            this.tabConCategoria.Name = "tabConCategoria";
            this.tabConCategoria.SelectedIndex = 0;
            this.tabConCategoria.Size = new System.Drawing.Size(392, 394);
            this.tabConCategoria.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BAddDataBase);
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Controls.Add(this.labMostrarTotal);
            this.tabPage1.Controls.Add(this.tbBuscar);
            this.tabPage1.Controls.Add(this.lMatenimCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datagListado
            // 
            this.datagListado.AllowUserToAddRows = false;
            this.datagListado.AllowUserToDeleteRows = false;
            this.datagListado.AllowUserToOrderColumns = true;
            this.datagListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datagListado.Location = new System.Drawing.Point(23, 134);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(326, 202);
            this.datagListado.TabIndex = 5;
            this.datagListado.DoubleClick += new System.EventHandler(this.DatagListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // labMostrarTotal
            // 
            this.labMostrarTotal.AutoSize = true;
            this.labMostrarTotal.Location = new System.Drawing.Point(33, 100);
            this.labMostrarTotal.Name = "labMostrarTotal";
            this.labMostrarTotal.Size = new System.Drawing.Size(16, 17);
            this.labMostrarTotal.TabIndex = 4;
            this.labMostrarTotal.Text = "0";
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.tbBuscar.Location = new System.Drawing.Point(120, 21);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(178, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // lMatenimCategoria
            // 
            this.lMatenimCategoria.AutoSize = true;
            this.lMatenimCategoria.Location = new System.Drawing.Point(33, 24);
            this.lMatenimCategoria.Name = "lMatenimCategoria";
            this.lMatenimCategoria.Size = new System.Drawing.Size(62, 17);
            this.lMatenimCategoria.TabIndex = 0;
            this.lMatenimCategoria.Text = "Nombre:";
            // 
            // lTituloCategoria
            // 
            this.lTituloCategoria.AutoSize = true;
            this.lTituloCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.lTituloCategoria.Location = new System.Drawing.Point(12, 11);
            this.lTituloCategoria.Name = "lTituloCategoria";
            this.lTituloCategoria.Size = new System.Drawing.Size(150, 31);
            this.lTituloCategoria.TabIndex = 2;
            this.lTituloCategoria.Text = "Categoria:";
            // 
            // BAddDataBase
            // 
            this.BAddDataBase.BackgroundImage = global::Precentacion.Properties.Resources.addDataBase24x;
            this.BAddDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BAddDataBase.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BAddDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAddDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BAddDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddDataBase.Location = new System.Drawing.Point(308, 11);
            this.BAddDataBase.Name = "BAddDataBase";
            this.BAddDataBase.Size = new System.Drawing.Size(41, 43);
            this.BAddDataBase.TabIndex = 9;
            this.BAddDataBase.UseVisualStyleBackColor = true;
            this.BAddDataBase.Click += new System.EventHandler(this.BAddDataBase_Click);
            // 
            // FormVistaCategoria_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.tabConCategoria);
            this.Controls.Add(this.lTituloCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVistaCategoria_Articulo";
            this.Text = "Listado de Categoria";
            this.Load += new System.EventHandler(this.FormVistaCategoria_Articulo_Load);
            this.tabConCategoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabConCategoria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datagListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label labMostrarTotal;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lMatenimCategoria;
        private System.Windows.Forms.Label lTituloCategoria;
        private System.Windows.Forms.Button BAddDataBase;
    }
}