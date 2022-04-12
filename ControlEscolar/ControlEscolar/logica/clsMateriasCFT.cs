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
    public class clsMateriasCFT
    {
        public static bool GuardarMateriaCFT(objMateriasCFT pobjMateriasCFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into materias_cft (CodigoMaterias,Id_CFT) VALUES ('{0}','{1}')",pobjMateriasCFT.CodigoMaterias,pobjMateriasCFT.IdCFT), Cnn);
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

        public static List<objMateriasCFT> BuscarMateriaCFT(int CodigoCFT)
        {
            List<objMateriasCFT> _lista = new List<objMateriasCFT>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select materias_cft.IdMaterias_CFT, materias_cft.CodigoMaterias, materias_cft.Id_CFT, materias.UAC, cft.Nombre from materias, materias_cft,cft where cft.Id_CFT= '{0}' and materias_cft.CodigoMaterias = materias.CodigoMaterias and materias_cft.Id_CFT = cft.Id_CFT", CodigoCFT), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                objMateriasCFT pobjMateriasCFT = new objMateriasCFT();
                pobjMateriasCFT.IdMaterias_CFT = Dr.GetInt32(0);
                pobjMateriasCFT.CodigoMaterias = Dr.GetInt32(1);
                pobjMateriasCFT.IdCFT = Dr.GetInt32(2);
                pobjMateriasCFT.UAC = Dr.GetString(3);
                pobjMateriasCFT.CFT = Dr.GetString(4);
                _lista.Add(pobjMateriasCFT);
            }
            return _lista;
        }

        public static objMateriasCFT ObtenerMateriaCFT(int pIdMaterias_CFT)
        {
            objMateriasCFT pobjMateriasCFT = new objMateriasCFT();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select materias_cft.IdMaterias_CFT, materias_cft.CodigoMaterias, materias_cft.Id_CFT, materias.UAC, cft.Nombre from materias, materias_cft,cft where materias_cft.IdMaterias_CFT ='{0}' and materias_cft.CodigoMaterias = materias.CodigoMaterias and materias_cft.Id_CFT = cft.Id_CFT", pIdMaterias_CFT), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjMateriasCFT.IdMaterias_CFT = Dr.GetInt32(0);
                pobjMateriasCFT.CodigoMaterias = Dr.GetInt32(1);
                pobjMateriasCFT.IdCFT = Dr.GetInt32(2);
                pobjMateriasCFT.UAC = Dr.GetString(3);
                pobjMateriasCFT.CFT = Dr.GetString(4);
            }
            clsConexion.BaseDeDatos().Close();
            return pobjMateriasCFT;
        }

        public static bool ActualizarMateriaCFT(objMateriasCFT pobjMateriasCFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("UPDATE cobao.materias_cft SET CodigoMaterias = '{0}' , Id_CFT = '{1}' WHERE IdMaterias_CFT = '{2}' ", pobjMateriasCFT.CodigoMaterias, pobjMateriasCFT.IdCFT,pobjMateriasCFT.IdMaterias_CFT), Cnn);
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

        public static bool EliminarMateriaCFT(int pId_CFT)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM materias_cft WHERE IdMaterias_CFT='{0}'", pId_CFT), Cnn);
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
