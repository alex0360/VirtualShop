namespace Precentacion.Clases
{
    public class Comunes
    {
        /// <summary>
        /// Asigna La Fecha Actual del Sistema
        /// </summary>
        /// <param name="Label">La Etiqueta que a la que se decea Asignal</param>
        public void DiaHora(System.Windows.Forms.Label Label) => Label.Text = System.DateTime.Now.ToString();

        #region Apariencia
        /// <summary>
        /// Cambia el color de un Panel
        /// </summary>
        /// <param name="Panel">Panel afectado</param>
        /// <param name="Color">Color a cambiar</param>
        public void Color(System.Windows.Forms.Panel Panel, System.Drawing.Color Color) => Panel.BackColor = Color;
        #endregion

        #region Loggin
        /// <summary>
        /// Envia el Usuario y la Contraseña a la capa inferior
        /// </summary>
        /// <param name="Usuario">TextBox con el usuario</param>
        /// <param name="Password">TextBox con la Contaseña</param>
        /// <returns>Si hubo Considencia o no</returns>
        //
        // Contral de login
        public System.Boolean Acceso(System.Data.DataTable DataTable) {
            System.Boolean correto = false;
            if (DataTable.Rows.Count == 0)
                correto = false;
            if (DataTable.Rows.Count == 1)
                correto = true;
            return correto;
        }
        #endregion

        /// <summary>
        /// Cierra la Aplicacion
        /// </summary>
        public void Cerrar() {
            System.Windows.Forms.Application.Exit();
        }

        public void Now(System.Windows.Forms.DateTimePicker DateTimePicker)
        {
            DateTimePicker.Value = System.DateTime.Now;
        }
    }
}
