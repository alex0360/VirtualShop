namespace Precentacion
{
    partial class FormVistaProveedor
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
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LMostratCantidad = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.TCListado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TCListado
            // 
            this.TCListado.Size = new System.Drawing.Size(329, 320);
            // 
            // LTitulo
            // 
            this.LTitulo.Size = new System.Drawing.Size(121, 26);
            this.LTitulo.Text = "Proveedor";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Controls.Add(this.LMostratCantidad);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Size = new System.Drawing.Size(321, 294);
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LMostratCantidad, 0);
            this.tabPage1.Controls.SetChildIndex(this.datagListado, 0);
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
            this.datagListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.datagListado.GridColor = System.Drawing.SystemColors.Control;
            this.datagListado.Location = new System.Drawing.Point(4, 87);
            this.datagListado.Margin = new System.Windows.Forms.Padding(2);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(306, 184);
            this.datagListado.TabIndex = 12;
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
            this.LMostratCantidad.Location = new System.Drawing.Point(24, 63);
            this.LMostratCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMostratCantidad.Name = "LMostratCantidad";
            this.LMostratCantidad.Size = new System.Drawing.Size(13, 13);
            this.LMostratCantidad.TabIndex = 11;
            this.LMostratCantidad.Text = "0";
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(76, 17);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(134, 20);
            this.TBBuscar.TabIndex = 10;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // FormVistaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 378);
            this.Name = "FormVistaProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FormVistaProveedor_Load);
            this.TCListado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label LMostratCantidad;
        private System.Windows.Forms.TextBox TBBuscar;
    }
}