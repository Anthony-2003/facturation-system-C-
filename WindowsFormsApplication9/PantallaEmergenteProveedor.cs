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
    public partial class PantallaEmergenteProveedor : Form
    {
        public PantallaEmergenteProveedor()
        {
            InitializeComponent();
        }

        ConexionConSQL InstanciaSQL = new ConexionConSQL();

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaEmergenteProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = InstanciaSQL.MostrarDatosProveedor();
        }
    }
}
