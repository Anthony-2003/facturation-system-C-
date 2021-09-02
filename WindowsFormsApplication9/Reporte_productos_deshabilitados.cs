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
    public partial class Reporte_productos_deshabilitados : Form
    {
        public Reporte_productos_deshabilitados()
        {
            InitializeComponent();
        }

        private void Reporte_productos_deshabilitados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.Reporte_productos_deshabilitados' Puede moverla o quitarla según sea necesario.
           // this.Reporte_productos_deshabilitadosTableAdapter.Fill(this.Definitivo.Reporte_productos_deshabilitados);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ID_Producto")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button2.Visible = true;
            }

            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
                button2.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Descripcion")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
            }

            else
            {
                label2.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Categoria")
            {
                label3.Visible = true;
                textBox3.Visible = true;
                button3.Visible = true;
            }

            else
            {
                label3.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                this.Reporte_productos_deshabilitadosTableAdapter.FillByObtenerCategoria(this.Definitivo.Reporte_productos_deshabilitados, textBox3.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.Reporte_productos_deshabilitadosTableAdapter.FillByObtenerIDPro(this.Definitivo.Reporte_productos_deshabilitados, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.Reporte_productos_deshabilitadosTableAdapter.FillByObtenerNombreProducto(this.Definitivo.Reporte_productos_deshabilitados, textBox2.Text);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
