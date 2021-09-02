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
    public partial class ReporteGVentas : Form
    {
        public ReporteGVentas()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.Reporte_x_Ventas_V2' Puede moverla o quitarla según sea necesario.
            this.Reporte_x_Ventas_V2TableAdapter.Fill(this.Definitivo.Reporte_x_Ventas_V2);

            this.reportViewer1.RefreshReport();
        }
    }
}
