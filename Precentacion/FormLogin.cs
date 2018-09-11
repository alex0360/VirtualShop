using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();

        private void RedColor() {
            Comunes.Color(PUpLogin, Color.OrangeRed);
            Comunes.Color(PDownLogin, Color.OrangeRed);
        }
        private void BlueColor() {     
                Comunes.Color(PUpLogin, Color.RoyalBlue);
                Comunes.Color(PDownLogin, Color.RoyalBlue);  
        }
        private void Acceso() {
            System.Data.DataTable Datos = Negocio.Trabajador.Login(TBUsuario.Text, TBPass.Text);

            bool config
            = Comunes.Acceso(Datos);
            if (config)
            {
                FormPrincipal Form = new FormPrincipal() {
                    IdTrabajador = (int)Datos.Rows[0][0],
                    Nombre = Datos.Rows[0][1].ToString(),
                    Apellido = Datos.Rows[0][2].ToString(),
                    Acceso = Datos.Rows[0][3].ToString()
                };
                Form.Show();
                this.Hide();
            } else
                RedColor();
        }

        private void FormLogin_Load(object sender, EventArgs e) => Comunes.DiaHora(LDateTime);
        private void BAceptar_Click(object sender, EventArgs e) => Acceso();
        private void BCancelar_Click(object sender, EventArgs e) => Comunes.Cerrar();
        private void THora_Tick(object sender, EventArgs e) => Comunes.DiaHora(LDateTime);
        private void TColores_Tick(object sender, EventArgs e) => BlueColor();
    }
}
