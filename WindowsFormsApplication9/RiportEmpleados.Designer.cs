namespace WindowsFormsApplication9
{
    partial class RiportEmpleados
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
            this.DatosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosEmpleadosTableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.DatosEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(412, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // Definitivo
            // 
            this.Definitivo.DataSetName = "Definitivo";
            this.Definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosEmpleadosBindingSource
            // 
            this.DatosEmpleadosBindingSource.DataMember = "DatosEmpleados";
            this.DatosEmpleadosBindingSource.DataSource = this.Definitivo;
            // 
            // DatosEmpleadosTableAdapter
            // 
            this.DatosEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // RiportEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RiportEmpleados";
            this.Text = "RiportEmpleados";
            this.Load += new System.EventHandler(this.RiportEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosEmpleadosBindingSource;
        private Definitivo Definitivo;
        private DefinitivoTableAdapters.DatosEmpleadosTableAdapter DatosEmpleadosTableAdapter;
    }
}