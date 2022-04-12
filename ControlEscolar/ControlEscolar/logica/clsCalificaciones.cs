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
    class clsCalificaciones
    {
        public static int GuardarCalificacion(objCalificaciones pobjCalificaciones)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into calificaciones (1P,2P,3P,4P,5P,6P,Matricula,CodigoMateria, PromedioGeneral) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}' ,'{8}')", pobjCalificaciones.PrimerParcial, pobjCalificaciones.SegundoParcial, pobjCalificaciones.TercerParcial, pobjCalificaciones.CuartoParcial, pobjCalificaciones.QuintoParcial, pobjCalificaciones.SextoParcial, pobjCalificaciones.Matricula, pobjCalificaciones.CodigoMateria, pobjCalificaciones.PromedioGeneral), Cnn);
            try
            {
                resultado = Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Entrada Duplicada"+e);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objCalificaciones> BuscarCalificacion(string pMatricula, Int32 pCodigoMateria)
        {
            List<objCalificaciones> _lista = new List<objCalificaciones>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdCalificaciones,1P,2P,3P,4P,5P,6P,Matricula, CodigoMateria, PromedioGeneral from calificaciones where Matricula = '{0}' or CodigoMateria = '{1}'", pMatricula, pCodigoMateria), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objCalificaciones pobjCalificaciones = new objCalificaciones();
                pobjCalificaciones.IdCalificaciones = Dr.GetInt32(0);
                pobjCalificaciones.PrimerParcial = Dr.GetInt32(1);
                pobjCalificaciones.SegundoParcial = Dr.GetInt32(2);
                pobjCalificaciones.TercerParcial = Dr.GetInt32(3);
                pobjCalificaciones.CuartoParcial = Dr.GetInt32(4);
                pobjCalificaciones.QuintoParcial = Dr.GetInt32(5);
                pobjCalificaciones.SextoParcial = Dr.GetInt32(6);
                pobjCalificaciones.Matricula = Dr.GetString(7);
                pobjCalificaciones.CodigoMateria = Dr.GetInt32(8);
                pobjCalificaciones.PromedioGeneral = Dr.GetFloat(9);
                _lista.Add(pobjCalificaciones);
            }
            return _lista;
        }

        public static objCalificaciones ObtenerCalificacion(int pIdCalificacionn)
        {
            objCalificaciones pobjCalificaciones = new objCalificaciones();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdCalificaciones,1P,2P,3P,4P,5P,6P,Matricula, CodigoMateria, PromedioGeneral from Calificaciones where idCalificaciones = '{0}'", pIdCalificacionn), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjCalificaciones.IdCalificaciones = Dr.GetInt32(0);
                pobjCalificaciones.PrimerParcial = Dr.GetInt32(1);
                pobjCalificaciones.SegundoParcial = Dr.GetInt32(2);
                pobjCalificaciones.TercerParcial = Dr.GetInt32(3);
                pobjCalificaciones.CuartoParcial = Dr.GetInt32(4);
                pobjCalificaciones.QuintoParcial = Dr.GetInt32(5);
                pobjCalificaciones.SextoParcial = Dr.GetInt32(6);
                pobjCalificaciones.Matricula = Dr.GetString(7);
                pobjCalificaciones.CodigoMateria = Dr.GetInt32(8);
                pobjCalificaciones.PromedioGeneral = Dr.GetFloat(9);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjCalificaciones;
        }

        public static bool ActualizarCalificacion(objCalificaciones pobjCalificaciones)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update Calificaciones set 1P = '{0}',2P = '{1}',3P = '{2}',4P = '{3}',5P = '{4}',6P = '{5}', Matricula = '{6}', PromedioGeneral = '{7}' where IdCalificaciones = '{8}'", pobjCalificaciones.PrimerParcial, pobjCalificaciones.SegundoParcial, pobjCalificaciones.TercerParcial, pobjCalificaciones.CuartoParcial, pobjCalificaciones.QuintoParcial, pobjCalificaciones.SextoParcial, pobjCalificaciones.Matricula, pobjCalificaciones.PromedioGeneral, pobjCalificaciones.IdCalificaciones), Cnn);
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

        public static bool EliminarCalificacion (int pIdCalificacionn)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM calificaciones WHERE IdCalificaciones='{0}'", pIdCalificacionn), Cnn);
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
