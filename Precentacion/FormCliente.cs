using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormCliente : Precentacion.Clases.FaderForm
    {
        private System.Int32? IdCliente;
        public FormCliente()
        {
            InitializeComponent();
            _ReSize();
            this.TTMensaje.SetToolTip(TBNombre, "Ingrese un nombre para cliente");
            this.TTMensaje.SetToolTip(TBApellidos, "Ingrese un apellido para cliente");
            this.TTMensaje.SetToolTip(CBTipo_documento, "Selecione el tipo de documento");
            this.TTMensaje.SetToolTip(TBNum_documento, "Ingrese el numero del documento");

        }

        // Limpiar los Controles
        private void Clear()
        {
            IdCliente = null;
            TBNombre.Text = null;
            TBApellidos.Text = null;
            CBSexo.SelectedItem = null;
            DTPFecha_nacimiento.ResetText();
            CBTipo_documento.Text = null;
            TBNum_documento.Text = null;
            TBDireccion.Text = null;
            TBTelefono.Text = null;
            TBEmail.Text = null;
            CargarComboBox();
            ComboBoxSOLOLectura();
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
        // !Enabled Editar
        private void Editar(bool valor = false)
        {
            if (!IdCliente.Equals(null))

                isNuevo = valor;
        }
        // !Enabled Nuevo
        private System.Boolean isNuevo;
        private System.Boolean Nuevo()
        {
            if (IdCliente.Equals(null))
            {
                isNuevo = true;
                //TBNombre.Focus();
            }
            return isNuevo;
        }
        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Cliente.Mostrar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Metodo Mostrar
        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Cliente.Buscar_Cliente(this.TBBuscar.Text);
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Cargar ComboBox
        private void CargarComboBox()
        {
            new Negocio.Read(CBTipo_documento, "TDocs.vshop");
        }
        // Solo Lectura Combobox
        private void ComboBoxSOLOLectura() {
            new Negocio.Read(CBSexo);
            new Negocio.Read(CBTipo_documento);
        }
        #region Eventos
        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Clear();
            Mostrar();
            ReSize._get_initial_size();
        }
        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMostar();
        }
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
                            resultado = Negocio.Cliente.Eliminar(System.Convert.ToInt32(codigo));

                            if (resultado.Equals("Ok"))
                                MensajeOK("Se elimino Correctamente el registro");
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
        private void CBEliminar_CheckedChanged(object sender, EventArgs e) => RowsEliminar();
        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell cbEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["Eliminar"];
                cbEliminar.Value = !Convert.ToBoolean(cbEliminar.Value);
            }
        }
        private void DGVListado_DoubleClick(object sender, EventArgs e)
        {
            IdCliente = Convert.ToInt32(DGVListado.CurrentRow.Cells["idCliente"].Value);
            TBNombre.Text = Convert.ToString(DGVListado.CurrentRow.Cells["nombre"].Value);
            TBApellidos.Text = Convert.ToString(DGVListado.CurrentRow.Cells["apellidos"].Value);
            CBSexo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["sexo"].Value);
            DTPFecha_nacimiento.Value = Convert.ToDateTime(DGVListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            CBTipo_documento.Text = Convert.ToString(DGVListado.CurrentRow.Cells["tipo_documento"].Value);
            TBNum_documento.Text = Convert.ToString(DGVListado.CurrentRow.Cells["num_documento"].Value);
            TBDireccion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["direccion"].Value);
            TBTelefono.Text = Convert.ToString(DGVListado.CurrentRow.Cells["telefono"].Value);
            TBEmail.Text = Convert.ToString(DGVListado.CurrentRow.Cells["email"].Value);
            tabCon.SelectedIndex = 1;

            Editar();
        }
        private void BCancelar_Click(object sender, EventArgs e) => Clear();
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (TBNombre.Text == string.Empty ||TBApellidos.Text == string.Empty || CBTipo_documento.SelectedItem == null || TBNum_documento.Text == string.Empty)
                {
                    MensajeError();
                    if (TBNombre.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBNombre, "Ingrese un nombre");
                    if (TBApellidos.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBApellidos, "Ingrese un apellido");
                    if (CBTipo_documento.SelectedItem == null)
                        EPErrorIcono.SetError(CBTipo_documento, "Seleccione un tipo de documento");
                    if (TBNum_documento.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBNum_documento, "Ingrese un Numero de Documento");
                } else
                {
                    if (Nuevo())
                    {
                        respuesta = Negocio.Cliente.Insertar
                            (System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text.Trim().ToLower()),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellidos.Text.Trim().ToLower()),
                            CBSexo.Text,DTPFecha_nacimiento.Value,CBTipo_documento.Text,TBNum_documento.Text.Trim(),
                            TBDireccion.Text.Trim(), TBTelefono.Text.Trim(), TBEmail.Text.Trim().ToLower());
                    } else
                    {
                        respuesta = Negocio.Cliente.Editar(System.Convert.ToInt32(IdCliente),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text.Trim().ToLower()),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellidos.Text.Trim().ToLower()),
                            CBSexo.Text, DTPFecha_nacimiento.Value, CBTipo_documento.Text, TBNum_documento.Text.Trim(),
                            TBDireccion.Text.Trim(), TBTelefono.Text.Trim(), TBEmail.Text.Trim().ToLower());
                    }
                    if (respuesta.Equals("Ok"))
                    {
                        if (isNuevo)
                            MensajeOK("Se Inserto de forma Correcta el registro");
                        else
                            MensajeOK("Se Actualizo de forma Correcta el registro");
                    } else MensajeError(respuesta);
                    Clear();
                    Mostrar();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormCliente_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
    }
}
