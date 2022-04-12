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
    class clsProfesiones
    {
        public static int GuardarProfesion(objProfesiones pobjProfesiones)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into profesiones (NombreProfesion) values ('{0}')", pobjProfesiones.NombreProfesion), Cnn);
            try
            {
                resultado = Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool ActualizarProfesion(objProfesiones pobjProfesiones)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update profesiones set NombreProfesion = '{0}' where NombreProfesion = '{1}'", pobjProfesiones.NombreProfesion, pobjProfesiones.NombreProfesion), Cnn);

            resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            Cnn.Close();
            return resultado;
        }
    }
}
