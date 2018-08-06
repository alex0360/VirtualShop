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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GBMatenimiento = new System.Windows.Forms.GroupBox();
            this.EPErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(537, 252);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(128, 36);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(383, 252);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(1);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(128, 36);
            this.BGuardar.TabIndex = 5;
            this.BGuardar.Text = "&Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GBMatenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(777, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GBMatenimiento
            // 
            this.GBMatenimiento.Controls.Add(this.BCancelar);
            this.GBMatenimiento.Controls.Add(this.BGuardar);
            this.GBMatenimiento.Location = new System.Drawing.Point(17, 20);
            this.GBMatenimiento.Margin = new System.Windows.Forms.Padding(1);
            this.GBMatenimiento.Name = "GBMatenimiento";
            this.GBMatenimiento.Padding = new System.Windows.Forms.Padding(1);
            this.GBMatenimiento.Size = new System.Drawing.Size(681, 292);
            this.GBMatenimiento.TabIndex = 0;
            this.GBMatenimiento.TabStop = false;
            this.GBMatenimiento.Text = "-Texto-";
            // 
            // EPErrorIcono
            // 
            this.EPErrorIcono.ContainerControl = this;
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage2);
            this.tabCon.Location = new System.Drawing.Point(39, 60);
            this.tabCon.Margin = new System.Windows.Forms.Padding(1);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(785, 402);
            this.tabCon.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LTotalRegistro);
            this.tabPage1.Controls.Add(this.CBEliminar);
            this.tabPage1.Controls.Add(this.BImprimir);
            this.tabPage1.Controls.Add(this.BEliminar);
            this.tabPage1.Controls.Add(this.TBBuscar);
            this.tabPage1.Controls.Add(this.LBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(777, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.AutoSize = true;
            this.LTotalRegistro.Location = new System.Drawing.Point(11, 339);
            this.LTotalRegistro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTotalRegistro.Name = "LTotalRegistro";
            this.LTotalRegistro.Size = new System.Drawing.Size(16, 17);
            this.LTotalRegistro.TabIndex = 6;
            this.LTotalRegistro.Text = "0";
            // 
            // CBEliminar
            // 
            this.CBEliminar.AutoSize = true;
            this.CBEliminar.Location = new System.Drawing.Point(15, 65);
            this.CBEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(80, 21);
            this.CBEliminar.TabIndex = 4;
            this.CBEliminar.Text = "Eliminar";
            this.CBEliminar.UseVisualStyleBackColor = true;
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(541, 15);
            this.BImprimir.Margin = new System.Windows.Forms.Padding(1);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(97, 33);
            this.BImprimir.TabIndex = 3;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.UseVisualStyleBackColor = true;
            this.BImprimir.Visible = false;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(363, 15);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(96, 33);
            this.BEliminar.TabIndex = 2;
            this.BEliminar.Text = "&Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TBBuscar.Location = new System.Drawing.Point(80, 20);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(235, 22);
            this.TBBuscar.TabIndex = 1;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(11, 23);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(56, 17);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.LTitulo.Location = new System.Drawing.Point(33, 28);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(112, 31);
            this.LTitulo.TabIndex = 6;
            this.LTitulo.Text = "#Titulo:";
            // 
            // FaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 491);
            this.Controls.Add(this.tabCon);
            this.Controls.Add(this.LTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FaderForm";
            this.Text = "FaderForm";
            this.tabPage2.ResumeLayout(false);
            this.GBMatenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EPErrorIcono)).EndInit();
            this.tabCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BCancelar;
        public System.Windows.Forms.Button BGuardar;
        public System.Windows.Forms.ErrorProvider EPErrorIcono;
        public System.Windows.Forms.Label LTitulo;
        public System.Windows.Forms.ToolTip TTMensaje;
        public System.Windows.Forms.Button BImprimir;
        public System.Windows.Forms.TabControl tabCon;
        public System.Windows.Forms.Label LTotalRegistro;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.GroupBox GBMatenimiento;
        public System.Windows.Forms.Button BEliminar;
        public System.Windows.Forms.TextBox TBBuscar;
        public System.Windows.Forms.Label LBuscar;
        public System.Windows.Forms.CheckBox CBEliminar;
    }
}