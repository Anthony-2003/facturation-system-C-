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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AbrirFormulario(object Formulario)
        {
            if (this.MAINPANEL.Controls.Count > 0)
                this.MAINPANEL.Controls.RemoveAt(0);
            Form abrir = Formulario as Form;
            abrir.TopLevel = false;
            abrir.Dock = DockStyle.Fill;
            this.MAINPANEL.Controls.Add(abrir);
            this.MAINPANEL.Tag = abrir;
            abrir.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cLIENTESToolStripMenuItem1.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.Aqua;
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
            AbrirFormulario(new Form8());
            img1.Visible = false;
            img2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form10());
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void pRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pRODUCTOSToolStripMenuItem1.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.Aqua;
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
            AbrirFormulario(new Form9());
            img1.Visible = false;
            img2.Visible = false;
        }

        private void fACTURASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fACTURASToolStripMenuItem1.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240,240,240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.Aqua;
            }
            AbrirFormulario(new Form2());
            img1.Visible = false;
            img2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MAINPANEL_Paint(object sender, PaintEventArgs e)
        {
            iNICIOToolStripMenuItem.BackColor = Color.Aqua;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form10());
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iNICIOToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.Aqua;
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240,240,240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240,240,240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240,240,240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240,240,240);


            }
            AbrirFormulario(new Form10());
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_ventas Ventas = new Reporte_ventas();
            Ventas.Show();
        }

        private void eSPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cXCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Antho = new Form5();
            Antho.Show();
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba test = new Prueba();
            test.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (cLIENTESToolStripMenuItem.Checked)
            {
                cLIENTESToolStripMenuItem1.BackColor = Color.Black;
                
            }
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pROVEEDORToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240,240,240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.Aqua;
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
            AbrirFormulario(new PantallaProveedor());
                img1.Visible = false;
            img2.Visible = false;
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eMPLEADOSToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.Aqua;
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
        
            AbrirFormulario(new PantallaEmpleados());
            img1.Visible = false;
            img2.Visible = false;
        }

        private void img2_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cOMPRASToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.Aqua;
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
            img1.Visible = false;
            img2.Visible = false;
            AbrirFormulario(new Form6());
        }

        private void vENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_ventas Ventas = new Reporte_ventas();
            Ventas.Show();
        }

        private void cOMPRASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteCompras SawMaster = new ReporteCompras();
            SawMaster.Show();
        }

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteG_Clientes mostrar = new ReporteG_Clientes();
            mostrar.Show();
        }

        private void eMPLEADOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RiportEmpleados MostrarEmpleados = new RiportEmpleados();
            MostrarEmpleados.Show();
        }

        private void pRODUCTOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteGeneralProductos ReporteGProductos = new ReporteGeneralProductos();
            ReporteGProductos.Show();
        }

        private void pROVEEDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            P_ReporteGProveedor ReporteProveedor = new P_ReporteGProveedor();
            ReporteProveedor.Show();
        }

        private void vENTASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteGVentas ReporteGVentas = new ReporteGVentas();
            ReporteGVentas.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cOMPRASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteGeneralCompras ReporteCompras = new ReporteGeneralCompras();
            ReporteCompras.Show();

        }

        private void img1_Click(object sender, EventArgs e)
        {

        }
    }
}
