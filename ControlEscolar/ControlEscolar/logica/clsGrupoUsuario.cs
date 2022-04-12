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
    class clsGrupoUsuario
    {
        public static int GuardarGrupoUsuario(objGrupoUsuario pobjGrupoUsuario)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into grupousuario (NombreGrupoUsuario) values ('{0}')", pobjGrupoUsuario.NombreGrupoUsuario), Cnn);
            try
            {
                resultado = Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objGrupoUsuario> BuscarGrupoUsuario(string pNombreGrupoUsuario)
        {
            List<objGrupoUsuario> _lista = new List<objGrupoUsuario>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdGrupoUsuario, NombreGrupoUsuario from grupousuario where NombreGrupoUsuario = '{0}'", pNombreGrupoUsuario), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objGrupoUsuario pobjEnfermedad = new objGrupoUsuario();
                pobjEnfermedad.IdGrupoUsuario = Dr.GetInt32(0);
                pobjEnfermedad.NombreGrupoUsuario = Dr.GetString(1);

                _lista.Add(pobjEnfermedad);
            }
            return _lista;

        }

        public static objGrupoUsuario ObtenerGrupoUsuario(int pIdGrupoUsuario)
        {
            objGrupoUsuario pobjEnfermedad = new objGrupoUsuario();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdGrupoUsuario, NombreGrupoUsuario from grupousuario where IdGrupoUsuario = '{0}'", pIdGrupoUsuario), clsConexion.BaseDeDatos());

            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjEnfermedad.IdGrupoUsuario = Dr.GetInt32(0);
                pobjEnfermedad.NombreGrupoUsuario = Dr.GetString(1);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjEnfermedad;
        }

        public static bool ActualizarGrupoUsuario(objGrupoUsuario pobjGrupoUsuario)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();

            MySqlCommand Cmd = new MySqlCommand(string.Format("update grupousuario set NombreGrupoUsuario= '{0}' where IdGrupoUsuario = '{1}'", pobjGrupoUsuario.NombreGrupoUsuario, pobjGrupoUsuario.IdGrupoUsuario), Cnn);
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
