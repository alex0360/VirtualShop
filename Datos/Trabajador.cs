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
        private string _Nombre, _Apellidos, _Sexo, _Tipo_documento;
        private DateTime _Fecha_nacimiento;
        private string _Num_documento, _Direccion, _Telefono, _Email, _Acesso, _Usuario, _Password, _TextBuscar;

        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
        public string Tipo_documento { get => _Tipo_documento; set => _Tipo_documento = value; }
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

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="idTrabajador">id de la tabla</param>
        /// <param name="nombre">nombre del empleado</param>
        /// <param name="apellidos">apellidos del empleado</param>
        /// <param name="sexo">sexo {f,m}</param>
        /// <param name="fecha_nacimiento">fecha de nacimiento {00/00/0000}</param>
        /// <param name="tipo_documento"> Tipo de documento</param>
        /// <param name="num_documento">numero de documento</param>
        /// <param name="direccion">direccion</param>
        /// <param name="telefono">telefono</param>
        /// <param name="email">email</param>
        /// <param name="acesso">Enum con los tipos de acessos</param>
        /// <param name="usuario">nombre de usuario</param>
        /// <param name="password">password de usuario</param>
        /// <param name="textBuscar">texto a buscar</param>
        public Trabajador(int idTrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email, string acesso, string usuario, string password, string textBuscar) {
            IdTrabajador = idTrabajador;
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Fecha_nacimiento = fecha_nacimiento;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Acesso = acesso;
            Usuario = usuario;
            Password = password;
            TextBuscar = textBuscar;
        }


    }
}
