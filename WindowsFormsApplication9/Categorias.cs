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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool Editar = false;

        ConexionConSQL sql = new ConexionConSQL();

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarCategorias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Editar = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                if(textBox3.Text == "")
                {
                    MessageBox.Show("Necesita llenar el formulario", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql.InsertarCategoria(textBox3.Text);
                    MessageBox.Show("Insertado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = sql.MostrarCategorias();
                    textBox3.Text = textBox2.Text = "";
                }
            }

            else  if (Editar == true)
            {
                if(textBox3.Text == "")
                {
                    MessageBox.Show("Necesita llenar el formulario", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql.EditarCategoria(textBox3.Text, textBox2.Text);
                    MessageBox.Show("Editado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = sql.MostrarCategorias();
                    textBox3.Text = textBox2.Text = "";
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarCategorias();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("¿Seguro que desea deshabilitar?","IMPORTANTE",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql.DeshabilitarCategoria(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Deshabilitado correctamente", "IMPORATNE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = sql.MostrarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = sql.BuscarCategoria(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = sql.MostrarCategorias();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaDeshabilitadas CDES = new CategoriaDeshabilitadas();
            CDES.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
