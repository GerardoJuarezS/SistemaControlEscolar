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
    class clsAlumnoMaterias
    {
        public static bool GuardarPrimerSemestre(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}',1101),('{0}',1203),('{0}',1304),('{0}',1301),('{0}',1401),('{0}',1403),('{0}',1409)", pobjAlumnoMaterias.Matricula), Cnn);
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

        public static bool GuardarSegundoSemestre(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1102'),('{0}','1204'),('{0}','1305'),('{0}','1302'),('{0}','1402'),('{0}','1404'),('{0}','1410')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarTercerSemestreHSC(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1103'),('{0}','1205'),('{0}','1201'),('{0}','1407'),('{0}','1303'),('{0}','1405'),('{0}','4291'),('{0}','4293')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarCuartoSemestreHSC(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1104'),('{0}','1206'),('{0}','1202'),('{0}','1408'),('{0}','1306'),('{0}','1406'),('{0}','2101'),('{0}','4294'),('{0}','4292')", pobjAlumnoMaterias.Matricula), Cnn);
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

        public static bool GuardarQuintoSemestreHSC(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1208'),('{0}','1307'),('{0}','2301'),('{0}','2302'),('{0}','2353'),('{0}','2336'),('{0}','4297'),('{0}','4295')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarSextoSemestreHSC(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1207'),('{0}','1308'),('{0}','1309'),('{0}','2401'),('{0}','2402'),('{0}','2409'),('{0}','2436'),('{0}','4298'),('{0}','4296')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarTercerSemestreTICS(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1103'),('{0}','1205'),('{0}','1201'),('{0}','1407'),('{0}','1303'),('{0}','1405'),('{0}','4601'),('{0}','4603')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarCuartoSemestreTICS(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1104'),('{0}','1206'),('{0}','1202'),('{0}','1408'),('{0}','1306'),('{0}','1406'),('{0}','2101'),('{0}','4604'),('{0}','4602')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarQuintoSemestreTICS(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1208'),('{0}','1307'),('{0}','2345'),('{0}','2349'),('{0}','2344'),('{0}','2353'),('{0}','4605'),('{0}','4607')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarSextoSemestreTICS(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1207'),('{0}','1308'),('{0}','1309'),('{0}','2445'),('{0}','2449'),('{0}','2451'),('{0}','2444'),('{0}','4608'),('{0}','4606')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarTercerSemestreADMON(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1103'),('{0}','1205'),('{0}','1201'),('{0}','1407'),('{0}','1303'),('{0}','1405'),('{0}','4033'),('{0}','4031')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarCuartoSemestreADMON(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1104'),('{0}','1206'),('{0}','1202'),('{0}','1408'),('{0}','1306'),('{0}','1406'),('{0}','2101'),('{0}','4034'),('{0}','4032')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarQuintoSemestreADMON(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1208'),('{0}','1307'),('{0}','2345'),('{0}','2363'),('{0}','2358'),('{0}','2326'),('{0}','4035'),('{0}','4037')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarSextoSemestreADMON(objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','1207'),('{0}','1308'),('{0}','1309'),('{0}','2445'),('{0}','2458'),('{0}','2523'),('{0}','2426'),('{0}','4038'),('{0}','4036')", pobjAlumnoMaterias.Matricula), Cnn);
            try
            {
                resultado = Convert.ToBoolean(Cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Duplicada");

            }
            Cnn.Close();
            return resultado;
        }

        public static bool GuardarAlumnoMateria (objAlumnoMaterias pobjAlumnoMaterias)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("insert into alumnomaterias (Matricula, CodigoMaterias) values ('{0}','{1}')", pobjAlumnoMaterias.Matricula, pobjAlumnoMaterias.CodigoMaterias), Cnn);
            try
            {
                resultado =Convert.ToBoolean( Cmd.ExecuteNonQuery());
            }
            catch (Exception ee)
            {
                MessageBox.Show("Entrada Duplicada" + ee);

            }
            Cnn.Close();
            return resultado;
        }

        public static List<objAlumnoMaterias> BuscarAlumnoMateria(string pMatricula)
        {
            List<objAlumnoMaterias> _lista = new List<objAlumnoMaterias>();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select alumnomaterias.IdAlumnoMaterias, alumnomaterias.Matricula, alumnomaterias.CodigoMaterias,materias.UAC from AlumnoMaterias,materias where Matricula = '{0}' and alumnomaterias.CodigoMaterias = materias.CodigoMaterias", pMatricula), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {

                objAlumnoMaterias pobjAlumnoMateria = new objAlumnoMaterias();
                pobjAlumnoMateria.IdAlumnoMateria = Dr.GetInt32(0);
                pobjAlumnoMateria.Matricula = Dr.GetString(1);
                pobjAlumnoMateria.CodigoMaterias = Dr.GetInt32(2);
                pobjAlumnoMateria.UAC = Dr.GetString(3);
                _lista.Add(pobjAlumnoMateria);
            }
            return _lista;
        }

        public static objAlumnoMaterias ObtenerAlumnoMateria(int pIdAlumnoMateriaa)
        {
            objAlumnoMaterias pobjAlumnoMateria = new objAlumnoMaterias();
            MySqlCommand Cmd = new MySqlCommand(string.Format("select IdAlumnoMaterias, Matricula, CodigoMaterias from AlumnoMaterias where IdAlumnoMaterias = '{0}'", pIdAlumnoMateriaa), clsConexion.BaseDeDatos());
            MySqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                pobjAlumnoMateria.IdAlumnoMateria = Dr.GetInt32(0);
                pobjAlumnoMateria.Matricula = Dr.GetString(1);
                pobjAlumnoMateria.CodigoMaterias = Dr.GetInt32(2);
            }

            clsConexion.BaseDeDatos().Close();
            return pobjAlumnoMateria;
        }

        public static bool ActualizarAlumnoMateria(objAlumnoMaterias pobjAlumnoMateria)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("update AlumnoMateria set Matricula = '{0}', CodigoMateria = '{1}' where IdAlumnoMateria = '{2}'",pobjAlumnoMateria.Matricula,pobjAlumnoMateria.CodigoMaterias, pobjAlumnoMateria.IdAlumnoMateria), Cnn);
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

        public static bool EliminarAlumnoMateria(int pIdAlumnoMateria)
        {
            bool resultado = false;
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand(string.Format("delete from alumnomaterias where IdAlumnoMaterias = '{0}'", pIdAlumnoMateria), Cnn);
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
