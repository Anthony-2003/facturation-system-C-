using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class MainMenuV2 : Form
    {
        public MainMenuV2()
        {
            InitializeComponent();
        }

        
        private void AbrirFormulario(object Formulario)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form abrir = Formulario as Form;
            abrir.TopLevel = false;
            abrir.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(abrir);
            this.panel2.Tag = abrir;
            abrir.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            img2.Visible = false;
            img1.Visible = false;
            AbrirFormulario(new Form8());
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img2.Visible = false;
            img1.Visible = false;
            AbrirFormulario(new PantallaEmpleados());

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
