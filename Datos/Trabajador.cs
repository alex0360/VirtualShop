using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Trabajador
    {
        private int _IdTrabajador;
        private string _Nombre, _Apellidos, _Sexo, _Tipo_documento;
        private DateTime _Fecha_nacimiento;
        private string _Num_documento, _Direccion, _Telefono, _Email, _Acesso, _Usuario, _Password, _TextBuscar;

        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
        public string Tipo_documento { get => _Tipo_documento; set => _Tipo_documento = value; }
        public string Num_documento { get => _Num_documento; set => _Num_documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Acesso { get => _Acesso; set => _Acesso = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string TextBuscar { get => _TextBuscar; set => _TextBuscar = value; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Trabajador() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="idTrabajador">id de la tabla</param>
        /// <param name="nombre">nombre del empleado</param>
        /// <param name="apellidos">apellidos del empleado</param>
        /// <param name="sexo">sexo {f,m}</param>
        /// <param name="fecha_nacimiento">fecha de nacimiento {00/00/0000}</param>
        /// <param name="tipo_documento"> Tipo de documento</param>
        /// <param name="num_documento">numero de documento</param>
        /// <param name="direccion">direccion</param>
        /// <param name="telefono">telefono</param>
        /// <param name="email">email</param>
        /// <param name="acesso">Enum con los tipos de acessos</param>
        /// <param name="usuario">nombre de usuario</param>
        /// <param name="password">password de usuario</param>
        /// <param name="textBuscar">texto a buscar</param>
        public Trabajador(int idTrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email, string acesso, string usuario, string password, string textBuscar) {
            IdTrabajador = idTrabajador;
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Fecha_nacimiento = fecha_nacimiento;
            Tipo_documento = tipo_documento;
            Num_documento = num_documento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Acesso = acesso;
            Usuario = usuario;
            Password = password;
            TextBuscar = textBuscar;
        }

        /// <summary>
        /// Inserta una Fila en la Tabla.Trabajador
        /// </summary>
        /// <param name="Trabajador">La Instacia de Datos.Trabajador</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Insertar(Trabajador Trabajador)
        {
            string respuesta = null;
            try {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpInsertar_Trabajador",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParId = new SqlParameter {
                    ParameterName = "@idTrabajador",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Nombre
                };sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParApellidos = new SqlParameter {
                    ParameterName = "@apellidos",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 40,
                    Value = Trabajador.Apellidos
                };sqlCommand.Parameters.Add(ParApellidos);
                SqlParameter ParSexo = new SqlParameter() {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1,
                    Value = Trabajador.Sexo
                }; sqlCommand.Parameters.Add(ParSexo);
                SqlParameter ParFecha_nacimiento = new SqlParameter() {
                    ParameterName = "@fecha_nacimiento",
                    SqlDbType = SqlDbType.Date,
                    Value = Trabajador.Fecha_nacimiento
                }; sqlCommand.Parameters.Add(ParFecha_nacimiento);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 14,
                    Value = Trabajador.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Trabajador.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 10,
                    Value = Trabajador.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Trabajador.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
                SqlParameter ParAcesso = new SqlParameter() {
                    ParameterName = "@acesso",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Acesso
                }; sqlCommand.Parameters.Add(ParAcesso);
                SqlParameter ParUsuario = new SqlParameter() {
                    ParameterName = "@usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Usuario
                }; sqlCommand.Parameters.Add(ParUsuario);
                SqlParameter ParPassword = new SqlParameter() {
                    ParameterName = "@password",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Password
                }; sqlCommand.Parameters.Add(ParPassword);
                respuesta = sqlCommand.ExecuteNonQuery() == 1?
                    "Ok" : "No se ingreso el registro";
            }
            catch(Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Actualiza una Fila en la Tabla.Trabajador
        /// </summary>
        /// <param name="Trabajador">La Instacia de Datos.Trabajador</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Editar(Trabajador Trabajador)
        {
            string respuesta = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEditar_Trabajador",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParId = new SqlParameter {
                    ParameterName = "@idTrabajador",
                    SqlDbType = SqlDbType.Int,
                    Value = Trabajador.IdTrabajador
                }; sqlCommand.Parameters.Add(ParId);
                SqlParameter ParNombre = new SqlParameter {
                    ParameterName = "@nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Nombre
                }; sqlCommand.Parameters.Add(ParNombre);
                SqlParameter ParApellidos = new SqlParameter {
                    ParameterName = "@apellidos",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 40,
                    Value = Trabajador.Apellidos
                }; sqlCommand.Parameters.Add(ParApellidos);
                SqlParameter ParSexo = new SqlParameter() {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 1,
                    Value = Trabajador.Sexo
                }; sqlCommand.Parameters.Add(ParSexo);
                SqlParameter ParFecha_nacimiento = new SqlParameter() {
                    ParameterName = "@fecha_nacimiento",
                    SqlDbType = SqlDbType.Date,
                    Value = Trabajador.Fecha_nacimiento
                }; sqlCommand.Parameters.Add(ParFecha_nacimiento);
                SqlParameter ParTipo_documento = new SqlParameter() {
                    ParameterName = "@tipo_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Tipo_documento
                }; sqlCommand.Parameters.Add(ParTipo_documento);
                SqlParameter ParNum_documento = new SqlParameter() {
                    ParameterName = "@num_documento",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 14,
                    Value = Trabajador.Num_documento,
                }; sqlCommand.Parameters.Add(ParNum_documento);
                SqlParameter ParDireccion = new SqlParameter() {
                    ParameterName = "@direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = Trabajador.Direccion,
                }; sqlCommand.Parameters.Add(ParDireccion);
                SqlParameter ParTelefono = new SqlParameter() {
                    ParameterName = "@telefono",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 10,
                    Value = Trabajador.Telefono,
                }; sqlCommand.Parameters.Add(ParTelefono);
                SqlParameter ParEmail = new SqlParameter() {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Trabajador.Email,
                }; sqlCommand.Parameters.Add(ParEmail);
                SqlParameter ParAcesso = new SqlParameter() {
                    ParameterName = "@acesso",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Acesso
                }; sqlCommand.Parameters.Add(ParAcesso);
                SqlParameter ParUsuario = new SqlParameter() {
                    ParameterName = "@usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Usuario
                }; sqlCommand.Parameters.Add(ParUsuario);
                SqlParameter ParPassword = new SqlParameter() {
                    ParameterName = "@password",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Trabajador.Password
                }; sqlCommand.Parameters.Add(ParPassword);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Ok" : "No se Actulizo el registro";
            } catch (Exception ex)
            {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }

        /// <summary>
        /// Elimina una Fila en la Tabla.Trabajador
        /// </summary>
        /// <param name="Trabajador">La Instacia de Datos.Trabajador</param>
        /// <returns>String:OK, Message.Error, Null</returns>
        public string Eliminar(Trabajador Trabajador)
        {
            string respuesta = null;
            try {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_Trabajador",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParId = new SqlParameter() {
                    ParameterName = "@idTrabajador",
                    SqlDbType = SqlDbType.Int,
                    Value = Trabajador.IdTrabajador
                };sqlCommand.Parameters.Add(ParId);

                respuesta = sqlCommand.ExecuteNonQuery() == 1?
                    "Ok":"No se Elimino el Registro"; 
            }
            catch(Exception ex) {
                respuesta = ex.Message.ToString();
            }
            return respuesta;
        }
        /// <summary>
        /// Carga una obj.Tabla en memoria
        /// </summary>
        /// <returns>DataTable:Tabla.Trabajador{100Filas},Null</returns>
        public DataTable Mostrar()
        {
            DataTable tableResutado = new DataTable("Trabajador");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_Trabajador",
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
        /// Busca en un texto Introducido en Una Tabla.Trabajador
        /// </summary>
        /// <param name="Trabajador">a Instacia de Datos.Trabajador</param>
        /// <returns>DataTable:Tabla.Trabajador{},Null</returns>
        public DataTable Buscar_Trabajador(Trabajador Trabajador)
        {
            DataTable tableResutado = new DataTable("Trabajador");
            try
            {
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_Trabajador",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 150,
                    Value = Trabajador.TextBuscar
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
        /// Comprueba si el Nombre de Usuario Existe O no
        /// </summary>
        /// <param name="Trabajador">Instacia de Trabajador</param>
        /// <returns>Un Unico valor o Null</returns>
        public DataTable Buscar_Usuario(Trabajador Trabajador)
        {
            DataTable tablaResultado = new DataTable("Trabajador");
            try {
                SqlCommand sqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscarUsuario_Trabajador",
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter ParBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = Trabajador.TextBuscar
                };sqlCommand.Parameters.Add(ParBuscar);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(tablaResultado);

            } catch(Exception ex) {
                tablaResultado = null;
            }
            return tablaResultado;

        }

    }
}
