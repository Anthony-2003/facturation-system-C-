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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ConexionConSQL Consulta = new ConexionConSQL();
        Form8 prestame = new Form8();

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Consulta.Actualizar(txtid2.Text, txtnombre2.Text, txtapellido2.Text, txttelefono2.Text, txtdireccion2.Text))
            {
                MessageBox.Show("Datos actualizados");
                prestame.DataGridV.DataSource = Consulta.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se ha podido modificar.");
            }
        }
    }
}
