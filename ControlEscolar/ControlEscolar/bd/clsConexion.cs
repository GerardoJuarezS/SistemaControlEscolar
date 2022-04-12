using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
namespace ControlEscolar.bd
{
    public class clsConexion
    {
        public static MySqlConnection BaseDeDatos()
        {
            MySqlConnection conectar = new MySqlConnection("server=URL; database=basededatos;user=usuario;pwd=contraseña; max pool size=2048");
            try
            {
                conectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
            return conectar;
        }

    }
}
