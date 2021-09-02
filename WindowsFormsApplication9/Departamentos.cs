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
    public partial class Departamentos : Form
    {
        public Departamentos()
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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ConexionConSQL sql = new ConexionConSQL();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarDepartamentos();
        }

        bool Editar = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = sql.BuscarDepartamentos(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = sql.MostrarDepartamentos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                if(textBox3.Text == "")
                {
                    MessageBox.Show("Se necesitan datos necesarios para poder guardar", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    sql.InsertarDepartamento(textBox3.Text);
                    dataGridView1.DataSource = sql.MostrarDepartamentos();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Insertado correctamente","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                }
            }

            else if(Editar == true)
            {
                if(textBox3.Text == "")
                {
                    MessageBox.Show("No puedes editar con formularios vacíos", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    sql.EditarDepartamento(textBox3.Text, textBox2.Text);
                    dataGridView1.DataSource = sql.MostrarDepartamentos();
                    MessageBox.Show("Editado correctamente","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox2.Clear();
                    textBox3.Clear();
                    Editar = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de que deseas eliminar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql.DeshabilitarDepartamento(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = sql.MostrarDepartamentos();
                    MessageBox.Show("Eliminado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartamentosDeshabilitados DeptoDeshabilitado = new DepartamentosDeshabilitados();
            DeptoDeshabilitado.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarDepartamentos();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
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
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
