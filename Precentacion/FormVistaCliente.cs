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
    public partial class FormVistaCliente : Clases.FormVistas
    {
        public FormVistaCliente()
        {
            InitializeComponent();
            _ReSize();
        }

        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Visible = false;
        }
        //Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Cliente.Mostrar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }

        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Cliente.Buscar_Cliente(TBBuscar.Text);
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        private void TbBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();

        private void FormVistaCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
            ReSize._get_initial_size();
        }
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormVistaCliente_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion

        private void DGVListado_DoubleClick(object sender, EventArgs e)
        {
            FormVenta form = FormVenta.GetInstancia();

            var Parm1 = Convert.ToInt32(DGVListado.CurrentRow.Cells["idCliente"].Value);
            var Parm2 = Convert.ToString(DGVListado.CurrentRow.Cells["apellidos"].Value) +" "+ Convert.ToString(DGVListado.CurrentRow.Cells["nombre"].Value);

            form.SetCliente(Parm1, Parm2);
            this.Hide();
        }
    }
}
