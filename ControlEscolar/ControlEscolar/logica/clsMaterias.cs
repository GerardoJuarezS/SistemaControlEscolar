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
    class clsMaterias
    {
        public static bool GuardarMateria(objMaterias pobjMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into materias (CodigoMaterias, UAC, HorasMaterias, CreditosMaterias) values ('{0}','{1}','{2}','{3}')", pobjMaterias.CodigoMaterias, pobjMaterias.UAC, pobjMaterias.HorasMateria, pobjMaterias.CreditosMaterias), Cnn);
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

        public static List<objMaterias> Buscar(string pCodigoMaterias, string pNombreMateria)
        {
            List<objMaterias> _lista = new List<objMaterias>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select CodigoMaterias,UAC, HorasMaterias, CreditosMaterias from materias where CodigoMaterias = '{0}' or UAC = '{1}'", pCodigoMaterias, pNombreMateria), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objMaterias pobjMaterias = new objMaterias();
                pobjMaterias.CodigoMaterias = Dr.GetInt32(0);
                pobjMaterias.UAC = Dr.GetString(1);
                pobjMaterias.HorasMateria = Dr.GetInt32(2);
                pobjMaterias.CreditosMaterias = Dr.GetInt32(3);
                _lista.Add(pobjMaterias);
            }
            return _lista;

        }

        public static objMaterias ObtenerMateria(int pCodigoMateriass)
        {
            objMaterias pobjMaterias = new objMaterias();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select CodigoMaterias,UAC, HorasMaterias, CreditosMaterias from materias where CodigoMaterias = '{0}'",pCodigoMateriass), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjMaterias.CodigoMaterias = Dr.GetInt32(0);
                pobjMaterias.UAC = Dr.GetString(1);
                pobjMaterias.HorasMateria = Dr.GetInt32(2);
                pobjMaterias.CreditosMaterias = Dr.GetInt32(3);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjMaterias;
        }

        public static bool Actualizar(objMaterias pobjMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("update materias set CodigoMaterias = '{0}', UAC = '{1}', HorasMaterias = '{2}', CreditosMaterias = '{3}' where CodigoMaterias = '{4}'", pobjMaterias.CodigoMaterias, pobjMaterias.UAC, pobjMaterias.HorasMateria, pobjMaterias.CreditosMaterias,pobjMaterias.CodigoMaterias_Anterior), Cnn);
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

        public static bool EliminarMateria(int pCodigoMateria)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM materias WHERE CodigoMaterias='{0}'", pCodigoMateria), Cnn);
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
