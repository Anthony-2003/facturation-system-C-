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
    public partial class _Especifico__ReporteDeCompras : Form
    {
        public _Especifico__ReporteDeCompras()
        {
            InitializeComponent();
        }

        private void _Especifico__ReporteDeCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.ReporteDeCompras_Especifico' Puede moverla o quitarla según sea necesario.
            this.ReporteDeCompras_EspecificoTableAdapter.Fill(this.Definitivo.ReporteDeCompras_Especifico);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
