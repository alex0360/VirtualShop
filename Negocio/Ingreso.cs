using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Ingreso
    {
        private static Datos.Ingreso Obj;
        public static string Insertar(int idTrabajador, int idProveedor,
            DateTime fecha, string tipo_comprobante, string serie,
            string correlativo, decimal igv, string estado, System.Data.DataTable Detalle)
        {
            Obj = new Datos.Ingreso {
                IdTrabajador = idTrabajador, IdProveedor = idProveedor,
                Fecha = fecha, Tipo_comprobante = tipo_comprobante, Serie= serie,
                Correlativo = correlativo, Igv = igv, Estado = estado
            };
            List<Datos.Detalles_ingreso> detalles = new List<Datos.Detalles_ingreso>();
            foreach (System.Data.DataRow row in Detalle.Rows)
            {
                Datos.Detalles_ingreso detalle = new Datos.Detalles_ingreso {
                    IdArticulo = Convert.ToInt32(row["idArticulo"]),
                    Precio_compra = Convert.ToInt32(row["precio_compra"]),
                    Precio_venta = Convert.ToInt32(row["precio_venta"]),
                    Stock_inicial = Convert.ToInt32(row["stock_inicial"]),
                    Stock_actual = Convert.ToInt32(row["stock_inicial"]),
                    Fecha_produccion = Convert.ToDateTime(row["fecha_produccion"]),
                    Fecha_vencimiento = Convert.ToDateTime(row["fecha_vencimiento"])
                };
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj,detalles);
        }

        public static string Anular(int idIngreso)
        {
            Obj = new Datos.Ingreso {
                IdIngreso = idIngreso
            };
            return Obj.Anular(Obj);
        }

        public static System.Data.DataTable Mostrar()
        {
            return new Datos.Ingreso().Mostrar();
        }

        public static System.Data.DataTable Mostar(int? idIngreso)
        {
            return new Datos.Ingreso().MostrarDetalles(Convert.ToString(idIngreso));
        }

        public static System.Data.DataTable BuscarMostar(string textBuscar, string textBuscar2)
        {
            Obj = new Datos.Ingreso();
            return Obj.BuscarFecha(textBuscar,textBuscar2);
        }
    }
}
