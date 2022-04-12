using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using System.Windows.Forms;
namespace ControlEscolar.logica
{
   public class clsInicioSesion
    {
        public static bool IniciarSesion(objUsuarios pobjUsuarios, objGrupoUsuario pobjGrupoUsuario)
        {
            bool rtn = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select * from usuarios,grupousuario where nombreusuario = '{0}' and contraseña = '{1}' and grupousuario.NombreGrupoUsuario = '{2}' and usuarios.IdGrupoUsuario = grupousuario.IdGrupoUsuario", pobjUsuarios.NombreUsuario, pobjUsuarios.Contraseña, pobjGrupoUsuario.NombreGrupoUsuario), Cnn);
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                rtn = true;
            }
            Cnn.Close();
            return rtn;
        }
        
    }
}
