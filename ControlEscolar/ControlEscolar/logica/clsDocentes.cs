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
    class clsDocentes
    {
        public static bool GuardarDocente(objDocentes pobjDocentes)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into docentes (rfc, iddireccion,iddatospersonales,idprofesion) values ('{0}','{1}','{2}','{3}')", pobjDocentes.Rfc, pobjDocentes.IdDireccion, pobjDocentes.IdDatosPersonales, pobjDocentes.IdProfesion), Cnn);
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

        public static List<objBusquedaDocente> Buscar(string pRfc)
        {
            List<objBusquedaDocente> _lista = new List<objBusquedaDocente>();

            MySqlCommand Cmd = new MySqlCommand(string.Format("select docentes.Rfc, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Nss, datospersonales.Sexo, datospersonales.Celular, datospersonales.Telefono, datospersonales.Correo, datospersonales.Curp, datospersonales.FechaNacimiento,direccion.Estado, direccion.Distrito, direccion.Municipio, direccion.Calle, direccion.Colonia, direccion.Localidad, direccion.Numero, profesiones.NombreProfesion, direccion.IdDireccion, datospersonales.IdDatosPersonales, profesiones.IdProfesion from docentes, datospersonales, direccion, profesiones where Rfc = '{0}' and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales and docentes.IdDireccion = direccion.IdDireccion and docentes.IdProfesion = profesiones.IdProfesion", pRfc), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                objBusquedaDocente pobjBusquedaDocente = new objBusquedaDocente();
                pobjBusquedaDocente.Rfc = Dr.GetString(0);
                pobjBusquedaDocente.Nombre = Dr.GetString(1);
                pobjBusquedaDocente.ApellidoPaterno = Dr.GetString(2);
                pobjBusquedaDocente.ApellidoMaterno = Dr.GetString(3);
                pobjBusquedaDocente.Nss = Dr.GetString(4);
                pobjBusquedaDocente.Sexo = Dr.GetString(5);
                pobjBusquedaDocente.Celular = Dr.GetString(6);
                pobjBusquedaDocente.Telefono = Dr.GetString(7);
                pobjBusquedaDocente.Correo = Dr.GetString(8);
                pobjBusquedaDocente.Curp = Dr.GetString(9);
                pobjBusquedaDocente.FechaNacimiento = Dr.GetString(10);
                pobjBusquedaDocente.NombreEstado = Dr.GetString(11);
                pobjBusquedaDocente.NombreDistrito = Dr.GetString(12);
                pobjBusquedaDocente.NombreMunicipio = Dr.GetString(13);
                pobjBusquedaDocente.Calle = Dr.GetString(14);
                pobjBusquedaDocente.Colonia = Dr.GetString(15);
                pobjBusquedaDocente.Localidad = Dr.GetString(16);
                pobjBusquedaDocente.Numero = Dr.GetString(17);
                pobjBusquedaDocente.NombreProfesion = Dr.GetString(18);
                pobjBusquedaDocente.IdDireccion = Dr.GetInt32(19);
                pobjBusquedaDocente.IdDatosPersonales = Dr.GetInt32(20);
                pobjBusquedaDocente.IdProfesion = Dr.GetInt32(21);
                _lista.Add(pobjBusquedaDocente);
            }
            return _lista;
        }
        public static objBusquedaDocente ObtenerDocente(string pRfcc)
        {
            objBusquedaDocente pobjBusquedaDocente = new objBusquedaDocente();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select docentes.Rfc, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Nss, datospersonales.Sexo, datospersonales.Celular, datospersonales.Telefono, datospersonales.Correo, datospersonales.Curp, datospersonales.FechaNacimiento,direccion.Estado, direccion.Distrito, direccion.Municipio, direccion.Calle, direccion.Colonia, direccion.Localidad, direccion.Numero, profesiones.NombreProfesion, direccion.IdDireccion, datospersonales.IdDatosPersonales, profesiones.IdProfesion from docentes, datospersonales, direccion, profesiones where Rfc = '{0}' and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales and docentes.IdDireccion = direccion.IdDireccion and docentes.IdProfesion = profesiones.IdProfesion", pRfcc), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjBusquedaDocente.Rfc = Dr.GetString(0);
                pobjBusquedaDocente.Nombre = Dr.GetString(1);
                pobjBusquedaDocente.ApellidoPaterno = Dr.GetString(2);
                pobjBusquedaDocente.ApellidoMaterno = Dr.GetString(3);
                pobjBusquedaDocente.Nss = Dr.GetString(4);
                pobjBusquedaDocente.Sexo = Dr.GetString(5);
                pobjBusquedaDocente.Celular = Dr.GetString(6);
                pobjBusquedaDocente.Telefono = Dr.GetString(7);
                pobjBusquedaDocente.Correo = Dr.GetString(8);
                pobjBusquedaDocente.Curp = Dr.GetString(9);
                pobjBusquedaDocente.FechaNacimiento = Dr.GetString(10);
                pobjBusquedaDocente.NombreEstado = Dr.GetString(11);
                pobjBusquedaDocente.NombreDistrito = Dr.GetString(12);
                pobjBusquedaDocente.NombreMunicipio = Dr.GetString(13);
                pobjBusquedaDocente.Calle = Dr.GetString(14);
                pobjBusquedaDocente.Colonia = Dr.GetString(15);
                pobjBusquedaDocente.Localidad = Dr.GetString(16);
                pobjBusquedaDocente.Numero = Dr.GetString(17);
                pobjBusquedaDocente.NombreProfesion = Dr.GetString(18);
                pobjBusquedaDocente.IdDireccion = Dr.GetInt32(19);
                pobjBusquedaDocente.IdDatosPersonales = Dr.GetInt32(20);
                pobjBusquedaDocente.IdProfesion = Dr.GetInt32(21);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjBusquedaDocente;
        }

        public static bool Actualizar(objDocentes pobjDocentes)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update docentes set Rfc='{0}', IdProfesion='{1}' where Rfc = '{2}'", pobjDocentes.Rfc,pobjDocentes.IdProfesion,pobjDocentes.antRfc), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
                MessageBox.Show(""+resultado);
                Cnn.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Error" + ee);
            }
            
            return resultado;
        }

        public static bool EliminarDocente (string pRFC)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("DELETE FROM docentes WHERE Rfc='{0}';", pRFC), Cnn);
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
    }
}
