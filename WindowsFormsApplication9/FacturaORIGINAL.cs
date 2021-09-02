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
    public partial class FacturaORIGINAL : Form
    {
        public FacturaORIGINAL()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClienteEmergente klk = new ClienteEmergente();
            klk.ShowDialog();
            if (klk.DialogResult == DialogResult.OK)
            {
                ID_C.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[0].Value.ToString();
                NombreC.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[1].Value.ToString();
                ApellidoC.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FacturaORIGINAL_Load(object sender, EventArgs e)
        {

        }
    }
}
