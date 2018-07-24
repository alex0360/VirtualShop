namespace Negocio
{
    public class Categoria{
        private static Datos.Categoria ObjCategoria = null;

        /// <summary>
        /// Invoca el metodo Insertar Datos.Categoria
        /// </summary>
        /// <param name="nombre">Nombre de la Categoria</param>
        /// <param name="descripcion">Descripcion</param>
        /// <returns>El resultado de Datos.DCategoria.Insertar</returns>
        public static string Insertar(string nombre, string descripcion) {
            
                ObjCategoria = new Datos.Categoria
                {
                    Nombre = nombre,
                    Descripcion = descripcion
                };
            return ObjCategoria.Insertar(ObjCategoria);
        }

        /// <summary>
        /// Invoca el metodo Editar Datos.Categoria
        /// </summary>
        /// <param name="idCategoria">id de la Tabla.Categoria</param>
        /// <param name="nombre">Nombre de la Categoria</param>
        /// <param name="descripcion">Descripcion</param>
        /// <returns>El resultado de Datos.DCategoria.Editar</returns>
        public static string Editar(int idCategoria, string nombre, string descripcion){
            ObjCategoria = new Datos.Categoria {
                IdCategoria = idCategoria,
                Nombre = nombre,
                Descripcion = descripcion
            };
            return ObjCategoria.Editar(ObjCategoria);
        }

        /// <summary>
        /// Invoca el metodo Eliminar Datos.Categoria
        /// </summary>
        /// <param name="idCategoria">id de la Tabla.Categoria</param>
        /// <returns>El resultado de Datos.DCategoria.Eliminar</returns>
        public static string Eliminar(int idCategoria){
            ObjCategoria = new Datos.Categoria {
                    IdCategoria = idCategoria
            };
            return ObjCategoria.Eliminar(ObjCategoria);
        }

        /// <summary>
        /// Invoca el metodo Datos.DCategoria.Mostar
        /// </summary>
        /// <returns>DataTable:Tabla.Categoria{200Filas},Null</returns>
        public static System.Data.DataTable Mostar()
        {
            return new Datos.Categoria().Mostrar();
        }

        /// <summary>
        /// Invoca el metodo Datos.DCategoria.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Categoria,Null</returns>
        public static System.Data.DataTable BuscarMostar(string textBuscar)
        {
            ObjCategoria = new Datos.Categoria {
                TextBuscar = textBuscar
            };
            return ObjCategoria.MostrarNombre(ObjCategoria);
        }
    }
}
