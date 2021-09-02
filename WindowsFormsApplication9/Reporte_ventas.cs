﻿using System;
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
    public partial class Reporte_ventas : Form
    {
        public Reporte_ventas()
        {
            InitializeComponent();
        }

        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        
        private void Reporte_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Definitivo.Reporte_x_Ventas_V2' Puede moverla o quitarla según sea necesario.
           // this.Reporte_x_Ventas_V2TableAdapter.Fill(this.Definitivo.Reporte_x_Ventas_V2);

            this.reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Introduzca ID", "IMPROTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                this.Reporte_x_Ventas_V2TableAdapter.FillByClienteHabilitado(this.Definitivo.Reporte_x_Ventas_V2, Convert.ToInt16(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime FechaInicial = Fecha1.Value;
            DateTime FechaFinal = Fecha2.Value;
            this.Reporte_x_Ventas_V2TableAdapter.FechaVentasHabilitados(this.Definitivo.Reporte_x_Ventas_V2, FechaInicial, FechaFinal);
            this.reportViewer1.RefreshReport();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Introduzca un nombre", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Reporte_x_Ventas_V2TableAdapter.NombreClientehabilitado(this.Definitivo.Reporte_x_Ventas_V2, textBox2.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Fecha")
            {
                label1.Visible = true;
                Fecha1.Visible = true;
                label2.Visible = true;
                Fecha2.Visible = true;
                button3.Visible = true;
            }

            else
            {
                label1.Visible = false;
                Fecha1.Visible = false;
                label2.Visible = false;
                Fecha2.Visible = false;
                button3.Visible = false;

            }

            if (comboBox1.SelectedItem.ToString() == "ID_Cliente")
            {
                ID_Cliente.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }

            else
            {
                ID_Cliente.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }

            if (comboBox1.SelectedItem.ToString() == "Nombre_C")
            {
                label3.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
            }

            else
            {
                label3.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
