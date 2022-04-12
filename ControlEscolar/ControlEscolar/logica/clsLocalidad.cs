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
    public class clsLocalidad
    {
        public static bool GuardarLocalidad(objLocalidad pobjLocalidad)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into localidad (NombreLocalidad, IdMunicipio) VALUES ('{0}','{1}')", pobjLocalidad.NombreLocalidad, pobjLocalidad.IdMunicipio), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Entrada Duplicada" + e);

            }
            Cnn.Close();
            return resultado;
        }
    }
}
