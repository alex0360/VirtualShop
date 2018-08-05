using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Read
    {
        /// <summary>
        /// Carga una Lista desde un Archivo a un ComboBox
        /// </summary>
        /// <param name="ComboBox">Nombre de ComboBox</param>
        /// <param name="File">Ruta/nombre.extencion del Archivo</param>
        public Read(System.Windows.Forms.ComboBox ComboBox, String File)
        {
            try
            {
                ComboBox.Items.Clear();
                using (System.IO.StreamReader SR = new System.IO.StreamReader(File))
                {
                    while (SR.Peek() >= 0)
                    {
                        ComboBox.Items.Add(SR.ReadLine());
                    }
                }
            } catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.Message); }
        }
    }
}
