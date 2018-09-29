using System;
using System.Collections.Generic;

using System.Data;

namespace Negocio
{
    public class Venta
    {
        private static Datos.Venta Obj = null;
        /// <summary>
        /// Insertar que llama al método Insertar de la clase Datos.Venta
        /// </summary>
        /// <param name="idCliente">Forent Key</param>
        /// <param name="idTrabajador">Forent Key</param>
        /// <param name="fecha">Fecha de </param>
        /// <param name="tipo_comprobante">Tipo de Comprobante{ticket,Factura, ect}</param>
        /// <param name="serie">Numero de Serie</param>
        /// <param name="correlativo">Numero de Relacion</param>
        /// <param name="igv">Itbs</param>
        /// <param name="estado">Estado {Anulado o Activo}</param>
        /// <param name="Detalles">DataTable</param>
        /// <returns>Un resultado{Ok, Null}</returns>
        public static string Insertar( int idTrabajador, int idCliente, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo,
            decimal igv, DataTable Detalles)
        {
            Obj = new Datos.Venta {
                IdCliente = idCliente,
                IdTrabajador = idTrabajador,
                Fecha = fecha,
                Tipo_Comprobante = tipo_comprobante,
                Serie = serie,
                Correlativo = correlativo,
                Igv = igv
            };
            List<Datos.Detalle_venta> detalles = new List<Datos.Detalle_venta>();
            foreach (DataRow row in Detalles.Rows)
            {
                Datos.Detalle_venta detalle = new Datos.Detalle_venta {
                    IdDetalle_Ingreso = Convert.ToInt32(row["idDetalle_ingreso"].ToString()),
                    Cantidad = Convert.ToInt32(row["Cantidad"].ToString()),
                    Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString()),
                    Descuento = Convert.ToDecimal(row["Descuento"].ToString())
                };
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }
        /// <summary>
        /// Anular que llama al método Anular de la clase Datos.Venta
        /// </summary>
        /// <param name="idVenta">Id para flitrar</param>
        /// <returns>Un Resultado {Ok,Null}</returns>
        public static string Eliminar(int idVenta)
        {
            Datos.Venta Obj = new Datos.Venta {
                IdVenta = idVenta
            };
            return Obj.Eliminar(Obj);
        }
        /// <summary>
        /// Método Mostrar que llama al método Mostrar de la clase Datos.Venta
        /// </summary>
        /// <returns>Un Data Table</returns>
        public static DataTable Mostrar() => new Datos.Venta().Mostrar();
        /// <summary>
        /// Método Buscar Fechas que llama al método Buscar Fechas de la Clase Datos.Venta
        /// </summary>
        /// <param name="textBuscar">Primera fecha a buscar</param>
        /// <param name="textBuscar2">Segunda fecha a buscar</param>
        /// <returns>Data Table con todos los resultados</returns>
        public static DataTable BuscarFechas(string textBuscar, string textBuscar2) => new Datos.Venta().BuscarFechas(textBuscar, textBuscar2);
        /// <summary>
        /// Mostrar los detalles de las ventas por un filtro
        /// </summary>
        /// <param name="textBuscar">Fecha para filtrar la busqueda</param>
        /// <returns>Un DataTable con los resultados de un dia</returns>
        public static DataTable Mostrar(int? textBuscar) => new Datos.Venta().Mostrar(Convert.ToString(textBuscar));
        /// <summary>
        /// Muestra los articulos por Nombre
        /// </summary>
        /// <param name="textBuscar">Nombre del Articulo a buscar</param>
        /// <returns>Un DataTable con los resultados de un nombre</returns>
        public static DataTable MostrarArticulo_Venta_Nombre(string textBuscar) => new Datos.Venta().MostrarArticulo_Venta_Nombre(textBuscar);
        /// <summary>
        /// Muestra los articulos por Codigo
        /// </summary>
        /// <param name="textBuscar">Codigo del Articulo a buscar</param>
        /// <returns>Un DataTable con los resultados de un codigo</returns>
        public static DataTable MostrarArticulo_Venta_Codigo(string textBuscar) => new Datos.Venta().MostrarArticulo_Venta_Codigo(textBuscar);
    }
}
