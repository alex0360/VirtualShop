using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormVenta : Clases.FaderForm
    {
        //Variables
        //
        public int? IdTrabajador;
        private DataTable DtDetalles;
        private decimal totalPagado = 0;
        private static FormVenta _Instancia;
        private int? IdVenta, IdCliente, IdArticulo;
        private decimal precio_compra = 0;
        //Fin de las Variables
        //
        #region Metodos
        public FormVenta()
        {
            InitializeComponent();
            TTMensaje.SetToolTip(TBCliente,"Seleccione un Cliente");
            TTMensaje.SetToolTip(TBSerie, "Ingrese una serie del Comprobante");
            TTMensaje.SetToolTip(TBCorrelativo, "Ingrese un numero del Comprobante");
            TTMensaje.SetToolTip(MUDCantidad, "Ingrese la Cantidad del Articulo");
            TTMensaje.SetToolTip(TBArticulo, "Seleccione un Articulo");
            TBStockActual.ReadOnly = true;
            TBPrecio_venta.ReadOnly = true;
            CargarComboBox();
            ComboBoxSOLOLectura();
            _ReSize();
        }
        public static FormVenta GetInstancia()
        {
            if (_Instancia == null) _Instancia = new FormVenta();
            return _Instancia;
        }        
        public void SetCliente(int idCliente, string nombre)
        {
            IdCliente = idCliente;
            TBCliente.Text = nombre;
        }
        public void SetArticulo(int idArtuculo, string nombre,
            decimal precio_compra, decimal precio_venta, int stock, DateTime fecha_vencimiento)
        {
            IdArticulo = idArtuculo;
            TBArticulo.Text = nombre;
            this.precio_compra = precio_compra;
            TBPrecio_venta.Text = Convert.ToString(precio_venta);
            TBStockActual.Text = Convert.ToString(stock);
            DTPFecha_Vencimiento.Value = fecha_vencimiento;

        }
        #endregion
        #region Funciones
        // Mensaje de informacion       
        protected override void MensajeOK(string mensaje = "Operacion Correta") =>
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Mensaje de Error
        protected override void MensajeError(string mensaje = "Falta ingresar algunos datos, seran remarcados") =>
           MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // Limpiar los Controles
        private void Clear()
        {
            IdVenta = null;
            IdCliente = null;
            TBCliente.Text = string.Empty;
            TBSerie.Text = string.Empty;
            TBCorrelativo.Text = string.Empty;
            TBIgv.Text = string.Empty;
            LTotal_Pagado.Text = "0.0";
            TBDescuento.Text = "0";
            TBIgv.Text = "18";
            CrearTabla();
        }
        private void ClearDetalle()
        {
            IdArticulo = null;
            TBArticulo.Text = string.Empty;
            TBStockActual.Text = string.Empty;
            MUDCantidad.Value = 1;
            TBDescuento.Text = "0";
            precio_compra = 0;
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
            if (IdVenta.Equals(null))
            {
                isNuevo = true;
            }
            return isNuevo;
        }

        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Venta.Mostrar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            CargarFechaActual();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }

        // Metodo Mostrar
        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Venta.BuscarFechas(DTPFecha_inicio.Value.ToString("dd/MM/yyyy"), DTPFecha_Final.Value.ToString("dd/MM/yyyy"));
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Metodo Mostrar Detalles
        private void MostrarDetalles()
        {
            DGVListados_detalles.DataSource = Negocio.Venta.Mostrar(IdVenta);
            DGVListados_detalles.Columns[0].Visible = false;
        }
        // Crear La tabla
        private void CrearTabla()
        {
            DtDetalles = new DataTable("Detalle");
            DtDetalles.Columns.Add("idDetalle_ingreso", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("Articulo", Type.GetType("System.String"));
            DtDetalles.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("precio_venta", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("Descuento", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("SubTotal", Type.GetType("System.Decimal"));
            // Relacionamos nuestro DataGridView con nuesta DataTable
            DGVListados_detalles.DataSource = DtDetalles;
        }
        private void CargarComboBox()
        {
            new Negocio.Read(CBComprobante, "LCom.vshop");
        }
        private void CargarFechaActual()
        {
            new Clases.Comunes().Now(DTPFecha_inicio);
            new Clases.Comunes().Now(DTPFecha_Final);
            new Clases.Comunes().Now(DTPFecha);
            new Clases.Comunes().Now(DTPFecha_Vencimiento);
        }
        // Solo Lectura Combobox
        private void ComboBoxSOLOLectura()
        {
            new Negocio.Read(CBComprobante);
        }
        #endregion
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormVentas_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
        #region Eventos
        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            FormVistaCliente vista = new FormVistaCliente();
            vista.ShowDialog();
        }
        private void BuscarArticulo_Click(object sender, EventArgs e)
        {
            FormVistaArticuloVenta vista = new FormVistaArticuloVenta();
            vista.ShowDialog();
        }
        private void BBuscar_fecha_Click(object sender, EventArgs e) => BuscarMostar();
        private void BEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente Desea Eliminar", "Sistema de Ventas", MessageBoxButtons.OKCancel);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string resultado = string.Empty;

                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultado = Negocio.Venta.Eliminar(System.Convert.ToInt32(codigo));

                            if (resultado.Equals("Ok"))
                                MensajeOK("Se Elimino correctamente el registro");
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
        private void DGVListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                IdVenta = Convert.ToInt32(DGVListado.CurrentRow.Cells["idVenta"].Value);
                TBCliente.Text = Convert.ToString(DGVListado.CurrentRow.Cells["cliente"].Value);
                DTPFecha.Value = Convert.ToDateTime(DGVListado.CurrentRow.Cells["fecha"].Value);
                CBComprobante.Text = Convert.ToString(DGVListado.CurrentRow.Cells["tipo_comprobante"].Value);
                TBSerie.Text = Convert.ToString(DGVListado.CurrentRow.Cells["serie"].Value);
                TBCorrelativo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["correlativo"].Value);
                LTotal_Pagado.Text = Convert.ToString(DGVListado.CurrentRow.Cells["total"].Value);
                MostrarDetalles();
                tabCon.SelectedIndex = 1;
            } catch { }
        }
        private void CBEliminar_CheckedChanged(object sender, EventArgs e) => RowsEliminar();
        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell cbEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["Eliminar"];
                cbEliminar.Value = !Convert.ToBoolean(cbEliminar.Value);
            }
        }
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (CBComprobante.Text == string.Empty || TBSerie.Text == string.Empty ||
                    TBCorrelativo.Text == string.Empty || IdCliente == null)
                {
                    MensajeError();
                    if (CBComprobante.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(CBComprobante, "Selecciona un comprobante");
                    if (TBSerie.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBSerie, "Ingrese un numero de serie");
                    if (TBCorrelativo.Text == string.Empty)
                        EPErrorIcono.SetError(TBCorrelativo, "Escriba un Correlativo");
                    if (TBCliente.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBCliente, "Seleccione un Cliente");
                } else
                {
                    if (Nuevo())
                    {
                        respuesta = Negocio.Venta.Insertar(Convert.ToInt32(IdTrabajador), Convert.ToInt32(IdCliente), DTPFecha.Value,
                            CBComprobante.Text, TBSerie.Text, TBCorrelativo.Text, Convert.ToDecimal(TBIgv.Text), DtDetalles);
                    }
                    if (respuesta.Equals("Ok"))
                    {
                        if (isNuevo)
                            MensajeOK("Se Inserto de forma Correcta el registro");
                    } else MensajeError(respuesta);
                    Clear();
                    ClearDetalle();
                    Mostrar();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex + ex.StackTrace, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Clear(); ClearDetalle();
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdArticulo == null || MUDCantidad.Text == string.Empty ||
                    TBDescuento.Text == string.Empty || TBStockActual.Text == string.Empty)
                {
                    MensajeError();
                    if (TBArticulo.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBArticulo, "Seleccion un Articulo");
                    if (MUDCantidad.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(MUDCantidad, "Ingrese un Cantidad");
                    if (TBDescuento.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBPrecio_venta, "Ingrese un Descuento");
                    if (TBStockActual.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBStockActual, "Ingrese un Stock Inicial");
                } else
                {
                    bool registrar = true;
                    foreach (DataRow row in DtDetalles.Rows)
                    {
                        if (Convert.ToInt32(row["idDetalle_ingreso"]) == IdArticulo)
                        {
                            registrar = false;
                            MensajeError("Ya se Encuentra el Articulo en el Detalle");
                        }
                    }
                    if (registrar && Convert.ToInt32(MUDCantidad.Value) <= Convert.ToInt32(TBStockActual.Text))
                    {
                        decimal subTotal = Convert.ToDecimal(TBStockActual.Text) * Convert.ToDecimal(TBPrecio_venta.Text) - Convert.ToDecimal(TBDescuento.Text);
                        totalPagado = totalPagado + subTotal;
                        LTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                        //Agragar ese detalle al datalistadodetalles
                        DataRow row = DtDetalles.NewRow();
                        row["idDetalle_ingreso"] = IdArticulo;
                        row["Articulo"] = TBArticulo.Text;
                        row["Cantidad"] = Convert.ToInt32(MUDCantidad.Text);
                        row["precio_venta"] = Convert.ToDecimal(TBPrecio_venta.Text);
                        row["Descuento"] = Convert.ToDecimal(TBDescuento.Text);
                        row["SubTotal"] = subTotal;
                        DtDetalles.Rows.Add(row);
                        DGVListados_detalles.Columns[0].Visible = false;
                        ClearDetalle();
                    } else {
                        MensajeError("No Hay Stock suficiente");
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = DGVListados_detalles.CurrentCell.RowIndex;
                DataRow row = DtDetalles.Rows[index];
                //Disminuir el TotalPagado
                totalPagado = totalPagado - Convert.ToDecimal(row["subtotal"]);
                LTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                DtDetalles.Rows.Remove(row);
            } catch
            {
                MensajeError("No hay fila para remaver");
            }

        }

        private void BComprobante_Click(object sender, EventArgs e)
        {
            FormReporteFactura form = new FormReporteFactura
            {
                IdVenta = Convert.ToInt32(DGVListado.CurrentRow.Cells["idVenta"].Value)
            };
            form.ShowDialog();
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
            CargarFechaActual();
        }

        private void FormVentas_FormClosing(object sender, FormClosingEventArgs e) => _Instancia = null;
        private void FormVentas_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            Clear();
            ReSize._get_initial_size();
        }
        #endregion
    }
}
