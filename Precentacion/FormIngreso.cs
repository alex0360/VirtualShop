using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormIngreso : Clases.FaderForm
    {
        //Variables
        //
        public Int32? IdTrabajador;
        private static FormIngreso _Instancia;
        private Int32? IdProveedor, IdArticulo;
        #region Metodos
        public FormIngreso()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SingleTon de la Instacia FormIngreso
        /// </summary>
        /// <returns>La Instacia</returns>
        public static FormIngreso GetIngreso() {
            if (_Instancia == null) _Instancia = new FormIngreso();
            return _Instancia;
        }
        /// <summary>
        /// Asignacion de valores
        /// </summary>
        /// <param name="idProveedor">Id</param>
        /// <param name="nombre">Nombre del Proveedor</param>
        public void SetProveedor(int idProveedor, string nombre) {
            IdProveedor = idProveedor;
            TBProveedor.Text = nombre;
        }
        /// <summary>
        /// Asignacion de Valores
        /// </summary>
        /// <param name="idArticulo">Id</param>
        /// <param name="nombre">Nombre del Artuculo</param>
        public void SetArticulo(int idArticulo, string nombre) {
            IdArticulo = idArticulo;
            TBArticulo.Text = nombre;
        }
        #endregion
        #region Funciones
        private void Clear()
        {
            
            CargarComboBox();
            ComboBoxSOLOLectura();
        }
        private void CargarComboBox()
        {
            new Negocio.Read(CBComprovante, "LCom.vshop");
        }
        // Solo Lectura Combobox
        private void ComboBoxSOLOLectura()
        {
            new Negocio.Read(CBComprovante);
        }
        #endregion
        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            FormVistaProveedor form = new FormVistaProveedor();
            form.ShowDialog();
        }

        private void BuscarArticulo_Click(object sender, EventArgs e)
        {
            FormVistaArticulo fom = new FormVistaArticulo();
            fom.ShowDialog();

        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
            
        }
    }
}
