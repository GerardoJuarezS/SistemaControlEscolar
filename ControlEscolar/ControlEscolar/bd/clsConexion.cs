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
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=cobao;user=root;pwd=1990-2014; max pool size=2048");
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
