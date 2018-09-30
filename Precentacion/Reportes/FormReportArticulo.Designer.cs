namespace Precentacion
{
    partial class FormReportArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataSetPrincipal = new Precentacion.DataSetPrincipal();
            this.SpMostrar_ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpMostrar_ArticuloTableAdapter = new Precentacion.DataSetPrincipalTableAdapters.SpMostrar_ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpMostrar_ArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RWReportes
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SpMostrar_ArticuloBindingSource;
            this.RWReportes.LocalReport.DataSources.Add(reportDataSource2);
            this.RWReportes.LocalReport.ReportEmbeddedResource = "Precentacion.Reportes.ReportArticulo.rdlc";
            this.RWReportes.ServerReport.BearerToken = null;
            this.RWReportes.Size = new System.Drawing.Size(1077, 727);
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpMostrar_ArticuloBindingSource
            // 
            this.SpMostrar_ArticuloBindingSource.DataMember = "SpMostrar_Articulo";
            this.SpMostrar_ArticuloBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // SpMostrar_ArticuloTableAdapter
            // 
            this.SpMostrar_ArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Name = "FormReportArticulo";
            this.Text = "Reporte de Articulo";
            this.Load += new System.EventHandler(this.FormReportArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpMostrar_ArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SpMostrar_ArticuloBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.SpMostrar_ArticuloTableAdapter SpMostrar_ArticuloTableAdapter;
    }
}