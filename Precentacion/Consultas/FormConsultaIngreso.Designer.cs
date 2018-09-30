namespace Precentacion.Consultas
{
    partial class FormConsultaIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaIngreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BActualizar = new System.Windows.Forms.Button();
            this.BBuscar_fecha = new System.Windows.Forms.Button();
            this.LFecha_Final = new System.Windows.Forms.Label();
            this.DTPFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.LFecha_Inicial = new System.Windows.Forms.Label();
            this.DTPFecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.Size = new System.Drawing.Size(101, 29);
            this.LTitulo.Text = "Ingreso";
            // 
            // PBImagen
            // 
            this.PBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PBImagen.Image")));
            this.PBImagen.Location = new System.Drawing.Point(648, 9);
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(581, 9);
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.Location = new System.Drawing.Point(14, 465);
            // 
            // BActualizar
            // 
            this.BActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BActualizar.BackgroundImage")));
            this.BActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BActualizar.Location = new System.Drawing.Point(238, 42);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(45, 39);
            this.BActualizar.TabIndex = 39;
            this.BActualizar.UseVisualStyleBackColor = true;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
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
            this.BBuscar_fecha.Location = new System.Drawing.Point(190, 59);
            this.BBuscar_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.BBuscar_fecha.Name = "BBuscar_fecha";
            this.BBuscar_fecha.Size = new System.Drawing.Size(22, 21);
            this.BBuscar_fecha.TabIndex = 38;
            this.BBuscar_fecha.UseVisualStyleBackColor = true;
            this.BBuscar_fecha.Click += new System.EventHandler(this.BBuscar_fecha_Click);
            // 
            // LFecha_Final
            // 
            this.LFecha_Final.AutoSize = true;
            this.LFecha_Final.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha_Final.Location = new System.Drawing.Point(113, 41);
            this.LFecha_Final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Final.Name = "LFecha_Final";
            this.LFecha_Final.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Final.TabIndex = 36;
            this.LFecha_Final.Text = "Fecha Inicial";
            // 
            // DTPFecha_Final
            // 
            this.DTPFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Final.Location = new System.Drawing.Point(112, 60);
            this.DTPFecha_Final.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_Final.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Final.Name = "DTPFecha_Final";
            this.DTPFecha_Final.Size = new System.Drawing.Size(74, 20);
            this.DTPFecha_Final.TabIndex = 34;
            this.DTPFecha_Final.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 221);
            // 
            // LFecha_Inicial
            // 
            this.LFecha_Inicial.AutoSize = true;
            this.LFecha_Inicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LFecha_Inicial.Location = new System.Drawing.Point(14, 41);
            this.LFecha_Inicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha_Inicial.Name = "LFecha_Inicial";
            this.LFecha_Inicial.Size = new System.Drawing.Size(67, 13);
            this.LFecha_Inicial.TabIndex = 37;
            this.LFecha_Inicial.Text = "Fecha Inicial";
            // 
            // DTPFecha_inicio
            // 
            this.DTPFecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_inicio.Location = new System.Drawing.Point(14, 60);
            this.DTPFecha_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_inicio.Name = "DTPFecha_inicio";
            this.DTPFecha_inicio.Size = new System.Drawing.Size(74, 20);
            this.DTPFecha_inicio.TabIndex = 35;
            this.DTPFecha_inicio.Value = new System.DateTime(2018, 9, 18, 11, 11, 35, 217);
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.BackgroundColor = System.Drawing.Color.White;
            this.DGVListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListado.GridColor = System.Drawing.SystemColors.Control;
            this.DGVListado.Location = new System.Drawing.Point(11, 99);
            this.DGVListado.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListado.MultiSelect = false;
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(771, 344);
            this.DGVListado.TabIndex = 33;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormConsultaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.BBuscar_fecha);
            this.Controls.Add(this.LFecha_Final);
            this.Controls.Add(this.DTPFecha_Final);
            this.Controls.Add(this.LFecha_Inicial);
            this.Controls.Add(this.DTPFecha_inicio);
            this.Controls.Add(this.DGVListado);
            this.Name = "FormConsultaIngreso";
            this.Text = "Consulta de Ingreso";
            this.Load += new System.EventHandler(this._Load);
            this.Resize += new System.EventHandler(this._Resize);
            this.Controls.SetChildIndex(this.LTitulo, 0);
            this.Controls.SetChildIndex(this.PBImagen, 0);
            this.Controls.SetChildIndex(this.BImprimir, 0);
            this.Controls.SetChildIndex(this.LTotalRegistro, 0);
            this.Controls.SetChildIndex(this.DGVListado, 0);
            this.Controls.SetChildIndex(this.DTPFecha_inicio, 0);
            this.Controls.SetChildIndex(this.LFecha_Inicial, 0);
            this.Controls.SetChildIndex(this.DTPFecha_Final, 0);
            this.Controls.SetChildIndex(this.LFecha_Final, 0);
            this.Controls.SetChildIndex(this.BBuscar_fecha, 0);
            this.Controls.SetChildIndex(this.BActualizar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BActualizar;
        private System.Windows.Forms.Button BBuscar_fecha;
        private System.Windows.Forms.Label LFecha_Final;
        private System.Windows.Forms.DateTimePicker DTPFecha_Final;
        private System.Windows.Forms.Label LFecha_Inicial;
        private System.Windows.Forms.DateTimePicker DTPFecha_inicio;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}