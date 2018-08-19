using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Trabajador
    {
        private int _IdTrabajador;
        private string _Nombre, _Apellidos, _Sexo;
        private DateTime _Fecha_nacimiento;
        private string _Num_documento, _Direccion, _Telefono, _Email, _Acesso, _Usuario, _Password, _TextBuscar;

        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
        public string Num_documento { get => _Num_documento; set => _Num_documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Acesso { get => _Acesso; set => _Acesso = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }
        
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Trabajador() { }

        public Trabajador(int idTrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string dirrecion, string telefono, string email, string acesso, string usuario, string password, string textBuscar) {

        }
    }
}
