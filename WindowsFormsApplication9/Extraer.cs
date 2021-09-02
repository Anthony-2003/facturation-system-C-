using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    
   public class Extraer
    {
        ConexionConSQL neta = new ConexionConSQL();

        public bool Login(string usuario, string contraseña)
        {
            return neta.Login(usuario, contraseña);
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
