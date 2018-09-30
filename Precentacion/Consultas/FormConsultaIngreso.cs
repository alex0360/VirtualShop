using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion.Consultas
{
    public partial class FormConsultaIngreso : Clases.FormConsulta
    {
        public FormConsultaIngreso()
        {
            InitializeComponent();
            _ReSize();
        }
        // Metodo para Ocultar Columns
        private void OcultarColumns() => DGVListado.Columns[0].Visible = false;
        // Metodo Mostrar
        private void CargarFechaActual()
        {
            new Clases.Comunes().Now(DTPFecha_inicio);
            new Clases.Comunes().Now(DTPFecha_Final);
        }
        private void Mostrar()
        {
            DGVListado.DataSource = Negocio.Ingreso.Mostrar();
            DGVListado.AutoResizeColumns();
            OcultarColumns();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
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
        private void _Load(object sender, EventArgs e)
        {
            Mostrar();
            CargarFechaActual();
            ReSize._get_initial_size();
        }
        #endregion
        // Mostrar Por Los DateTime
        private void BuscarMostar()
        {
            DGVListado.DataSource = Negocio.Ingreso.BuscarMostar(DTPFecha_inicio.Value.ToString("dd/MM/yyyy"), DTPFecha_Final.Value.ToString("dd/MM/yyyy"));
            OcultarColumns();
            LTotalRegistro.Text = "Total de Regristros: " + Convert.ToString(DGVListado.Rows.Count);
        }
        private void BBuscar_fecha_Click(object sender, EventArgs e) => BuscarMostar();

        private void BActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
            CargarFechaActual();
        }
    }
}
