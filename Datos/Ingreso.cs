using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Ingreso
    {
        //Variables
        //
        private int _IdIngreso;
        private int _IdTrabajador;
        private int _IdProveedor;
        private DateTime _Fecha;
        private string _Tipo_comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Igv;
        private string _Estado;
        //Propiedades
        //
        public int IdIngreso { get => _IdIngreso; set => _IdIngreso = value; }
        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo_comprobante { get => _Tipo_comprobante; set => _Tipo_comprobante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Igv { get => _Igv; set => _Igv = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        //Constructores
        //
        public Ingreso() { }
        public Ingreso(int idIngreso, int idTrabajador, int idProveedor,
            DateTime fecha, string tipo_comprobante, string serie, 
            string correlativo, decimal igv, string estado) {
            IdIngreso = idIngreso;
            IdTrabajador = idTrabajador;
            IdProveedor = idProveedor;
            Fecha = fecha;
            Tipo_comprobante = tipo_comprobante;
            Serie = serie;
            Correlativo = correlativo;
            Igv = igv;
            Estado = estado;
        }
        //Metodos
        //
        /// <summary>
        /// Insertar los datos a la tabla Ingreso
        /// </summary>
        /// <param name="Ingreso">Las intancia de Ingreso</param>
        /// <param name="Detalle">Una lista de Detalles de Ingresos</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Ingreso Ingreso,List<Detalles_ingreso> Detalle)
        {
            string respuesta = null;
            try
            {
                //Establecer Trasaccion
                SqlTransaction SqlTransaction =
                    Conexion.SqlConnection.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    Transaction = SqlTransaction,
                    CommandText = "SpInsertar_ingreso",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idIngreso",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParIdTrabajador = new SqlParameter() {
                    ParameterName = "@idTrabajador",
                    SqlDbType = SqlDbType.Int,
                    Value = Ingreso.IdTrabajador
                }; sqlCommand.Parameters.Add(ParIdTrabajador);
                SqlParameter ParIdProveedor = new SqlParameter() {
                    ParameterName = "@idProveedor",
                    SqlDbType = SqlDbType.Int,
                    Value = Ingreso.IdProveedor
                }; sqlCommand.Parameters.Add(ParIdProveedor);
                SqlParameter ParFecha = new SqlParameter() {
                    ParameterName = "@fecha",
                    SqlDbType = SqlDbType.Date,
                    Value = Ingreso.Fecha
                }; sqlCommand.Parameters.Add(ParFecha);
                SqlParameter ParTipo_Descripcion = new SqlParameter() {
                    ParameterName = "@tipo_descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Ingreso.Tipo_comprobante
                }; sqlCommand.Parameters.Add(ParTipo_Descripcion);
                SqlParameter ParSerie = new SqlParameter() {
                    ParameterName = "@Serie",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 4,
                    Value = Ingreso.Serie
                }; sqlCommand.Parameters.Add(ParSerie);
                SqlParameter ParCorrelativo = new SqlParameter() {
                    ParameterName = "@correlativo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 7,
                    Value = Ingreso.Correlativo
                }; sqlCommand.Parameters.Add(ParCorrelativo);
                SqlParameter ParIgv = new SqlParameter() {
                    ParameterName = "@Igv",
                    SqlDbType = SqlDbType.Decimal,
                    Precision = 4,
                    Scale = 2,
                    Value = Ingreso.Igv
                }; sqlCommand.Parameters.Add(ParIgv);
                SqlParameter ParEstado = new SqlParameter() {
                    ParameterName = "@estado",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 7,
                    Value = Ingreso.Estado
                }; sqlCommand.Parameters.Add(ParEstado);

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";
                if (respuesta.Equals("Ok"))
                {
                    //Obtener el Codigo del Ingreso generado
                    this.IdIngreso = Convert.ToInt32(sqlCommand.Parameters["@idIngreso"].Value);
                    foreach (Detalles_ingreso detalle in Detalle)
                    {
                        detalle.IdIngreso = this.IdIngreso;
                        // Llamar al metodo Insertar de la Clase Detalle de ingreso
                        respuesta = detalle.Insertar(detalle, ref Conexion.SqlConnection, ref SqlTransaction);
                        if (!respuesta.Equals("Ok")) break;
                    }
                }
                if (respuesta.Equals("Ok"))
                    SqlTransaction.Commit();
                else
                    SqlTransaction.Rollback();

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            } finally { Conexion.SqlConnection.Close(); }
            return respuesta;
        }
        /// <summary>
        /// Anula un Registro de la tabla Ingreso
        /// </summary>
        /// <param name="Ingreso">Intacia de Ingreso</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Anular(Ingreso Ingreso)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpAnular_ingreso",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idIngreso",
                    SqlDbType = SqlDbType.Int,
                    Value = Ingreso.IdIngreso,
                }; sqlCommand.Parameters.Add(ParId);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Anulo el registro";
            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }
        /// <summary>
        /// Muestra los datos de la tabla Ingreso
        /// </summary>
        /// <returns>Una DataTable que contiene las columnas</returns>
        public DataTable Mostrar()
        {
            DataTable tableResutado = new DataTable("Ingreso");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Ingreso",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
        /// <summary>
        /// Muestra los datos de la table con dos algumentos
        /// </summary>
        /// <param name="textBuscar">texto con la fecha inicial</param>
        /// <param name="textBuscar2">texto con la fecha final</param>
        /// <returns>El resultado de la busqueda</returns>
        public DataTable BuscarFecha(string textBuscar, string textBuscar2)
        {
            DataTable tableResutado = new DataTable("Ingreso");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Ingreso_Fecha",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = textBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);
                SqlParameter ParTextBuscar2 = new SqlParameter() {
                    ParameterName = "@textBuscar2",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = textBuscar2
                }; sqlCommand.Parameters.Add(ParTextBuscar2);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
        /// <summary>
        /// Muestra los detalles de la tabla
        /// </summary>
        /// <param name="textBuscar">Filtro para buscar</param>
        /// <returns>El resultado de la busqueda</returns>
        public DataTable MostrarDetalles(string textBuscar)
        {
            DataTable tableResutado = new DataTable("Detalle_ingreso");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_detalle_ingreso",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
    }
}