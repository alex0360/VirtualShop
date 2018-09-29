using System;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Detalle_venta
    {
        private int _IdDetalle_venta;
        private int _IdVenta;
        private int _IdDetalle_Ingreso;
        private int _Cantidad;
        private decimal _Precio_venta;
        private decimal _Descuento;

        //Propiedades
        public int IdDetalle_venta { get => _IdDetalle_venta; set => _IdDetalle_venta = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public int IdDetalle_Ingreso { get => _IdDetalle_Ingreso; set => _IdDetalle_Ingreso = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }

        //Constructores
        public Detalle_venta()
        {

        }
        public Detalle_venta(int idDetalle_venta, int idVenta, int idDetalle_ingreso, 
            int cantidad, decimal precio_venta, decimal descuento)
        {
            this.IdDetalle_venta = idDetalle_venta;
            this.IdVenta = idVenta;
            this.IdDetalle_Ingreso = idDetalle_ingreso;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Descuento = descuento;

        }

        //Método Insertar
        public string Insertar(Detalle_venta Detalle_Venta, 
            ref SqlConnection SqlConnection, ref SqlTransaction SqlTransaction)
        {
            string respuesta = null;
            try
            {
                SqlCommand SqlCommand = new SqlCommand() {
                    Connection = SqlConnection,
                    Transaction = SqlTransaction,
                    CommandText = "SpInsertar_detalle_venta",
                    CommandType = CommandType.StoredProcedure
                };


                SqlParameter ParId = new SqlParameter {
                    ParameterName = "@idDetalle_venta",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                SqlCommand.Parameters.Add(ParId);

                SqlParameter ParIdventa = new SqlParameter {
                    ParameterName = "@idVenta",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_Venta.IdVenta
                };
                SqlCommand.Parameters.Add(ParIdventa);

                SqlParameter ParIddetalle_ingreso = new SqlParameter {
                    ParameterName = "@idDetalle_ingreso",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_Venta.IdDetalle_Ingreso
                };
                SqlCommand.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter {
                    ParameterName = "@cantidad",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_Venta.Cantidad
                };
                SqlCommand.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_Venta = new SqlParameter {
                    ParameterName = "@precio_venta",
                    SqlDbType = SqlDbType.Money,
                    Value = Detalle_Venta.Precio_venta
                };
                SqlCommand.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParDescuento = new SqlParameter {
                    ParameterName = "@descuento",
                    SqlDbType = SqlDbType.Money,
                    Value = Detalle_Venta.Descuento
                };
                SqlCommand.Parameters.Add(ParDescuento);

                //Ejecutamos nuestro comando
                respuesta = SqlCommand.ExecuteNonQuery() == 1 ? "OK" :
                    Convert.ToString(IdVenta) +
                    Convert.ToString(IdDetalle_Ingreso) +
                    Convert.ToString(Cantidad) +
                    Convert.ToString(Precio_venta) +
                    Convert.ToString(Descuento);

            } catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }

    }
}
