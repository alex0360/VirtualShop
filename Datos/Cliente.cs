using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class Cliente
   {
        private int _IdCliente;
        private string _Nombre;
        private string _Apellidos;
        private string _Sexo;
        private DateTime _Fecha_nacimiento;
        private string _Tipo_documento;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _TextBuscar;

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Tipo_documento { get => _Tipo_documento; set => _Tipo_documento = value; }
        public string Num_documento { get => _Num_documento; set => _Num_documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Cliente() {}
        /// <summary>
        /// Constructor All Paramets
        /// </summary>
        /// <param name="idCliente">id de la tabla</param>
        /// <param name="nombre">Primer nombre del cliente</param>
        /// <param name="apellidos">Los dos Apellidos del cliente</param>
        /// <param name="sexo">Genero del cliente</param>
        /// <param name="fecha_nacimiento">Fecha de nacimento...calcular la edad</param>
        /// <param name="tipo_documento">Tipo de documento</param>
        /// <param name="num_documento">Numero del documento</param>
        /// <param name="direccion">Direccion del Cliente</param>
        /// <param name="telefono">Telefono del cliente</param>
        /// <param name="email">Email del cliente</param>
        /// <param name="textBuscar">paramets a buscar</param>
        public Cliente(int idCliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, 
            string num_documento, string direccion, string telefono, string email, string textBuscar) {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Fecha_nacimiento = fecha_nacimiento;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            TextBuscar = textBuscar;
        }
        /// <summary>
        /// Insentar Fila a Tabla.Cliente
        /// </summary>
        /// <param name="Cliente">La Instacia de Datos.Cliente</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Cliente Cliente)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Cliente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCliente",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Cliente.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParApellidos = new SqlParameter() {
                    ParameterName = "@apellidos",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 40,
                    Value = Cliente.Apellidos
                }; sqlCommand.Parameters.Add(ParApellidos);
                SqlParameter ParSexo = new SqlParameter() {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1,
                    Value = Cliente.Sexo
                }; sqlCommand.Parameters.Add(ParSexo);
                SqlParameter ParFecha_nacimiento = new SqlParameter() {
                    ParameterName = "@fecha_nacimiento",
                    SqlDbType = SqlDbType.Date,
                    Value = Cliente.Fecha_nacimiento
                }; sqlCommand.Parameters.Add(ParFecha_nacimiento);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Cliente.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 14,
                    Value = Cliente.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Cliente.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size =10,
                    Value = Cliente.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Cliente.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
               
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se ingreso el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }
        /// <summary>
        /// Modificar Fila de la Tabla.Cliente
        /// </summary>
        /// <param name="Clienter">La Instacia de Datos.Cliente</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Cliente Cliente)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Cliente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCliente",
                    SqlDbType = SqlDbType.Int,
                    Value = Cliente.IdCliente
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter() {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Cliente.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParApellidos = new SqlParameter() {
                    ParameterName = "@apellidos",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 40,
                    Value = Cliente.Apellidos
                }; sqlCommand.Parameters.Add(ParApellidos);
                SqlParameter ParSexo = new SqlParameter() {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1,
                    Value = Cliente.Sexo
                }; sqlCommand.Parameters.Add(ParSexo);
                SqlParameter ParFecha_nacimiento = new SqlParameter() {
                    ParameterName = "@fecha_nacimiento",
                    SqlDbType = SqlDbType.Date,
                    Value = Cliente.Fecha_nacimiento
                }; sqlCommand.Parameters.Add(ParFecha_nacimiento);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Cliente.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 14,
                    Value = Cliente.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Cliente.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 10,
                    Value = Cliente.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Cliente.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Actualizo el registro";

            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }
        /// <summary>
        /// Elimia Fila Tabla.Cliente
        /// </summary>
        /// <param name="Cliente">La Instacia de Datos.Cliente</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Cliente Cliente)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Cliente",
                    CommandType = CommandType.StoredProcedure,
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idCliente",
                    SqlDbType = SqlDbType.Int,
                    Value=Cliente.IdCliente
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
            DataTable tableResutado = new DataTable("Cliente");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Cliente",
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
        /// Busca en un texto Introducido en Una Tabla.Cliente
        /// </summary>
        /// <param name="Cliente">La Instacia de Datos.Cliente</param>
        /// <returns>DataTable:Tabla.Categoria{},Null</returns>
        public DataTable Buscar_Cliente(Cliente Cliente)
        {
            DataTable tableResutado = new DataTable("Cliente");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Cliente",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Cliente.TextBuscar
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
