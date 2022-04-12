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
    class clsAlumnoSemestre
    {
        public static bool GuardarAlumnoSemestre(objAlumnoSemestre pobjAlumnoSemestre)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnosemestre (Matricula, IdSemestre) values ('{0}','{1}')", pobjAlumnoSemestre.Matricula, pobjAlumnoSemestre.IdSemestre), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Entrada Duplicada"+ e);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objAlumnoSemestre> BuscarAlumnoSemestre(string pMatricula, Int32 pSemestre)
        {
            List<objAlumnoSemestre> _lista = new List<objAlumnoSemestre>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select idAlumnoSemestre, Matricula, idsemestre from AlumnoSemestres where Matricula = '{0}' or idsemestre = '{1}'", pMatricula, pSemestre), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlumnoSemestre pobjAlumnoSemestre = new objAlumnoSemestre();
                pobjAlumnoSemestre.IdAlumnoSemestre = Dr.GetInt32(0);
                pobjAlumnoSemestre.Matricula = Dr.GetString(1);
                pobjAlumnoSemestre.IdSemestre = Dr.GetInt32(2);
                _lista.Add(pobjAlumnoSemestre);
            }
            return _lista;
        }

        public static objAlumnoSemestre ObtenerAlumnoSemestre(int pIdAlumnoSemestree)
        {
            objAlumnoSemestre pobjAlumnoSemestre = new objAlumnoSemestre();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select idAlumnoSemestre, Matricula, idsemestre from AlumnoSemestres where idAlumnoSemestre = '{0}'", pIdAlumnoSemestree), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlumnoSemestre.IdAlumnoSemestre = Dr.GetInt32(0);
                pobjAlumnoSemestre.Matricula = Dr.GetString(1);
                pobjAlumnoSemestre.IdSemestre = Dr.GetInt32(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjAlumnoSemestre;
        }

        public static bool ActualizarAlumnoSemestre(objAlumnoSemestre pobjAlumnoSemestre)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update AlumnoSemestre set Matricula = '{0}', idsemestre = '{1}' where IdAlumnoSemestre = '{2}'", pobjAlumnoSemestre.Matricula, pobjAlumnoSemestre.IdSemestre, pobjAlumnoSemestre.IdAlumnoSemestre), Cnn);
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
