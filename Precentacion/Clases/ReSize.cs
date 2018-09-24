using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Precentacion.Clases
{
    class ReSize
    {
        #region Primer Bloque
        // Esta es una declaración privada dentro de la clase, 
        //no se ha incluido ninguna otra definición estática para fines de seguridad
        List<Rectangle> _arr_control_storage = 
            new List<Rectangle>();
        private bool ShowRowHeader = false;
        public ReSize(Form _form_)
        {
            Form = _form_; // El Formulario de Llamada
            _formSize = _form_.ClientSize; // Guarde el tamaño del formulario inicial
            _fontsize = _form_.Font.Size; // Tamaño de fuente
        }
        private float _fontsize { get; set; }
        private SizeF _formSize { get; set; }
        private Form Form { get; set; }
        #endregion
        #region Segundo Bloque
        public void _get_initial_size() // Obtener tamaño inicial
        {
            var _controls = _get_all_controls(Form);// llama al enumerador
            foreach (Control Control in _controls) // Pasa por los controles
            {
                _arr_control_storage.Add(Control.Bounds); // guarda límites de control / dimensión           
                                                          // Si tiene datagridview
                if (Control.GetType() == typeof(DataGridView))
                    DataGridView_Column_Adjust(((DataGridView)Control), ShowRowHeader);
            }
        }
        #endregion
        #region Tercer Bloque
        public void _resize() // Establecer el tamaño
        {
            double _form_ratio_width = (double)Form.ClientSize.Width / (double)_formSize.Width; // La relación podría ser mayor o menor que 1
            double _form_ratio_height = (double)Form.ClientSize.Height / (double)_formSize.Height; // Este también
            var _controls = _get_all_controls(Form); // volver a enumerar la colección de control
            int _pos = -1;// no cambie este valor a menos que sepa lo que está haciendo
            foreach (Control control in _controls)
            {
                // hacer algo de cálculo matemático
                _pos += 1;// incrementar en 1;
                System.Drawing.Size _controlSize = new System.Drawing.Size
                ((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                    (int)(_arr_control_storage[_pos].Height * _form_ratio_height)); // Usar para dimensionar

                System.Drawing.Point _controlposition = new System.Drawing.Point((int)
                (_arr_control_storage[_pos].X * _form_ratio_width),
                (int)(_arr_control_storage[_pos].Y * _form_ratio_height));// Uso para la ubicación

                // Establecer límites
                control.Bounds = new System.Drawing.Rectangle(_controlposition, _controlSize); //juntar

                // Suponiendo que tiene una datagridview dentro de un formulario()
                // si quiere mostrar el encabezado de la fila, reemplace la declaración falsa de
                // showRowHeader en la parte superior / public declaration en true;
                if (control.GetType() == typeof(DataGridView))
                    DataGridView_Column_Adjust(((DataGridView)control), ShowRowHeader);

                // Tamaño automático de fuente
                control.Font = new System.Drawing.Font(Form.Font.FontFamily,
                 (float)(((Convert.ToDouble(_fontsize) * _form_ratio_width) / 2) +
                  ((Convert.ToDouble(_fontsize) * _form_ratio_height) / 2)));

            }
        }
        #endregion
        #region Cuarto Bloque
        private void DataGridView_Column_Adjust(DataGridView DataGridView, bool _showRowHeader) // Si tiene datagridview
                                                                                                // y desea cambiar el tamaño de la columna en función de su dimensión.
        {
            int intRowHeader = 0;
            const int Hscrollbarwidth = 5;
            if (_showRowHeader)
                intRowHeader = DataGridView.RowHeadersWidth;
            else
                DataGridView.RowHeadersVisible = false;

            for (int i = 0; i < DataGridView.ColumnCount; i++)
            {
                if (DataGridView.Dock == DockStyle.Fill) //en caso de que el datagridview esté acoplado
                    DataGridView.Columns[i].Width = ((DataGridView.Width - intRowHeader) / DataGridView.ColumnCount);
                else
                    DataGridView.Columns[i].Width = ((DataGridView.Width - intRowHeader - Hscrollbarwidth) / DataGridView.ColumnCount);
            }
            DataGridView.AutoResizeColumns();
        }
        #endregion
        #region Enumerable
        private static IEnumerable<Control> _get_all_controls(Control Control)
        {
            return Control.Controls.Cast<Control>().SelectMany(item =>
                _get_all_controls(item)).Concat(Control.Controls.Cast<Control>()).Where(control =>
                control.Name != string.Empty);
        }
        #endregion
        //#region Adicional

        //private int X;
        //Point point = new Point();
        ////public ReSize()
        ////{
        ////    float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
        ////    float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
        ////    SizeF scale = new SizeF(widthRatio, heightRatio);
        ////    foreach (Control control in this.Controls)
        ////    {
        ////        control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
        ////    }
        ////}
        //public ReSize(Control Control)
        //{
        //    X = Screen.PrimaryScreen.WorkingArea.Width - 1024;
        //    X = X / 2;

        //    point.Y = Control.Location.Y + 50;
        //    point.X = Control.Location.X + X;

        //    Control.Location = point;
        //}
        //#endregion
    }
}
