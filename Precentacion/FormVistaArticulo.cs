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
    public partial class FormVistaArticulo : Clases.FormVistas
    {
        public FormVistaArticulo()
        {
            _ReSize();
            InitializeComponent();
        }
        
        // Metodo para Ocultar Columns
        private void OcultarColumns()
        {
            new Negocio.Articulo().AdjustColumn(datagListado);
            datagListado.Columns[0].Visible = false;
            datagListado.Columns[1].Visible = false;
        }
        //Metodo Mostrar
        private void Mostrar()
        {
            datagListado.DataSource = Negocio.Articulo.Mostrar();
            datagListado.AutoResizeColumns();
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }
        private void BuscarMostar()
        {
            datagListado.DataSource = Negocio.Articulo.BuscarMostar(TBBuscar.Text);
            OcultarColumns();
            LMostratCantidad.Text = "Total de Regristros: " + Convert.ToString(datagListado.Rows.Count);
        }
        private void TbBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();
        private void DatagListado_DoubleClick(object sender, EventArgs e)
        {
            FormIngreso form = FormIngreso.GetIngreso();

            var Parm1 = Convert.ToInt32(datagListado.CurrentRow.Cells["idArticulo"].Value);
            var Parm2 = Convert.ToString(datagListado.CurrentRow.Cells["nombre"].Value);

            form.SetArticulo(idArticulo: Parm1, nombre: Parm2);
            Hide();
        }
        private void FormVistaArticulo_Load(object sender, EventArgs e)
        {
            Mostrar();
            ReSize._get_initial_size();
        }
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormVistaArticulo_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
    }
}
