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
    class clsAlumnoEnfermedad
    {
        public static int GuardarAlumnoEnfermedad(objAlumnoEnfermedad pobjAlumnoEnfermedad)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnoenfermedad (IdEnfermedad, Matricula) values ('{0}','{1}')", pobjAlumnoEnfermedad.IdEnfermedad, pobjAlumnoEnfermedad.Matricula), Cnn);
            try
            {
                resultado = Cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Entrada Duplicada"+ ee);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objAlumnoEnfermedad> BuscarAlumnoEnfermedad(string pMatricula)
        {
            List<objAlumnoEnfermedad> _lista = new List<objAlumnoEnfermedad>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoEnfermedad, IdEnfermedad, Matricula from alumnoenfermedad where Matricula = '{0}'", pMatricula), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlumnoEnfermedad pobjAlumnoEnfermedad = new objAlumnoEnfermedad();
                pobjAlumnoEnfermedad.IdAlumnoEnfermedad = Dr.GetInt32(0);
                pobjAlumnoEnfermedad.IdEnfermedad = Dr.GetInt32(1);
                pobjAlumnoEnfermedad.Matricula = Dr.GetString(2);

                _lista.Add(pobjAlumnoEnfermedad);
            }
            return _lista;
        }

        public static objAlumnoEnfermedad ObtenerAlumnoEnfermedad(int pIdAlumnoEnfermedd)
        {
            objAlumnoEnfermedad pobjAlumnoEnfermedad = new objAlumnoEnfermedad();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoEnfermedad, IdEnfermedad, Matricula from alumnoenfermedad where IdAlumnoEnfermedad = '{0}'", pIdAlumnoEnfermedd), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlumnoEnfermedad.IdAlumnoEnfermedad = Dr.GetInt32(0);
                pobjAlumnoEnfermedad.IdEnfermedad = Dr.GetInt32(1);
                pobjAlumnoEnfermedad.Matricula = Dr.GetString(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjAlumnoEnfermedad;
        }

        public static bool ActualizarAlumnoEnfermedad(objAlumnoEnfermedad pobjAlumnoEnfermedad)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alumnoenfermedad set IdEnfermedad = '{0}' where IdAlumnoEnfermedad = '{1}'", pobjAlumnoEnfermedad.IdEnfermedad, pobjAlumnoEnfermedad.IdAlumnoEnfermedad), Cnn);
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

        public static bool EliminarAlumnoEnfermedad(int pIdAlumnoEnfermedad)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM alumnoenfermedad WHERE IdAlumnoEnfermedad='{0}'", pIdAlumnoEnfermedad), Cnn);
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
