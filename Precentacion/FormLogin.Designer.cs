﻿namespace Precentacion
{
    partial class FormLogin
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
            this.PUpLogin = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PDownLogin = new System.Windows.Forms.Panel();
            this.GBLogin = new System.Windows.Forms.GroupBox();
            this.LDateTime = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.THora = new System.Windows.Forms.Timer(this.components);
            this.TColores = new System.Windows.Forms.Timer(this.components);
            this.PUpLogin.SuspendLayout();
            this.GBLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PUpLogin
            // 
            this.PUpLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.PUpLogin.Controls.Add(this.LTitulo);
            this.PUpLogin.Location = new System.Drawing.Point(-6, -8);
            this.PUpLogin.Name = "PUpLogin";
            this.PUpLogin.Size = new System.Drawing.Size(692, 99);
            this.PUpLogin.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(225, 27);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(206, 38);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Virtual Shop";
            // 
            // PDownLogin
            // 
            this.PDownLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.PDownLogin.Location = new System.Drawing.Point(-6, 285);
            this.PDownLogin.Name = "PDownLogin";
            this.PDownLogin.Size = new System.Drawing.Size(692, 48);
            this.PDownLogin.TabIndex = 1;
            // 
            // GBLogin
            // 
            this.GBLogin.Controls.Add(this.LDateTime);
            this.GBLogin.Controls.Add(this.BCancelar);
            this.GBLogin.Controls.Add(this.BAceptar);
            this.GBLogin.Controls.Add(this.TBPass);
            this.GBLogin.Controls.Add(this.TBUsuario);
            this.GBLogin.Controls.Add(this.LPass);
            this.GBLogin.Controls.Add(this.LUsuario);
            this.GBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLogin.Location = new System.Drawing.Point(226, 97);
            this.GBLogin.Name = "GBLogin";
            this.GBLogin.Size = new System.Drawing.Size(438, 182);
            this.GBLogin.TabIndex = 2;
            this.GBLogin.TabStop = false;
            this.GBLogin.Text = "Acceso al Sistema";
            // 
            // LDateTime
            // 
            this.LDateTime.AutoSize = true;
            this.LDateTime.Location = new System.Drawing.Point(159, 20);
            this.LDateTime.Name = "LDateTime";
            this.LDateTime.Size = new System.Drawing.Size(16, 18);
            this.LDateTime.TabIndex = 5;
            this.LDateTime.Text = "#";
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.BCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(294, 138);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(92, 33);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.BAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.BAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.ForeColor = System.Drawing.Color.White;
            this.BAceptar.Location = new System.Drawing.Point(162, 138);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(92, 33);
            this.BAceptar.TabIndex = 2;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = false;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(162, 95);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(224, 24);
            this.TBPass.TabIndex = 1;
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(162, 50);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(224, 24);
            this.TBUsuario.TabIndex = 0;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPass.Location = new System.Drawing.Point(19, 95);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(97, 20);
            this.LPass.TabIndex = 1;
            this.LPass.Text = "Password:";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(36, 50);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(80, 20);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // PBImagen
            // 
            this.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBImagen.Image = global::Precentacion.Properties.Resources.imagen;
            this.PBImagen.InitialImage = global::Precentacion.Properties.Resources.imagen;
            this.PBImagen.Location = new System.Drawing.Point(12, 97);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(208, 182);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 3;
            this.PBImagen.TabStop = false;
            // 
            // THora
            // 
            this.THora.Enabled = true;
            this.THora.Interval = 1000;
            this.THora.Tag = "Hora";
            this.THora.Tick += new System.EventHandler(this.THora_Tick);
            // 
            // TColores
            // 
            this.TColores.Enabled = true;
            this.TColores.Interval = 3000;
            this.TColores.Tag = "Hora";
            this.TColores.Tick += new System.EventHandler(this.TColores_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 330);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.GBLogin);
            this.Controls.Add(this.PDownLogin);
            this.Controls.Add(this.PUpLogin);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PUpLogin.ResumeLayout(false);
            this.PUpLogin.PerformLayout();
            this.GBLogin.ResumeLayout(false);
            this.GBLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Precentacion.Clases.Comunes Comunes = new Clases.Comunes();
        private System.Windows.Forms.Panel PUpLogin;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PDownLogin;
        private System.Windows.Forms.GroupBox GBLogin;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.Label LDateTime;
        private System.Windows.Forms.Timer THora;
        private System.Windows.Forms.Timer TColores;
    }
}