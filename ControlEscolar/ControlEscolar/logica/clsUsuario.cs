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
    class clsUsuario
    {
        public static bool GuardarUsuario(objUsuarios pobjUsuarios)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into usuarios (NombreUsuario, Contraseña, IdGrupoUsuario, IdDatosPersonales) values ('{0}','{1}','{2}','{3}')",pobjUsuarios.NombreUsuario, pobjUsuarios.Contraseña, pobjUsuarios.IdGrupoUsuario,pobjUsuarios.IdDatosPersonales), Cnn);
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

        public static List<objBusquedaUsuario> Buscar(string pCurp)
        {
            List<objBusquedaUsuario> _lista = new List<objBusquedaUsuario>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select usuarios.IdUsuarios,datospersonales.IdDatosPersonales, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Curp, datospersonales.Telefono, datospersonales.Celular, datospersonales.correo, datospersonales.Nss, datospersonales.Sexo, datospersonales.FechaNacimiento,usuarios.NombreUsuario,usuarios.Contraseña,usuarios.IdUsuarios, grupousuario.NombreGrupoUsuario from datospersonales,usuarios,grupousuario where datospersonales.Curp = '{0}' and usuarios.IdDatosPersonales = datospersonales.IdDatosPersonales and usuarios.IdGrupoUsuario = grupousuario.IdGrupoUsuario", pCurp), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objBusquedaUsuario pobjBusquedaUsuario = new objBusquedaUsuario();
                pobjBusquedaUsuario.IdUsuario = Dr.GetInt32(0);
                pobjBusquedaUsuario.IdDatosPersonales = Dr.GetInt32(1);
                pobjBusquedaUsuario.NombreUsuario = Dr.GetString(12);
                pobjBusquedaUsuario.Contraseña = Dr.GetString(13);
                pobjBusquedaUsuario.NombreGrupoUsuario = Dr.GetString(15);
                pobjBusquedaUsuario.Nombre = Dr.GetString(2);
                pobjBusquedaUsuario.ApellidoPaterno = Dr.GetString(3);
                pobjBusquedaUsuario.ApellidoMaterno = Dr.GetString(4);
                pobjBusquedaUsuario.Curp = Dr.GetString(5);
                pobjBusquedaUsuario.Telefono = Dr.GetString(6);
                pobjBusquedaUsuario.Celular = Dr.GetString(7);
                pobjBusquedaUsuario.Correo = Dr.GetString(8);
                pobjBusquedaUsuario.Nss = Dr.GetString(9);
                pobjBusquedaUsuario.Sexo = Dr.GetString(10);
                pobjBusquedaUsuario.FechaNacimiento = Dr.GetString(11);

                _lista.Add(pobjBusquedaUsuario);
            }
            return _lista;
        }
        public static objBusquedaUsuario ObtenerUsuario(int pId)
        {
            objBusquedaUsuario pobjBusquedaUsuario = new objBusquedaUsuario();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select usuarios.IdUsuarios,datospersonales.IdDatosPersonales, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, datospersonales.Curp, datospersonales.Telefono, datospersonales.Celular, datospersonales.correo, datospersonales.Nss, datospersonales.Sexo, datospersonales.FechaNacimiento,usuarios.NombreUsuario,usuarios.Contraseña,grupousuario.NombreGrupoUsuario from datospersonales,usuarios,grupousuario where usuarios.IdUsuarios = {0} and usuarios.IdDatosPersonales = datospersonales.IdDatosPersonales and usuarios.IdGrupoUsuario = grupousuario.IdGrupoUsuario", pId), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
         
            while (Dr.Read())
            {
                pobjBusquedaUsuario.IdUsuario = Dr.GetInt32(0);
                pobjBusquedaUsuario.IdDatosPersonales = Dr.GetInt32(1);
                pobjBusquedaUsuario.NombreUsuario = Dr.GetString(12);
                pobjBusquedaUsuario.Contraseña = Dr.GetString(13);
                pobjBusquedaUsuario.NombreGrupoUsuario = Dr.GetString(14);
                pobjBusquedaUsuario.Nombre = Dr.GetString(2);
                pobjBusquedaUsuario.ApellidoPaterno = Dr.GetString(3);
                pobjBusquedaUsuario.ApellidoMaterno = Dr.GetString(4);
                pobjBusquedaUsuario.Curp = Dr.GetString(5);
                pobjBusquedaUsuario.Telefono = Dr.GetString(6);
                pobjBusquedaUsuario.Celular = Dr.GetString(7);
                pobjBusquedaUsuario.Correo = Dr.GetString(8);
                pobjBusquedaUsuario.Nss = Dr.GetString(9);
                pobjBusquedaUsuario.Sexo = Dr.GetString(10);
                pobjBusquedaUsuario.FechaNacimiento = Dr.GetString(11);
            }
           
            clsConexion.BaseDeDatos().Close();
            return pobjBusquedaUsuario;
        }

        public static bool ActualizarUsuario (objUsuarios pobjUsuarios )
        {
            bool resultado = false;
            try
            {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update usuarios set NombreUsuario ='{0}',Contraseña ='{1}', IdGrupoUsuario = '{2}', IdDatosPersonales = '{3}' where IdUsuarios  ='{4}' ", pobjUsuarios.NombreUsuario, pobjUsuarios.Contraseña, pobjUsuarios.IdGrupoUsuario, pobjUsuarios.IdDatosPersonales, pobjUsuarios.IdUsuarios), Cnn);
           
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
                Cnn.Close(); Cnn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error"+ ee);
            }
           
            return resultado;
        }

        public  bool HabraPerfiles ()
        {
            string consulta = "select count(*) from usuarios";
            MySqlCommand Cmd = new MySqlCommand(consulta,clsConexion.BaseDeDatos());
            object resultado = Cmd.ExecuteScalar();
            int res = Convert.ToInt32(resultado);
            if  (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
