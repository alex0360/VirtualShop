using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Proveedor
    {
        private static Datos.Proveedor Obj = null;
        /// <summary>
        /// Insertando los datos a la tabla.Proveedor
        /// </summary>
        /// <param name="idProveedor">id de la tabla.Proveedor</param>
        /// <param name="razon_social">Razon Social</param>
        /// <param name="sector_comercial">Sector Comercial</param>
        /// <param name="tipo_documento">Tipo Documento</param>
        /// <param name="direccion">Direccion</param>
        /// <param name="telefono">Telefono</param>
        /// <param name="email">Email</param>
        /// <param name="url">Url</param>
        /// <returns>El resultado de Datos.Proveedor.Insertar</returns>
        public static string Insertar(string razon_social, string sector_comercial,
            string tipo_documento, string num_documento, string direccion, string telefono,
            string email, string url)
        {
            Obj = new Datos.Proveedor {
                Razon_social = razon_social,
                Sector_Comercial = sector_comercial,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Url = url
        };
            return Obj.Insertar(Obj);
        }
        /// <summary>
        /// Invoca el metodo Editar Datos.Proveedor
        /// </summary>
        /// <param name="idProveedor">id de la Tabla.Proveedor</param>
        /// <param name="razon_social">Razon Social</param>
        /// <param name="sector_comercial">Sector Comercial</param>
        /// <param name="tipo_documento">Tipo Documento</param>
        /// <param name="direccion">Direccion</param>
        /// <param name="telefono">Telefono</param>
        /// <param name="email">Email</param>
        /// <param name="url">Url</param>
        /// <returns>El resultado de Datos.Proveedor.Editar</returns>
        public static string Editar(int idProveedor, string razon_social, string sector_comercial,
            string tipo_documento, string num_documento, string direccion, string telefono,
            string email, string url)
        {
            Obj = new Datos.Proveedor {
                IdProveedor = idProveedor,
                Razon_social = razon_social,
                Sector_Comercial = sector_comercial,
                Tipo_documento = tipo_documento,
                Num_documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Url = url
        };
            return Obj.Editar(Obj);
        }
        /// <summary>
        /// Invoca el metodo Eliminar Datos.Proveedor
        /// </summary>
        /// <param name="idProveedor">id de la Tabla.Articulo</param>
        /// <returns>El resultado de Datos.Proveedor.Eliminar</returns>
        public static string Eliminar(int idProveedor)
        {
            Obj = new Datos.Proveedor {
                IdProveedor = idProveedor
            };
            return Obj.Eliminar(Obj);
        }
        /// <summary>
        /// Invoca el metodo Datos.Proveedor.Mostar
        /// </summary>
        /// <returns>DataTable:Tabla.Proveedor{100Filas},Null</returns>
        public static System.Data.DataTable Mostar() => new Datos.Proveedor().Mostrar();
        /// <summary>
        /// Invoca el metodo Datos.Proveedor.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Proveedor{},Null</returns>
        public static System.Data.DataTable BuscarMostar(string textBuscar)
        {
            Obj = new Datos.Proveedor {
                TextBuscar = textBuscar
            };
            return Obj.MostrarNumDoc_RazonSocial(Obj);
        }
    }
}
