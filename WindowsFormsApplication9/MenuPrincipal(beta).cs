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
using System.Data.SqlClient;


namespace WindowsFormsApplication9
{
    public partial class MenuPrincipal_beta_ : Form
    {

        public MenuPrincipal_beta_()
        {
            InitializeComponent();

        }

       



        Form8 Clientes = new Form8();

        ConexionConSQL sql = new ConexionConSQL();

        Form8 ProductosPantalla = new Form8();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MenuPrincipal_beta__Load(object sender, EventArgs e)
        {
            sql.Abrir();
            iNICIOToolStripMenuItem.BackColor = Color.Aqua;
            AbrirFormulario(new Form10());
            LOGIN User = new LOGIN();
            usercacha();
            sql.Cerrar();

           




            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Administrador)
            {

                
              
               
               
            }

            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Ventas)
            {
                //vamos a ver si funciona espera
                //intancia el boton que quieres desabilitar
                Form8 Clientes = new Form8();
                Clientes.Eliminar.Enabled = false;
                eMPLEADOSToolStripMenuItem.Enabled = false;
                pROVEEDORToolStripMenuItem.Enabled = false;
                cOMPRASToolStripMenuItem.Enabled = false;
                pRODUCTOSToolStripMenuItem1.Enabled = false;
                pROVEEDORToolStripMenuItem1.Enabled = false;
                cOMPRASToolStripMenuItem1.Enabled = false;
                pRODUCTOSToolStripMenuItem2.Enabled = false;
                cOMPRASToolStripMenuItem1.Enabled = false;
                cOMPRASToolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
                eMPLEADOSToolStripMenuItem1.Enabled = false;
                
               
                
            }
            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Almacen)
            {
                //vamos a ver si funciona espera
                //intancia el boton que quieres desabilitar

                
                cLIENTESToolStripMenuItem1.Enabled = false;
                eMPLEADOSToolStripMenuItem.Enabled = false;
             fACTURASToolStripMenuItem1.Enabled = false;
                vENTASToolStripMenuItem2.Enabled = false;
                cLIENTESToolStripMenuItem2.Enabled = false;
                eMPLEADOSToolStripMenuItem1.Enabled = false;
                vENTASToolStripMenuItem1.Enabled = false;

            }








        } 

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
            Clientes.DataGridV.Width = 23000;
            
          
            
        }

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


        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MAINPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        }

        private void eMPLEADOSToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iNICIOToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.Aqua;
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);


            }

            AbrirFormulario(new Form10());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
         
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pROVEEDORToolStripMenuItem.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.Aqua;
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
            }
            AbrirFormulario(new PantallaProveedor());
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
            AbrirFormulario(new Form6());
        }

        private void fACTURASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fACTURASToolStripMenuItem1.Selected)
            {
                iNICIOToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cLIENTESToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                eMPLEADOSToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                pRODUCTOSToolStripMenuItem1.BackColor = Color.FromArgb(240, 240, 240);
                pROVEEDORToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                cOMPRASToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
                fACTURASToolStripMenuItem1.BackColor = Color.Aqua;
            }
            AbrirFormulario(new Form2());
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

        private void cOMPRASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteGeneralCompras ReporteCompras = new ReporteGeneralCompras();
            ReporteCompras.Show();
        }

        private void vENTASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteGVentas ReporteGVentas = new ReporteGVentas();
            ReporteGVentas.Show();
        }

        private void vENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cOMPRASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN Devolver = new LOGIN();
            Devolver.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void usercacha()

        {
            Usuario.Text = ClassLibrary1.Tipodeusuario.Nombre + " " + ClassLibrary1.Tipodeusuario.Apellido;
                
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Maximizar_MouseEnter(object sender, EventArgs e)
        {
            
           
        }

        private void hABILITADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteCompras SawMaster = new ReporteCompras();
            SawMaster.Show();
        }

        private void dESHABILITADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEspecificoComprasDeshabilitadas Mostrar = new ReporteEspecificoComprasDeshabilitadas();
            Mostrar.Show();
        }

        private void hABILITADOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_ventas Ventas = new Reporte_ventas();
            Ventas.Show();
        }

        private void dESHABILITADOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_de_ventas VentasDes = new Reporte_de_ventas();
            VentasDes.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reporte_productos_habilitados ReporteProductos = new Reporte_productos_habilitados();
            ReporteProductos.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Reporte_productos_deshabilitados ReporteProductoDeshabilitados = new Reporte_productos_deshabilitados();
            ReporteProductoDeshabilitados.Show();
        }
    }
}
