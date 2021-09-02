using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class LOGIN : Form
    {
        //voy hacer algo que a mi mefun ok mi novio, pero si no te funciona utlizamos el mismo metodo que el mio y ya ok xdxdciono
        public LOGIN()
        {
            InitializeComponent();
        }
        ConexionConSQL AbrirXD = new ConexionConSQL();
        MenuPrincipal_beta_ MenuPrincipal = new MenuPrincipal_beta_();
        public string Usuario;
        public string Contraseña;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUARIO";


            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "CONTRASEÑA")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.Black;



            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "CONTRASEÑA";
                textBox2.UseSystemPasswordChar = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "USUARIO")
            {
                MessageBox.Show("Introduzca su nombre de usuario.");
            }

            else if (textBox2.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Introduzca su contraseña");
            }

            
            if(textBox1.Text!= "USUARIO"){
                if(textBox2.Text!="CONTRASEÑA"){

                    Extraer Tu = new Extraer();
                    var Loginn = Tu.Login(textBox1.Text, textBox2.Text);
                    if(Loginn==true){

                        MessageBox.Show("Welcome");
                        MenuPrincipal_beta_ acceder = new MenuPrincipal_beta_();
                        this.Hide();

                        acceder.Show();
                        

                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos.");
                    }

                }

            }



            /*Cache klkw = new Cache();
            Usuario = textBox1.Text;
            Contraseña = textBox2.Text;
            ConexionConSQL Logear = new ConexionConSQL();
            MenuPrincipal_beta_ ne = new MenuPrincipal_beta_();
            Logear.Abrir(); no coño donde tu hciste tu HAHAHAhah 
            SqlCommand ProXD = new SqlCommand("SELECT Empleados.ID_Empleado, Empleados.Nombre, Empleados.Apellido FROM Usuarios INNER JOIN Empleados ON Usuarios.ID_Empleado = Empleados.ID_Empleado WHERE Usuarios.Usuario = @Usuario and Usuarios.Contraseña = @Contraseña", Logear.Conectar);
            ProXD.Parameters.AddWithValue("Usuario", Usuario);
            ProXD.Parameters.AddWithValue("Contraseña", Contraseña);

            SqlDataReader klk = ProXD.ExecuteReader();
            if (klk.Read())
            {
                Cachek.ID = Convert.ToString(klk["ID_Empleado"]);
               Cachek.Nombre = Convert.ToString(klk["Nombre"]);
                Cachek.Apellido = Convert.ToString(klk["Apellido"]);
            }
            Logear.Cerrar();
            LogearP(this.textBox1.Text, this.textBox2.Text);*/
            
            







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        public void LogearP(string Usuario, string Contraseña)
        {


            //busca donde haces las consultas
          /*  try
            {
                AbrirXD.Abrir();//Coje el valor de ahi: ya veo 
                SqlCommand ProXD = new SqlCommand("SELECT Usuarios.Usuario,Usuarios.Tipo_Usuario, Usuarios.Contraseña, Empleados.Nombre FROM Usuarios INNER JOIN Empleados ON Usuarios.ID_Empleado = Empleados.ID_Empleado WHERE Usuarios.Usuario = @Usuario and Usuarios.Contraseña = @Contraseña", AbrirXD.Conectar);
                ProXD.Parameters.AddWithValue("Usuario", Usuario);
                ProXD.Parameters.AddWithValue("Contraseña", Contraseña);
                SqlDataAdapter SDA = new SqlDataAdapter(ProXD);
                DataTable DT = new DataTable();
                SDA.Fill(DT);

                if (DT.Rows.Count == 1)
                {
                    
                    if (DT.Rows[0][1].ToString() == "Administrador")
                    { 
                        //intnetaras algo mas? :O o bueno xd, croe que la consulta no ta asiemdo efeto eso iba a ver ahora compai k nada sigue HAHAHAH ño
                        MessageBox.Show("Welcome");
                        MenuPrincipal_beta_ acceder = new MenuPrincipal_beta_();
                        this.Hide();

                        acceder.Show();
                     

                        //Jonas :O
                        //lo probaste con el admin?   con ese no xdd pero ese tiene acceso a todo  but vamoa probar  
                        //una pregunta solo el de esa pantalla no te funciona o es en todas?  no he probado en las otras xd  mira ve prueba revisalo todos ok xd
                    }
         //coño me falta algo y no se que es diache :(
         //tu puedes hacer esta consulta en otro lado? NOse en verdad XDD la de loguearse crees que puedes?  vamo a inventar espera que yo se hacerlo pero te toy preguntado si puedes si  HAHaha hazlo tu HAHAHAHAH ahahahahaha ok

                     
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos.");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                AbrirXD.Cerrar();
            }
            Usuario = textBox1.Text;
            Contraseña = textBox2.Text;*/

        }


        private void LOGIN_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }
    }
    //MainMenu acceder = new MainMenu();
      //      this.Hide();
    //acceder.Show();
    }

