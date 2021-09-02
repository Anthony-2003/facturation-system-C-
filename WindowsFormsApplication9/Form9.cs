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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        ConexionConSQL Conecto = new ConexionConSQL();
        public bool Editar = false;
        
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Form2 Facturar = new Form2();

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListCategoria()
        {
            comboBox1.DataSource = Conecto.ListCategoria();
            comboBox1.DisplayMember = "Categoria";
            comboBox1.ValueMember = "ID_Categoria";

        }

        private void ListProveedor()
        {
            comboBox2.DataSource = Conecto.ListProveedor();
            comboBox2.DisplayMember = "Empresa";
            comboBox2.ValueMember = "ID_Proveedor";
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conecto.MostrarDatosProductos();
            ListCategoria();
            ListProveedor();
            comboBox1.Text = comboBox2.Text = "";

            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Ventas)
            {
                button6.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                txtCantidadproducto.Enabled = false;
                txtIDProducto.Enabled = false;
                txtNombreproducto.Enabled = false;
                txtPrecioProducto1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;






            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form11 xdd = new Form11();
            xdd.Show();
        }
        //espera wa bebe agua ok

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtIDProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombreproducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPrecioProducto1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCantidadproducto.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }

            else
            {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                if (Editar == false)
                {
                    if (txtNombreproducto.Text == "" && txtCantidadproducto.Text == "" && txtPrecioProducto1.Text == "" && comboBox1.Text == "" && comboBox2.Text == "" || txtNombreproducto.Text == "" || txtCantidadproducto.Text == "" || txtPrecioProducto1.Text == "" || comboBox1.Text == "" || comboBox2.Text =="")
                    {
                        MessageBox.Show("Faltan datos necesarios", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Conecto.InsertarProductos(txtNombreproducto.Text, (txtPrecioProducto1.Text), (txtCantidadproducto.Text), (comboBox1.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue).ToString());
                        MessageBox.Show("Producto insertado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridView1.DataSource = Conecto.MostrarDatosProductos();
                        txtNombreproducto.Text = txtPrecioProducto1.Text = txtCantidadproducto.Text = comboBox1.Text = comboBox2.Text = "";
                    }
                }

                if (Editar == true)
                {
                    if (txtNombreproducto.Text == "" && txtCantidadproducto.Text == "" && txtPrecioProducto1.Text == "" && comboBox1.Text == "" && comboBox2.Text == ""|| txtNombreproducto.Text == "" || txtCantidadproducto.Text == "" || txtPrecioProducto1.Text == "" || comboBox1.Text=="" || comboBox2.Text =="")
                    {
                        MessageBox.Show("Faltan datos necesarios para poder editar", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Conecto.EditarProducto(txtNombreproducto.Text, txtPrecioProducto1.Text, txtCantidadproducto.Text, comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Editado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridView1.DataSource = Conecto.MostrarDatosProductos();
                        txtNombreproducto.Text = txtPrecioProducto1.Text = txtCantidadproducto.Text = comboBox1.Text = comboBox2.Text = txtIDProducto.Text = "";
                    }
                }
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                    if (MessageBox.Show("¿Esta seguro de que desea eliminar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conecto.DeshabilitarProducto(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        dataGridView1.DataSource = Conecto.MostrarDatosProductos();
                    MessageBox.Show("Eliminado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

                else
                {
                MessageBox.Show("Seleccione una fila", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
           
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = Conecto.BuscarProducto(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = Conecto.MostrarDatosProductos();
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (Facturar.Mostrar == true)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    return;
                }

                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }*/
        }

        private void PanelProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosDeshabilitados Mostrar = new ProductosDeshabilitados();
            Mostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categorias PantallaC = new Categorias();
            PantallaC.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conecto.MostrarDatosProductos();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conecto.MostrarDatosProductos();
            ListCategoria();
            ListProveedor();
            comboBox1.Text = comboBox2.Text = "";


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreproducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioProducto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
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
                e.Handled = false;

            }
        }

        private void txtCantidadproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
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
                e.Handled = false;

            }
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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
