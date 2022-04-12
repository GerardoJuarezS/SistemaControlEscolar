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
    public class clsServicioSocial
    {
        public static bool GuardarServicioSocial (objServicioSocial pobjServicioSocial)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into serviciosocial (Dependencia, NombreDelPrograma, SubPrograma, ActividadBasica, Modalidad, Areas, Fecha_Inicio, Fecha_Final, Direccion_IdDireccion) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",pobjServicioSocial.Dependencia,pobjServicioSocial.NombreDelPrograma,pobjServicioSocial.SubPrograma,pobjServicioSocial.ActividadBasica,pobjServicioSocial.Modalidad,pobjServicioSocial.Areas,pobjServicioSocial.FechaInicio.Year+"-"+pobjServicioSocial.FechaInicio.Month+"-"+pobjServicioSocial.FechaInicio.Day,pobjServicioSocial.FechaFinal.Year+"-"+pobjServicioSocial.FechaFinal.Month+"-"+pobjServicioSocial.FechaFinal.Day,pobjServicioSocial.IdDireccion),Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepcion" + e);
            }
            Cnn.Close();
            return resultado;
        }

        public static List<objServicioSocial> BuscarServicioSocial(string pNombreDelPrograma, string pNombreDependencia)
        {
            List<objServicioSocial> _lista = new List<objServicioSocial>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select serviciosocial.IdServicioSocial, Dependencia, NombreDelPrograma, SubPrograma, ActividadBasica, Modalidad, Areas, Fecha_Inicio, Fecha_Final, Direccion_IdDireccion,Matricula, direccion.Estado,direccion.Distrito,direccion.Municipio,direccion.Localidad,direccion.Colonia,direccion.Calle,direccion.Numero from direccion, serviciosocial, alumnoserviciosocial where alumnoserviciosocial.Matricula = '{0}' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial and direccion.IdDireccion = serviciosocial.Direccion_IdDireccion or serviciosocial.Dependencia = '{1}' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial and direccion.IdDireccion = serviciosocial.Direccion_IdDireccion", pNombreDelPrograma, pNombreDependencia), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objServicioSocial pobjServicioSocial = new objServicioSocial();
                pobjServicioSocial.IdServicioSocial = Dr.GetInt32(0);
                pobjServicioSocial.Dependencia = Dr.GetString(1);
                pobjServicioSocial.NombreDelPrograma = Dr.GetString(2);
                pobjServicioSocial.SubPrograma = Dr.GetString(3);
                pobjServicioSocial.ActividadBasica = Dr.GetString(4);
                pobjServicioSocial.Modalidad = Dr.GetString(5);
                pobjServicioSocial.Areas = Dr.GetString(6);
                pobjServicioSocial.FechaInicio = Dr.GetDateTime(7);
                pobjServicioSocial.FechaFinal = Dr.GetDateTime(8);
                pobjServicioSocial.IdDireccion = Dr.GetInt32(9);
                pobjServicioSocial.Matricula = Dr.GetString(10);
                pobjServicioSocial.Estado = Dr.GetString(11);
                pobjServicioSocial.Distrito = Dr.GetString(12);
                pobjServicioSocial.Municipio = Dr.GetString(13);
                pobjServicioSocial.Localidad = Dr.GetString(14);
                pobjServicioSocial.Colonia = Dr.GetString(15);
                pobjServicioSocial.Calle = Dr.GetString(16);
                pobjServicioSocial.Numero = Dr.GetString(17);

                _lista.Add(pobjServicioSocial);
            }
            return _lista;

        }

        public static objServicioSocial ObtenerServicioSocial(int pIdServicioSociall)
        {
            objServicioSocial pobjServicioSocial = new objServicioSocial();

            MySqlCommand Cmd = new MySqlCommand(string.Format("select serviciosocial.IdServicioSocial, Dependencia, NombreDelPrograma, SubPrograma, ActividadBasica, Modalidad, Areas, Fecha_Inicio, Fecha_Final, Direccion_IdDireccion,Matricula, direccion.Estado,direccion.Distrito,direccion.Municipio,direccion.Localidad,direccion.Colonia,direccion.Calle,direccion.Numero from direccion, serviciosocial, alumnoserviciosocial where alumnoserviciosocial.IdServicioSocial = '{0}' and serviciosocial.IdServicioSocial = alumnoserviciosocial.IdServicioSocial and direccion.IdDireccion = serviciosocial.Direccion_IdDireccion", pIdServicioSociall), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjServicioSocial.IdServicioSocial = Dr.GetInt32(0);
                pobjServicioSocial.Dependencia = Dr.GetString(1);
                pobjServicioSocial.NombreDelPrograma = Dr.GetString(2);
                pobjServicioSocial.SubPrograma = Dr.GetString(3);
                pobjServicioSocial.ActividadBasica = Dr.GetString(4);
                pobjServicioSocial.Modalidad = Dr.GetString(5);
                pobjServicioSocial.Areas = Dr.GetString(6);
                pobjServicioSocial.FechaInicio = Dr.GetDateTime(7);
                pobjServicioSocial.FechaFinal = Dr.GetDateTime(8);
                pobjServicioSocial.IdDireccion = Dr.GetInt32(9);
                pobjServicioSocial.Matricula = Dr.GetString(10);
                pobjServicioSocial.Estado = Dr.GetString(11);
                pobjServicioSocial.Distrito = Dr.GetString(12);
                pobjServicioSocial.Municipio = Dr.GetString(13);
                pobjServicioSocial.Localidad = Dr.GetString(14);
                pobjServicioSocial.Colonia = Dr.GetString(15);
                pobjServicioSocial.Calle = Dr.GetString(16);
                pobjServicioSocial.Numero = Dr.GetString(17);
            }
            clsConexion.BaseDeDatos().Close();
            return pobjServicioSocial;
        }

        public static bool ActualizarServicioSocial(objServicioSocial pobjServicioSocial)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update serviciosocial set Dependencia = '{0}', NombreDelPrograma = '{1}', SubPrograma = '{2}', ActividadBasica = '{3}', Modalidad = '{4}', Areas = '{5}', Fecha_Inicio = '{6}', Fecha_Final = '{7}', Direccion_IdDireccion = '{8}' where IdServicioSocial = '{9}'", pobjServicioSocial.Dependencia, pobjServicioSocial.NombreDelPrograma, pobjServicioSocial.SubPrograma, pobjServicioSocial.ActividadBasica, pobjServicioSocial.Modalidad, pobjServicioSocial.Areas, pobjServicioSocial.FechaInicio.Year +"-"+ pobjServicioSocial.FechaInicio.Month +"-"+ pobjServicioSocial.FechaInicio.Day, pobjServicioSocial.FechaFinal.Year +"-"+ pobjServicioSocial.FechaFinal.Month +"-"+ pobjServicioSocial.FechaFinal.Day, pobjServicioSocial.IdDireccion, pobjServicioSocial.IdServicioSocial), Cnn);
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

        public static bool EliminarServicioSocial(int pIdServicioSocial)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM serviciosocial WHERE IdServicioSocial='{0}'", pIdServicioSocial), Cnn);
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
