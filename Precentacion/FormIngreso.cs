using System;
using System.Data;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormIngreso : Clases.FaderForm
    {
        //Variables
        //
        public int? IdTrabajador;
        private DataTable DtDetalles;
        private decimal totalPagado = 0; 
        private static FormIngreso _Instancia;
        private int?  IdIngreso,IdProveedor, IdArticulo;
        //Fin de las Variables
        //
        #region Metodos
        public FormIngreso()
        {
            InitializeComponent();
            _ReSize();
            base.TTMensaje.SetToolTip(this.TBProveedor, "Seleccione el Proveedor");
            base.TTMensaje.SetToolTip(this.TBSerie, "Ingrese la Serie");
            base.TTMensaje.SetToolTip(this.TBCorrelativo, "Ingrese el número del comprobante");
            base.TTMensaje.SetToolTip(this.TBStock, "Ingrese la cantidad en Stock");
            base.TTMensaje.SetToolTip(this.TBArticulo, "Seleccione el Articulo de compra");
            TBArticulo.ReadOnly = true;
            TBProveedor.ReadOnly = true;
            CargarComboBox();
            ComboBoxSOLOLectura();
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
        public void SetProveedor(int idProveedor, string razon_social) {
            IdProveedor = idProveedor;
            TBProveedor.Text = razon_social;
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
        protected override void MensajeOK(string mensaje = "Operacion Correta") => 
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Mensaje de Error
         protected override void MensajeError(string mensaje = "Falta ingresar algunos datos, seran remarcados") => 
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (IdIngreso.Equals(null))
            {
                isNuevo = true;
            }
            return isNuevo;
        }

        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Ingreso.Mostrar();
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
            OcultarColumns();
        }
        // Crear La tabla
        private void CrearTabla() {
            DtDetalles = new DataTable("Detalle");
            DtDetalles.Columns.Add("idArticulo", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("Articulo", Type.GetType("System.String"));
            DtDetalles.Columns.Add("precio_compra", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("precio_venta", Type.GetType("System.Decimal"));
            DtDetalles.Columns.Add("stock_inicial", Type.GetType("System.Int32"));
            DtDetalles.Columns.Add("fecha_produccion", Type.GetType("System.DateTime"));
            DtDetalles.Columns.Add("fecha_vencimiento", Type.GetType("System.DateTime"));
            DtDetalles.Columns.Add("SubTotal", Type.GetType("System.Decimal"));
            // Relacionamos nuestro DataGridView con nuesta DataTable
            DGVListados_detalles.DataSource = DtDetalles;
        }
        private void CargarComboBox()
        {
            new Negocio.Read(CBComprobante, "LCom.vshop");
        }
        // Solo Lectura Combobox
        private void ComboBoxSOLOLectura()
        {
            new Negocio.Read(CBComprobante);
        }
        #endregion
        #region Eventos
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
        private void BBuscar_fecha_Click(object sender, EventArgs e) => BuscarMostar();
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
        private void DGVListado_DoubleClick(object sender, EventArgs e)
        {
            IdIngreso = Convert.ToInt32(DGVListado.CurrentRow.Cells["idIngreso"].Value);
            TBProveedor.Text = Convert.ToString(DGVListado.CurrentRow.Cells["Proveedor"].Value);
            DTPFecha.Value = Convert.ToDateTime(DGVListado.CurrentRow.Cells["fecha"].Value);
            CBComprobante.Text = Convert.ToString(DGVListado.CurrentRow.Cells["tipo_comprobante"].Value);
            TBSerie.Text = Convert.ToString(DGVListado.CurrentRow.Cells["serie"].Value);
            TBCorrelativo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["correlativo"].Value);
            LTotal_Pagado.Text = Convert.ToString(DGVListado.CurrentRow.Cells["total"].Value);
            MostrarDetalles();
            tabCon.SelectedIndex = 1;
        }
        private void CBEliminar_CheckedChanged(object sender, EventArgs e) =>RowsEliminar();
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (CBComprobante.Text == string.Empty || TBSerie.Text == string.Empty ||
                    TBCorrelativo.Text == string.Empty || IdProveedor == null)
                {
                    MensajeError();
                    if (CBComprobante.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(CBComprobante, "Selecciona un comprobante");
                    if (TBSerie.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBSerie, "Ingrese un numero de serie");
                    if (TBCorrelativo.Text == string.Empty)
                        EPErrorIcono.SetError(TBCorrelativo, "Escriba un Correlativo");
                    if (TBProveedor.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBProveedor, "Seleccione un Proveedor");
                } else
                {
                    if (Nuevo())
                    {
                        respuesta = Negocio.Ingreso.Insertar(Convert.ToInt32(IdTrabajador), Convert.ToInt32(IdProveedor), DTPFecha.Value,
                            CBComprobante.Text, TBSerie.Text, TBCorrelativo.Text, Convert.ToDecimal(TBIgv.Text),"EMITIDO",DtDetalles);
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
                MessageBox.Show(ex.Message + ex.StackTrace, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Clear();ClearDetalle();
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdArticulo == null || TBPrecio_venta.Text == string.Empty ||
                    TBPrecio_compra.Text == string.Empty || TBStock.Text == string.Empty)
                {
                    MensajeError();
                    if (TBArticulo.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBArticulo, "Seleccion un Articulo");
                    if (TBPrecio_compra.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBPrecio_compra, "Ingrese un Precio de Compra");
                    if (TBPrecio_venta.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBPrecio_venta, "Ingrese un Precio de Venta");
                    if (TBStock.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBStock, "Ingrese un Stock Inicial");
                } else
                {
                    bool registrar = true;
                    foreach (DataRow row in DtDetalles.Rows)
                    {
                        if (Convert.ToInt32(row["idArticulo"]) == IdArticulo)
                        {
                            registrar = false;
                            MensajeError("Ya se Encuentra el Articulo en el Detalle");
                        }
                    }
                    if (registrar) {
                        decimal subTotal = Convert.ToDecimal(TBStock.Text) * Convert.ToDecimal(TBPrecio_compra.Text);
                        totalPagado = totalPagado + subTotal;
                        LTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                        //Agragar ese detalle al datalistadodetalles
                        DataRow row = DtDetalles.NewRow();
                        row["idArticulo"] = IdArticulo;
                        row["Articulo"] = TBArticulo.Text;
                        row["precio_compra"] = Convert.ToDecimal(TBPrecio_compra.Text);
                        row["precio_venta"] = Convert.ToDecimal(TBPrecio_venta.Text);
                        row["stock_inicial"] = Convert.ToInt32(TBStock.Text);
                        row["fecha_produccion"] = DTPFecha_Produccion.Value;
                        row["fecha_vencimiento"] = DTPFecha_Vencimiento.Value;
                        row["SubTotal"] = subTotal;
                        DtDetalles.Rows.Add(row);
                        DGVListados_detalles.Columns[0].Visible = false;
                        ClearDetalle();

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
            } catch {
                MensajeError("No hay fila para remaver");
            }
        }
        private void FormIngreso_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            Clear();
            ReSize._get_initial_size();
        }
        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e) => _Instancia = null;
        #endregion
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormIngreso_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
    }
}
