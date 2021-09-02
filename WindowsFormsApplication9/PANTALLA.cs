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
    public partial class PANTALLA : Form
    {
        public PANTALLA()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NOMBRE2p.Clear();
            TELEFONO2p.Clear();
            DIRECCION2p.Clear();
            APELLIDO2p.Clear();
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
        Form8 Prestar = new Form8();
        ConexionConSQL Consulta = new ConexionConSQL();
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (Consulta.Insertar(NOMBRE2p.Text, APELLIDO2p.Text, TELEFONO2p.Text, DIRECCION2p.Text))
            {
                MessageBox.Show("Datos insertados correctamente");
                Prestar.DataGridV.DataSource = Consulta.MostrarDatos();
                ID2p.Text = NOMBRE2p.Text = APELLIDO2p.Text = DIRECCION2p.Text = TELEFONO2p.Text = "";
            }
            else
            {
                MessageBox.Show("No se realizo correctamente");
            }

          
        }

        private void PANTALLA_Load(object sender, EventArgs e)
        {
            Prestar.DataGridV.DataSource = Consulta.MostrarDatos();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void ID2p_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOMBRE2p_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID2p_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
