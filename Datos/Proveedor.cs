using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Proveedor
    {
        private int _IdProveedor;
        private string _Razon_social;
        private string _Sector_Comercial;
        private string _Tipo_documento;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Url;
        private string _TextBuscar;

        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string Razon_social { get => _Razon_social; set => _Razon_social = value; }
        public string Sector_Comercial { get => _Sector_Comercial; set => _Sector_Comercial = value; }
        public string Tipo_documento { get => _Tipo_documento; set => _Tipo_documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Url { get => _Url; set => _Url = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }
        public string Num_documento { get => _Num_documento; set => _Num_documento = value; }

        // Constuctor Vacio
        public Proveedor() { }

        /// <summary>
        /// Constructor All Paramets
        /// </summary>
        /// <param name="idProveedor">id de la tabla.Proveedor</param>
        /// <param name="razon_social">Razon Social</param>
        /// <param name="sector_comercial">Sector Comercial</param>
        /// <param name="tipo_documento">Tipo Documento</param>
        /// <param name="direccion">Direccion</param>
        /// <param name="telefono">Telefono</param>
        /// <param name="email">Email</param>
        /// <param name="url">Url</param>
        /// <param name="textBuscar">Campo a buscar</param>
        public Proveedor(
            int idProveedor, string razon_social, string sector_comercial,
            string tipo_documento, string num_documento, string direccion, string telefono, 
            string email, string url, string textBuscar) {

            IdProveedor = idProveedor;
            Razon_social = razon_social;
            Sector_Comercial = sector_comercial;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Url = url;
            TextBuscar = textBuscar;
        }

        /// <summary>
        /// Insentar Fila a Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Proveedor Proveedor)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Proveedor",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idProveedor",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParRazon_social = new SqlParameter() {
                    ParameterName = "@razon_social",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Proveedor.Razon_social
                }; sqlCommand.Parameters.Add(ParRazon_social);
                SqlParameter ParSector_comercial = new SqlParameter() {
                    ParameterName = "@sector_comercial",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Sector_Comercial
                }; sqlCommand.Parameters.Add(ParSector_comercial);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Proveedor.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
                SqlParameter ParUrl = new SqlParameter() {
                    ParameterName = "@url_web",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Proveedor.Url,
                }; sqlCommand.Parameters.Add(ParUrl);

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Modificar Fila de la Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Proveedor Proveedor)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Proveedor",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idProveedor",
                    SqlDbType = SqlDbType.Int,
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParRazon_social = new SqlParameter() {
                    ParameterName = "@razon_social",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Proveedor.Razon_social
                }; sqlCommand.Parameters.Add(ParRazon_social);
                SqlParameter ParSector_comercial = new SqlParameter() {
                    ParameterName = "@sector_comercial",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Sector_Comercial
                }; sqlCommand.Parameters.Add(ParSector_comercial);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Proveedor.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
                SqlParameter ParUrl = new SqlParameter() {
                    ParameterName = "@url_web",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Proveedor.Url,
                }; sqlCommand.Parameters.Add(ParUrl);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Actualizo el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Elimia Fila Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Proveedor Proveedor)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Proveedor",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idProveedor",
                    SqlDbType = SqlDbType.Int,
                    Value = Proveedor.IdProveedor,
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
        /// <returns>DataTable:Tabla.Proveedor{100Filas},Null</returns>
        public DataTable Mostrar()
        {
            DataTable tableResutado = new DataTable("Proveedor");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Proveedor",
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
        /// Busca una en texto Introducido en Una Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>DataTable:Tabla.Proveedor.Num_document{},Null</returns>
        public DataTable MostrarNumDocument(Proveedor Proveedor)
        {
            DataTable tableResutado = new DataTable("Proveedor");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "Spbuscar_Proveedor_num_documento",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Proveedor.TextBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
        /// <summary>
        /// Busca una en texto Introducido en Una Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>DataTable:Tabla.Proveedor.Razon_social{},Null</returns>
        public DataTable MostrarR_social(Proveedor Proveedor)
        {
            DataTable tableResutado = new DataTable("Proveedor");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "Spbuscar_Proveedor_razon_social",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Proveedor.TextBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch
            {
                tableResutado = null;
            }
            return tableResutado;
        }
        /// <summary>
        /// Busca una en texto Introducido en Una Tabla.Proveedor
        /// </summary>
        /// <param name="Proveedor">La Instacia de Datos.Proveedor</param>
        /// <returns>DataTable:Tabla.Proveedor.Razon_social or Numero Documento{},Null</returns>
        public DataTable MostrarNumDoc_RazonSocial(Proveedor Proveedor)
        {
            DataTable tableResutado = new DataTable("Proveedor");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "Spbuscar_Proveedor_NumDoc_RazonSocial",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Proveedor.TextBuscar
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
