using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Detalles_ingreso
    {
        //Variables
        //
        private int _IdDetalle_ingreso;
        private int _IdIngreso;
        private int _IdArticulo;
        private decimal _Precio_compra;
        private decimal _Precio_venta;
        private int _Stock_inical;
        private int _Stock_actual;
        private DateTime _Fecha_produccion;
        private DateTime _Fecha_vencimiento;
        //Propiedades
        //
        public int IdDetalle_ingreso { get => _IdDetalle_ingreso; set => _IdDetalle_ingreso = value; }
        public int IdIngreso { get => _IdIngreso; set => _IdIngreso = value; }
        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
        public decimal Precio_compra { get => _Precio_compra; set => _Precio_compra = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public int Stock_inical { get => _Stock_inical; set => _Stock_inical = value; }
        public int Stock_actual { get => _Stock_actual; set => _Stock_actual = value; }
        public DateTime Fecha_produccion { get => _Fecha_produccion; set => _Fecha_produccion = value; }
        public DateTime Fecha_vencimiento { get => _Fecha_vencimiento; set => _Fecha_vencimiento = value; }
        //Constructores
        //
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Detalles_ingreso() { }
        /// <summary>
        /// Constructor Con parametros
        /// </summary>
        /// <param name="idDetalle_ingreso">Id detalles de los Ingreso</param>
        /// <param name="idIngreso">fk de Ingresos</param>
        /// <param name="idArticulo">fk del Articulo</param>
        /// <param name="precio_compra">Precio de Compra</param>
        /// <param name="precio_venta">Precio de Venta</param>
        /// <param name="stock_inicial">Cantidad Inicial</param>
        /// <param name="stock_actual">Cantidad Actual</param>
        /// <param name="fecha_producto">fecha de Ingreso del Producto</param>
        /// <param name="fecha_vencimiento">Fecha de caducidad</param>
        public Detalles_ingreso(int idDetalle_ingreso, int idIngreso,
            int idArticulo, decimal precio_compra, decimal precio_venta,
            int stock_inicial, int stock_actual, DateTime fecha_producto,
            DateTime fecha_vencimiento)
        {
            this.IdDetalle_ingreso = idDetalle_ingreso;
            this.IdIngreso = IdIngreso;
            this.IdArticulo = idArticulo;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Stock_inical = stock_inicial;
            this.Stock_actual = Stock_actual;
            this.Fecha_produccion = fecha_producto;
            this.Fecha_produccion = fecha_vencimiento;
        }
        //Metodos
        //
        public string Insertar(Detalles_ingreso Detalle_ingreso,
            ref SqlConnection SqlConnection, ref SqlTransaction SqlTransaction)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = SqlConnection,
                    Transaction = SqlTransaction,
                    CommandText = "SpInsertar_detalle_ingreso",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idDetalle_ingreso",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParIdIngreso = new SqlParameter() {
                    ParameterName = "@idIngreso",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_ingreso.IdIngreso
                }; sqlCommand.Parameters.Add(ParIdIngreso);
                SqlParameter ParIdArticulo = new SqlParameter() {
                    ParameterName = "@idArticulo",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_ingreso.IdArticulo
                }; sqlCommand.Parameters.Add(ParIdArticulo);
                SqlParameter ParPrecio_compra = new SqlParameter() {
                    ParameterName = "@precio_compra",
                    SqlDbType = SqlDbType.Money,
                    Value = Detalle_ingreso.Precio_compra
                }; sqlCommand.Parameters.Add(ParPrecio_compra);
                SqlParameter ParPrecio_venta = new SqlParameter() {
                    ParameterName = "@precio_venta",
                    SqlDbType = SqlDbType.Money,
                    Value = Detalle_ingreso.Precio_venta
                }; sqlCommand.Parameters.Add(ParPrecio_venta);
                SqlParameter ParStock_Inicial= new SqlParameter() {
                    ParameterName = "@stock_inicial",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_ingreso.Stock_inical
                }; sqlCommand.Parameters.Add(ParStock_Inicial);
                SqlParameter ParStock_Actual= new SqlParameter() {
                    ParameterName = "@stock_actual",
                    SqlDbType = SqlDbType.Int,
                    Value = Detalle_ingreso.Stock_actual
                }; sqlCommand.Parameters.Add(ParStock_Actual);
                SqlParameter ParFecha_Produccion = new SqlParameter() {
                    ParameterName = "@fecha_produccion",
                    SqlDbType = SqlDbType.Date,
                    Value = Detalle_ingreso.Fecha_produccion
                }; sqlCommand.Parameters.Add(ParFecha_Produccion);
                SqlParameter ParFecha_Vencimiento = new SqlParameter() {
                    ParameterName = "@fecha_vencimiento",
                    SqlDbType = SqlDbType.Date,
                    Value = Detalle_ingreso.Fecha_vencimiento
                }; sqlCommand.Parameters.Add(ParFecha_Vencimiento);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

    }
}
