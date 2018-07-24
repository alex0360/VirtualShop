using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Categoria
    {
        private int _IdCategoria;
        private string _Nombre;
        private string _Descripcion;
        private string _TextBuscar;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Categoria() {}

        /// <summary>
        /// Constructor All Paremeters
        /// </summary>
        /// <param name="_IdCategoria">Id de la Categoria</param>
        /// <param name="_Nombre">Nombre para la Categoria</param>
        /// <param name="_Descripcion">Descripcion de la Categoria</param>
        /// <param name="_TextBuscar">Texto con el Elemento a Buscar</param>
        public Categoria(int _IdCategoria,string _Nombre, string _Descripcion, string _TextBuscar)
        {
            IdCategoria = _IdCategoria;
            Nombre = _Nombre;
            Descripcion = _Descripcion;
            TextBuscar = _TextBuscar;
        }

        /// <summary>
        /// Insentar Fila a Tabla.Categoria
        /// </summary>
        /// <param name="Categoria">La Instacia de Datos.DCategoria</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Categoria Categoria)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Categoria",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCategoria",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Categoria.Nombre
                };sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 255,
                    Value = Categoria.Descripcion
                }; sqlCommand.Parameters.Add(ParDescripcion);

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex){
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Modificar Fila de la Tabla.Categoria
        /// </summary>
        /// <param name="Categoria">La Instacia de Datos.DCategoria</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Categoria Categoria)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Categoria",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCategoria",
                    SqlDbType = SqlDbType.Int,
                    Value = Categoria.IdCategoria,
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Categoria.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 255,
                    Value = Categoria.Descripcion
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
        /// Elimia Fila Tabla.Categoria
        /// </summary>
        /// <param name="Categoria">La Instacia de Datos.DCategoria</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Categoria Categoria)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(){
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Categoria",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCategoria",
                    SqlDbType = SqlDbType.Int,
                    Value = Categoria.IdCategoria,
                }; sqlCommand.Parameters.Add(ParId);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Elimino el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Carga una obj.Tabla en memoria
        /// </summary>
        /// <returns>DataTable:Tabla.Categoria{200Filas},Null</returns>
        public DataTable Mostrar() {
            DataTable tableResutado = new DataTable("Categoria");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Categoria",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);   
            }
            catch{
                tableResutado = null;
            } return tableResutado;
        }

        /// <summary>
        /// Busca una en texto Introducido en Una Tabla.Categoria
        /// </summary>
        /// <param name="Categoria">La Instacia de Datos.DCategoria</param>
        /// <returns>DataTable:Tabla.Categoria{},Null</returns>
        public DataTable MostrarNombre(Categoria Categoria) {
            DataTable tableResutado = new DataTable("Categoria");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Categoria",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Categoria.TextBuscar
                };sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            }
            catch {
                tableResutado = null;
            }
            return tableResutado;
        }
    }
}