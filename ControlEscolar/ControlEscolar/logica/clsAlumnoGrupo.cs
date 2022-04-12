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
    class clsAlumnoGrupo
    {
        public static bool GuardarAlumnoGrupo(objAlumnoGrupo pobjAlumnoGrupo)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnogrupo (Matricula, IdGrupo) values ('{0}','{1}')", pobjAlumnoGrupo.Matricula, pobjAlumnoGrupo.IdGrupo), Cnn);
            try
            {
                resultado = Convert.ToBoolean( Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Entrada Duplicada" + e);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objAlumnoGrupo> BuscarAlumnoGrupo(string pMatricula)
        {
            List<objAlumnoGrupo> _lista = new List<objAlumnoGrupo>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoGrupo, Matricula, IdGrupo from alumnogrupo where Matricula = '{0}'", pMatricula), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlumnoGrupo pobjAlumnoGrupo = new objAlumnoGrupo();
                pobjAlumnoGrupo.IdAlumnoGrupo = Dr.GetInt32(0);
                pobjAlumnoGrupo.Matricula = Dr.GetString(1);
                pobjAlumnoGrupo.IdGrupo = Dr.GetInt32(2);

                _lista.Add(pobjAlumnoGrupo);
            }
            return _lista;
        }

        public static objAlumnoGrupo ObtenerAlumnoGrupo(int pIdAlumnoGrupoo)
        {
            objAlumnoGrupo pobjAlumnoGrupo = new objAlumnoGrupo();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoGrupo, Matricula, IdGrupo from alumnogrupo where IdAlumnoGrupo = '{0}'", pIdAlumnoGrupoo), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlumnoGrupo.IdAlumnoGrupo = Dr.GetInt32(0);
                pobjAlumnoGrupo.Matricula = Dr.GetString(1);
                pobjAlumnoGrupo.IdGrupo = Dr.GetInt32(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjAlumnoGrupo;
        }

        public static bool ActualizarAlumnoGrupo(objAlumnoGrupo pobjAlumnoGrupo)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alumnogrupo set Matricula = '{0}', IdGrupo = '{1}' where IdAlumnoGrupo = '{2}'", pobjAlumnoGrupo.Matricula, pobjAlumnoGrupo.IdGrupo,pobjAlumnoGrupo.IdAlumnoGrupo), Cnn);
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

        public static bool EliminarAlumnoGrupo(int pIdAlumnoGrupo)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM alumnogrupo WHERE IdAlumnoGrupo='{0}'", pIdAlumnoGrupo), Cnn);
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
