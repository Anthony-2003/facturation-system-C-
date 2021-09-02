using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class ComprasDeshabilitadas : Form
    {
        public ComprasDeshabilitadas()
        {
            InitializeComponent();
        }

        private void ComprasDeshabilitadas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteDeCompras_DefinitivoDeshabilitados' Puede moverla o quitarla según sea necesario.
            //this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.Fill(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados);
   
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.ProveedorDeshabilitado(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados, Convert.ToInt16(textBox1.Text)).ToString();
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Introduza un ID", "IMPROTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime FechaInicial = dateTimePicker1.Value;
            DateTime FechaFinal = dateTimePicker2.Value;
            if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "")
            {

                this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.FillByObtenesFechas(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados, FechaInicial.ToString(), FechaFinal.ToString());

                // this.ReporteComprasTableAdapter.ObtenerProveedor(this.Definitivo.ReporteCompras, (Convert.ToInt32(textBox1.Text)));

            }
            this.reportViewer1.RefreshReport();
        }

        private void NombrePro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.FillByNombreProveedorDeshabilitado(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados, NombrePro.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.FillByObtenerEmpresaDeshabilitado(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados, textBox3.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ReporteDeCompras_DefinitivoDeshabilitadosTableAdapter.FillByObtenerProductoDeshabilitado(this.Definitivo.ReporteDeCompras_DefinitivoDeshabilitados, textBox4.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
