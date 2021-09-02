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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.Definitivo.Clientes);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
            if (textBox1.Text != "")
            {
                try
                {
                    int IDC = Convert.ToInt32(textBox1.Text);
                    this.ClientesTableAdapter.SoliCliente(this.Definitivo.Clientes, IDC);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception)
                {
                  
                }
            }
        
            if (textBox2.Text != "") { 
                try
                {
                    string Nombre = Convert.ToString(textBox2.Text);
                    this.ClientesTableAdapter.SolicitudNombre(this.Definitivo.Clientes, Nombre);
                    this.reportViewer1.RefreshReport();
                }


                catch (Exception)
                {
                   
                }
        }
            


           
            



        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Buscar";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
