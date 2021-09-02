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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }
        string[,] lista = new string[1000, 6];
        int fila;
        public bool guardar = false;
        ConexionConSQL InstanciaSQL = new ConexionConSQL();

        bool ModificarProducto = false;
        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN mostrar = new LOGIN();
            this.Hide();
            mostrar.Show();
        }
        //busca las consultas otra vez JAJAJJAA 

        private void Form2_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
          textBox1.Text = InstanciaSQL.AumentarFac().ToString();
            MenuPrincipal_beta_ XD = new MenuPrincipal_beta_();
           
            button4.Enabled = false;
            //espera ya veo k psa no me captura los tipos int
            //antes se te mostraba?  aja haz el metodoque estaba con el id COMO si me acuerdo dejos xd 

            label16.Text = ClassLibrary1.Tipodeusuario.Id_Empleado.ToString();
            //una pregunta quien es que realiza la factura en tu empresa? los de ventas compai, y el administrador un empleado encargado de esoverdad? si y porque pones que el empleado se muestre en esos label  varios empleados hacen facturas marika
            label15.Text= ClassLibrary1.Tipodeusuario.Nombre + " " + ClassLibrary1.Tipodeusuario.Apellido;
            //mira ve pruebo?si
        }


     
        public void ListarEmpleados()
        {
           // comboBox1.DataSource = InstanciaSQL.ListarEmpleados();
            //comboBox1.DisplayMember = "Nombre";
            //comboBox1.ValueMember = "ID_Empleado";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        { if (ModificarProducto == false)
            {
             
               if (idproducto.Text != "" && CantidadPro.Text != "" && PrecioPro.Text != "")
                {
                  
                    {
                        lista[fila, 0] = idproducto.Text.ToString();
                        lista[fila, 1] = DesPro.Text;
                        lista[fila, 2] = CantidadPro.Text;
                        lista[fila, 3] = PrecioPro.Text;
                        lista[fila, 4] = (float.Parse(PrecioPro.Text) * float.Parse(CantidadPro.Text)).ToString();
                        dataGridView1.Rows.Add(lista[fila, 0], lista[fila, 1], lista[fila, 2], lista[fila, 3], lista[fila, 4]);
                        fila++;
                        //idproducto.Text = CantidadPro.Text = PrecioPro.Text = DesPro.Text = "";

                        CostoAPagar();
                        idproducto.Text = DesPro.Text = CantidadPro.Text = PrecioPro.Text = "";
                        button5.Enabled = true;
                    }







                }
              
            }
      
            }
    
               
             
               
            
         
        

        public void CostoAPagar()
        {
            double CostoTotal = 0;
            int sumando = 0;

            sumando = dataGridView1.RowCount;

            for (int a = 0; a < sumando; a++)
            {
                CostoTotal += Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
            }
            lblTotalAPagar.Text = CostoTotal.ToString();

        }



        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
                
        }

        public bool Mostrar = false;

        private void button6_Click(object sender, EventArgs e)
        {
           
            ClienteEmergente klk = new ClienteEmergente();
            klk.ShowDialog();
            if(klk.DialogResult==DialogResult.OK)
            {
                ID_C.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[0].Value.ToString();
                NombreC.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[1].Value.ToString();
                ApellidoC.Text = klk.DataGridV.Rows[klk.DataGridV.CurrentRow.Index].Cells[2].Value.ToString();
            }
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           ProductoEmergenteOriginal XD = new ProductoEmergenteOriginal();
            
            

            XD.ShowDialog();
            
            if (XD.DialogResult == DialogResult.OK)
            {
                idproducto.Text = XD.dataGridView1.Rows[XD.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                DesPro.Text = XD.dataGridView1.Rows[XD.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
              
                PrecioPro.Text = XD.dataGridView1.Rows[XD.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                CantidadPro.Focus();
             

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // textBox2.Text == "" && ID_C.Text == "
                InstanciaSQL.Conectar.Close();
            textBox1.Text = InstanciaSQL.AumentarFac().ToString();
            ID_C.Clear();
            NombreC.Clear();
            ApellidoC.Clear();
            
            idproducto.Clear();
            DesPro.Clear();
            PrecioPro.Clear();
            dataGridView1.Rows.Clear();
            lblTotalAPagar.Text = "$0.00";
            idproducto.Text = "";
            txtPago.Clear();
            
            lblDevolucion.Text = "$0.00";
            CantidadPro.Clear();
            Agregar.Enabled = true;
            button8.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
          
            btnLimpiar.Enabled = false;
            idproducto.Text = DesPro.Text = PrecioPro.Text = CantidadPro.Text = txtPago.Text = "";
            lblDevolucion.Text = lblTotalAPagar.Text = "$0.00";
            dataGridView1.Rows.Clear();
            button5.Enabled = true;
            NombreC.ReadOnly = false;
            ApellidoC.ReadOnly = false;
            CantidadPro.ReadOnly = false;
            txtPago.ReadOnly = false;

        }

        private void Numero_Factura_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PANTALLA enseñar = new PANTALLA();
            enseñar.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID_C.Text == "" && NombreC.Text == "" && ApellidoC.Text == "" && idproducto.Text == "" && DesPro.Text == "" && CantidadPro.Text == "" && PrecioPro.Text == "" && dataGridView1.Rows.Count == 0 && txtPago.Text == "")
            {
                MessageBox.Show("Se requiere información importante antes de imprimir", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
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
                Ticket1.TextoIzquierda("No Fac: " + textBox1.Text);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + label15.Text);///////////////////////////////////
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
                Ticket1.AgregaTotales("Total", Convert.ToInt32(lblTotalAPagar.Text)); // imprime linea con total
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
                /*  while (dataGridView1.RowCount > 0)//limpia el dgv
                  { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                  //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                  txtPago.Text = idproducto.Text = DesPro.Text = PrecioPro.Text = CantidadPro.Text = txtPago.Text = "";
                  lblDevolucion.Text = lblTotalAPagar.Text = "$0.00";*/
                guardar = false;
                button4.Enabled = false;
                btnLimpiar.Enabled = true;


            }
        }

            
        private void lblDevolucion_Click(object sender, EventArgs e)
        {
           
         
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                

                if (lblTotalAPagar.Text == "$0.00")
                {
                    
                }

                else if(txtPago.Text == "")
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

        DateTime Fecha = DateTime.Now;
        DateTime Hora = DateTime.Now.ToLocalTime();

        

        private void button3_Click(object sender, EventArgs e)
        {

            if (ID_C.Text != "" && NombreC.Text != "" && ApellidoC.Text != "" && lblTotalAPagar.Text != "$0.00" && txtPago.Text != "")
            { 
                guardar = true;
                if (guardar == true)
                {

                    InstanciaSQL.Conectar.Close();
                    InstanciaSQL.InsertarFactura(ID_C.Text, label16.Text, Fecha.ToString("yyyy/MM/dd"));
                    InstanciaSQL.Conectar.Close();



                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        InstanciaSQL.InsertarDetalleFactura(textBox1.Text, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString(), Fila.Cells[4].Value.ToString());

                    }
                    Agregar.Enabled = false;
                    button8.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    NombreC.ReadOnly = true;
                    ApellidoC.ReadOnly = true;
                    idproducto.ReadOnly = true;
                    button5.Enabled = false;
                    DesPro.ReadOnly = true;
                    CantidadPro.ReadOnly = true;
                    PrecioPro.ReadOnly = true;
                    dataGridView1.ReadOnly = true;
                    txtPago.ReadOnly = true;
                    button4.Enabled = true;

                    MessageBox.Show("Guardado Correctamente");
                }    
            }

            else
            {
                MessageBox.Show("Se deben llenar los datos necesarios antes de guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            }
 
       
        private void lblTotalAPagar_Click(object sender, EventArgs e)
        {

        }

        private void ID_C_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                ModificarProducto = true;
                idproducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DesPro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                PrecioPro.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                CantidadPro.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                button5.Enabled = false;
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
                MessageBox.Show("Seleccione una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ModificarProducto = false;

        }

        private void CantidadPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void NombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No puedes eliminar filas si no hay productos");
            }
            else
            {

                dataGridView1.Rows.RemoveAt(0);
                CostoAPagar();
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

        private void idproducto_TextChanged(object sender, EventArgs e)
        {
            if(idproducto.Text == "")
            {
                CantidadPro.Text = "";
                PrecioPro.Text = "";
                DesPro.Text = "";
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            if (lblTotalAPagar.Text != "$0.00")
            {
                txtPago.Enabled = true;
            }

            else
            {
                txtPago.Enabled = false;
                txtPago.Clear();
            }
        }

        private void NombreC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ApellidoC_KeyPress(object sender, KeyPressEventArgs e)
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
