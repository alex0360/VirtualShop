namespace Precentacion
{
    partial class FormArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.labMostrarTotal = new System.Windows.Forms.Label();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.butImprimir = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lMatenimCategoria = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datagListado = new System.Windows.Forms.DataGridView();
            this.tooltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.groupb = new System.Windows.Forms.GroupBox();
            this.PFk = new System.Windows.Forms.Panel();
            this.CBPresentacion = new System.Windows.Forms.ComboBox();
            this.TBCategoria = new System.Windows.Forms.TextBox();
            this.LPresentacion = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCon = new System.Windows.Forms.TabControl();
            this.lTitulo = new System.Windows.Forms.Label();
            this.BSearchCategoria = new System.Windows.Forms.Button();
            this.BCargar = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupb.SuspendLayout();
            this.PFk.SuspendLayout();
            this.GB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // labMostrarTotal
            // 
            this.labMostrarTotal.AutoSize = true;
            this.labMostrarTotal.Location = new System.Drawing.Point(12, 305);
            this.labMostrarTotal.Name = "labMostrarTotal";
            this.labMostrarTotal.Size = new System.Drawing.Size(16, 17);
            this.labMostrarTotal.TabIndex = 6;
            this.labMostrarTotal.Text = "0";
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(15, 66);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(80, 21);
            this.chbEliminar.TabIndex = 4;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            this.chbEliminar.CheckedChanged += new System.EventHandler(this.ChbEliminar_CheckedChanged);
            // 
            // butImprimir
            // 
            this.butImprimir.Location = new System.Drawing.Point(421, 15);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(97, 34);
            this.butImprimir.TabIndex = 3;
            this.butImprimir.Text = "&Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(319, 15);
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
            this.tbBuscar.Location = new System.Drawing.Point(80, 21);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(233, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // lMatenimCategoria
            // 
            this.lMatenimCategoria.AutoSize = true;
            this.lMatenimCategoria.Location = new System.Drawing.Point(12, 24);
            this.lMatenimCategoria.Name = "lMatenimCategoria";
            this.lMatenimCategoria.Size = new System.Drawing.Size(62, 17);
            this.lMatenimCategoria.TabIndex = 0;
            this.lMatenimCategoria.Text = "Nombre:";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eleminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // datagListado
            // 
            this.datagListado.AllowUserToAddRows = false;
            this.datagListado.AllowUserToDeleteRows = false;
            this.datagListado.AllowUserToOrderColumns = true;
            this.datagListado.BackgroundColor = System.Drawing.Color.White;
            this.datagListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagListado.GridColor = System.Drawing.SystemColors.Control;
            this.datagListado.Location = new System.Drawing.Point(15, 93);
            this.datagListado.MultiSelect = false;
            this.datagListado.Name = "datagListado";
            this.datagListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagListado.RowTemplate.Height = 24;
            this.datagListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagListado.Size = new System.Drawing.Size(687, 209);
            this.datagListado.TabIndex = 5;
            this.datagListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagListado_CellContentClick);
            this.datagListado.DoubleClick += new System.EventHandler(this.DatagListado_DoubleClick);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(540, 250);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(128, 36);
            this.butCancelar.TabIndex = 6;
            this.butCancelar.Text = "&Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(381, 250);
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
            this.tbDescripcion.Location = new System.Drawing.Point(108, 129);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(261, 97);
            this.tbDescripcion.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.tbNombre.Location = new System.Drawing.Point(108, 59);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(261, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Location = new System.Drawing.Point(6, 132);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(86, 17);
            this.labDescripcion.TabIndex = 3;
            this.labDescripcion.Text = "Descripcion:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(18, 62);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 17);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre:";
            // 
            // groupb
            // 
            this.groupb.Controls.Add(this.PFk);
            this.groupb.Controls.Add(this.butCancelar);
            this.groupb.Controls.Add(this.butGuardar);
            this.groupb.Controls.Add(this.tbDescripcion);
            this.groupb.Controls.Add(this.TBCodigo);
            this.groupb.Controls.Add(this.tbNombre);
            this.groupb.Controls.Add(this.label1);
            this.groupb.Controls.Add(this.labDescripcion);
            this.groupb.Controls.Add(this.labNombre);
            this.groupb.Controls.Add(this.GB);
            this.groupb.Location = new System.Drawing.Point(17, 20);
            this.groupb.Name = "groupb";
            this.groupb.Size = new System.Drawing.Size(683, 292);
            this.groupb.TabIndex = 0;
            this.groupb.TabStop = false;
            this.groupb.Text = "Articulo";
            // 
            // PFk
            // 
            this.PFk.Controls.Add(this.CBPresentacion);
            this.PFk.Controls.Add(this.BSearchCategoria);
            this.PFk.Controls.Add(this.TBCategoria);
            this.PFk.Controls.Add(this.LPresentacion);
            this.PFk.Controls.Add(this.LCategoria);
            this.PFk.Location = new System.Drawing.Point(400, 18);
            this.PFk.Name = "PFk";
            this.PFk.Size = new System.Drawing.Size(277, 73);
            this.PFk.TabIndex = 10;
            // 
            // CBPresentacion
            // 
            this.CBPresentacion.BackColor = System.Drawing.SystemColors.Control;
            this.CBPresentacion.FormattingEnabled = true;
            this.CBPresentacion.Location = new System.Drawing.Point(104, 39);
            this.CBPresentacion.Name = "CBPresentacion";
            this.CBPresentacion.Size = new System.Drawing.Size(164, 24);
            this.CBPresentacion.TabIndex = 9;
            // 
            // TBCategoria
            // 
            this.TBCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.TBCategoria.Location = new System.Drawing.Point(82, 6);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.Size = new System.Drawing.Size(151, 22);
            this.TBCategoria.TabIndex = 2;
            // 
            // LPresentacion
            // 
            this.LPresentacion.AutoSize = true;
            this.LPresentacion.Location = new System.Drawing.Point(3, 41);
            this.LPresentacion.Name = "LPresentacion";
            this.LPresentacion.Size = new System.Drawing.Size(95, 17);
            this.LPresentacion.TabIndex = 1;
            this.LPresentacion.Text = "Presentacion:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(3, 9);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(73, 17);
            this.LCategoria.TabIndex = 1;
            this.LCategoria.Text = "Categoria:";
            // 
            // TBCodigo
            // 
            this.TBCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TBCodigo.Location = new System.Drawing.Point(108, 27);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(261, 22);
            this.TBCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // GB
            // 
            this.GB.Controls.Add(this.BCargar);
            this.GB.Controls.Add(this.BLimpiar);
            this.GB.Controls.Add(this.PBImagen);
            this.GB.Location = new System.Drawing.Point(400, 109);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(213, 135);
            this.GB.TabIndex = 9;
            this.GB.TabStop = false;
            this.GB.Text = "Imagen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupb);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage2);
            this.tabCon.Location = new System.Drawing.Point(30, 57);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(728, 365);
            this.tabCon.TabIndex = 5;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lTitulo.Location = new System.Drawing.Point(24, 23);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(137, 31);
            this.lTitulo.TabIndex = 4;
            this.lTitulo.Text = "Articulos:";
            // 
            // BSearchCategoria
            // 
            this.BSearchCategoria.BackgroundImage = global::Precentacion.Properties.Resources.searchDataBase24x;
            this.BSearchCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BSearchCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BSearchCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BSearchCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BSearchCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSearchCategoria.Location = new System.Drawing.Point(239, 5);
            this.BSearchCategoria.Name = "BSearchCategoria";
            this.BSearchCategoria.Size = new System.Drawing.Size(35, 30);
            this.BSearchCategoria.TabIndex = 8;
            this.BSearchCategoria.UseVisualStyleBackColor = true;
            this.BSearchCategoria.Click += new System.EventHandler(this.BSearchCategoria_Click);
            // 
            // BCargar
            // 
            this.BCargar.BackgroundImage = global::Precentacion.Properties.Resources.Addarchivo2;
            this.BCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BCargar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCargar.Location = new System.Drawing.Point(145, 33);
            this.BCargar.Name = "BCargar";
            this.BCargar.Size = new System.Drawing.Size(58, 44);
            this.BCargar.TabIndex = 8;
            this.BCargar.UseVisualStyleBackColor = true;
            this.BCargar.Click += new System.EventHandler(this.BCargar_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackgroundImage = global::Precentacion.Properties.Resources.RemoveArchivo;
            this.BLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Location = new System.Drawing.Point(146, 80);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(57, 47);
            this.BLimpiar.TabIndex = 8;
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // PBImagen
            // 
            this.PBImagen.BackgroundImage = global::Precentacion.Properties.Resources.File;
            this.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBImagen.Location = new System.Drawing.Point(6, 30);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(117, 97);
            this.PBImagen.TabIndex = 7;
            this.PBImagen.TabStop = false;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.lTitulo);
            this.Name = "FormArticulo";
            this.Text = ".:Articulos:.";
            this.Load += new System.EventHandler(this.FormArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupb.ResumeLayout(false);
            this.groupb.PerformLayout();
            this.PFk.ResumeLayout(false);
            this.PFk.PerformLayout();
            this.GB.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabCon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupb;
        private System.Windows.Forms.Button BCargar;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.ToolTip tooltMensaje;
        private System.Windows.Forms.Panel PFk;
        private System.Windows.Forms.Button BSearchCategoria;
        private System.Windows.Forms.TextBox TBCategoria;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.ComboBox CBPresentacion;
        private System.Windows.Forms.Label LPresentacion;
        private System.Windows.Forms.PictureBox PBImagen;
    }
}