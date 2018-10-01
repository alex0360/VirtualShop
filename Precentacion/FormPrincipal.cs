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
    public partial class FormPrincipal : Form
    {
        private int childFormNumber = 0;

        public int? IdTrabajador;
        public string Apellido;
        public string Nombre;
        public string Acceso;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        #region Codigo Generado
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form {
                MdiParent = this,
                Text = "Ventana " + childFormNumber++
            };
            childForm.Show();
        }
        #region abrir y Guardar Files
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        #endregion
        #region Una Linia
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) => toolStrip.Visible = toolBarToolStripMenuItem.Checked;

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) => statusStrip.Visible = statusBarToolStripMenuItem.Checked;

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);
        #endregion
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion Codigo Generado

        #region Eventos
        private void FormPrincipal_Load(object sender, EventArgs e) => GestionUsuario();
        // Cerrar la Aplicacion
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e) => Comunes.Cerrar();
        private void SalirTSMI_Click(object sender, EventArgs e) => Comunes.Cerrar();
        // Open una Categoria
        private void CategoriasTSMI_Click(object sender, EventArgs e)
        {
            FormCategoria Form = new FormCategoria {
                MdiParent = this
                               
            };  Form.Show();
        }
        // Open una presentacion
        private void PresentacionTSMI_Click(object sender, EventArgs e)
        {
            FormPresentacion Form = new FormPresentacion {
                MdiParent = this
            };  Form.Show();
            
        }
        // Open un Articulo
        private void ArticulosTSMI_Click(object sender, EventArgs e)
        {
            FormArticulo Form = FormArticulo.GetInstacia();
            Form.MdiParent = this;
            Form.Show();
        }

        private void ProveedorTSMI_Click(object sender, EventArgs e)
        {
            FormProveedor Form = new FormProveedor {
                MdiParent = this
            };  Form.Show();
        }

        private void ClienteTSMI_Click(object sender, EventArgs e)
        {
            FormCliente Form = new FormCliente {
                MdiParent = this
            };  Form.Show();
        }

        private void TrabajadoresTSMI_Click(object sender, EventArgs e)
        {
            FormTrabajador Form = new FormTrabajador{
                MdiParent = this
            };  Form.Show();
        }
        private void IngresosTSMI_Click(object sender, EventArgs e)
        {
            FormIngreso Form = FormIngreso.GetInstancia();
            Form.MdiParent = this;
            Form.Show();
            Form.IdTrabajador = this.IdTrabajador;
        }
        private void VentasTSMI_Click(object sender, EventArgs e)
        {
            FormVenta Form = FormVenta.GetInstancia();
            Form.MdiParent = this;
            Form.Show();
            Form.IdTrabajador = IdTrabajador;
        }
        private void StockDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStockArticulo form = new FormStockArticulo();
            form.MdiParent = this;
            form.Show();
        }
        private void VentasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FormConsultaVentas form = new Consultas.FormConsultaVentas();
            form.MdiParent = this;
            form.Show();
        }
        private void ComprasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FormConsultaIngreso form = new Consultas.FormConsultaIngreso();
            form.MdiParent = this;
            form.Show();
        }
        #endregion
        #region Accesos
        private void GestionUsuario() {
            TSSLUsuario.Text = Nombre + " " + Apellido;
            if (Acceso == "Administrador")
                Administrador();
            else if (Acceso == "Vendedor")
                Vendedor();
            else if (Acceso == "Almacenista")
                Almacenista();
            else {
                TSMIAlmacen.Enabled = false;
                TSMICompras.Enabled = false;
                TSMIVentas.Enabled = false;
                TSMIMantenimiento.Enabled = false;
                TSMIConsultas.Enabled = false;
                TSMIHerramienta.Enabled = false;
                TSBCompras.Enabled = false;
                TSBVentas.Enabled = false;
            }
        }
        private void Administrador() {
            TSMIAlmacen.Enabled = true;
            TSMICompras.Enabled = true;
            TSMIVentas.Enabled = true;
            TSMIMantenimiento.Enabled = true;
            TSMIConsultas.Enabled = true;
            TSMIHerramienta.Enabled = true;
            TSBCompras.Enabled = true;
            TSBVentas.Enabled = true;
        }
        private void Vendedor() {
            TSMIAlmacen.Enabled = false;
            TSMICompras.Enabled = false;
            TSMIVentas.Enabled = true;
            TSMIMantenimiento.Enabled = false;
            TSMIConsultas.Enabled = true;
            TSMIHerramienta.Enabled = true;
            TSBCompras.Enabled = true;
            TSBVentas.Enabled = true;
        }
        private void Almacenista() {
            TSMIAlmacen.Enabled = true;
            TSMICompras.Enabled = true;
            TSMIVentas.Enabled = false;
            TSMIMantenimiento.Enabled = false;
            TSMIConsultas.Enabled = true;
            TSMIHerramienta.Enabled = true;
            TSBCompras.Enabled = true;
            TSBVentas.Enabled = false;
        }



        #endregion

       
    }
}
