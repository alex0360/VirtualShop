using System;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Articulo
    {
        private int _IdArticulo;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private byte[] _Imagen;
        private int _IdCategoria;
        private int _IdPresentacion;
        private string _TextBuscar;

        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public int IdPresentacion { get => _IdPresentacion; set => _IdPresentacion = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Articulo() { }

        /// <summary>
        /// Constructor All Parametrs
        /// </summary>
        /// <param name="idArticulo">id de la tabla.Articulo</param>
        /// <param name="codigo">Codigo de barra</param>
        /// <param name="nombre">Nombre del Articulo</param>
        /// <param name="descripcion">Descripcion del Articulo</param>
        /// <param name="imagen">Imgan si la tiena</param>
        /// <param name="idCategoria">fk de la tabla.Categoria</param>
        /// <param name="idPresentacion">fk de la tabla.Presentacion</param>
        /// <param name="textBuscar">Campo a buscar</param>
        public Articulo(int idArticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion, string textBuscar)
        {
            IdArticulo = idArticulo;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Imagen = imagen;
            IdCategoria = idCategoria;
            IdPresentacion = idPresentacion;
            TextBuscar = textBuscar;
        }

        /// <summary>
        /// Insentar Fila a Tabla.Articulo
        /// </summary>
        /// <param name="Articulo">La Instacia de Datos.Articulo</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Articulo Articulo)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Articulo",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idArticulo",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParCodigo = new SqlParameter() {
                    ParameterName = "@codigo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Articulo.Codigo
                }; sqlCommand.Parameters.Add(ParCodigo);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Articulo.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = Articulo.Descripcion
                }; sqlCommand.Parameters.Add(ParDescripcion);
                SqlParameter ParImagen = new SqlParameter() {
                    ParameterName = "@imagen",
                    SqlDbType = SqlDbType.Image,
                    Value = Articulo.Imagen
                }; sqlCommand.Parameters.Add(ParImagen);
                SqlParameter ParIdCategoria = new SqlParameter() {
                    ParameterName = "@idCategoria",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdCategoria
                }; sqlCommand.Parameters.Add(ParIdCategoria);
                SqlParameter ParIdPresentacion = new SqlParameter() {
                    ParameterName = "@idPresentacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdPresentacion
                }; sqlCommand.Parameters.Add(ParIdPresentacion);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Modificar Fila de la Tabla.Articulo
        /// </summary>
        /// <param name="Articulo">La Instacia de Datos.Articulo</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Articulo Articulo)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Articulo",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idArticulo",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdPresentacion,
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParCodigo = new SqlParameter() {
                    ParameterName = "@codigo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Articulo.Codigo
                }; sqlCommand.Parameters.Add(ParCodigo);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Articulo.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParDescripcion = new SqlParameter() {
                    ParameterName = "@descripcion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1024,
                    Value = Articulo.Descripcion
                }; sqlCommand.Parameters.Add(ParDescripcion);
                SqlParameter ParImagen = new SqlParameter() {
                    ParameterName = "@imagen",
                    SqlDbType = SqlDbType.Image,
                    Value = Articulo.Imagen
                }; sqlCommand.Parameters.Add(ParImagen);
                SqlParameter ParIdCategoria = new SqlParameter() {
                    ParameterName = "@idCategoria",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdCategoria
                }; sqlCommand.Parameters.Add(ParIdCategoria);
                SqlParameter ParIdPresentacion = new SqlParameter() {
                    ParameterName = "@idPresentacion",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdPresentacion
                }; sqlCommand.Parameters.Add(ParIdPresentacion);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Actualizo el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            } 
            return respuesta;
        }

        /// <summary>
        /// Elimia Fila Tabla.Articulo
        /// </summary>
        /// <param name="Articulo">La Instacia de Datos.Articulo</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Articulo Articulo)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Articulo",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idArticulo",
                    SqlDbType = SqlDbType.Int,
                    Value = Articulo.IdArticulo,
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
        /// <returns>DataTable:Tabla.Articulo{100Filas},Null</returns>
        public DataTable Mostrar()
        {
            DataTable tableResutado = new DataTable("Articulo");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Articulo",
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
        /// Busca una en texto Introducido en Una Tabla.Articulo
        /// </summary>
        /// <param name="Articulo">La Instacia de Datos.Articulo</param>
        /// <returns>DataTable:Tabla.Articulo{},Null</returns>
        public DataTable MostrarNombre(Articulo Articulo)
        {
            DataTable tableResutado = new DataTable("Articulo");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Articulo",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Articulo.TextBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }

        public DataTable StockArticulo()
        {
            DataTable tableResutado = new DataTable("Articulo");
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpStock_Articulo",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            }
            catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
    }
}
