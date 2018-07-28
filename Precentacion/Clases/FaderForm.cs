using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion.Clases
{
    public partial class FaderForm : Form
    {
        public FaderForm()
        {
            InitializeComponent();
        }

        // Mensaje de informacion       
        protected virtual void MensajeOK(string mensaje = "Operacion Correta") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // Mensaje de Error
        protected virtual void MensajeError(string mensaje = "Falta ingresar algunos datos, seran remarcados") => MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // CheckBox MostrarRowsEliminar
       protected virtual void RowsEliminar()
        {
            if (CBEliminar.Checked)
                DGVListado.Columns[0].Visible = true;
            else
                DGVListado.Columns[0].Visible = false;
        }

    }
}
