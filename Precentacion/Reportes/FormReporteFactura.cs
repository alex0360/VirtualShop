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
    public partial class FormReporteFactura : Form
    {
        private int _IdVenta;
        public int IdVenta { get { return _IdVenta; } set { _IdVenta = value; } }
        public FormReporteFactura()
        {
            InitializeComponent();
        }

        private void FormReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                this.SpReporte_FacturaTableAdapter.Fill(this.DataSetPrincipal.SpReporte_Factura, IdVenta);

            }
            catch { }
            finally { this.reportViewer1.RefreshReport(); }
        }
    }
}
