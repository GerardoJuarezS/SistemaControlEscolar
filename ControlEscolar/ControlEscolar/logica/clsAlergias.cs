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
    public class clsAlergias
    {
        public static bool GuardarAlergia(objAlergias pobjAlergias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alergias (`NombreAlergia`) VALUES ('{0}')", pobjAlergias.NombreAlergia), Cnn);
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

        public static List<objAlergias> BuscarAlergia(string pNombreAlergia)
        {
            List<objAlergias> _lista = new List<objAlergias>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlergias, NombreAlergia from alergias where NombreAlergia = '{0}'", pNombreAlergia), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlergias pobjBusquedaAlergia = new objAlergias();
                pobjBusquedaAlergia.IdAlergias = Dr.GetInt32(0);
                pobjBusquedaAlergia.NombreAlergia = Dr.GetString(1);

                _lista.Add(pobjBusquedaAlergia);
            }
            return _lista;

        }

        public static objAlergias ObtenerAlergia(int pIdAlergia)
        {
            objAlergias pobjAlergias = new objAlergias();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlergias, NombreAlergia from alergias where IdAlergias = '{0}'", pIdAlergia), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlergias.IdAlergias = Dr.GetInt32(0);
                pobjAlergias.NombreAlergia = Dr.GetString(1);
            }
            clsConexion.BaseDeDatos().Close();
            return pobjAlergias;
        }

        public static bool ActualizarAlergia(objAlergias pobjAlergias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alergias set NombreAlergia = '{0}' where IdAlergias = '{1}'", pobjAlergias.NombreAlergia, pobjAlergias.IdAlergias), Cnn);
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

        public static bool EliminarAlergia (int pIdAlergia)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM alergias WHERE IdAlergias='{0}'", pIdAlergia), Cnn);
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