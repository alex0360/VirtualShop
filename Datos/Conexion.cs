namespace Datos
{
    class Conexion
    {
        public static System.Data.SqlClient.SqlConnection SqlConnection = Trigger();

        private static System.Data.SqlClient.SqlConnection Trigger()
        {
            SqlConnection =
                new System.Data.SqlClient.SqlConnection
                    (System.Configuration.ConfigurationManager.AppSettings
                        ["ConectionStringDBVentas"]);

            if (SqlConnection.State == System.Data.ConnectionState.Open) SqlConnection.Close();
            if (SqlConnection.State == System.Data.ConnectionState.Closed) SqlConnection.Open();

            return SqlConnection;
        }
        ~Conexion() { if (SqlConnection.State == System.Data.ConnectionState.Open) SqlConnection.Close(); }
    }
}
