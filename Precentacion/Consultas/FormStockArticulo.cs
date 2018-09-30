using System;
namespace Precentacion
{
    public partial class FormStockArticulo : Clases.FormConsulta
    {
        public FormStockArticulo()
        {
            InitializeComponent();
            _ReSize();
        }
        // Metodo para Ocultar Columns
        private void OcultarColumns() => DGVListado.Columns[0].Visible = false;
        // Metodo Mostrar
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Articulo.StockArticulo();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            labMostrarTotal.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        #region ReSize
        private Clases.ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new Clases.ReSize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        private void _Load(object sender, EventArgs e) {
            Mostrar();
            ReSize._get_initial_size();
        }
        #endregion

    }
}