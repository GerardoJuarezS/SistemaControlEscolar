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
    class clsDatosPersonales
    {
        public static bool GuardarDatosPersonales(objDatospersonales pobjDatospersonales)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into datospersonales (Nombre, ApellidoPaterno, ApellidoMaterno, Curp, Telefono, Celular, Correo, Nss, Sexo, Foto, FechaNacimiento) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", pobjDatospersonales.Nombre, pobjDatospersonales.ApellidoPaterno, pobjDatospersonales.ApellidoMaterno, pobjDatospersonales.Curp, pobjDatospersonales.Telefono, pobjDatospersonales.Celular, pobjDatospersonales.Correo, pobjDatospersonales.Nss, pobjDatospersonales.Sexo, pobjDatospersonales.Foto, pobjDatospersonales.FechaNacimiento.Year + "-" + pobjDatospersonales.FechaNacimiento.Month + "-" + pobjDatospersonales.FechaNacimiento.Day), Cnn);
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

        public static bool ActualizarDatosPersonales(objDatospersonales pobjDatospersonales)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update datospersonales set Nombre = '{0}',ApellidoPaterno='{1}', ApellidoMaterno='{2}', Curp='{3}', Telefono='{4}', Celular='{5}', Correo='{6}', Nss='{7}', Sexo='{8}', Foto='{9}',FechaNacimiento='{10}' where IdDatosPersonales = '{11}'", pobjDatospersonales.Nombre, pobjDatospersonales.ApellidoPaterno, pobjDatospersonales.ApellidoMaterno, pobjDatospersonales.Curp, pobjDatospersonales.Telefono, pobjDatospersonales.Celular, pobjDatospersonales.Correo, pobjDatospersonales.Nss, pobjDatospersonales.Sexo, pobjDatospersonales.Foto, pobjDatospersonales.FechaNacimiento.Year + "-" + pobjDatospersonales.FechaNacimiento.Month + "-" + pobjDatospersonales.FechaNacimiento.Day,pobjDatospersonales.IdDatosPersonales), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
                Cnn.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("error" + ee);
            }
            
            return resultado;
        }

        public static bool EliminarDatosPersonales (string pCurp)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM datospersonales WHERE IdDatosPersonales='{0}'",pCurp), Cnn);
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
