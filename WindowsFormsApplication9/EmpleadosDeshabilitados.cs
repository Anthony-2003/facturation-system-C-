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
    public partial class EmpleadosDeshabilitados : Form
    {
        public EmpleadosDeshabilitados()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ConexionConSQL sql = new ConexionConSQL();

        private void EmpleadosDeshabilitados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =sql.EmpleadosDeshabilitados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = sql.BuscarEmpleadoDeshabilitado(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = sql.EmpleadosDeshabilitados();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                sql.HabilitarEmpleado(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = sql.EmpleadosDeshabilitados();
                MessageBox.Show("Habilitado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Seleccione una fila","IMPORTANTE",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
