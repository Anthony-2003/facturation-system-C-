using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class ReporteCompras : Form
    {
        public ReporteCompras()
        {
            InitializeComponent();
        }

        ConexionConSQL ConexionBD = new ConexionConSQL();

        private void ReporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteCompras_Definitivo' Puede moverla o quitarla según sea necesario.
            //this.ReporteCompras_DefinitivoTableAdapter.Fill(this.Definitivo.ReporteCompras_Definitivo);
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteCompras' Puede moverla o quitarla según sea necesario.
            Definitivo.EnforceConstraints = false;
           
           // this.ReporteComprasTableAdapter.Fill(this.Definitivo.ReporteCompras);
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteDeCompras_Especifico' Puede moverla o quitarla según sea necesario.
            //this.ReporteDeCompras_EspecificoTableAdapter.Fill(this.Definitivo.ReporteDeCompras_Especifico);
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteCompras' Puede moverla o quitarla según sea necesario.
           
           
           
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DateTime FechaInicial = dateTimePicker1.Value;
            DateTime FechaFinal = dateTimePicker2.Value;
            if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "")
            {
                
                this.ReporteCompras_DefinitivoTableAdapter.FillByObtenerFecha(this.Definitivo.ReporteCompras_Definitivo, FechaInicial.ToString(), FechaFinal.ToString());

               // this.ReporteComprasTableAdapter.ObtenerProveedor(this.Definitivo.ReporteCompras, (Convert.ToInt32(textBox1.Text)));
              
            }
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ConexionBD.Abrir();
            SqlCommand comando = new SqlCommand("SELECT Nombre_Proveedor,Empresa FROM Proveedor WHERE ID_Proveedor=@ID_Proveedor",ConexionBD.Conectar);
            comando.Parameters.AddWithValue("@ID_Proveedor",textBox1.Text);
            comando.ExecuteNonQuery();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                textBox2.Text = lector["Nombre_Proveedor"].ToString();
                textBox3.Text = lector["Empresa"].ToString();
            }
            ConexionBD.Cerrar();*/
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.ReporteCompras_DefinitivoTableAdapter.FillByObtenerNombrePro(this.Definitivo.ReporteCompras_Definitivo,NombrePro.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.ReporteCompras_DefinitivoTableAdapter.FillByIDproveedor(this.Definitivo.ReporteCompras_Definitivo, Convert.ToInt16(textBox1.Text)).ToString();
                textBox1.Text = "";
                this.reportViewer1.RefreshReport();
            }

            else
            {
                MessageBox.Show("Introduzca un ID", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ReporteCompras_DefinitivoTableAdapter.FillByObtenerEmpresa(this.Definitivo.ReporteCompras_Definitivo, textBox3.Text);
            this.reportViewer1.RefreshReport();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ReporteCompras_DefinitivoTableAdapter.FillByObtenerProducto(this.Definitivo.ReporteCompras_Definitivo, textBox4.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Fecha")
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
                NombrePro.Visible =false;
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
    }
}
