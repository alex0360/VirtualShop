using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Presentacion
    {
        private int _IdPresentacion;
        private string _Nombre;
        private string _Descripcion;
        private string _TextBuscar;

        public int IdPresentacion { get => _IdPresentacion; set => _IdPresentacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Presentacion() { }

        /// <summary>
        /// Constructor All Paramets
        /// </summary>
        /// <param name="idPresentacion">id</param>
        /// <param name="nombre">Nombre de la Presentacion</param>
        /// <param name="descripcion">Descripcion 255 palabras</param>
        /// <param name="texbuscar">nombre a buscar</param>
        public Presentacion(int idPresentacion, string nombre, string descripcion, string texbuscar)
        {
            IdPresentacion = IdPresentacion;
            Nombre = nombre;
            Descripcion = descripcion;
            TextBuscar = descripcion;
        }

        /// <summary>
        /// Insentar Fila a Tabla.Presentacion
        /// </summary>
        /// <param name="Presentacion">La Instacia de Datos.Presentacion</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Presentacion Presentacion)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Presentacion",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idPresentacion",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Presentacion.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 255,
                    Value = Presentacion.Descripcion
                }; sqlCommand.Parameters.Add(ParDescripcion);

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Modificar Fila de la Tabla.Presentacion
        /// </summary>
        /// <param name="Presentacion">La Instacia de Datos.Presentacion</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Presentacion Presentacion)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Presentacion",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idPresentacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Presentacion.IdPresentacion,
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Presentacion.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 255,
                    Value = Presentacion.Descripcion
                }; sqlCommand.Parameters.Add(ParDescripcion);

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Actualizo el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Elimia Fila Tabla.Presentacion
        /// </summary>
        /// <param name="Presentacion">La Instacia de Datos.Presentacion</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Presentacion Presentacion)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Presentacion",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idPresentacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Presentacion.IdPresentacion,
                }; sqlCommand.Parameters.Add(ParId);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Elimino el registro";
            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Carga una obj.Tabla en memoria
        /// </summary>
        /// <returns>DataTable:Tabla.Presentacion{100Filas},Null</returns>
        public DataTable Mostrar()
        {
            DataTable tableResutado = new DataTable("Presentacion");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Presentacion",
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
        /// Busca una en texto Introducido en Una Tabla.Presentacion
        /// </summary>
        /// <param name="Presentacion">La Instacia de Datos.Presentacion</param>
        /// <returns>DataTable:Tabla.Categoria{},Null</returns>
        public DataTable MostrarNombre(Presentacion Presentacion)
        {
            DataTable tableResutado = new DataTable("Presentacion");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Presentacion",
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Presentacion.TextBuscar
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
