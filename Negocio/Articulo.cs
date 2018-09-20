using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Articulo
    {
        private static Datos.Articulo Obj = null;

        /// <summary>
        /// Insertando los datos a la tabla.Articulo
        /// </summary>
        /// <param name="codigo">Codigo de barra</param>
        /// <param name="nombre">Nombre del Articulo</param>
        /// <param name="descripcion">Descripcion del Articulo</param>
        /// <param name="imagen">Imgan si la tiena</param>
        /// <param name="idCategoria">fk de la tabla.Categoria</param>
        /// <param name="idPresentacion">fk de la tabla.Presentacion</param>
        /// <returns>El resultado de Datos.Articulo.Insertar</returns>
        public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion)
        {
            Obj = new Datos.Articulo {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                Imagen = imagen,
                IdCategoria = idCategoria,
                IdPresentacion = idPresentacion
            };
            return Obj.Insertar(Obj);
        }

        /// <summary>
        /// Invoca el metodo Editar Datos.Articulo
        /// </summary>
        /// <param name="idArticulo">id de la Tabla.Articulo</param>
        /// <param name="codigo">Codigo de barra</param>
        /// <param name="nombre">Nombre del Articulo</param>
        /// <param name="descripcion">Descripcion del Articulo</param>
        /// <param name="imagen">Imgan si la tiena</param>
        /// <param name="idCategoria">fk de la tabla.Categoria</param>
        /// <param name="idPresentacion">fk de la tabla.Presentacion</param>
        /// <returns>El resultado de Datos.Articulo.Editar</returns>
        public static string Editar(int idArticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion)
        {
            Obj = new Datos.Articulo{
                IdArticulo = idArticulo,
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                Imagen = imagen,
                IdCategoria = idCategoria,
                IdPresentacion = idPresentacion
            };
            return Obj.Editar(Obj);
        }

        /// <summary>
        /// Invoca el metodo Eliminar Datos.Articulo
        /// </summary>
        /// <param name="idArticulo">id de la Tabla.Articulo</param>
        /// <returns>El resultado de Datos.Articulo.Eliminar</returns>
        public static string Eliminar(int idArticulo)
        {
            Obj = new Datos.Articulo {
                IdArticulo = idArticulo
            };
            return Obj.Eliminar(Obj);
        }

        /// <summary>
        /// Invoca el metodo Datos.Articulo.Mostar
        /// </summary>
        /// <returns>DataTable:Tabla.Articulo{100Filas},Null</returns>
        public static System.Data.DataTable Mostrar()
        {
            return new Datos.Articulo().Mostrar();
        }

        /// <summary>
        /// Invoca el metodo Datos.Articulo.BuscarMostar
        /// </summary>
        /// <param name="textBuscar">El Texto que sera buscado</param>
        /// <returns>DataTable:Tabla.Articulo{},Null</returns>
        public static System.Data.DataTable BuscarMostar(string textBuscar)
        {
            Obj = new Datos.Articulo {
                TextBuscar = textBuscar
            };            
            return Obj.MostrarNombre(Obj);
        }

        public void AdjustColumn(System.Windows.Forms.DataGridView DataGridView)
        {
            DataGridView.Columns["idArticulo"].DisplayIndex = 0;
            DataGridView.Columns["codigo"].DisplayIndex = 1; 
            DataGridView.Columns["nombre"].DisplayIndex = 2;  
            DataGridView.Columns["descripcion"].DisplayIndex = 4;/*3*/  DataGridView.Columns["descripcion"].Width = 150;
            DataGridView.Columns["imagen"].DisplayIndex = 3;/*4*/  DataGridView.Columns["imagen"].Width = 100;
            DataGridView.Columns["idCategoria"].DisplayIndex = 5;
            DataGridView.Columns["idPresentacion"].DisplayIndex = 6;
        }
    }
}
