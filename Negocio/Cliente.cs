using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        private static Datos.Cliente Obj = null;
        /// <summary>
        /// Insertando los datos a la tabla.Cliente
        /// </summary>
        /// <param name = "nombre" > Primer nombre del cliente</param>
        /// <param name="apellidos">Los dos Apellidos del cliente</param>
        /// <param name="sexo">Genero del cliente</param>
        /// <param name="fecha_nacimiento">Fecha de nacimento...calcular la edad</param>
        /// <param name="tipo_documento">Tipo de documento</param>
        /// <param name="num_documento">Numero del documento</param>
        /// <param name="direccion">Direccion del Cliente</param>
        /// <param name="telefono">Telefono del cliente</param>
        /// <param name="email">Email del cliente</param>
        /// <returns>El resultado de Datos.Cliente.Insertar</returns>
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento,
            string num_documento, string direccion, string telefono, string email)
        {
            Obj = new Datos.Cliente {
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_nacimiento = fecha_nacimiento,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email
            };
            return Obj.Insertar(Obj);
        }
        /// <summary>
        /// Update a los datos a la tabla.Cliente
        /// </summary>
        /// <param name="idCliente">Id de la tabla</param>
        /// <param name = "nombre" > Primer nombre del cliente</param>
        /// <param name="apellidos">Los dos Apellidos del cliente</param>
        /// <param name="sexo">Genero del cliente</param>
        /// <param name="fecha_nacimiento">Fecha de nacimento...calcular la edad</param>
        /// <param name="tipo_documento">Tipo de documento</param>
        /// <param name="num_documento">Numero del documento</param>
        /// <param name="direccion">Direccion del Cliente</param>
        /// <param name="telefono">Telefono del cliente</param>
        /// <param name="email">Email del cliente</param>
        /// <returns>El resultado de Datos.Cliente.Editar</returns>
        public static string Editar(int idCliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento,
            string num_documento, string direccion, string telefono, string email)
        {
            Obj = new Datos.Cliente {
                IdCliente = idCliente,
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_nacimiento = fecha_nacimiento,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email
            };
            return Obj.Editar(Obj);
        }
        /// <summary>
        /// Delete una fila de la tabla.Cliente
        /// </summary>
        /// <param name="idCliente">id de la tabla</param>
        /// <returns>El resultado de Datos.Cliente.Eliminar</returns>
        public static string Eliminar(int idCliente)
        {
            Obj = new Datos.Cliente {
                IdCliente = idCliente
            };
            return Obj.Eliminar(Obj);
        }
        /// <summary>
        /// Muestra los datos de una tabla
        /// </summary>
        /// <returns>DataTable:Tabla.Cliente{200Filas},Null</returns>
        public static System.Data.DataTable Mostrar() => new Datos.Cliente().Mostrar();
        /// <summary>
        /// Invoca el metodo Datos.Cliente.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Cliente,Null</returns>
        public static System.Data.DataTable Buscar_Cliente(string textBuscar)
        {
            Obj = new Datos.Cliente {
                TextBuscar = textBuscar
            };
            return Obj.Buscar_Cliente(Obj);
        }
    }
}
