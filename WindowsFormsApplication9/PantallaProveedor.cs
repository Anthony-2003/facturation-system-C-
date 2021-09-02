using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication9
{
    public partial class PantallaProveedor : Form
    {
        ConexionConSQL InstanciaSQL = new ConexionConSQL();
    
        public PantallaProveedor()
        {
            InitializeComponent();
        }
        bool Editar = false;
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PantallaProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                if (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Faltan datos necesarios para poder guardar la información", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InstanciaSQL.InsertarProveedor(textBox3.Text, textBox4.Text, textBox5.Text, maskedTextBox1.Text, textBox6.Text);
                    MessageBox.Show("Insertado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox3.Text = textBox4.Text = textBox5.Text = maskedTextBox1.Text = textBox6.Text = textBox8.Text = "";
                    dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
                }
            }
            else if (Editar == true)
            {
                if (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Faltan datos necesarios para poder guardar la información", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                InstanciaSQL.ActualizarProveedor(textBox3.Text, textBox4.Text, textBox5.Text, maskedTextBox1.Text, textBox6.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Editado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
                textBox3.Text = textBox4.Text = textBox5.Text = maskedTextBox1.Text = textBox6.Text = textBox8.Text = "";
                Editar = false;
            }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
               dataGridView1.DataSource = InstanciaSQL.BuscarProveedor(textBox1.Text, textBox1.Text);
                    }
            else
            {
                dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }

            else
            {
                MessageBox.Show("Seleccione una fia","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta Seguro que desea eliminar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InstanciaSQL.DeshabilitarProveedor(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
                    MessageBox.Show("Eliminado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorDeshabilitado mostrar = new ProveedorDeshabilitado();
            mostrar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = false;

            }
            else
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
                e.Handled = false;

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
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
