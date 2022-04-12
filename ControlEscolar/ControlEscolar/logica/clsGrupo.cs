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
    class clsGrupo
    {
        public static bool GuardarGrupos(objGrupos pobjGrupos)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into grupo (IdGrupo, NombreGrupo) values ('{0}','{1}')", pobjGrupos.Idgrupo, pobjGrupos.NombreGrupo), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objGrupos> Buscar(string pNombreGrupo)
        {
            List<objGrupos> _lista = new List<objGrupos>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdGrupo, NombreGrupo from grupo where NombreGrupo = '{0}'", pNombreGrupo), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objGrupos pobjGrupos = new objGrupos();
                pobjGrupos.Idgrupo = Dr.GetInt32(0);
                pobjGrupos.NombreGrupo = Dr.GetString(1);

                _lista.Add(pobjGrupos);
            }
            return _lista;

        }

        public static objGrupos ObtenerGrupo(int pIdGrupo)
        {
            objGrupos pobjGrupos = new objGrupos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdGrupo, NombreGrupo from grupo where IdGrupo = '{0}'", pIdGrupo), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjGrupos.Idgrupo = Dr.GetInt32(0);
                pobjGrupos.NombreGrupo = Dr.GetString(1);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjGrupos;
        }

        public static bool Actualizar(objGrupos pobjGrupos)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("update grupo set NombreGrupo = '{0}' where IdGrupo = '{1}'", pobjGrupos.NombreGrupo, pobjGrupos.Idgrupo), Cnn);
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
    }
}
