namespace Precentacion
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.lTituloCategoria = new System.Windows.Forms.Label();
            this.tabConCategoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labMostrarTotal = new System.Windows.Forms.Label();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.butImprimir = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.lMatenimCategoria = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupbCategoria = new System.Windows.Forms.GroupBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tooltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.PBTitulo = new System.Windows.Forms.PictureBox();
            this.tabConCategoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lTituloCategoria
            // 
            this.lTituloCategoria.AutoSize = true;
            this.lTituloCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.lTituloCategoria.Location = new System.Drawing.Point(9, 9);
            this.lTituloCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTituloCategoria.Name = "lTituloCategoria";
            this.lTituloCategoria.Size = new System.Drawing.Size(122, 26);
            this.lTituloCategoria.TabIndex = 0;
            this.lTituloCategoria.Text = "Categoria:";
            // 
            // tabConCategoria
            // 
            this.tabConCategoria.Controls.Add(this.tabPage1);
            this.tabConCategoria.Controls.Add(this.tabPage2);
            this.tabConCategoria.Location = new System.Drawing.Point(14, 37);
            this.tabConCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tabConCategoria.Name = "tabConCategoria";
            this.tabConCategoria.SelectedIndex = 0;
            this.tabConCategoria.Size = new System.Drawing.Size(588, 329);
            this.tabConCategoria.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagListado);
            this.tabPage1.Controls.Add(this.labMostrarTotal);
            this.tabPage1.Controls.Add(this.chbEliminar);
            this.tabPage1.Controls.Add(this.butImprimir);
            this.tabPage1.Controls.Add(this.butEliminar);
            this.tabPage1.Controls.Add(this.butBuscar);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Controls.Add(this.lMatenimCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(580, 303);
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
            this.datagListado.Location = new System.Drawing.Point(11, 109);
            this.datagListado.Margin = new System.Windows.Forms.Padding(2);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(532, 164);
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
            this.labMostrarTotal.Location = new System.Drawing.Point(8, 288);
            this.labMostrarTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMostrarTotal.Name = "labMostrarTotal";
            this.labMostrarTotal.Size = new System.Drawing.Size(13, 13);
            this.labMostrarTotal.TabIndex = 4;
            this.labMostrarTotal.Text = "0";
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(11, 80);
            this.chbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(62, 17);
            this.chbEliminar.TabIndex = 3;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            this.chbEliminar.CheckedChanged += new System.EventHandler(this.ChbEliminar_CheckedChanged);
            // 
            // butImprimir
            // 
            this.butImprimir.Location = new System.Drawing.Point(666, 2);
            this.butImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(86, 28);
            this.butImprimir.TabIndex = 2;
            this.butImprimir.Text = "&Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(457, 11);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(86, 28);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "&Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Location = new System.Drawing.Point(367, 11);
            this.butBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(86, 28);
            this.butBuscar.TabIndex = 2;
            this.butBuscar.Text = "&Buscar";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.ButBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(59, 16);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(153, 20);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // lMatenimCategoria
            // 
            this.lMatenimCategoria.AutoSize = true;
            this.lMatenimCategoria.Location = new System.Drawing.Point(8, 19);
            this.lMatenimCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMatenimCategoria.Name = "lMatenimCategoria";
            this.lMatenimCategoria.Size = new System.Drawing.Size(47, 13);
            this.lMatenimCategoria.TabIndex = 0;
            this.lMatenimCategoria.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupbCategoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(580, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupbCategoria
            // 
            this.groupbCategoria.Controls.Add(this.butCancelar);
            this.groupbCategoria.Controls.Add(this.butGuardar);
            this.groupbCategoria.Controls.Add(this.tbDescripcion);
            this.groupbCategoria.Controls.Add(this.tbNombre);
            this.groupbCategoria.Controls.Add(this.labDescripcion);
            this.groupbCategoria.Controls.Add(this.labNombre);
            this.groupbCategoria.Location = new System.Drawing.Point(18, 19);
            this.groupbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.groupbCategoria.Name = "groupbCategoria";
            this.groupbCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.groupbCategoria.Size = new System.Drawing.Size(449, 234);
            this.groupbCategoria.TabIndex = 0;
            this.groupbCategoria.TabStop = false;
            this.groupbCategoria.Text = "Categoria";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(294, 185);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(96, 29);
            this.butCancelar.TabIndex = 4;
            this.butCancelar.Text = "&Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(80, 185);
            this.butGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(96, 29);
            this.butGuardar.TabIndex = 4;
            this.butGuardar.Text = "&Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.ButGuardar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescripcion.Location = new System.Drawing.Point(80, 72);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(311, 80);
            this.tbDescripcion.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.Location = new System.Drawing.Point(80, 38);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(311, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(11, 74);
            this.labDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labDescripcion.TabIndex = 2;
            this.labDescripcion.Text = "Descripcion:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(11, 41);
            this.labNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // PBTitulo
            // 
            this.PBTitulo.Image = ((System.Drawing.Image)(resources.GetObject("PBTitulo.Image")));
            this.PBTitulo.Location = new System.Drawing.Point(502, 9);
            this.PBTitulo.Name = "PBTitulo";
            this.PBTitulo.Size = new System.Drawing.Size(100, 50);
            this.PBTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTitulo.TabIndex = 2;
            this.PBTitulo.TabStop = false;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 377);
            this.Controls.Add(this.PBTitulo);
            this.Controls.Add(this.tabConCategoria);
            this.Controls.Add(this.lTituloCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategoria";
            this.Text = "Matenimiento de Categoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.Resize += new System.EventHandler(this.FormCategoria_Resize);
            this.tabConCategoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupbCategoria.ResumeLayout(false);
            this.groupbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.Label lTituloCategoria;
        private System.Windows.Forms.TabControl tabConCategoria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView datagListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label labMostrarTotal;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.Button butImprimir;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label lMatenimCategoria;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupbCategoria;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip tooltMensaje;
        private System.Windows.Forms.PictureBox PBTitulo;
    }
}