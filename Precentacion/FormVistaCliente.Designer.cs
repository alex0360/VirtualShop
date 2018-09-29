namespace Precentacion
{
    partial class FormVistaCliente
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
            this.LMostratCantidad = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.TCListado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TCListado
            // 
            this.TCListado.Size = new System.Drawing.Size(368, 413);
            // 
            // LTitulo
            // 
            this.LTitulo.Size = new System.Drawing.Size(87, 26);
            this.LTitulo.Text = "Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Controls.Add(this.LMostratCantidad);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Size = new System.Drawing.Size(360, 387);
            this.tabPage1.Controls.SetChildIndex(this.TBBuscar, 0);
            this.tabPage1.Controls.SetChildIndex(this.LMostratCantidad, 0);
            this.tabPage1.Controls.SetChildIndex(this.DGVListado, 0);
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
            this.DGVListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVListado.GridColor = System.Drawing.SystemColors.Control;
            this.DGVListado.Location = new System.Drawing.Point(4, 68);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(352, 315);
            this.DGVListado.TabIndex = 15;
            this.DGVListado.DoubleClick += new System.EventHandler(this.DGVListado_DoubleClick);
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
            this.LMostratCantidad.Location = new System.Drawing.Point(4, 44);
            this.LMostratCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMostratCantidad.Name = "LMostratCantidad";
            this.LMostratCantidad.Size = new System.Drawing.Size(13, 13);
            this.LMostratCantidad.TabIndex = 14;
            this.LMostratCantidad.Text = "0";
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(76, 17);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(150, 20);
            this.TBBuscar.TabIndex = 13;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // FormVistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 461);
            this.Name = "FormVistaCliente";
            this.Text = "Listado De Cliente";
            this.Load += new System.EventHandler(this.FormVistaCliente_Load);
            this.Resize += new System.EventHandler(this._Resize);
            this.TCListado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label LMostratCantidad;
        private System.Windows.Forms.TextBox TBBuscar;
    }
}