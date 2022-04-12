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
    class clsEnfermedad
    {
        public static bool GuardarEnfermedad(objEnfermedad pobjEnfermedad)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into enfermedad (`NombreEnfermedad`) VALUES ('{0}')", pobjEnfermedad.NombreEnfermedad), Cnn);
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

        public static List<objEnfermedad> Buscar(string pNombreEnfermedad)
        {
            List<objEnfermedad> _lista = new List<objEnfermedad>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdEnfermedad, NombreEnfermedad from enfermedad where NombreEnfermedad = '{0}'", pNombreEnfermedad), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objEnfermedad pobjEnfermedad = new objEnfermedad();
                pobjEnfermedad.IdEnfermedad = Dr.GetInt32(0);
                pobjEnfermedad.NombreEnfermedad = Dr.GetString(1);

                _lista.Add(pobjEnfermedad);
            }
            return _lista;

        }

        public static objEnfermedad ObtenerEnfermedad(int pIdEnfermedad)
        {
            objEnfermedad pobjEnfermedad = new objEnfermedad();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdEnfermedad, NombreEnfermedad from enfermedad where IdEnfermedad = '{0}'", pIdEnfermedad), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjEnfermedad.IdEnfermedad = Dr.GetInt32(0);
                pobjEnfermedad.NombreEnfermedad = Dr.GetString(1);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjEnfermedad;
        }

        public static bool Actualizar(objEnfermedad pobjEnfermedad)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("update enfermedad set NombreEnfermedad = '{0}' where IdEnfermedad = '{1}'", pobjEnfermedad.NombreEnfermedad, pobjEnfermedad.IdEnfermedad), Cnn);
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
