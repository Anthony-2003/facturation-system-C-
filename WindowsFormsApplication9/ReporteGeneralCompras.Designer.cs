namespace WindowsFormsApplication9
{
    partial class ReporteGeneralCompras
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
            this.ReporteComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteComprasTableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.ReporteComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.ReporteG_Compras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // Definitivo
            // 
            this.Definitivo.DataSetName = "Definitivo";
            this.Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteComprasBindingSource
            // 
            this.ReporteComprasBindingSource.DataMember = "ReporteCompras";
            this.ReporteComprasBindingSource.DataSource = this.Definitivo;
            // 
            // ReporteComprasTableAdapter
            // 
            this.ReporteComprasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGeneralCompras";
            this.Text = "ReporteGeneralCompras";
            this.Load += new System.EventHandler(this.ReporteGeneralCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteComprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteComprasBindingSource;
        private Definitivo Definitivo;
        private DefinitivoTableAdapters.ReporteComprasTableAdapter ReporteComprasTableAdapter;
    }
}