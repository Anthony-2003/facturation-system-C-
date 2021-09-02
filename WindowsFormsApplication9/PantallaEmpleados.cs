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
    public partial class PantallaEmpleados : Form
    {
        public PantallaEmpleados()
        {
            InitializeComponent();
        }

        bool Editar = false;
       private string genero = string.Empty;
        ConexionConSQL SQLConexion = new ConexionConSQL();

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'definitivo.Empleados' Puede moverla o quitarla según sea necesario.
         //   this.empleadosTableAdapter.Fill(this.definitivo.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'definitivo.Empleados' Puede moverla o quitarla según sea necesario.
            // this.empleadosTableAdapter.Fill(this.definitivo.Empleados);
            dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
            ListarDepartamento();
            Masculino.Checked = false;
            Femenino.Checked = false;
            Departamento.Text = "";
        }

        public void ListarDepartamento()
        {
            Departamento.DataSource = SQLConexion.ListarDepartamento();
            Departamento.DisplayMember = "Departamento";
            Departamento.ValueMember = "ID_Departamento";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

          

            
            try {
                if (Editar == false)
                {
                    if (NombreEmpleado.Text == "" && ApellidoEmpleado.Text == "" && CedulaEmpleado.Text == "" && Departamento.Text == "" && Masculino.Checked  == false && Femenino.Checked == false && SueldoEmpleado.Text == "" || NombreEmpleado.Text == "" || ApellidoEmpleado.Text == "" || CedulaEmpleado.Text == "" || Departamento.Text =="" || Masculino.Checked == false || Femenino.Checked == true || SueldoEmpleado.Text =="")
                    {
                        MessageBox.Show("Faltan datos para poder guardar", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SQLConexion.InsertarEmpleados(NombreEmpleado.Text, ApellidoEmpleado.Text, TelefonoEmpleado.Text, CedulaEmpleado.Text, Departamento.SelectedValue.ToString(), genero.ToString(), Convert.ToUInt32(SueldoEmpleado.Text).ToString());
                        MessageBox.Show("Insertado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
                        NombreEmpleado.Text = ApellidoEmpleado.Text = TelefonoEmpleado.Text = CedulaEmpleado.Text = Departamento.Text = SueldoEmpleado.Text = "";
                        Masculino.Checked = false;
                        Femenino.Checked = false;
                    }
                }

                if(Editar == true)
                {
                
                    
                        if (NombreEmpleado.Text == "" && ApellidoEmpleado.Text == "" && CedulaEmpleado.Text == "" && SueldoEmpleado.Text == ""|| NombreEmpleado.Text == "" || ApellidoEmpleado.Text == "" || CedulaEmpleado.Text == "" || SueldoEmpleado.Text == "")
                        {
                            MessageBox.Show("No se puede editar si existen formularios vacíos", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            SQLConexion.EditarEmpleado(NombreEmpleado.Text, ApellidoEmpleado.Text, TelefonoEmpleado.Text, CedulaEmpleado.Text, Departamento.SelectedValue.ToString(), genero.ToString(), SueldoEmpleado.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            MessageBox.Show("Editado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
                            NombreEmpleado.Text = ApellidoEmpleado.Text = TelefonoEmpleado.Text = CedulaEmpleado.Text = Departamento.Text = SueldoEmpleado.Text = textBox7.Text = "";
                             Editar = false;
                        Masculino.Checked = false;
                        Femenino.Checked = false;
                    }
                    
                       
                    
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genero = "M";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genero = "F";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editar = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NombreEmpleado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ApellidoEmpleado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TelefonoEmpleado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                CedulaEmpleado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Departamento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if ((dataGridView1.CurrentRow.Cells[6].Value.ToString() == "M"))
                {
                    Masculino.Checked = true;
                }

                else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "F"){
                    Femenino.Checked = true;
                }
                SueldoEmpleado.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            }

            else
            {
                MessageBox.Show("Selecione una fila","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = SQLConexion.FiltrarEmpleado(textBox1.Text);
            }

            else
            {
                dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de que desea eliminar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLConexion.DeshabilitarEmpleado(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
                    MessageBox.Show("Eliminado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Selecione una fila","IMPORTANTE",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.empleadosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.definitivo);

        }

        private void empleadosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.definitivo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadosDeshabilitados MostrarD = new EmpleadosDeshabilitados();
            MostrarD.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departamentos Mostrar = new Departamentos();
            Mostrar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLConexion.MostrarDatosEmpleados();
            ListarDepartamento();
            Departamento.Text = "";
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

        private void NombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CedulaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SueldoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Departamento_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Departamento_KeyPress(object sender, KeyPressEventArgs e)
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
