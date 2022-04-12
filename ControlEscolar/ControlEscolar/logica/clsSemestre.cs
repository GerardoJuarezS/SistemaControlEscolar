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
    class clsSemestre
    {
        public static int GuardarSemestre(objSemestre pobjSemestre)
        {
            int resultado = 0;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into semestre (IdSemestre, Nombre, FechaInicio, FechaFinal) values ('{0}','{1}','{2}','{3}')", pobjSemestre.IdSemestre, pobjSemestre.NombreSemestre, pobjSemestre.FechaInicio.Year + "-" + pobjSemestre.FechaInicio.Month + "-" + pobjSemestre.FechaInicio.Day, pobjSemestre.FechaFinal.Year + "-" + pobjSemestre.FechaFinal.Month + "-" + pobjSemestre.FechaFinal.Day), clsConexion.BaseDeDatos());
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
    }
}
