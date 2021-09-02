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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        string[,] Lista = new string[200, 200];
        int fila;
        ConexionConSQL sql = new ConexionConSQL();

        bool ModificarProducto = false;
        bool Guardar = false;
        private void Form6_Load(object sender, EventArgs e)
        {
            IDCOMPRA.Text = sql.AumentarCompra();
            btnLimpiar.Enabled = false;
            button4.Enabled = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveedorEmergente proveedor = new ProveedorEmergente();

            proveedor.ShowDialog();

            if(proveedor.DialogResult == DialogResult.OK)
            {
                IDPROVEEDOR.Text = proveedor.dataGridView1.Rows[proveedor.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = proveedor.dataGridView1.Rows[proveedor.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = proveedor.dataGridView1.Rows[proveedor.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                textBox4.Text = proveedor.dataGridView1.Rows[proveedor.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            }


        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAPagar_Click(object sender, EventArgs e)
        {
            if(lblTotalAPagar.Text != "$0.00")
            {
                txtPago.Enabled = true;
            }
            else if (txtPago.Enabled == false)
            {
                txtPago.Clear();
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
  

                if (txtPago.Text == "")
                {
                    txtPago.Text.ToString();
                    lblDevolucion.Text = "$0.00";
                }

                else
                {
                    Convert.ToInt64(txtPago.Text);
                    lblDevolucion.Text = (int.Parse(txtPago.Text) - int.Parse(lblTotalAPagar.Text)).ToString();
                    txtPago.ToString();
                    

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblDevolucion_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(idproducto.Text == "")
            {
                DesPro.Text = CantidadPro.Text = PrecioPro.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductoEmergenteOriginal Producto = new ProductoEmergenteOriginal();

            Producto.ShowDialog();

            if(Producto.DialogResult == DialogResult.OK)
            {
                idproducto.Text = Producto.dataGridView1.Rows[Producto.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                DesPro.Text = Producto.dataGridView1.Rows[ Producto.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                PrecioPro.Text = Producto.dataGridView1.Rows[Producto.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                CantidadPro.Focus();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AñadirProveedor AñadirProveedor = new AñadirProveedor();
            AñadirProveedor.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (ModificarProducto == false)
            {

                if (idproducto.Text != "" && DesPro.Text != "" && PrecioPro.Text != "" && CantidadPro.Text != "")
                {
                    if (dataGridView1.Rows.Count >= 0) 
                    {
                                          
                        {
                            Lista[fila, 0] = idproducto.Text;
                            Lista[fila, 1] = DesPro.Text;
                            Lista[fila, 2] = CantidadPro.Text;
                            Lista[fila, 3] = PrecioPro.Text;
                            Lista[fila, 4] = (Convert.ToInt16(CantidadPro.Text) * Convert.ToInt16(PrecioPro.Text)).ToString();

                            dataGridView1.Rows.Add(Lista[fila, 0], Lista[fila, 1], Lista[fila, 2], Lista[fila, 3], Lista[fila, 4]);

                            idproducto.Text = DesPro.Text = PrecioPro.Text = CantidadPro.Text = "";
                            CostoAPagar();
                        }
                    }
                   


                }
            }
        }

                public void CostoAPagar() {

            double CostoTotal = 0;
            int sumando = 0;

            sumando = dataGridView1.RowCount;

            for (int a = 0; a < sumando; a++)
            {
                CostoTotal += Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
            }
            lblTotalAPagar.Text = CostoTotal.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
                CostoAPagar();
                if(dataGridView1.RowCount == 0)
                {
                    lblTotalAPagar.Text = "$0.00";
                }
                          
                
            }

            else
            {
                MessageBox.Show("Seleccione una fila","" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            IDPROVEEDOR.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            sql.Conectar.Close();
            IDCOMPRA.Text = sql.AumentarCompra().ToString();
            idproducto.Clear();
            DesPro.Clear();
            CantidadPro.Clear();
            PrecioPro.Clear();
            dataGridView1.Rows.Clear();
            txtPago.Clear();
            lblDevolucion.Text = "$0.00";
            lblTotalAPagar.Text = "$0.00";
            btnLimpiar.Enabled = false;
            Agregar.Enabled = true;
            button8.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            CantidadPro.ReadOnly = false;
            txtPago.ReadOnly = false;
            Guardar = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ModificarProducto = true;
                idproducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DesPro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                CantidadPro.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                PrecioPro.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                if (ModificarProducto == true)
                {
                    if (idproducto.Text == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ModificarProducto = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            if (IDPROVEEDOR.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dataGridView1.RowCount > 0 && txtPago.Text != "")
            {
                Guardar = true;
                if(Guardar == true)
                {
                    button4.Enabled = true;
                }
                btnLimpiar.Enabled = false;
                Agregar.Enabled = false;
                button8.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                CantidadPro.ReadOnly = true;
                txtPago.ReadOnly = true;

                ConexionConSQL BD = new ConexionConSQL();
                if (IDPROVEEDOR.Text != "")
                {

                    BD.InsertarCompra(Fecha.ToString("yyyy/MM/dd"), IDPROVEEDOR.Text);

                }

                foreach (DataGridViewRow Rows in dataGridView1.Rows)
                {
                    BD.InsertarDetalle_Compra(IDCOMPRA.Text, Rows.Cells[0].Value.ToString(), Rows.Cells[2].Value.ToString(), Rows.Cells[3].Value.ToString(), Rows.Cells[4].Value.ToString());
                }

                MessageBox.Show("Guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Se deben llenar los datos necesarios antes de guardar","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IDPROVEEDOR.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dataGridView1.RowCount > 0 && txtPago.Text != "")
            {
               
                
                //Desde aqui copiamos
                Class1.CreaTicket Ticket1 = new Class1.CreaTicket();

                Ticket1.TextoCentro("FERRETERIA HALASA"); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("Dirc: xxxx");
                Ticket1.TextoIzquierda("Tel: 809-313-3124");
                Ticket1.TextoIzquierda("Rnc: xxxx");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Compra: " + IDCOMPRA.Text);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: ");///////////////////////////////////
                Ticket1.TextoIzquierda("");
                Class1.CreaTicket.LineasGuion();

                Class1.CreaTicket.EncabezadoVenta();
                Class1.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dataGridView1.Rows)
                { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString()));//imprime una linea de descripcion
                                                                                                                                                                                                      //imprime una linea de descripcion
                }
                //Ticket1.AgregaArticulo(DesPro.Text,double.Parse (PrecioPro.Text),int.Parse (ca.Text),double.Parse( "123"));

                Class1.CreaTicket.LineasGuion();
                Ticket1.AgregaTotales("Sub-Total", int.Parse("0")); // imprime linea con total
                Ticket1.AgregaTotales("Menos Descuento", int.Parse("0")); // imprime linea con total
                Ticket1.AgregaTotales("Mas ITBIS", int.Parse("0")); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", int.Parse(lblTotalAPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", int.Parse(txtPago.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", int.Parse(lblDevolucion.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
                Ticket1.ImprimirTiket(impresora);
                //hasta aqui el codigo de imprimir


                fila = 0;
                //while (dataGridView1.RowCount > 0)//limpia el dgv
                //{ dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                btnLimpiar.Enabled = true;
                button4.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Se requiere información importante antes de imprimir","Importante",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void lblTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            if(lblTotalAPagar.Text != "$0.00")
            {
                txtPago.Enabled = true;
            }

            else
            {
                txtPago.Enabled = false;
                txtPago.Clear();
            }
           
            
          
        }

        private void lblDevolucion_TextChanged(object sender, EventArgs e)
        {
            if(txtPago.Text == "")
            {
                lblDevolucion.Text = "$0.00"; 
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CantidadPro_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }

        }
    }
    }

