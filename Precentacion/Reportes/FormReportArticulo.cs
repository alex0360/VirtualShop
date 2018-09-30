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
    public partial class FormReportArticulo : Clases.FormReportes
    {
        public FormReportArticulo()
        {
            InitializeComponent();
        }

        private void FormReportArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.SpMostrar_Articulo' Puede moverla o quitarla según sea necesario.
                this.SpMostrar_ArticuloTableAdapter.Fill(this.DataSetPrincipal.SpMostrar_Articulo);
            }
            catch { }
            finally {
                this.RWReportes.RefreshReport();
            }
        }
    }
}
