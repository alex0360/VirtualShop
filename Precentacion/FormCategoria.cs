using System;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class FormCategoria : Form
    {
        private System.Int32? IdCategoria;

        public FormCategoria()
        {
            InitializeComponent();
            this.tooltMensaje.SetToolTip(this.tbNombre, "Ingrese un Nombre para la Categoria");
        }
        
        // Mensaje de informacion       
        private void MensajeOK(string mensaje="Operacion Correta")
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        // Mensaje de Error
        private void MensajeError(string mensaje="Falta ingresar algunos datos, seran remarcados")
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        // Limpiar los Controles
        private void Clear()
        {
            IdCategoria = null;
            this.tbNombre.Text = String.Empty;
            this.tbDescripcion.Text = String.Empty;
        }
        
        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            datagListado.Columns[0].Visible = false;
            datagListado.Columns[1].Visible = false;
        }

        // CheckBox MostrarRowsEliminar
        private void RowsEliminar()
        {
            if (chbEliminar.Checked)
                datagListado.Columns[0].Visible = true;
            else
                datagListado.Columns[0].Visible = false;
        }

        // !Enabled Editar
        private void Editar()
        {
            if (!IdCategoria.Equals(null))
            
                isNuevo = false;
        }

        // !Enabled Nuevo
        private System.Boolean isNuevo;
        private System.Boolean Nuevo()
        {
            if (IdCategoria.Equals(null))
            {
                isNuevo = true;
                tbNombre.Focus();
            }
            return isNuevo;   
        }

        // Metodo Mostrar
        private void Mostrar()
        {
            datagListado.DataSource = Negocio.Categoria.Mostar();
            datagListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            labMostrarTotal.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }

        // Metodo Mostrar
        private void BuscarMostar()
        {
            datagListado.DataSource = Negocio.Categoria.BuscarMostar(this.tbBuscar.Text);
            OcultarColumns();
            RowsEliminar();
            labMostrarTotal.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }

        #region Eventos del Formulario
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Clear();
            Mostrar();

        }

        private void ButBuscar_Click(object sender, EventArgs e)
        {
            BuscarMostar();
        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMostar();
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (tbNombre.Text == string.Empty)
                {
                    MensajeError();
                    errorIcono.SetError(tbNombre, "Ingrese un Nombre");
                } else
                {
                    if (Nuevo())
                    {
                        respuesta = Negocio.Categoria.Insertar
                            (System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbNombre.Text.Trim().ToLower()), tbDescripcion.Text.Trim());
                    } else
                    {
                        respuesta = Negocio.Categoria.Editar(System.Convert.ToInt32(IdCategoria),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbNombre.Text.Trim().ToLower()), 
                            tbDescripcion.Text.Trim());
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

            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace,"Excepcion",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButCancelar_Click(object sender, EventArgs e) => Clear();

        private void ChbEliminar_CheckedChanged(object sender, EventArgs e)=> RowsEliminar();

        // DataGridView
        private void DatagListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell cbEliminar = (DataGridViewCheckBoxCell)datagListado.Rows[e.RowIndex].Cells["Eliminar"];
                cbEliminar.Value =!Convert.ToBoolean(cbEliminar.Value);
            }
        }
        private void DatagListado_DoubleClick(object sender, EventArgs e)
        {
            IdCategoria = Convert.ToInt32(datagListado.CurrentRow.Cells["idCategoria"].Value);
            tbNombre.Text = Convert.ToString(datagListado.CurrentRow.Cells["nombre"].Value);
            tbDescripcion.Text = Convert.ToString(datagListado.CurrentRow.Cells["descripcion"].Value);

            tabConCategoria.SelectedIndex = 1;
            Editar();
        }

        private void ButEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente Desea Eliminar", "Sistema de Ventas", MessageBoxButtons.OKCancel);

                if(opcion == DialogResult.OK)
                {
                    string codigo;
                    string resultado = string.Empty;

                    foreach(DataGridViewRow row in datagListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultado = Negocio.Categoria.Eliminar(System.Convert.ToInt32(codigo));

                            if (resultado.Equals("Ok"))
                                MensajeOK("Se elimino Correctamente el registro");
                            else
                                MensajeError(resultado);
                        }
                    }
                    Mostrar();
                }
            } catch (Exception ex){
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
    }
}
