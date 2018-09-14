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
        public int? IdTrabajador;
        private DataTable DtDetalles;
        private decimal Acumulador = 0; 
        private static FormIngreso _Instancia;
        private int?  IdIngreso,IdProveedor, IdArticulo;
        //Fin de las Variables
        //
        #region Metodos
        public FormIngreso()
        {
            InitializeComponent();
            base.TTMensaje.SetToolTip(this.TBProveedor, "Seleccione el Proveedor");
            base.TTMensaje.SetToolTip(this.TBSerie, "Ingrese la Serie");
            base.TTMensaje.SetToolTip(this.TBCorrelativo, "Ingrese el número del comprobante");
            base.TTMensaje.SetToolTip(this.TBStock, "Ingrese la cantidad en Stock");
            base.TTMensaje.SetToolTip(this.TBArticulo, "Seleccione el Articulo de compra");
            TBArticulo.ReadOnly = true;
            TBProveedor.ReadOnly = true;
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
        // Mensaje de informacion       
        protected override void MensajeOK(string mensaje = "Operacion Correta") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Mensaje de Error
         protected override void MensajeError(string mensaje = "Falta ingresar algunos datos, seran remarcados") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // Limpiar los Controles
        private void Clear()
        {
            IdIngreso = null;
            IdProveedor = null;
            TBProveedor.Text = string.Empty;
            TBSerie.Text = string.Empty;
            TBCorrelativo.Text = string.Empty;
            TBIgv.Text = string.Empty;
            LTotal_Pagado.Text = "0.0";
            TBIgv.Text = "18";
            CrearTabla();
        }
        private void ClearDetalle() {
            IdArticulo = null;
            TBArticulo.Text = string.Empty;
            TBStock.Text = string.Empty;
            TBPrecio_compra.Text = string.Empty;
            TBPrecio_venta.Text = string.Empty;
        }

        // Habilitar o desha Controles
        private void Habilitar(bool valor)
        {

        }

        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Visible = false;
        }

        // CheckBox MostrarRowsEliminar
        private void RowsEliminar()
        {
            if (CBEliminar.Checked)
                DGVListado.Columns[0].Visible = true;
            else
                DGVListado.Columns[0].Visible = false;
        }


        // !Enabled Nuevo
        private System.Boolean isNuevo;
        private System.Boolean Nuevo()
        {
            if (IdArticulo.Equals(null))
            {
                isNuevo = true;
            }
            return isNuevo;
        }

        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Articulo.Mostar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }

        // Metodo Mostrar
        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Ingreso.BuscarMostar(DTPFecha_inicio.Value.ToString("dd/MM/yyyy"),DTPFecha_Final.Value.ToString("dd/MM/yyyy"));
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Metodo Mostrar Detalles
        private void MostrarDetalles()
        {
            DGVListados_detalles.DataSource = Negocio.Ingreso.Mostar(IdIngreso);
        }
        // Crear La tabla
        private void CrearTabla() {
            DtDetalles = new DataTable("Detalle");
            DtDetalles.Columns.Add("idAticulo", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("articulo", Type.GetType("System.String"));
            DtDetalles.Columns.Add("precio_compra", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("precio_venta", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("stock_inicial", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("fecha_produccion", Type.GetType("System.DateTime"));
            DtDetalles.Columns.Add("fecha_vencimiento", Type.GetType("System.DateTime"));
            DtDetalles.Columns.Add("SubTotal", Type.GetType("System.Decimal"));
            // Relacionamos nuestro DataGridView con nuesta DataTable
            DGVListado.DataSource = DtDetalles;
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

        private void BBuscar_fecha_Click(object sender, EventArgs e)
        {
            BuscarMostar();
        }

        private void DatagListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell cbEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["Eliminar"];
                cbEliminar.Value = !Convert.ToBoolean(cbEliminar.Value);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente Desea Anular", "Sistema de Ventas", MessageBoxButtons.OKCancel);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string resultado = string.Empty;

                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultado = Negocio.Ingreso.Anular(System.Convert.ToInt32(codigo));

                            if (resultado.Equals("Ok"))
                                MensajeOK("Se Anulo Correctamente el registro");
                            else
                                MensajeError(resultado);
                        }
                    }
                    Mostrar();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            Clear();
        }

        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
            
        }
    }
}
