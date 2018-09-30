namespace Precentacion
{
    partial class FormPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.lTitulo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupb = new System.Windows.Forms.GroupBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labMostrarTotal = new System.Windows.Forms.Label();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.butImprimir = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lMatenimCategoria = new System.Windows.Forms.Label();
            this.tooltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.PBTitulo = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.groupb.SuspendLayout();
            this.tabCon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lTitulo.Location = new System.Drawing.Point(12, 24);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(158, 26);
            this.lTitulo.TabIndex = 2;
            this.lTitulo.Text = "Presentacion:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupb
            // 
            this.groupb.Controls.Add(this.butCancelar);
            this.groupb.Controls.Add(this.butGuardar);
            this.groupb.Controls.Add(this.tbDescripcion);
            this.groupb.Controls.Add(this.tbNombre);
            this.groupb.Controls.Add(this.labDescripcion);
            this.groupb.Controls.Add(this.labNombre);
            this.groupb.Location = new System.Drawing.Point(17, 20);
            this.groupb.Name = "groupb";
            this.groupb.Size = new System.Drawing.Size(394, 292);
            this.groupb.TabIndex = 0;
            this.groupb.TabStop = false;
            this.groupb.Text = "Presentacion";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(241, 209);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(128, 36);
            this.butCancelar.TabIndex = 6;
            this.butCancelar.Text = "&Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(107, 209);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(128, 36);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "&Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.ButGuardar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescripcion.Location = new System.Drawing.Point(107, 88);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(261, 97);
            this.tbDescripcion.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.Location = new System.Drawing.Point(107, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(261, 19);
            this.tbNombre.TabIndex = 2;
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(15, 91);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labDescripcion.TabIndex = 3;
            this.labDescripcion.Text = "Descripcion:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(15, 50);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre:";
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage2);
            this.tabCon.Location = new System.Drawing.Point(18, 65);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(419, 365);
            this.tabCon.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Controls.Add(this.labMostrarTotal);
            this.tabPage1.Controls.Add(this.chbEliminar);
            this.tabPage1.Controls.Add(this.butImprimir);
            this.tabPage1.Controls.Add(this.butEliminar);
            this.tabPage1.Controls.Add(this.tbBuscar);
            this.tabPage1.Controls.Add(this.lMatenimCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 339);
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
            this.datagListado.Location = new System.Drawing.Point(15, 125);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(374, 168);
            this.datagListado.TabIndex = 5;
            this.datagListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagListado_CellContentClick);
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
            this.labMostrarTotal.Location = new System.Drawing.Point(12, 305);
            this.labMostrarTotal.Name = "labMostrarTotal";
            this.labMostrarTotal.Size = new System.Drawing.Size(13, 13);
            this.labMostrarTotal.TabIndex = 6;
            this.labMostrarTotal.Text = "0";
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(15, 98);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(62, 17);
            this.chbEliminar.TabIndex = 4;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            this.chbEliminar.CheckedChanged += new System.EventHandler(this.ChbEliminar_CheckedChanged);
            // 
            // butImprimir
            // 
            this.butImprimir.Location = new System.Drawing.Point(292, 15);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(97, 34);
            this.butImprimir.TabIndex = 3;
            this.butImprimir.Text = "&Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(190, 15);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(96, 34);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "&Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.tbBuscar.Location = new System.Drawing.Point(65, 21);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(119, 19);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // lMatenimCategoria
            // 
            this.lMatenimCategoria.AutoSize = true;
            this.lMatenimCategoria.Location = new System.Drawing.Point(12, 24);
            this.lMatenimCategoria.Name = "lMatenimCategoria";
            this.lMatenimCategoria.Size = new System.Drawing.Size(47, 13);
            this.lMatenimCategoria.TabIndex = 0;
            this.lMatenimCategoria.Text = "Nombre:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // PBTitulo
            // 
            this.PBTitulo.Image = ((System.Drawing.Image)(resources.GetObject("PBTitulo.Image")));
            this.PBTitulo.Location = new System.Drawing.Point(282, 7);
            this.PBTitulo.Name = "PBTitulo";
            this.PBTitulo.Size = new System.Drawing.Size(151, 74);
            this.PBTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTitulo.TabIndex = 9;
            this.PBTitulo.TabStop = false;
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 447);
            this.Controls.Add(this.PBTitulo);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.lTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPresentacion";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            this.Resize += new System.EventHandler(this._Resize);
            this.tabPage2.ResumeLayout(false);
            this.groupb.ResumeLayout(false);
            this.groupb.PerformLayout();
            this.tabCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupb;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TabControl tabCon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datagListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label labMostrarTotal;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.Button butImprimir;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lMatenimCategoria;
        private System.Windows.Forms.ToolTip tooltMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        public System.Windows.Forms.PictureBox PBTitulo;
    }
}