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
    public partial class FormVistaProveedor : Clases.FormVistas
    {
        public FormVistaProveedor()
        {
            InitializeComponent();
        }
       
        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            datagListado.Columns[0].Visible = false;
            datagListado.Columns[1].Visible = false;
        }
        //Metodo Mostrar
        private void Mostrar()
        {
            datagListado.DataSource = Negocio.Proveedor.Mostar();
            datagListado.AutoResizeColumns();
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }

        private void BuscarMostar()
        {
            datagListado.DataSource = Negocio.Proveedor.BuscarMostar(TBBuscar.Text);
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }
        private void FormVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }
        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMostar();
        }
        private void DatagListado_DoubleClick(object sender, EventArgs e)
        {
            FormIngreso form = FormIngreso.GetIngreso();
            form.SetArticulo(Convert.ToInt32(datagListado.CurrentRow.Cells["idProveedor"].Value), Convert.ToString(datagListado.CurrentRow.Cells["nombre"].Value));
            Hide();
        }

        private void FormVistaProveedor_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
