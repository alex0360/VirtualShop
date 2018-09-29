namespace Precentacion
{
    partial class FormReporteFactura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporte_FacturaTableAdapter1 = new Precentacion.DataSetPrincipalTableAdapters.SpReporte_FacturaTableAdapter();
            this.dataSetPrincipal1 = new Precentacion.DataSetPrincipal();
            this.tableAdapterManager1 = new Precentacion.DataSetPrincipalTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Precentacion.Reportes.Reporte_informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1185, 730);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReporte_FacturaTableAdapter1
            // 
            this.spReporte_FacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetPrincipal1
            // 
            this.dataSetPrincipal1.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Precentacion.DataSetPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 730);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteFactura";
            this.Text = "Reporte de Factura";
            this.Load += new System.EventHandler(this.FormReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetPrincipalTableAdapters.SpReporte_FacturaTableAdapter spReporte_FacturaTableAdapter1;
        private DataSetPrincipal dataSetPrincipal1;
        private DataSetPrincipalTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}