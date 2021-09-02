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
    public partial class ReporteEspecificoComprasDeshabilitadas : Form
    {
        public ReporteEspecificoComprasDeshabilitadas()
        {
            InitializeComponent();
        }

        private void ReporteEspecificoComprasDeshabilitadas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo' Puede moverla o quitarla según sea necesario.
           //this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.Fill(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime FechaInicial = dateTimePicker1.Value;
            DateTime FechaFinal = dateTimePicker2.Value;
            if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "")
            {

                this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.FillByObtenerFecha(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo, FechaInicial.ToString(), FechaFinal.ToString());

                // this.ReporteComprasTableAdapter.ObtenerProveedor(this.Definitivo.ReporteCompras, (Convert.ToInt32(textBox1.Text)));

            }

            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.FillByObtenerIdProveedor(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo, Convert.ToInt16(textBox1.Text)).ToString();
                textBox1.Text = "";
                this.reportViewer1.RefreshReport();
            }

            else
            {
                MessageBox.Show("Introduzca un ID", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.FillByObtenerNombreProveedor(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo, NombrePro.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.FillByObtenerEmpresa(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo, textBox3.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ReporteEspecificoComprasDeshabilitadasDefinitivoTableAdapter.FillByObtenerNombreProducto(this.Definitivo.ReporteEspecificoComprasDeshabilitadasDefinitivo, textBox4.Text);
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Fecha")
            {
                label1.Visible = true;
                dateTimePicker1.Visible = true;
                label2.Visible = true;
                dateTimePicker2.Visible = true;
                button3.Visible = true;
            }

            else
            {
                label1.Visible = false;
                dateTimePicker1.Visible = false;
                label2.Visible = false;
                dateTimePicker2.Visible = false;
                button3.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "ID_Proveedor")
            {
                label3.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }

            else
            {
                label3.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Nombre_P")
            {
                label4.Visible = true;
                NombrePro.Visible = true;
                button2.Visible = true;
            }

            else
            {
                label4.Visible = false;
                NombrePro.Visible = false;
                button2.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Empresa")
            {
                label6.Visible = true;
                textBox3.Visible = true;
                button4.Visible = true;
            }

            else
            {
                label6.Visible = false;
                textBox3.Visible = false;
                button4.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Producto")
            {
                label7.Visible = true;
                textBox4.Visible = true;
                button5.Visible = true;
            }

            else
            {
                label7.Visible = false;
                textBox4.Visible = false;
                button5.Visible = false;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NombrePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
