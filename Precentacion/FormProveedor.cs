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
    public partial class FormProveedor : Clases.FaderForm
    {
        private System.Int32? IdProveedor;

        public FormProveedor()
        {
            InitializeComponent();
            //this.TTMensaje.SetToolTip(TBNombre, "Ingrese un Nombre para la Articulo");
        }
       
        // Limpiar los Controles
        private void Clear()
        {
            IdProveedor = null;
            TBRazon.Text = null;
            CBSector_comercial.Text = null;
            CBTipo_documento.Text = null;
            TBNum_documento.Text = null;
            TBDireccion.Text = null;
            TBTelefono.Text = null;
            TBEmail.Text = null;
            TBUrl.Text = null;
            CargarSector_comercial();
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
            if (!IdProveedor.Equals(null))

                isNuevo = valor;
        }
        // !Enabled Nuevo
        private System.Boolean isNuevo;
        private System.Boolean Nuevo()
        {
            if (IdProveedor.Equals(null))
            {
                isNuevo = true;
                //TBNombre.Focus();
            }
            return isNuevo;
        }
        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Proveedor.Mostar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Metodo Mostrar
        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Proveedor.BuscarMostar(this.TBBuscar.Text);
            OcultarColumns();
            RowsEliminar();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        // Cargar ComboBox
        private void CargarSector_comercial()
        {
            try {
                CBSector_comercial.Items.Clear();
                using (System.IO.StreamReader SR = new System.IO.StreamReader("sector_comercial.sc"))
                {
                    while (SR.Peek() >= 0)
                    {
                        CBSector_comercial.Items.Add(SR.ReadLine());
                    }
                }
            } catch(Exception e) { MessageBox.Show(e.Message); }
        }
        #region Eventos
        private void FormProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Clear();
            Mostrar();
        }
        private void TBBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();
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
                            resultado = Negocio.Proveedor.Eliminar(System.Convert.ToInt32(codigo));

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
            IdProveedor = Convert.ToInt32(DGVListado.CurrentRow.Cells["idProveedor"].Value);
            TBRazon.Text = Convert.ToString(DGVListado.CurrentRow.Cells["razon_social"].Value);
            CBSector_comercial.Text = Convert.ToString(DGVListado.CurrentRow.Cells["sector_comercial"].Value);
            CBTipo_documento.Text = Convert.ToString(DGVListado.CurrentRow.Cells["tipo_documento"].Value);
            TBNum_documento.Text = Convert.ToString(DGVListado.CurrentRow.Cells["num_documento"].Value);
            TBDireccion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["direccion"].Value);
            TBTelefono.Text = Convert.ToString(DGVListado.CurrentRow.Cells["telefono"].Value);
            TBEmail.Text = Convert.ToString(DGVListado.CurrentRow.Cells["email"].Value);
            TBUrl.Text = Convert.ToString(DGVListado.CurrentRow.Cells["url_web"].Value);
            tabCon.SelectedIndex = 1;
            
            Editar();
        }
        private void BGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (TBRazon.Text == string.Empty || TBNum_documento.Text == string.Empty)
                {
                    MensajeError();
                    if(TBRazon.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBRazon, "Ingrese un Razon Social");
                    if (TBNum_documento.Text.Equals(string.Empty))
                        EPErrorIcono.SetError(TBNum_documento, "Ingrese un Numero de Documento");
                    

                } else
                {
                    if (Nuevo())
                    {
                        respuesta = Negocio.Proveedor.Insertar
                            (System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBRazon.Text.Trim().ToLower()),
                            CBSector_comercial.Text, CBTipo_documento.Text,
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNum_documento.Text.Trim().ToLower()),
                            TBDireccion.Text.Trim(), TBTelefono.Text.Trim(), TBEmail.Text.Trim().ToLower(),TBUrl.Text.Trim());
                    } else
                    {
                        respuesta = Negocio.Proveedor.Editar(System.Convert.ToInt32(IdProveedor),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBRazon.Text.Trim().ToLower()),
                            CBSector_comercial.Text, CBTipo_documento.Text,
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNum_documento.Text.Trim().ToLower()),
                            TBDireccion.Text.Trim(), TBTelefono.Text.Trim(), TBEmail.Text.Trim().ToLower(), TBUrl.Text.Trim());
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
        private void BCancelar_Click(object sender, EventArgs e) => Clear();
        #endregion

    }
}