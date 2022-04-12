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
    class clsAlumnoAlergia
    {
        public static int GuardarAlumnoAlergia(objAlumnoAlergia pobjAlumnoAlergia)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnoalergia (IdAlergias, Matricula) values ('{0}','{1}')", pobjAlumnoAlergia.IdAlergia, pobjAlumnoAlergia.Matricula), Cnn);
            try
            {
                resultado = Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Entrada Duplicada" + e);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objAlumnoAlergia> BuscarAlumnoAlergia(string pMatricula)
        {
            List<objAlumnoAlergia> _lista = new List<objAlumnoAlergia>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoAlergia, IdAlergias, Matricula from alumnoalergia where Matricula = '{0}'", pMatricula), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlumnoAlergia pobjAlumnoAlergia = new objAlumnoAlergia();
                pobjAlumnoAlergia.IdAlumnoAlergia = Dr.GetInt32(0);
                pobjAlumnoAlergia.IdAlergia = Dr.GetInt32(1);
                pobjAlumnoAlergia.Matricula = Dr.GetString(2);

                _lista.Add(pobjAlumnoAlergia);
            }
            return _lista;

        }

        public static objAlumnoAlergia ObtenerAlumnoAlergia(int pIdAlumnoAlergia)
        {
            objAlumnoAlergia pobjAlumnoAlergia = new objAlumnoAlergia();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoAlergia, IdAlergias, Matricula from alumnoalergia where IdAlumnoAlergia = '{0}'", pIdAlumnoAlergia), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlumnoAlergia.IdAlumnoAlergia = Dr.GetInt32(0);
                pobjAlumnoAlergia.IdAlergia = Dr.GetInt32(1);
                pobjAlumnoAlergia.Matricula = Dr.GetString(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjAlumnoAlergia;
        }

        public static bool ActualizarAlumnoAlergia(objAlumnoAlergia pobjAlumnoAlergia)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alumnoalergia set IdAlergias = '{0}' where IdAlumnoAlergia = '{1}'", pobjAlumnoAlergia.IdAlergia, pobjAlumnoAlergia.IdAlumnoAlergia), Cnn);
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

        public static bool EliminarAlumnoAlergia(int pIdAlumnoAlergia)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM alumnoAlergia WHERE IdAlumnoAlergia='{0}'", pIdAlumnoAlergia), Cnn);
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
