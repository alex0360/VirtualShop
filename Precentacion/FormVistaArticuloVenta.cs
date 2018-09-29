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
    public partial class FormVistaArticuloVenta : Clases.FormVistas
    {
        public FormVistaArticuloVenta()
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
        //Metodo Mostra

        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Venta.MostrarArticulo_Venta_Codigo(TBBuscar.Text);
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        private void TbBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();

        private void FormVistaArticuloVenta_Load(object sender, EventArgs e)
        {
            ReSize._get_initial_size();
        }
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormVistaArticuloVenta_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion

        private void DGVListado_DoubleClick(object sender, EventArgs e)
        {
            FormVenta form = FormVenta.GetInstancia();

            var Parm1 = Convert.ToInt32(DGVListado.CurrentRow.Cells["idDetalle_ingreso"].Value);
            var Parm2 = Convert.ToString(DGVListado.CurrentRow.Cells["nombre"].Value);
            var Parm3 = Convert.ToDecimal(DGVListado.CurrentRow.Cells["precio_compra"].Value);
            var Parm4 = Convert.ToDecimal(DGVListado.CurrentRow.Cells["precio_venta"].Value);
            var Parm5 = Convert.ToInt32(DGVListado.CurrentRow.Cells["stock_actual"].Value);
            var Parm6 = Convert.ToDateTime(DGVListado.CurrentRow.Cells["fecha_vencimiento"].Value);
            form.SetArticulo(idArtuculo:Parm1, nombre:Parm2, precio_compra:Parm3, 
                precio_venta:Parm4, stock:Parm5, fecha_vencimiento:Parm6);
            this.Hide();
        }
    }
}