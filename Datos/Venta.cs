﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Venta
    {
        private int _IdVenta;
        private int _IdCliente;
        private int _IdTrabajador;
        private DateTime _Fecha;
        private string _Tipo_Comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Igv;
        private string _Estado;

        //Propiedades
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo_Comprobante { get => _Tipo_Comprobante; set => _Tipo_Comprobante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Igv { get => _Igv; set => _Igv = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //Constructores
        public Venta()
        {

        }
        public Venta(int idVenta, int idCliente, int idTrabajador, 
            DateTime fecha, string tipo_comprobante, string serie, 
            string correlativo, decimal igv, string estado)
        {
            this.IdVenta = idVenta;
            this.IdCliente = idCliente;
            this.IdTrabajador = idTrabajador;
            this.Fecha = fecha;
            this.Tipo_Comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            this.Estado = estado;
        }
        //Métodos
        public string Insertar(Venta Venta, List<Detalle_venta> detalles)
        {
            string respuesta = null;
            try
            {
                //Establecer la transacción
                SqlTransaction SqlTransaction = Conexion.SqlConnection.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    Transaction = SqlTransaction,
                    CommandText = "SpInsertar_venta",
                    CommandType = CommandType.StoredProcedure
                };

                //Parámtros
                SqlParameter ParId = new SqlParameter {
                    ParameterName = "@idVenta",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                SqlCommand.Parameters.Add(ParId);

                SqlParameter ParIdCliente = new SqlParameter {
                    ParameterName = "@idCliente",
                    SqlDbType = SqlDbType.Int,
                    Value = Venta.IdCliente
                };
                SqlCommand.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTrabajador = new SqlParameter {
                    ParameterName = "@idTrabajador",
                    SqlDbType = SqlDbType.Int,
                    Value = Venta.IdTrabajador
                };
                SqlCommand.Parameters.Add(ParIdTrabajador);

                SqlParameter ParFecha = new SqlParameter {
                    ParameterName = "@fecha",
                    SqlDbType = SqlDbType.Date,
                    Value = Venta.Fecha
                };
                SqlCommand.Parameters.Add(ParFecha);

                SqlParameter ParTipo_Comprobante = new SqlParameter {
                    ParameterName = "@tipo_comprobante",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20,
                    Value = Venta.Tipo_Comprobante
                };
                SqlCommand.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParSerie = new SqlParameter {
                    ParameterName = "@serie",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 4,
                    Value = Venta.Serie
                };
                SqlCommand.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter {
                    ParameterName = "@correlativo",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 7,
                    Value = Venta.Correlativo
                };
                SqlCommand.Parameters.Add(ParCorrelativo);

                SqlParameter ParIgv = new SqlParameter {
                    ParameterName = "@igv",
                    SqlDbType = SqlDbType.Decimal,
                    Precision = 4,
                    Scale = 2,
                    Value = Venta.Igv
                };
                SqlCommand.Parameters.Add(ParIgv);

                SqlParameter ParEstado = new SqlParameter {
                    ParameterName = "@estado",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 7,
                    Value = Venta.Estado
                };
                SqlCommand.Parameters.Add(ParEstado);


                //Ejecutamos nuestro comando
                respuesta = SqlCommand.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (respuesta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.IdVenta = Convert.ToInt32(SqlCommand.Parameters["@idVenta"].Value);
                    foreach (Detalle_venta detalle in detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        detalle.IdVenta = this.IdVenta;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        respuesta = detalle.Insertar(detalle, ref Conexion.SqlConnection, ref SqlTransaction);
                        if (!respuesta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        } else
                        {
                            //Actualizamos el Stock

                            respuesta = DisminuirStock(detalle.IdDetalle_Ingreso, detalle.Cantidad);
                            if (!respuesta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTransaction.Commit();
                } else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTransaction.Rollback();
                }

            } catch (Exception ex)
            {
                respuesta = ex.Message;
            } finally
            {
                Conexion.SqlConnection.Close();
            }
            return respuesta;

        }

        public string Eliminar(Venta Venta)
        {
            string respuesta = null;
            try
            {
                //Establecer el Comando
                SqlCommand sqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpEliminar_venta",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParId = new SqlParameter {
                    ParameterName = "@idVenta",
                    SqlDbType = SqlDbType.Int,
                    Value = Venta.IdVenta
                };
                sqlCommand.Parameters.Add(ParId);
                //Ejecutamos nuestro comando

                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "OK";

            } catch (Exception ex)
            {
                respuesta = ex.Message;
            } finally
            {
            }
            return respuesta;
        }
        //Disminuir Stock
        public string DisminuirStock(int idDetalle_ingreso, int cantidad)
        {
            string respuesta = null;
            
            try
            {
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpDisminuir_stock",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParIddetalle_ingreso = new SqlParameter {
                    ParameterName = "@idDetalle_ingreso",
                    SqlDbType = SqlDbType.Int,
                    Value = idDetalle_ingreso
                };
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter {
                    ParameterName = "@cantidad",
                    SqlDbType = SqlDbType.Int,
                    Value = cantidad
                };
                SqlCmd.Parameters.Add(ParCantidad);
                //Ejecutamos nuestro comando

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Se actualizó el Stock";

            } catch (Exception ex)
            {
                respuesta = ex.Message;
            } finally
            {

            }
            return respuesta;
        }


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable Resultado = new DataTable("Venta");
            try
            {
                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_venta",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(Resultado);

            } catch
            {
                Resultado = null;
            }
            return Resultado;

        }


        //Método BuscarFechas
        public DataTable BuscarFechas(string TextBuscar1, string TextBuscar2)
        {
            DataTable DtResultado = new DataTable("Venta");
            try
            {

                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_venta_fecha",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextoBuscar = new SqlParameter {
                    ParameterName = "@textBuscar1",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = TextBuscar1
                };
                SqlCommand.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter {
                    ParameterName = "@textBuscar2",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = TextBuscar2
                };
                SqlCommand.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(DtResultado);

            } catch
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Método BuscarFechas
        public DataTable MostrarDetalle(string textBuscar)
        {
            DataTable Resultado = new DataTable("Detalle_venta");
            try
            {

                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpMostrar_detalle_venta",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextoBuscar = new SqlParameter {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                };
                SqlCommand.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(Resultado);

            } catch
            {
                Resultado = null;
            }
            return Resultado;

        }
        public DataTable MostrarArticulo_Venta_Nombre(string textBuscar)
        {
            DataTable Resultado = new DataTable("Articulo");
            try
            {
                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_articulo_venta_nombre",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextoBuscar = new SqlParameter {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                };
                SqlCommand.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(Resultado);

            } catch
            {
                Resultado = null;
            }
            return Resultado;

        }
        public DataTable MostrarArticulo_Venta_Codigo(string textBuscar)
        {
            DataTable Resultado = new DataTable("Articulo");
            try
            {
                SqlCommand SqlCommand = new SqlCommand {
                    Connection = Conexion.SqlConnection,
                    CommandText = "SpBuscar_articulo_venta_Codigo",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextoBuscar = new SqlParameter {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                };
                SqlCommand.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(Resultado);

            } catch
            {
                Resultado = null;
            }
            return Resultado;

        }
    }
}