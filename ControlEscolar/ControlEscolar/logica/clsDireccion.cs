using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.logica;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ControlEscolar.logica
{
    class clsDireccion
    {
        public static bool GuardarDireccion(objDireccion pobjDireccion)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("INSERT INTO direccion (Estado, Distrito, Municipio, Localidad, Colonia,Calle,Numero) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}')",pobjDireccion.Estado, pobjDireccion.Distrito,pobjDireccion.Municipio, pobjDireccion.Localidad, pobjDireccion.Colonia, pobjDireccion.Calle, pobjDireccion.Numero), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            Cnn.Close();
            return resultado;
        }
        public static bool Actualizar(objDireccion pobjDireccion)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("UPDATE direccion SET Estado='{0}', Distrito='{1}', Municipio='{2}', Localidad='{3}', Colonia='{4}', Calle='{5}', Numero='{6}' WHERE IdDireccion='{7}'", pobjDireccion.Estado, pobjDireccion.Distrito,pobjDireccion.Municipio,pobjDireccion.Localidad, pobjDireccion.Colonia, pobjDireccion.Calle, pobjDireccion.Numero, pobjDireccion.IdDireccion), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show(" error "+e);
            }
            
            Cnn.Close();
            return resultado;
        }

        public static bool EliminarDireccion(int pIdDireccion)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM direccion WHERE IdDireccion='{0}'; ", pIdDireccion), Cnn);
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
