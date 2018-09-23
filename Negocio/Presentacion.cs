namespace Negocio
{
    public class Presentacion
    {
        private static Datos.Presentacion ObjPresentacion = null;
        /// <summary>
        /// Invoca el metodo Insertar Datos.Presentacion
        /// </summary>
        /// <param name="nombre">Nombre de la Presentacion</param>
        /// <param name="descripcion">Descripcion</param>
        /// <returns>El resultado de Datos.Presentacion.Insertar</returns>
        public static string Insertar(string nombre, string descripcion)
        {
            ObjPresentacion = new Datos.Presentacion {
                Nombre = nombre,
                Descripcion = descripcion
            };
            return ObjPresentacion.Insertar(ObjPresentacion);
        }
        /// <summary>
        /// Invoca el metodo Editar Datos.Presentacion
        /// </summary>
        /// <param name="idPresentacion">id de la Tabla.Presentacion</param>
        /// <param name="nombre">Nombre de la Presentacion</param>
        /// <param name="descripcion">Descripcion</param>
        /// <returns>El resultado de Datos.Presentacion.Editar</returns>
        public static string Editar(int idPresentacion, string nombre, string descripcion)
        {
            ObjPresentacion = new Datos.Presentacion {
                IdPresentacion = idPresentacion,
                Nombre = nombre,
                Descripcion = descripcion
            };
            return ObjPresentacion.Editar(ObjPresentacion);
        }
        /// <summary>
        /// Invoca el metodo Eliminar Datos.Presentacion
        /// </summary>
        /// <param name="idPresentacion">id de la Tabla.Presentacion</param>
        /// <returns>El resultado de Datos.Presentacion.Eliminar</returns>
        public static string Eliminar(int idPresentacion)
        {
            ObjPresentacion = new Datos.Presentacion {
                IdPresentacion = idPresentacion
            };
            return ObjPresentacion.Eliminar(ObjPresentacion);
        }
        /// <summary>
        /// Invoca el metodo Datos.Presentacion.Mostar
        /// </summary>
        /// <returns>DataTable:Tabla.Presentacion{100Filas},Null</returns>
        public static System.Data.DataTable Mostar() => new Datos.Presentacion().Mostrar();
        /// <summary>
        /// Invoca el metodo Datos.Presentacion.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Presentacion{},Null</returns>
        public static System.Data.DataTable BuscarMostar(string textBuscar)
        {
            ObjPresentacion = new Datos.Presentacion {
                TextBuscar = textBuscar
            };
            return ObjPresentacion.MostrarNombre(ObjPresentacion);
        }
    }
}
