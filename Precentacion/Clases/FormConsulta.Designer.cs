namespace Precentacion.Clases
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.LTitulo = new System.Windows.Forms.Label();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.BImprimir = new System.Windows.Forms.Button();
            this.LTotalRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.LTitulo.Location = new System.Drawing.Point(12, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(87, 29);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Titulo:";
            // 
            // PBImagen
            // 
            this.PBImagen.Image = global::Precentacion.Properties.Resources.add;
            this.PBImagen.Location = new System.Drawing.Point(585, 9);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(140, 68);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 1;
            this.PBImagen.TabStop = false;
            // 
            // BImprimir
            // 
            this.BImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BImprimir.BackgroundImage")));
            this.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BImprimir.Location = new System.Drawing.Point(664, 83);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(61, 54);
            this.BImprimir.TabIndex = 2;
            this.BImprimir.UseVisualStyleBackColor = true;
            // 
            // LTotalRegistro
            // 
            this.LTotalRegistro.AutoSize = true;
            this.LTotalRegistro.Location = new System.Drawing.Point(132, 21);
            this.LTotalRegistro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LTotalRegistro.Name = "LTotalRegistro";
            this.LTotalRegistro.Size = new System.Drawing.Size(13, 13);
            this.LTotalRegistro.TabIndex = 7;
            this.LTotalRegistro.Text = "0";
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 583);
            this.Controls.Add(this.LTotalRegistro);
            this.Controls.Add(this.BImprimir);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.LTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LTitulo;
        public System.Windows.Forms.PictureBox PBImagen;
        public System.Windows.Forms.Button BImprimir;
        public System.Windows.Forms.Label LTotalRegistro;
    }
}