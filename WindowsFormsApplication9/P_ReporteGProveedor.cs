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
    public partial class P_ReporteGProveedor : Form
    {
        public P_ReporteGProveedor()
        {
            InitializeComponent();
        }

        private void P_ReporteGProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.DatosProveedor' Puede moverla o quitarla según sea necesario.
            this.DatosProveedorTableAdapter.Fill(this.Definitivo.DatosProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
