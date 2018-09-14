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
    public partial class FormVistaCategoria : Form
    {
        public FormVistaCategoria()
        {
            InitializeComponent();
        }
        private static bool _Instacia;
        /// <summary>
        /// Para saber si fue instaciada por VistaCategoria
        /// </summary>
        public static bool GetInstacia {
            get { return _Instacia; }
            set { _Instacia = value; }
        }
        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            datagListado.Columns[0].Visible = false;
            datagListado.Columns[1].Visible = false;
        }
        // Metodo Mostrar
        private void Mostrar()
        {
            datagListado.DataSource = Negocio.Categoria.Mostar();
            datagListado.AutoResizeColumns();
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }
        // Metodo Mostrar
        private void BuscarMostar()
        {
            datagListado.DataSource = Negocio.Categoria.BuscarMostar(this.TBBuscar.Text);
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
            FormArticulo form = FormArticulo.GetInstacia();

            var par1 = Convert.ToInt32(this.datagListado.CurrentRow.Cells["idCategoria"].Value);
            var par2 = Convert.ToString(this.datagListado.CurrentRow.Cells["nombre"].Value);

            form.SetCategoria(par1, par2);
            this.Hide();
            //FormIngreso form = FormIngreso.GetIngreso();
            //form.SetArticulo(Convert.ToInt32(datagListado.CurrentRow.Cells["idArticulo"].Value),Convert.ToString(datagListado.CurrentRow.Cells["nombre"].Value));
            //Hide();
        }

        private void FormVistaCategoria_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
