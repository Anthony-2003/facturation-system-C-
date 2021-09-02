namespace WindowsFormsApplication9
{
    partial class ReporteGVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Definitivo = new WindowsFormsApplication9.Definitivo();
            this.Reporte_x_Ventas_V2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_x_Ventas_V2TableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.Reporte_x_Ventas_V2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_x_Ventas_V2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_x_Ventas_V2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.ReporteGVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // Definitivo
            // 
            this.Definitivo.DataSetName = "Definitivo";
            this.Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_x_Ventas_V2BindingSource
            // 
            this.Reporte_x_Ventas_V2BindingSource.DataMember = "Reporte_x_Ventas_V2";
            this.Reporte_x_Ventas_V2BindingSource.DataSource = this.Definitivo;
            // 
            // Reporte_x_Ventas_V2TableAdapter
            // 
            this.Reporte_x_Ventas_V2TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGVentas";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_x_Ventas_V2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_x_Ventas_V2BindingSource;
        private Definitivo Definitivo;
        private DefinitivoTableAdapters.Reporte_x_Ventas_V2TableAdapter Reporte_x_Ventas_V2TableAdapter;
    }
}