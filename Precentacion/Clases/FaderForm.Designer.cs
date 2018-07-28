namespace Precentacion.Clases
{
    partial class FaderForm
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
            this.components = new System.ComponentModel.Container();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GBMatenimiento = new System.Windows.Forms.GroupBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.EPErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LTotalRegistro = new System.Windows.Forms.Label();
            this.CBEliminar = new System.Windows.Forms.CheckBox();
            this.BImprimir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.TTMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.LTitulo = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.GBMatenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).BeginInit();
            this.tabCon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(470, 236);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(112, 34);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(335, 236);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(112, 34);
            this.BGuardar.TabIndex = 5;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.TBDescripcion.Location = new System.Drawing.Point(92, 121);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDescripcion.Size = new System.Drawing.Size(229, 93);
            this.TBDescripcion.TabIndex = 4;
            // 
            // TBNombre
            // 
            this.TBNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TBNombre.Location = new System.Drawing.Point(92, 56);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(229, 21);
            this.TBNombre.TabIndex = 2;
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(6, 124);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(76, 15);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripcion:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GBMatenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(629, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GBMatenimiento
            // 
            this.GBMatenimiento.Controls.Add(this.BCancelar);
            this.GBMatenimiento.Controls.Add(this.BGuardar);
            this.GBMatenimiento.Controls.Add(this.TBDescripcion);
            this.GBMatenimiento.Controls.Add(this.TBNombre);
            this.GBMatenimiento.Controls.Add(this.LDescripcion);
            this.GBMatenimiento.Controls.Add(this.LNombre);
            this.GBMatenimiento.Location = new System.Drawing.Point(15, 19);
            this.GBMatenimiento.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GBMatenimiento.Name = "GBMatenimiento";
            this.GBMatenimiento.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.GBMatenimiento.Size = new System.Drawing.Size(596, 274);
            this.GBMatenimiento.TabIndex = 0;
            this.GBMatenimiento.TabStop = false;
            this.GBMatenimiento.Text = "-Texto-";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(15, 59);
            this.LNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(55, 15);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // EPErrorIcono
            // 
            this.EPErrorIcono.ContainerControl = this;
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage2);
            this.tabCon.Location = new System.Drawing.Point(34, 56);
            this.tabCon.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(637, 344);
            this.tabCon.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Controls.Add(this.LTotalRegistro);
            this.tabPage1.Controls.Add(this.CBEliminar);
            this.tabPage1.Controls.Add(this.BImprimir);
            this.tabPage1.Controls.Add(this.BEliminar);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Controls.Add(this.LBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(629, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.DGVListado.Location = new System.Drawing.Point(13, 89);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(601, 196);
            this.DGVListado.TabIndex = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.AutoSize = true;
            this.LTotalRegistro.Location = new System.Drawing.Point(8, 286);
            this.LTotalRegistro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTotalRegistro.Name = "LTotalRegistro";
            this.LTotalRegistro.Size = new System.Drawing.Size(14, 15);
            this.LTotalRegistro.TabIndex = 6;
            this.LTotalRegistro.Text = "0";
            // 
            // CBEliminar
            // 
            this.CBEliminar.AutoSize = true;
            this.CBEliminar.Location = new System.Drawing.Point(13, 61);
            this.CBEliminar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(75, 19);
            this.CBEliminar.TabIndex = 4;
            this.CBEliminar.Text = "Eliminar";
            this.CBEliminar.UseVisualStyleBackColor = true;
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(370, 14);
            this.BImprimir.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(85, 31);
            this.BImprimir.TabIndex = 3;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(279, 14);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(84, 31);
            this.BEliminar.TabIndex = 2;
            this.BEliminar.Text = "&Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(70, 19);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(206, 21);
            this.TBBuscar.TabIndex = 1;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(10, 22);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(49, 15);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.LTitulo.Location = new System.Drawing.Point(29, 26);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(112, 31);
            this.LTitulo.TabIndex = 6;
            this.LTitulo.Text = "#Titulo:";
            // 
            // FaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 420);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.LTitulo);
            this.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FaderForm";
            this.Text = "FaderForm";
            this.tabPage2.ResumeLayout(false);
            this.GBMatenimiento.ResumeLayout(false);
            this.GBMatenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        public System.Windows.Forms.Button BCancelar;
        public System.Windows.Forms.Button BGuardar;
        public System.Windows.Forms.Label LNombre;
        public System.Windows.Forms.ErrorProvider EPErrorIcono;
        public System.Windows.Forms.TextBox TBDescripcion;
        public System.Windows.Forms.TextBox TBNombre;
        public System.Windows.Forms.Label LDescripcion;
        protected System.Windows.Forms.GroupBox GBMatenimiento;
        protected System.Windows.Forms.TabControl tabCon;
        public System.Windows.Forms.Label LTitulo;
        public System.Windows.Forms.ToolTip TTMensaje;
        public System.Windows.Forms.Button BImprimir;
        protected System.Windows.Forms.Button BEliminar;
        protected System.Windows.Forms.TextBox TBBuscar;
        protected System.Windows.Forms.Label LBuscar;
        protected System.Windows.Forms.DataGridView DGVListado;
        protected System.Windows.Forms.Label LTotalRegistro;
        protected System.Windows.Forms.CheckBox CBEliminar;
    }
}