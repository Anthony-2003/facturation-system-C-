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
    public partial class ClienteEmergente : Form
    {
        public ClienteEmergente()
        {
            InitializeComponent();
        }

        ConexionConSQL InstanciaSQL = new ConexionConSQL();

        private void ClienteEmergente_Load(object sender, EventArgs e)
        {
            DataGridV.DataSource = InstanciaSQL.MostrarDatos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DataGridV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Form2 factura = new Form2();

        private void DataGridV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (factura.Mostrar == true)
            {
                if (DataGridV.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void BuscarCli_TextChanged(object sender, EventArgs e)
        {
            if (BuscarCli.Text != "")
            {
                DataGridV.DataSource = InstanciaSQL.Buscar(BuscarCli.Text);
            }

            else
            {
                DataGridV.DataSource = InstanciaSQL.MostrarDatos();
            }
        }

        private void DataGridV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridV.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

