using System;

namespace Precentacion
{
    public partial class FormVistaProveedor : Clases.FormVistas
    {
        public FormVistaProveedor()
        {
            InitializeComponent();
            _ReSize();
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
            datagListado.DataSource = Negocio.Proveedor.Mostrar();
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
        private void TbBuscar_TextChanged(object sender, EventArgs e) => BuscarMostar();
        private void DatagListado_DoubleClick(object sender, EventArgs e)
        {
            FormIngreso form = FormIngreso.GetInstancia();

            var Parm1 = Convert.ToInt32(datagListado.CurrentRow.Cells["idProveedor"].Value);
            var Parm2 = Convert.ToString(datagListado.CurrentRow.Cells["razon_social"].Value);

            form.SetProveedor(idProveedor: Parm1, razon_social: Parm2);
            Hide();
        }

        private void FormVistaProveedor_Load(object sender, EventArgs e)
        {
            Mostrar();
            ReSize._get_initial_size();
        }
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += FormVistaProveedor_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
    }
}
