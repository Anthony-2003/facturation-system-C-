namespace WindowsFormsApplication9
{
    partial class _Especifico__ReporteDeCompras
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
            this.ReporteDeCompras_EspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Definitivo = new WindowsFormsApplication9.Definitivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteDeCompras_EspecificoTableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.ReporteDeCompras_EspecificoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDeCompras_EspecificoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteDeCompras_EspecificoBindingSource
            // 
            this.ReporteDeCompras_EspecificoBindingSource.DataMember = "ReporteDeCompras_Especifico";
            this.ReporteDeCompras_EspecificoBindingSource.DataSource = this.Definitivo;
            // 
            // Definitivo
            // 
            this.Definitivo.DataSetName = "Definitivo";
            this.Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteDeCompras_EspecificoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.ReporteDeCompras_Especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(147, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(599, 353);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteDeCompras_EspecificoTableAdapter
            // 
            this.ReporteDeCompras_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // _Especifico__ReporteDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "_Especifico__ReporteDeCompras";
            this.Text = "_Especifico__ReporteDeCompras";
            this.Load += new System.EventHandler(this._Especifico__ReporteDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDeCompras_EspecificoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteDeCompras_EspecificoBindingSource;
        private Definitivo Definitivo;
        private DefinitivoTableAdapters.ReporteDeCompras_EspecificoTableAdapter ReporteDeCompras_EspecificoTableAdapter;
    }
}