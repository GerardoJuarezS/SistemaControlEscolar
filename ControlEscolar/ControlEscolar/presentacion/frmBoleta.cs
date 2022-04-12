using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
using ControlEscolar.logica;
using ControlEscolar.objetos;
namespace ControlEscolar.presentacion
{
    public partial class frmBoleta : Form
    {
        public frmBoleta()
        {
            InitializeComponent();
        }
        void mostrarFechaNacimiento()
        {
            string semestreanterior;
            string consultasemestreanterior = "select datospersonales.FechaNacimiento from datospersonales,alumno where alumno.Matricula='"+lblmatricula.Text+"' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales;";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblfechanacimiento.Text= semestreanterior;
            }
        }
        void mostrarCURP()
        {
            string semestreanterior;
            string consultasemestreanterior = "select datospersonales.Curp from datospersonales,alumno where alumno.Matricula='"+lblmatricula.Text+"' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblcurp.Text = semestreanterior;
            }
        }
        void mostrarSexo()
        {
            string semestreanterior;
            string consultasemestreanterior = "select datospersonales.Sexo from datospersonales,alumno where alumno.Matricula='"+lblmatricula.Text+"' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblsexo.Text = semestreanterior;
            }
        }
        private void frmBoleta_Load(object sender, EventArgs e)
        {

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select 1P, 2p, 3p, 4p ,5p 6p, PromedioGeneral, UAC from calificaciones, materias,materiasemestre where Matricula = '"+lblmatricula.Text+"' and materiasemestre.IdSemestre = '"+lblsemestre.Text+"' and calificaciones.CodigoMateria = materias.CodigoMaterias and materiasemestre.CodigoMaterias = calificaciones.CodigoMateria and materiasemestre.CodigoMaterias = calificaciones.CodigoMateria";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();

            mostrarFechaNacimiento();
            mostrarCURP();
            mostrarSexo();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf1.PrintFileName = "Boleta de calificaciones";
            pf1.Print();
        }
    }
}
