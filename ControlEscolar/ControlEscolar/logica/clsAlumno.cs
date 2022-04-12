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
    class clsAlumno
    {
        public static bool GuardarInscripcion(objAlumno pobjAlumno)
        {


            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumno(Matricula, Tutor, IdDatosPersonales, IdDireccion) values ('{0}','{1}','{2}','{3}') ", pobjAlumno.Matricula, pobjAlumno.Tutor, pobjAlumno.IdDatosPersonales, pobjAlumno.IdDireccion), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);

            }
            clsConexion.BaseDeDatos().Close();
            return resultado;
        }

        public static List<objBusquedaInscripcion> BuscarAlumno(string pMatricula)
        {
            List<objBusquedaInscripcion> _lista = new List<objBusquedaInscripcion>();

            MySqlCommand Cmd = new MySqlCommand(string.Format("select alumno.Matricula, alumno.Tutor, datospersonales.IdDatosPersonales, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Curp, datospersonales.Telefono, datospersonales.Celular, datospersonales.Correo, datospersonales.Nss, datospersonales.Sexo, datospersonales.foto, datospersonales.FechaNacimiento, direccion.IdDireccion,direccion.Estado,direccion.Distrito, direccion.Municipio, direccion.Colonia, direccion.calle, direccion.Numero, direccion.Localidad,alumnogrupo.IdAlumnoGrupo, alumnogrupo.IdGrupo, alumnosemestre.idAlumnoSemestre, alumnosemestre.idsemestre from alumno, direccion, datospersonales,alumnogrupo,alumnosemestre where alumno.Matricula = '{0}' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales and alumno.IdDireccion = direccion.IdDireccion and alumno.Matricula = alumnogrupo.Matricula and alumno.Matricula = alumnosemestre.Matricula", pMatricula), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                objBusquedaInscripcion pobjBusquedaInscripcion = new objBusquedaInscripcion();
                pobjBusquedaInscripcion.Matricula = Dr.GetString(0);
                pobjBusquedaInscripcion.Tutor = Dr.GetString(1);
                pobjBusquedaInscripcion.IdDatosPersonales = Dr.GetInt32(2);
                pobjBusquedaInscripcion.Nombre = Dr.GetString(3);
                pobjBusquedaInscripcion.ApellidoPaterno = Dr.GetString(4);
                pobjBusquedaInscripcion.ApellidoMaterno = Dr.GetString(5);
                pobjBusquedaInscripcion.Curp = Dr.GetString(6);
                pobjBusquedaInscripcion.Telefono = Dr.GetString(7);
                pobjBusquedaInscripcion.Celular = Dr.GetString(8);
                pobjBusquedaInscripcion.Correo = Dr.GetString(9);
                pobjBusquedaInscripcion.Nss = Dr.GetString(10);
                pobjBusquedaInscripcion.Sexo = Dr.GetString(11);
                pobjBusquedaInscripcion.FechaNacimiento = Dr.GetString(13);
                pobjBusquedaInscripcion.IdDireccion = Dr.GetInt32(14);
                pobjBusquedaInscripcion.NombreEstado = Dr.GetString(15);
                pobjBusquedaInscripcion.NombreDistrito = Dr.GetString(16);
                pobjBusquedaInscripcion.NombreMunicipio = Dr.GetString(17);
                pobjBusquedaInscripcion.Colonia = Dr.GetString(18);
                pobjBusquedaInscripcion.Calle = Dr.GetString(19);
                pobjBusquedaInscripcion.Numero = Dr.GetString(20);
                pobjBusquedaInscripcion.Localidad = Dr.GetString(21);
                pobjBusquedaInscripcion.IdAlumnoGrupo = Dr.GetInt32(22);
                pobjBusquedaInscripcion.IdGrupo = Dr.GetInt32(23);
                pobjBusquedaInscripcion.IdAlumnoSemestre = Dr.GetInt32(24);
                pobjBusquedaInscripcion.IdSemestre = Dr.GetInt32(25);
                _lista.Add(pobjBusquedaInscripcion);
            }
            return _lista;
        }

        public static objBusquedaInscripcion ObtenerAlumno(string pMatriculaa)
        {
            objBusquedaInscripcion pobjBusquedaInscripcion = new objBusquedaInscripcion();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select alumno.Matricula, alumno.Tutor, datospersonales.IdDatosPersonales, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Curp, datospersonales.Telefono, datospersonales.Celular, datospersonales.Correo, datospersonales.Nss, datospersonales.Sexo, datospersonales.foto, datospersonales.FechaNacimiento, direccion.IdDireccion,direccion.Estado,direccion.Distrito, direccion.Municipio, direccion.Colonia, direccion.calle, direccion.Numero, direccion.Localidad,alumnogrupo.IdAlumnoGrupo, alumnogrupo.IdGrupo, alumnosemestre.idAlumnoSemestre, alumnosemestre.idsemestre from alumno, direccion, datospersonales,alumnogrupo,alumnosemestre where alumno.Matricula = '{0}' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales and alumno.IdDireccion = direccion.IdDireccion and alumno.Matricula = alumnogrupo.Matricula and alumno.Matricula = alumnosemestre.Matricula", pMatriculaa), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjBusquedaInscripcion.Matricula = Dr.GetString(0);
                pobjBusquedaInscripcion.Tutor = Dr.GetString(1);
                pobjBusquedaInscripcion.IdDatosPersonales = Dr.GetInt32(2);
                pobjBusquedaInscripcion.Nombre = Dr.GetString(3);
                pobjBusquedaInscripcion.ApellidoPaterno = Dr.GetString(4);
                pobjBusquedaInscripcion.ApellidoMaterno = Dr.GetString(5);
                pobjBusquedaInscripcion.Curp = Dr.GetString(6);
                pobjBusquedaInscripcion.Telefono = Dr.GetString(7);
                pobjBusquedaInscripcion.Celular = Dr.GetString(8);
                pobjBusquedaInscripcion.Correo = Dr.GetString(9);
                pobjBusquedaInscripcion.Nss = Dr.GetString(10);
                pobjBusquedaInscripcion.Sexo = Dr.GetString(11);
                pobjBusquedaInscripcion.FechaNacimiento = Dr.GetString(13);
                pobjBusquedaInscripcion.IdDireccion = Dr.GetInt32(14);
                pobjBusquedaInscripcion.NombreEstado = Dr.GetString(15);
                pobjBusquedaInscripcion.NombreDistrito = Dr.GetString(16);
                pobjBusquedaInscripcion.NombreMunicipio = Dr.GetString(17);
                pobjBusquedaInscripcion.Colonia = Dr.GetString(18);
                pobjBusquedaInscripcion.Calle = Dr.GetString(19);
                pobjBusquedaInscripcion.Numero = Dr.GetString(20);
                pobjBusquedaInscripcion.Localidad = Dr.GetString(21);
                pobjBusquedaInscripcion.IdAlumnoGrupo = Dr.GetInt32(22);
                pobjBusquedaInscripcion.IdGrupo = Dr.GetInt32(23);
                pobjBusquedaInscripcion.IdAlumnoSemestre = Dr.GetInt32(24);
                pobjBusquedaInscripcion.IdSemestre = Dr.GetInt32(25);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjBusquedaInscripcion;
        }

        public static bool EliminarAlumno(string pMatricula)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("delete from alumno where Matricula ='{0}'", pMatricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
                MessageBox.Show("" + resultado);
                Cnn.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Error" + ee);
            }

            return resultado;
        }

        public static bool ActualizarInscripcion(objAlumno pobjAlumno)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update alumno set Matricula = '{0}', Tutor = '{1}' where Matricula = '{2}'", pobjAlumno.Matricula, pobjAlumno.Tutor, pobjAlumno.Matricula_anterior), Cnn);
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
