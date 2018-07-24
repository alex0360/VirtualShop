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
            this.tbBuscar = new System.Windows.Forms.TextBox();
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
            this.tabConCategoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lTituloCategoria
            // 
            this.lTituloCategoria.AutoSize = true;
            this.lTituloCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTituloCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.lTituloCategoria.Location = new System.Drawing.Point(13, 23);
            this.lTituloCategoria.Name = "lTituloCategoria";
            this.lTituloCategoria.Size = new System.Drawing.Size(150, 31);
            this.lTituloCategoria.TabIndex = 0;
            this.lTituloCategoria.Text = "Categoria:";
            // 
            // tabConCategoria
            // 
            this.tabConCategoria.Controls.Add(this.tabPage1);
            this.tabConCategoria.Controls.Add(this.tabPage2);
            this.tabConCategoria.Location = new System.Drawing.Point(19, 58);
            this.tabConCategoria.Name = "tabConCategoria";
            this.tabConCategoria.SelectedIndex = 0;
            this.tabConCategoria.Size = new System.Drawing.Size(746, 394);
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
            this.tabPage1.Controls.Add(this.tbBuscar);
            this.tabPage1.Controls.Add(this.lMatenimCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 365);
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
            this.datagListado.Location = new System.Drawing.Point(15, 134);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(709, 202);
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
            this.labMostrarTotal.Location = new System.Drawing.Point(561, 88);
            this.labMostrarTotal.Name = "labMostrarTotal";
            this.labMostrarTotal.Size = new System.Drawing.Size(16, 17);
            this.labMostrarTotal.TabIndex = 4;
            this.labMostrarTotal.Text = "0";
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(15, 98);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(80, 21);
            this.chbEliminar.TabIndex = 3;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            this.chbEliminar.CheckedChanged += new System.EventHandler(this.ChbEliminar_CheckedChanged);
            // 
            // butImprimir
            // 
            this.butImprimir.Location = new System.Drawing.Point(609, 15);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(115, 34);
            this.butImprimir.TabIndex = 2;
            this.butImprimir.Text = "&Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(478, 15);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(115, 34);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "&Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Location = new System.Drawing.Point(347, 15);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(115, 34);
            this.butBuscar.TabIndex = 2;
            this.butBuscar.Text = "&Buscar";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.ButBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.tbBuscar.Location = new System.Drawing.Point(120, 21);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(203, 22);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupbCategoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 365);
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
            this.groupbCategoria.Location = new System.Drawing.Point(24, 23);
            this.groupbCategoria.Name = "groupbCategoria";
            this.groupbCategoria.Size = new System.Drawing.Size(599, 288);
            this.groupbCategoria.TabIndex = 0;
            this.groupbCategoria.TabStop = false;
            this.groupbCategoria.Text = "Categoria";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(392, 228);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(128, 36);
            this.butCancelar.TabIndex = 4;
            this.butCancelar.Text = "&Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(107, 228);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(128, 36);
            this.butGuardar.TabIndex = 4;
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
            this.tbDescripcion.Size = new System.Drawing.Size(413, 97);
            this.tbDescripcion.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.Location = new System.Drawing.Point(107, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(413, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(15, 91);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(86, 17);
            this.labDescripcion.TabIndex = 2;
            this.labDescripcion.Text = "Descripcion:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(15, 50);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 17);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 464);
            this.Controls.Add(this.tabConCategoria);
            this.Controls.Add(this.lTituloCategoria);
            this.Name = "FormCategoria";
            this.Text = "Matenimiento de Categoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.tabConCategoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupbCategoria.ResumeLayout(false);
            this.groupbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
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
        private System.Windows.Forms.TextBox tbBuscar;
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
    }
}