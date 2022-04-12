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
    class clsMateriasSemestre
    {
        public static bool GuardarMateriasEnSemestre(objMateriaSemestre pobjMateriaSemestre)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into materiasemestre (codigomaterias, idsemestre) values ('{0}','{1}')", pobjMateriaSemestre.CodigoMaterias, pobjMateriaSemestre.IdSemestre), Cnn);
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

        public static List<objMateriaSemestre> Buscar(string pCodigoMateria, string pIdSemestre)
        {
            List<objMateriaSemestre> _lista = new List<objMateriaSemestre>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select UAC, materiasemestre.CodigoMaterias, materiasemestre.IdSemestre,materiasemestre.IdMateriaSemestre from materiasemestre, materias,semestre where materiasemestre.CodigoMaterias = '{0}' and materiasemestre.CodigoMaterias = materias.CodigoMaterias and materiasemestre.IdSemestre = semestre.IdSemestre or materiasemestre.IdSemestre = '{1}' and materiasemestre.CodigoMaterias = materias.CodigoMaterias and materiasemestre.IdSemestre = semestre.IdSemestre", pCodigoMateria, pIdSemestre), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                objMateriaSemestre pobjMateriaSemestre = new objMateriaSemestre();
                pobjMateriaSemestre.UAC = Dr.GetString(0);
                pobjMateriaSemestre.CodigoMaterias = Dr.GetInt32(1);
                pobjMateriaSemestre.IdSemestre = Dr.GetInt32(2);
                pobjMateriaSemestre.IdMateriaSemestre = Dr.GetInt32(3);
                _lista.Add(pobjMateriaSemestre);
            }
            return _lista;
        }

        public static objMateriaSemestre ObtenerMateria(int pIdMateriaSemestre)
        {
            objMateriaSemestre pobjMateriaSemestre = new objMateriaSemestre();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdMateriaSemestre, CodigoMaterias, IdSemestre from materiasemestre where IdMateriaSemestre = '{0}'", pIdMateriaSemestre), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjMateriaSemestre.IdMateriaSemestre = Dr.GetInt32(0);
                pobjMateriaSemestre.CodigoMaterias = Dr.GetInt32(1);
                pobjMateriaSemestre.IdSemestre = Dr.GetInt32(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjMateriaSemestre;
        }

        public static bool Actualizar(objMateriaSemestre pobjMateriaSemestre)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("update materiasemestre set CodigoMaterias= '{0}', IdSemestre = '{1}' where IdMateriaSemestre = '{2}'", pobjMateriaSemestre.CodigoMaterias, pobjMateriaSemestre.IdSemestre, pobjMateriaSemestre.IdMateriaSemestre), Cnn);
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

        public static bool Eliminar (int pIdMateriaSemestre)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM materiasemestre WHERE IdMateriaSemestre='{0}'", pIdMateriaSemestre), Cnn);
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
