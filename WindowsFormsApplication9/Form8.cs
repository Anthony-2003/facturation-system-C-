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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        ConexionConSQL Ejecutar = new ConexionConSQL();
        private bool Editar = false;



        private void textBox1_TextChanged(object sender, EventArgs e)
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PANTALLA mostrar = new PANTALLA();

            mostrar.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (DataGridV.SelectedRows.Count > 0)
            {
                Editar = true;
                txtID.Text = DataGridV.CurrentRow.Cells[0].Value.ToString();
                txtNOMBRE.Text = DataGridV.CurrentRow.Cells[1].Value.ToString();
                txtAPELLIDO.Text = DataGridV.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox1.Text = DataGridV.CurrentRow.Cells[3].Value.ToString();
                txtDIRECCION.Text = DataGridV.CurrentRow.Cells[4].Value.ToString();



            }
            else
            {
                MessageBox.Show("Seleccione una fila","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'definitivo.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.definitivo.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'definitivo.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.definitivo.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'programaDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.definitivo.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'programaDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.definitivo.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'programaDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.definitivo.Clientes);
            DataGridV.DataSource = Ejecutar.MostrarDatos();

            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Administrador)
            {
              
            }

            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Ventas)
            {
                Eliminar.Enabled = false;





            }






        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);*/

        }

        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           /* this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);*/

        }

        private void clientesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
          /*  this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);*/

        }

        private void clientesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
           /* this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);*/

        }

        private void clientesBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            /*this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridV.DataSource = Ejecutar.MostrarDatos();
            DataGridV.RefreshEdit();



        }

        Form2 traslatar = new Form2();
        private void BuscarCli_TextChanged(object sender, EventArgs e)
        {
            if (BuscarCli.Text != "")
            {
                DataGridV.DataSource = Ejecutar.Buscar(BuscarCli.Text);
            }
            else
            {
                DataGridV.DataSource = Ejecutar.MostrarDatos();
            }
        }

        private void BuscarCli_KeyUp(object sender, KeyEventArgs e)
        {
            /*Ejecutar.Abrir();
            SqlCommand comand = Ejecutar.Conectar.CreateCommand();
            comand.CommandType = CommandType.Text;
            comand.CommandText = "SELECT * FROM Clientes WHERE NombreC like ('" + BuscarCli.Text + "%')";
            comand.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(comand);
            SDA.Fill(DT);
             DataGridV.DataSource = DT;
            Ejecutar.Cerrar();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (DataGridV.SelectedRows.Count > 0)

            /*   if (Ejecutar.Eliminar(Convert.ToInt32((DataGridV.CurrentRow.Cells[0].Value)).ToString()))
                   { 
                   MessageBox.Show("Eliminado correctamente");
                   DataGridV.DataSource = Ejecutar.MostrarDatos();
                   }
               else
               {
                   MessageBox.Show("Error al eliminar");
               }
               else
               {
                   MessageBox.Show("Selecciones una fila");
               }*/

            if (DataGridV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de que deseas eliminar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ejecutar.Deshabilitar(DataGridV.CurrentRow.Cells[0].Value.ToString());
                    DataGridV.DataSource = Ejecutar.MostrarDatos();
                    MessageBox.Show("Eliminado correctamente", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Seleccione una fila","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DataGridV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                try
                {



                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void DataGridV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DataGridV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 Cruzar = Owner as Form2;

            this.Hide();





        }
        ConexionConSQL Consulta = new ConexionConSQL();

     
        private void button5_Click(object sender, EventArgs e)
        {
                                 
                if (Editar == false)
                {
                    try
                    {
                    if (txtNOMBRE.Text == "" && txtAPELLIDO.Text == "" || txtNOMBRE.Text == "" || txtAPELLIDO.Text == "")
                    {
                        MessageBox.Show("No puedes guardar con formularios vacíos", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        Consulta.Insertar(txtNOMBRE.Text, txtAPELLIDO.Text, maskedTextBox1.Text, txtDIRECCION.Text);
                        MessageBox.Show("Se inserto correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = txtNOMBRE.Text = txtAPELLIDO.Text = txtDIRECCION.Text = maskedTextBox1.Text = "";
                        DataGridV.DataSource = Ejecutar.MostrarDatos();
                    }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar " + ex);
                    }
                }
                 
                if (Editar == true)
                {
                    try
                    {


                    if (txtNOMBRE.Text == "" || txtAPELLIDO.Text == "" || txtNOMBRE.Text== "" || txtAPELLIDO.Text == "" )
                    {
                        MessageBox.Show("No puedes editar si existen formularios vacíos","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {

                        Consulta.Actualizar(txtID.Text, txtNOMBRE.Text, txtAPELLIDO.Text, maskedTextBox1.Text, txtDIRECCION.Text);
                        MessageBox.Show("Se edito correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        txtID.Text = txtNOMBRE.Text = txtAPELLIDO.Text = txtDIRECCION.Text = maskedTextBox1.Text = "";
                        DataGridV.DataSource = Ejecutar.MostrarDatos();
                        Editar = false;
                    }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar " + ex);
                    }
                }
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAPELLIDO_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTELEFONO_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
                ClientesDeshabilitados Mostrar = new ClientesDeshabilitados();
            Mostrar.ShowDialog();
        
                
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataGridV.DataSource = Ejecutar.MostrarDatos();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void BuscarCli_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
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
