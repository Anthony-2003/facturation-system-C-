namespace WindowsFormsApplication9
{
    partial class P_ReporteGProveedor
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
            this.DatosProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosProveedorTableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.DatosProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.ReporteGProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // Definitivo
            // 
            this.Definitivo.DataSetName = "Definitivo";
            this.Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosProveedorBindingSource
            // 
            this.DatosProveedorBindingSource.DataMember = "DatosProveedor";
            this.DatosProveedorBindingSource.DataSource = this.Definitivo;
            // 
            // DatosProveedorTableAdapter
            // 
            this.DatosProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // P_ReporteGProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "P_ReporteGProveedor";
            this.Text = "P_ReporteGProveedor";
            this.Load += new System.EventHandler(this.P_ReporteGProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosProveedorBindingSource;
        private Definitivo Definitivo;
        private DefinitivoTableAdapters.DatosProveedorTableAdapter DatosProveedorTableAdapter;
    }
}