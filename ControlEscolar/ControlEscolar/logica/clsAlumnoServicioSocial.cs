using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using System.Windows.Forms;

namespace ControlEscolar.logica
{
  public class clsAlumnoServicioSocial
    {
        public static bool GuardarAlumnoServicioSocial(objAlumnoServicioSocial pobjAlumnoServicioSocial)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnoserviciosocial (Matricula,IdServicioSocial) values ('{0}','{1}')", pobjAlumnoServicioSocial.Matricula,pobjAlumnoServicioSocial.IdServicioSocial), Cnn);
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

        //public static List<objServicioSocial> BuscarServicioSocial(string pNombreDelPrograma, string pNombreDependencia)
        //{
        //    List<objServicioSocial> _lista = new List<objServicioSocial>();
        //    MySqlCommand Cmd = new MySqlCommand(string.Format("select IdServicioSocial, Dependencia, NombreDelPrograma, SubPrograma, ActividadBasica, Modalidad, Areas, Fecha_Inicio, Fecha_Final, Direccion_IdDireccion from serviciosocial where Dependencia = '{0}' or NombreDelPrograma = '{1}'", pNombreDelPrograma, pNombreDependencia), clsConexion.BaseDeDatos());
        //    MySqlDataReader Dr = Cmd.ExecuteReader();
        //    while (Dr.Read())
        //    {

        //        objServicioSocial pobjServicioSocial = new objServicioSocial();
        //        pobjServicioSocial.IdServicioSocial = Dr.GetInt32(0);
        //        pobjServicioSocial.Dependencia = Dr.GetString(1);
        //        pobjServicioSocial.NombreDelPrograma = Dr.GetString(2);
        //        pobjServicioSocial.SubPrograma = Dr.GetString(3);
        //        pobjServicioSocial.ActividadBasica = Dr.GetString(4);
        //        pobjServicioSocial.Modalidad = Dr.GetString(5);
        //        pobjServicioSocial.Areas = Dr.GetString(6);
        //        pobjServicioSocial.FechaInicio = Dr.GetDateTime(7);
        //        pobjServicioSocial.FechaFinal = Dr.GetDateTime(8);
        //        pobjServicioSocial.IdDireccion = Dr.GetInt32(9);

        //        _lista.Add(pobjServicioSocial);
        //    }
        //    return _lista;

        //}

        //public static objServicioSocial ObtenerServicioSocial(int pIdServicioSocial)
        //{
        //    objServicioSocial pobjServicioSocial = new objServicioSocial();
        //    MySqlCommand Cmd = new MySqlCommand(string.Format("select IdServicioSocial, Dependencia, NombreDelPrograma, SubPrograma, ActividadBasica, Modalidad, Areas, Fecha_Inicio, Fecha_Final, Direccion_IdDireccion from serviciosocial where IdAlergias = '{0}'", pIdServicioSocial), clsConexion.BaseDeDatos());
        //    MySqlDataReader Dr = Cmd.ExecuteReader();

        //    while (Dr.Read())
        //    {
        //        pobjServicioSocial.IdServicioSocial = Dr.GetInt32(0);
        //        pobjServicioSocial.Dependencia = Dr.GetString(1);
        //        pobjServicioSocial.NombreDelPrograma = Dr.GetString(2);
        //        pobjServicioSocial.SubPrograma = Dr.GetString(3);
        //        pobjServicioSocial.ActividadBasica = Dr.GetString(4);
        //        pobjServicioSocial.Modalidad = Dr.GetString(5);
        //        pobjServicioSocial.Areas = Dr.GetString(6);
        //        pobjServicioSocial.FechaInicio = Dr.GetDateTime(7);
        //        pobjServicioSocial.FechaFinal = Dr.GetDateTime(8);
        //        pobjServicioSocial.IdDireccion = Dr.GetInt32(9);
        //    }
        //    clsConexion.BaseDeDatos().Close();
        //    return pobjServicioSocial;
        //}

        public static bool ActualizarAlumnoServicioSocial(objAlumnoServicioSocial pobjAlumnoServicioSocial)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alumnoserviciosocial set Matricula = '{0}', IdServicioSocial = '{1}' where idAlumnoServicioSocial ={2}", pobjAlumnoServicioSocial.Matricula,pobjAlumnoServicioSocial.IdServicioSocial,pobjAlumnoServicioSocial.IdAlumnoServicioSocial), Cnn);
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
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM alumnoserviciosocial WHERE idAlumnoServicioSocial={0}", pIdServicioSocial), Cnn);
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
