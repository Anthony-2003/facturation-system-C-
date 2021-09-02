using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication9
{
    class ConexionConSQL
    {
        string Conexion = "Data Source=A19A66906\\SQLEXPRESS; Initial Catalog=Programa;Integrated Security=True";
        public SqlConnection Conectar = new SqlConnection();
        private DataSet DS;
        int u = 0;
      

        public ConexionConSQL()
        {
            Conectar.ConnectionString = Conexion;

        }

        public void Abrir()
        {
            try
            {
                if (Conectar.State == ConnectionState.Closed)
                {
                    Conectar.Open();
                }


            }
            catch (Exception ERROR)
            {
                Console.Write(ERROR.Message);
            }
        }

        public void Cerrar()
        {
            if (Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
        }


        public bool Login(string usuario, string Contraseña)
        {
            Conectar.Open();
            using (var comandos = new SqlCommand())
            {
                comandos.Connection = Conectar;
                comandos.CommandText = ("SELECT * FROM Usuarios INNER JOIN Empleados ON Usuarios.ID_Empleado = Empleados.ID_Empleado WHERE Usuarios.Usuario = @Usuario and Usuarios.Contraseña = @Contraseña");
                comandos.Parameters.AddWithValue("@Usuario", usuario);
                //tranquilo
                comandos.Parameters.AddWithValue("@Contraseña", Contraseña);
                comandos.Parameters.AddWithValue("@Id_Usuario", ClassLibrary1.Tipodeusuario.Id_Usuario);
//l?  que ? XDD nanana
                comandos.CommandType = CommandType.Text;
                SqlDataReader SDA = comandos.ExecuteReader();

                if (SDA.HasRows)
                //pero cual nombre dices?  has dicho algo? xd no cuando entras al programa, arriba sale el nombre de usuario eso xd a no eso es facil bueno sigue xd ok 
                {

                    while (SDA.Read()) {

                        ClassLibrary1.Tipodeusuario.Id_Usuario = SDA.GetInt32(0);

                        ClassLibrary1.Tipodeusuario.Usuario = SDA.GetString(1);
                        ClassLibrary1.Tipodeusuario.Tipo_usuario = SDA.GetString(4);

                        ClassLibrary1.Tipodeusuario.Contraseña = SDA.GetString(2);
                        (ClassLibrary1.Tipodeusuario.Id_Empleado = (SDA.GetInt32(6))).ToString();
                        ClassLibrary1.Tipodeusuario.Nombre = SDA.GetString(7);
                        ClassLibrary1.Tipodeusuario.Apellido = SDA.GetString(8);
                        //vamos con los permisos ahora ok



                    }
                    return true;
                    // voy al baño pera tt

                }
                else
                {
                    return false;
                }
            }
        }
       
        public DataTable MostrarDatos()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Cliente, NombreC, Apellido,Teléfono,Dirección FROM Clientes WHERE Estado = 'Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        

        public bool Insertar(string Nombre, string Apellido, string Teléfono, string Dirección)
        {
            Conectar.Open();
            SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO Clientes VALUES ('{0}', '{1}', '{2}', '{3}','Habilitado')", new string[] { Nombre, Apellido, Teléfono, Dirección }), Conectar);
            int rowsafectadas = Comando.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }

        public bool Deshabilitar(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Clientes SET Estado='Deshabilitado' WHERE ID_Cliente = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool InsertarProveedor(string Nombre, string Apellido,string Empresa,string Teléfono,string Dirección)
        {
            Conectar.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Proveedor VALUES('{0}','{1}','{2}','{3}','{4}','Habilitado')", new string[] {Nombre,Apellido,Empresa,Teléfono,Dirección }),Conectar);
            int rowsafectadas = comando.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable BuscarProveedor(string Nombre, string Empresa)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Proveedor,Nombre_Proveedor,Apellido_Proveedor,Empresa,Teléfono,Dirección FROM Proveedor WHERE Nombre_Proveedor like '{0}%' or Empresa like '{1}%' and Estado='Habilitado'", Nombre, Empresa), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable BuscarProveedorDeshabilitado(string Nombre, string Empresa)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Proveedor,Nombre_Proveedor,Apellido_Proveedor,Empresa,Teléfono,Dirección FROM Proveedor WHERE Estado = 'Deshabilitado' and  Nombre_Proveedor like '{0}%' or Empresa like '{1}%' ", Nombre, Empresa), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool ActualizarProveedor(string Nombre,string Apellido,string Empresa, string Teléfono,string Dirección,string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Proveedor SET Nombre_Proveedor='{0}',Apellido_Proveedor='{1}',Empresa='{2}',Teléfono='{3}',Dirección='{4}' WHERE ID_Proveedor={5}", new string[] { Nombre, Apellido, Empresa, Teléfono, Dirección, ID }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
            
        }

     /*   public bool Eliminar(string ID)
        {
            Conectar.Open();
            SqlCommand Comando = new SqlCommand(string.Format("DELETE FROM Clientes WHERE ID_Cliente = {0}", ID), Conectar);
            int rowsafectadas = Comando.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }*/
        public DataTable Buscar(string nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Cliente, NombreC, Apellido, Teléfono, Dirección FROM Clientes WHERE NombreC like '{0}%' and Estado='Habilitado'", nombre), Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

       

        public bool Actualizar(string ID_Cliente, string Nombre, string Apellido, string Teléfono, string Dirección)
        {
            Conectar.Open();
            SqlCommand Comando = new SqlCommand(string.Format("UPDATE Clientes set NombreC = '{0}', Apellido = '{1}', Teléfono = '{2}', Dirección = '{3}' WHERE ID_Cliente = {4}", new string[] { Nombre, Apellido, Teléfono, Dirección, ID_Cliente }), Conectar);
            int rowsafectadas = Comando.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }

      
        public bool InsertarDetalleFactura(string ID_Factura, string ID_Producto,string Cantidad_PF, string Precio_U,string Total)
        {
            Conectar.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Detalle_Factura Values({0},{1},{2},{3},{4})", new string[] { ID_Factura, ID_Producto, Cantidad_PF, Precio_U, Total }), Conectar);
            int rowsafectadas = comando.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

       

        public DataTable MostrarDatosProductos()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Producto, Nombre as Descripción, Precio, Cantidad, Categoria.Categoria as Categoría, Proveedor.Empresa FROM Producto inner join Categoria ON Categoria.ID_Categoria = Producto.ID_Categoria inner join Proveedor ON Proveedor.ID_Proveedor = Producto.ID_Proveedor WHERE Producto.Estado = 'Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }
  
        public bool InsertarProductos(string Nombre,string Precio, string Cantidad, string Categoria, string Proveedor)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Producto VALUES('{0}', {1},{2}, {3}, {4},'Habilitado')", new string[] { Nombre, Precio, Cantidad, Categoria, Proveedor }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }


        public DataTable ProductosDeshabilitados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Producto, Nombre as Descripción, Precio, Cantidad, Categoria.Categoria as Categoría, Proveedor.Empresa FROM Producto inner join Categoria ON Categoria.ID_Categoria = Producto.ID_Categoria inner join Proveedor ON Proveedor.ID_Proveedor = Producto.ID_Proveedor WHERE Producto.Estado = 'Deshabilitado'",Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
            
        }

        public bool HabilitarProducto(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Producto SET Estado='Habilitado' WHERE ID_Producto={0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }



        public DataTable BuscarProductoDeshabilitado(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select ID_Producto, Nombre as Descripción, Cantidad, Precio, Categoria.Categoria, Proveedor.Empresa FROM Producto INNER JOIN Categoria on Producto.ID_Categoria = Categoria.ID_Categoria INNER JOIN Proveedor ON Producto.ID_Proveedor = Proveedor.ID_Proveedor WHERE Nombre like '{0}%' and Producto.Estado='Deshabilitado'", Nombre), Conectar);
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            DS = new DataSet();
            SDA.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool DeshabilitarProducto(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Producto SET Estado='Deshabilitado' WHERE ID_Producto={0}",ID),Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool EditarProducto(string Nombre, string Precio, string Cantidad, string Categoria, string Proveedor,string ID)
        {
            Conectar.Open();
            SqlCommand CMD = new SqlCommand(string.Format("UPDATE Producto SET Nombre='{0}',Precio={1},Cantidad={2},ID_Categoria={3},ID_Proveedor={4} WHERE ID_Producto={5}", new string[] { Nombre, Precio, Cantidad, Categoria, Proveedor, ID }),Conectar);
            int rowsafectadas = CMD.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable BuscarProducto(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select ID_Producto, Nombre as Descripción, Cantidad, Precio, Categoria.Categoria, Proveedor.Empresa FROM Producto INNER JOIN Categoria on Producto.ID_Categoria = Categoria.ID_Categoria INNER JOIN Proveedor ON Producto.ID_Proveedor = Proveedor.ID_Proveedor WHERE Nombre like '{0}%' and Producto.Estado='Habilitado'", Nombre), Conectar);
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            DS = new DataSet();
            SDA.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool DeshabilitarProveedor(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Proveedor SET Estado='Deshabilitado' WHERE ID_Proveedor={0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
            
        }

        public DataTable MostrarDepartamentos()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Departamento, Departamento FROM Departamento WHERE Estado='Habilitado'", Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable BuscarDepartamentos(string Departamento)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Departamento, Departamento FROM Departamento WHERE Estado='Habilitado' and Departamento like '{0}%'", Departamento), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"]; 
        }

        public bool InsertarDepartamento(string Departamento)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Departamento(Departamento, Estado) VALUES ('{0}','Habilitado')", new string[] { Departamento }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool EditarDepartamento(string Nombre, string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Departamento SET Departamento='{0}' WHERE ID_Departamento = {1}", Nombre, ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }

        public bool DeshabilitarDepartamento(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Departamento SET Estado='Deshabilitado' WHERE ID_Departamento = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }


        public DataTable MostrarCategorias()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Categoria, Categoria as Categoría FROM Categoria WHERE Estado = 'Habilitado'",Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool InsertarCategoria(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Categoria VALUES('{0}','Habilitado')", Nombre), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable MostrarCategoriasDeshabilitadas()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Categoria, Categoria as Categoría FROM Categoria WHERE Estado = 'Deshabilitado'"), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }


        public bool HabilitarCategoria(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Categoria SET Estado = 'Habilitado' WHERE ID_Categoria = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable BuscarCategoriasDeshabilitadas(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Categoria, Categoria as Categoría FROM Categoria WHERE Estado = 'Deshabilitado' AND Categoria like '{0}%'", Nombre), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS,"tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable BuscarCategoria(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select ID_Categoria, Categoria FROM Categoria WHERE Estado = 'Habilitado' and Categoria like '{0}%'", Nombre), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }
        public bool DeshabilitarCategoria(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Categoria SET Estado = 'Deshabilitado' WHERE ID_Categoria = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool EditarCategoria(string Nombre, string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Categoria SET Categoria = '{0}' WHERE ID_Categoria = {1}",Nombre,ID ), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool HabilitarDepartamento(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Departamento SET Estado = 'Habilitado' WHERE ID_Departamento  = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable BuscarDepartamentoDeshabilitado(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Departamento, Departamento FROM Departamento WHERE Estado = 'Deshabilitado' and Departamento like '{0}%'",Nombre),Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable MostrarDepartamentosDeshabilitados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Departamento, Departamento FROM Departamento WHERE Estado = 'Deshabilitado'", Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool HabilitarProveedor(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Proveedor SET Estado='Habilitado' WHERE ID_Proveedor={0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;

        }

        public DataTable MostrarDatosProveedorDeshabilitado()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Proveedor,Nombre_Proveedor,Apellido_Proveedor, Empresa, Teléfono,Dirección FROM Proveedor WHERE Estado='Deshabilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }


        public DataTable MostrarDatosProveedor()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Proveedor,Nombre_Proveedor,Apellido_Proveedor, Empresa, Teléfono,Dirección FROM Proveedor WHERE Estado='Habilitado'", Conectar);                               
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }




        public DataTable MostrarDatosEmpleados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Empleado, Nombre, Apellido, Teléfono, Cédula, Departamento.Departamento AS Departamento, Sexo, Sueldo FROM Empleados INNER JOIN Departamento ON Empleados.ID_Departamento = Departamento.ID_Departamento WHERE Empleados.Estado='Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable ClientesDeshabilitados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Cliente, NombreC, Apellido, Teléfono, Dirección FROM Clientes WHERE Estado='Deshabilitado'",Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable BuscarClientesDeshabilitados(string ID_Cliente)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Cliente, NombreC, Apellido, Teléfono, Dirección from Clientes WHERE NombreC like '{0}%' and Estado = 'Deshabilitado'",ID_Cliente),Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable EmpleadosDeshabilitados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Empleado, Nombre, Apellido, Teléfono, Cédula, Departamento.Departamento, Sexo, Sueldo FROM Empleados INNER JOIN Departamento ON Empleados.ID_Departamento = Departamento.ID_Departamento WHERE Empleados.Estado = 'Deshabilitado'", Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable BuscarEmpleadoDeshabilitado(string Nombre)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ID_Empleado, Nombre, Apellido, Teléfono, Cédula, Departamento.Departamento, Sexo, Sueldo FROM Empleados INNER JOIN Departamento ON Empleados.ID_Departamento = Departamento.ID_Departamento WHERE Empleados.Nombre like '{0}%' and Empleados.Estado = 'Deshabilitado'", Nombre), Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS,"tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool  HabilitarEmpleado(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Empleados set Estado='Habilitado' WHERE ID_Empleado = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool HabilitarCliente(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Clientes set Estado = 'Habilitado' WHERE ID_Cliente ={0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public DataTable ListCategoria()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria where Categoria.Estado = 'Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable ListProveedor()
        {
            
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedor WHERE Estado = 'Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }
        
        public bool InsertarFactura(string Cliente, string Empleado, string Fecha)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Factura VALUES({0},{1},'{2}')", new string[] { Cliente, Empleado, Fecha }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
           Conectar.Close();
            if (rowsafectadas > 0) return true;           
            else return false;
            

        }

        public DataTable ListarEmpleados()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados",Conectar);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DS = new DataSet();
            sda.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public bool InsertarEmpleados(string Nombre, string Apellido, string Teléfono, string Cedula, string Departamento, string Sexo, string Sueldo)
        {
            Conectar.Open();
            SqlCommand CMD = new SqlCommand(string.Format("INSERT INTO Empleados VALUES('{0}', '{1}','{2}','{3}', {4},'{5}',{6},'Habilitado')", new string[] { Nombre, Apellido, Teléfono, Cedula, Departamento, Sexo, Sueldo }),Conectar);
            int rowsafectadas = CMD.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool DeshabilitarEmpleado(string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Empleados set Estado='Deshabilitado' WHERE ID_Empleado = {0}", ID), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public bool EditarEmpleado(string Nombre,string Apellido,string Teléfono, string Cédula,string Departamento,string Sexo,string Sueldo,string ID)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Empleados SET Nombre='{0}',Apellido='{1}',Teléfono='{2}',Cédula='{3}',ID_Departamento={4},Sexo='{5}',Sueldo={6} WHERE ID_Empleado={7}", new string[] { Nombre, Apellido, Teléfono, Cédula, Departamento, Sexo, Sueldo,ID }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

        public string AumentarCompra()
        {

            Conectar.Open();
                SqlCommand cmd = new SqlCommand("SELECT(SELECT distinct top 1 ID_Compra FROM Compras order by ID_Compra desc) + 1 as ID_Compra",Conectar);
                
                SqlDataReader leer = cmd.ExecuteReader();
                 if (leer.Read())
                {
                
                return leer["ID_Compra"].ToString();
             
               
                 }

            else
            {

                return null;
                
            }

               

            }
        
              
            
            
            
        
        

        public DataTable FiltrarEmpleado(string Nombre)
        {
            Conectar.Open();
            SqlCommand CMD = new SqlCommand(string.Format("SELECT ID_Empleado, Nombre, Apellido, Teléfono, Cédula, Departamento.Departamento AS Departamento, Sexo, Sueldo FROM Empleados INNER JOIN Departamento ON Empleados.ID_Departamento = Departamento.ID_Departamento WHERE Empleados.Estado = 'Habilitado' and Nombre like '{0}%'", Nombre), Conectar);
            SqlDataAdapter SDA = new SqlDataAdapter(CMD);
            DS = new DataSet();
            SDA.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

        public DataTable ListarDepartamento()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Departamento Where Departamento.Estado='Habilitado'", Conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DS = new DataSet();
            ad.Fill(DS, "tabla");
            Conectar.Close();
            return DS.Tables["tabla"];
        }

       

     public string AumentarFac()
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand("SELECT(SELECT DISTINCT TOP 1 ID_Factura FROM Factura order by ID_Factura desc) + 1 as ID_Factura", Conectar);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                return leer["ID_Factura"].ToString();
            }
            else
            {
                return null;
            }
            Conectar.Close();
           
          
          
            
        }

        public bool InsertarDetalle_Compra(string ID_Compra, string ID_Producto, string Cantidad, string Precio, string Total)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Detalle_Compra VALUES({0},{1},{2},{3},{4})", new string[] { ID_Compra, ID_Producto, Cantidad, Precio, Total }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
        }

    


        public bool InsertarCompra(string Fecha, string ID_Proveedor)
        {
            Conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Compras VALUES ('{0}',{1})", new string[] { Fecha, ID_Proveedor }), Conectar);
            int rowsafectadas = cmd.ExecuteNonQuery();
            Conectar.Close();
            if (rowsafectadas > 0) return true;
            else return false;
          
        }

        public void tipoUsuario()
        {
            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Administrador)
            {

            }
            if (ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Ventas || ClassLibrary1.Tipodeusuario.Tipo_usuario == ClassLibrary1.Usuario.Almacen)
            {

            }
        }

     
     

    }

    
}

