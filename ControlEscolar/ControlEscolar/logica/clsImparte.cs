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
    class clsImparte
    {
        public static bool GuardarImparte(objImparte pobjImparte)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into imparte (Rfc, CodigoMaterias) values ('{0}','{1}')", pobjImparte.Rfc, pobjImparte.CodigoMaterias), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception ee)
            {
                MessageBox.Show("Entrada Duplicada" + ee);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objImparte> BuscarImparte(string pRfc)
        {
            List<objImparte> _lista = new List<objImparte>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select imparte.IdImparte, imparte.CodigoMaterias, imparte.Rfc, materias.CodigoMaterias, materias.UAC from materias, imparte where rfc = '{0}'  and imparte.CodigoMaterias = materias.CodigoMaterias", pRfc), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objImparte pobjImparte = new objImparte();
                pobjImparte.IdImparte = Dr.GetInt32(0);
                pobjImparte.CodigoMaterias = Dr.GetInt32(1);
                pobjImparte.Rfc = Dr.GetString(2);
                pobjImparte.UAC = Dr.GetString(4);
                _lista.Add(pobjImparte);
            }
            return _lista;

        }

        public static objImparte ObtenerImparte(int pIdImparte)
        {
            objImparte pobjImparte = new objImparte();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select imparte.IdImparte, imparte.CodigoMaterias, imparte.Rfc, materias.UAC from materias, imparte where imparte.IdImparte = '{0}' and imparte.CodigoMaterias = materias.CodigoMaterias", pIdImparte), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjImparte.IdImparte = Dr.GetInt32(0);
                pobjImparte.CodigoMaterias = Dr.GetInt32(1);
                pobjImparte.Rfc = Dr.GetString(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjImparte;
        }

        public static bool ActualizarImparte(objImparte pobjImparte)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("UPDATE imparte SET CodigoMaterias='{0}' WHERE IdImparte='{1}'", pobjImparte.CodigoMaterias, pobjImparte.IdImparte), Cnn);
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

        public static bool EliminarImparte(int pIdImparte)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM imparte WHERE IdImparte='{0}'", pIdImparte), Cnn);
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
