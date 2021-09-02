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
    public partial class ClientesDeshabilitados : Form
    {
        public ClientesDeshabilitados()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ConexionConSQL SQL = new ConexionConSQL();

        private void ClientesDeshabilitados_Load(object sender, EventArgs e)
        {
           

            dataGridView1.DataSource = SQL.ClientesDeshabilitados();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 Clientes = new Form8();

           Clientes.DataGridV.DataSource = SQL.MostrarDatos();

        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {

                dataGridView1.DataSource = SQL.BuscarClientesDeshabilitados(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = SQL.ClientesDeshabilitados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SQL.HabilitarCliente(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = SQL.ClientesDeshabilitados();
                MessageBox.Show("Habilitado","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form8 ClientesP = new Form8();
                ClientesP.DataGridV.DataSource = SQL.MostrarDatos();
            }

            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
