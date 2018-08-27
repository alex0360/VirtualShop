using System;
using System.Data;

namespace Negocio
{
    public class Trabajador
    {
        private static Datos.Trabajador Obj = null;
        /// <summary>
        /// Insertando los datos a la tabla.Trabajador
        /// </summary>
        /// <param name="nombre">Nombre del Trabajador</param>
        /// <param name="apellidos">Apellido del Trabajador</param>
        /// <param name="sexo">Genero del Trabajador</param>
        /// <param name="fecha_nacimiento">Fecha de nacimento...calcular la edad</param>
        /// <param name="tipo_documento">Tipo de documento</param>
        /// <param name="num_documento">Numero del documento</param>
        /// <param name="direccion">Direccion del Trabajador</param>
        /// <param name="telefono">Telefono del Trabajador</param>
        /// <param name="email">Email del Trabajador</param>
        /// <param name="acesso">Tipo de Acesso</param>
        /// <param name="usuario">Nombre de Usuario</param>
        /// <param name="password">Clave del Usuario</param>
        /// <returns>El resultado de Datos.Trabajador.Insertar</returns>
        public static string Insertar(
            string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email, string acesso, string usuario, string password)
        {
            Obj = new Datos.Trabajador(){
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_nacimiento = fecha_nacimiento,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Acesso = acesso,
                Usuario = usuario,
                Password = password
            };
            return Obj.Insertar(Obj);
        }
        /// <summary>
        /// Editar los datos a la tabla.Trabajador
        /// </summary>
        /// <param name="idTrabajador">Id de la Tabla.Trabajador</param>
        /// <param name="nombre">Nombre del Trabajador</param>
        /// <param name="apellidos">Apellido del Trabajador</param>
        /// <param name="sexo">Genero del Trabajador</param>
        /// <param name="fecha_nacimiento">Fecha de nacimento...calcular la edad</param>
        /// <param name="tipo_documento">Tipo de documento</param>
        /// <param name="num_documento">Numero del documento</param>
        /// <param name="direccion">Direccion del Trabajador</param>
        /// <param name="telefono">Telefono del Trabajador</param>
        /// <param name="email">Email del Trabajador</param>
        /// <param name="acesso">Tipo de Acesso</param>
        /// <param name="usuario">Nombre de Usuario</param>
        /// <param name="password">Clave del Usuario</param>
        /// <returns>El resultado de Datos.Trabajador.Editar</returns>
        public static string Editar(
            int idTrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email, string acesso, string usuario, string password)
        {
            Obj = new Datos.Trabajador {
                IdTrabajador = idTrabajador,
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_nacimiento = fecha_nacimiento,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Acesso = acesso,
                Usuario = usuario,
                Password = password
            };
            return Obj.Editar(Obj);
        }
        /// <summary>
        /// Delete Un Fila de Trabajador
        /// </summary>
        /// <param name="idTrabajador">id de la tabla.Trabajador</param>
        /// <returns>El resultado de Datos.Trabajador.Eliminar</returns>
        public static string Eliminar(int idTrabajador)
        {
            Obj = new Datos.Trabajador {
                IdTrabajador = idTrabajador
            };
            return Obj.Eliminar(Obj);
        }
        /// <summary>
        /// Mustra los datos de la Tabla.Trabajador
        /// </summary>
        /// <returns>DataTable:Tabla.Trabajador{100Filas},Null</returns>
        public static DataTable Mostrar()
        {
            return new Datos.Trabajador().Mostrar();
        }
        /// <summary>
        /// Invoca el metodo Datos.Trabajador.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Trabajador,Null</returns>
        public static DataTable Buscar_Trabajador(string textBuscar)
        {
            Obj = new Datos.Trabajador {
                TextBuscar = textBuscar
            };
            return Obj.Buscar_Trabajador(Obj);
        }
        /// <summary>
        /// Invoca el metodo Datos.Trabajador.BuscarUsuario
        /// </summary>
        /// <param name="textBuscar">El Nombre que sera buscado</param>
        /// <returns>DataTable:usuario o Null</returns>
        public static DataTable Buscar_Usuario(string textBuscar) {
            Obj = new Datos.Trabajador {
                TextBuscar = textBuscar
            };
            return Obj.Buscar_Usuario(Obj);
        }
    }
}
