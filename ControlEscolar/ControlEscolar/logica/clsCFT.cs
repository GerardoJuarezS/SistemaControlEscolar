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
    public class clsCFT
    {
        public static bool GuardarCFT(objCFT pobjCFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into cft (Nombre) VALUES ('{0}')", pobjCFT.NombreCFT), Cnn);
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

        public static List<objCFT> BuscarCFT(string NombreCFT)
        {
            List<objCFT> _lista = new List<objCFT>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select Id_CFT, Nombre from cft where Nombre = '{0}'", NombreCFT), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                objCFT pobjCFT = new objCFT();
                pobjCFT.IdCFT = Dr.GetInt32(0);
                pobjCFT.NombreCFT = Dr.GetString(1);
                _lista.Add(pobjCFT);
            }
            return _lista;
        }

        public static objCFT ObtenerCFT(int pId_CFT)
        {
            objCFT pobjCFT = new objCFT();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select Id_CFT, Nombre from cft where Id_CFT = '{0}'", pId_CFT), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjCFT.IdCFT = Dr.GetInt32(0);
                pobjCFT.NombreCFT = Dr.GetString(1);
            }
            clsConexion.BaseDeDatos().Close();
            return pobjCFT;
        }

        public static bool ActualizarCFT(objCFT pobjCFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update cft set Nombre = '{0}' where Id_CFT = '{1}'", pobjCFT.NombreCFT,pobjCFT.IdCFT), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
                Cnn.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Error" + ee);
            }

            return resultado;
        }

        public static bool EliminarCFT(int pId_CFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM cft WHERE Id_CFT='{0}'", pId_CFT), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar" + e);

            }
            Cnn.Close();
            return resultado;
        }
    }
}
