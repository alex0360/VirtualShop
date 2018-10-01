namespace Negocio
{
    /// <summary>
    /// Lectura
    /// </summary>
    public class Read
    {
        /// <summary>
        /// Carga una Lista desde un Archivo a un ComboBox
        /// </summary>
        /// <param name="ComboBox">Nombre de ComboBox</param>
        /// <param name="File">Ruta/nombre.extencion del Archivo</param>
        public Read(System.Windows.Forms.ComboBox ComboBox, System.String File)
        {
            try{
                ComboBox.Items.Clear();
                using (System.IO.StreamReader SR = new System.IO.StreamReader(File))
                {
                    while (SR.Peek() >= 0)
                    {
                        ComboBox.Items.Add(SR.ReadLine());
                    }
                }
            } catch{ }
        }
        /// <summary>
        /// Converte un ComboBox en un Control de solo Lectura
        /// </summary>
        /// <param name="ComboBox">Nombre de ComboBox</param>
        public Read(System.Windows.Forms.ComboBox ComboBox) => 
            ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    }
}