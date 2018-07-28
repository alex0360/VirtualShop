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
    public partial class FormArticulo : Form
    {
        private System.Int32? IdArticulo;
        private System.Int32? FkCategoria;

        public FormArticulo()
        {
            InitializeComponent();
            this.tooltMensaje.SetToolTip(tbNombre, "Ingrese un Nombre para la Articulo");
            this.tooltMensaje.SetToolTip(PBImagen, "Seleccion la Imagen del Articulo");
            this.tooltMensaje.SetToolTip(TBCategoria, "Seleccion la Categoria del Articulo");
            this.tooltMensaje.SetToolTip(CBPresentacion, "Seleccion la Presentacion del Articulo");

            this.TBCategoria.ReadOnly = true;
            LlenarCombPresentacion();
           
        }

        // Recoger los Datos
        private static FormArticulo _Instacia;
        /// <summary>
        /// Devuelve un Valor tipo Form Articulo
        /// </summary>
        /// <returns>Una Instacia de Form Articulo</returns>
        public static FormArticulo GetInstacia() {
            if(_Instacia == null)
            {
                _Instacia = new FormArticulo();
            }
            return _Instacia;
        }

        /// <summary>
        /// Octiene los datos para las Categoria
        /// </summary>
        /// <param name="idCategoria">id para tabla.Articulo.fkCategoria</param>
        /// <param name="nombre">nombre de la Categoria</param>
        public void SetCategoria(int idCategoria, string nombre)
        {
            this.FkCategoria = idCategoria;
            this.TBCategoria.Text = nombre;
        }

        // Mensaje de informacion       
        private void MensajeOK(string mensaje = "Operacion Correta") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Mensaje de Error
        private void MensajeError(string mensaje = "Falta ingresar algunos datos, seran remarcados") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // Limpiar los Controles
        private void Clear()
        {
            IdArticulo = null;
            this.TBCodigo.Text = string.Empty;
            this.tbNombre.Text = String.Empty;
            this.tbDescripcion.Text = String.Empty;
            this.PBImagen.Image = global::Precentacion.Properties.Resources.File;
            FkCategoria = null;
            this.TBCategoria.Text = string.Empty;
        }

        // Habilitar o desha Controles
        private void Habilitar(bool valor)
        {
            this.BSearchCategoria.Enabled = valor;
            this.CBPresentacion.Enabled = valor;
            this.BCargar.Enabled = valor;
            this.BLimpiar.Enabled = valor;
        }

        // Metodo llenar ComboBox
        private void LlenarCombPresentacion()
        {
            CBPresentacion.DataSource = Negocio.Presentacion.Mostar();
            CBPresentacion.ValueMember = "idPresentacion";
            CBPresentacion.DisplayMember = "nombre";
        }

        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            datagListado.Columns[0].Visible = false;
            datagListado.Columns[1].Visible = false;
            datagListado.Columns[6].Visible = false;
            datagListado.Columns[7].Visible = false;
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
            if (!IdArticulo.Equals(null))
                isNuevo = false;
        }

        // !Enabled Nuevo
        private System.Boolean isNuevo;
        private System.Boolean Nuevo()
        {
            if (IdArticulo.Equals(null))
            {
                isNuevo = true;
                tbNombre.Focus();
            }
            return isNuevo;
        }

        // Metodo Mostrar
        private void Mostrar()
        {
            datagListado.DataSource = Negocio.Articulo.Mostar();
            datagListado.AutoResizeColumns();
            OcultarColumns();
            RowsEliminar();
            labMostrarTotal.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }

        // Metodo Mostrar
        private void BuscarMostar()
        {
            datagListado.DataSource = Negocio.Articulo.BuscarMostar(this.tbBuscar.Text);
            OcultarColumns();
            RowsEliminar();
            labMostrarTotal.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }
        #region Eventos
        private void BCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                this.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PBImagen.Image = Image.FromFile(fileDialog.FileName);
            }
        }
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            this.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PBImagen.Image = global::Precentacion.Properties.Resources.File;
        }
        private void FormArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }
        private void ChbEliminar_CheckedChanged(object sender, EventArgs e) => RowsEliminar();
        private void ButEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente Desea Eliminar", "Sistema de Ventas", MessageBoxButtons.OKCancel);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string resultado = string.Empty;

                    foreach (DataGridViewRow row in datagListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultado = Negocio.Articulo.Eliminar(System.Convert.ToInt32(codigo));

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
        private void TbBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();
        private void ButGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;

                if (tbNombre.Text == string.Empty || FkCategoria == null || TBCodigo.Text==string.Empty)
                {
                    MensajeError("Falta ingresar un datos, seran ramarcados");
                    errorIcono.SetError(tbNombre, "Ingrese un Nombre");
                    errorIcono.SetError(TBCodigo, "Ingrese un Codigo");
                    errorIcono.SetError(TBCategoria, "Ingrese una Categoria");
                } else
                {
                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    this.PBImagen.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen = memoryStream.GetBuffer();

                    if (Nuevo())
                    {
                        respuesta = Negocio.Articulo.Insertar
                            (TBCodigo.Text.Trim().ToUpper(), 
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbNombre.Text.Trim().ToLower()), 
                            tbDescripcion.Text.Trim(),
                            imagen, System.Convert.ToInt32(FkCategoria), System.Convert.ToInt32(CBPresentacion.SelectedValue));
                            
                    } else
                    {
                        respuesta = Negocio.Articulo.Editar(System.Convert.ToInt32(IdArticulo),
                            TBCodigo.Text.Trim().ToUpper(),
                            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbNombre.Text.Trim().ToLower()),
                            tbDescripcion.Text.Trim(),
                            imagen, System.Convert.ToInt32(FkCategoria), System.Convert.ToInt32(CBPresentacion.SelectedValue));
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
        private void ButCancelar_Click(object sender, EventArgs e) => Clear();
        private void DatagListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datagListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell cbEliminar = (DataGridViewCheckBoxCell)datagListado.Rows[e.RowIndex].Cells["Eliminar"];
                cbEliminar.Value = !Convert.ToBoolean(cbEliminar.Value);
            }

        }
        private void DatagListado_DoubleClick(object sender, EventArgs e)
        {
            IdArticulo = Convert.ToInt32(datagListado.CurrentRow.Cells["idArticulo"].Value);
            TBCodigo.Text = Convert.ToString(datagListado.CurrentRow.Cells["codigo"].Value);
            tbNombre.Text = Convert.ToString(datagListado.CurrentRow.Cells["nombre"].Value);
            tbDescripcion.Text = Convert.ToString(datagListado.CurrentRow.Cells["descripcion"].Value);

            byte[] imagenBuffer = (byte[])this.datagListado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imagenBuffer);

            this.PBImagen.Image = Image.FromStream(memoryStream);
            this.PBImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            FkCategoria = Convert.ToInt32(datagListado.CurrentRow.Cells["idCategoria"].Value);
            TBCategoria.Text = Convert.ToString(datagListado.CurrentRow.Cells["categoria"].Value);
            this.CBPresentacion.SelectedValue = Convert.ToInt32(datagListado.CurrentRow.Cells["idPresentacion"].Value);


            tabCon.SelectedIndex = 1;
            Editar();
        }
        private void BSearchCategoria_Click(object sender, EventArgs e)
        {
            FormVistaCategoria_Articulo formVista = new FormVistaCategoria_Articulo();
            formVista.ShowDialog();
        }
        #endregion
    }
}
