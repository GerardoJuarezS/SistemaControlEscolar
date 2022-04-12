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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }
        public void LlenarMatriculas()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select alumno.Matricula from alumno", Cnn);
            Myda.Fill(dsMatricula, "alumno");
            cbMatricula.DataSource = dsMatricula.Tables[0].DefaultView;
            cbMatricula.ValueMember = "matricula";
            cbMatricula.DisplayMember = "matricula";
        }

        public void LlenarSemestres()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select alumnosemestre.idsemestre from alumnosemestre where alumnosemestre.Matricula = '"+cbMatricula.Text+"'", Cnn);
            Myda.Fill(dsMatricula, "alumnosemestre");
            cbSemestre.DataSource = dsMatricula.Tables[0].DefaultView;
            cbSemestre.ValueMember = "idsemestre";
            cbSemestre.DisplayMember = "idsemestre";
        }

        public void LlenarGrupo()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select alumnogrupo.IdGrupo from alumnogrupo where alumnogrupo.Matricula = '"+cbMatricula.Text+"'", Cnn);
            Myda.Fill(dsMatricula, "alumnogrupo");
            cbGrupo.DataSource = dsMatricula.Tables[0].DefaultView;
            cbGrupo.ValueMember = "IdGrupo";
            cbGrupo.DisplayMember = "IdGrupo";
        }

        void mostrarnombre(string matricula)
        {
            string nombre;
            string consultanombre = "SELECT datospersonales.Nombre FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnnombre = clsConexion.BaseDeDatos();
            MySqlCommand Cmdnombre = new MySqlCommand(String.Format(consultanombre), Cnnnombre);
            MySqlDataReader Drnombre = Cmdnombre.ExecuteReader();
            while (Drnombre.Read())
            {
                nombre = Drnombre.GetString(0);
                lblNombre.Text = nombre;
            }
        }

        void mostrarapellidopaterno(string matricula)
        {
            string ApellidoPaterno;
            string consultaAP = "SELECT datospersonales.ApellidoPaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnap = clsConexion.BaseDeDatos();
            MySqlCommand Cmdap = new MySqlCommand(String.Format(consultaAP), Cnnap);
            MySqlDataReader Drap = Cmdap.ExecuteReader();
            while (Drap.Read())
            {
                ApellidoPaterno = Drap.GetString(0);
                lblAP.Text = ApellidoPaterno;
            }
        }

        void mostrarapellidomaterno(string matricula)
        {
            string ApellidoMaterno;
            string consultaAM = "SELECT datospersonales.ApellidoMaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnam = clsConexion.BaseDeDatos();
            MySqlCommand Cmdam = new MySqlCommand(String.Format(consultaAM), Cnnam);
            MySqlDataReader Dram = Cmdam.ExecuteReader();
            while (Dram.Read())
            {
                ApellidoMaterno = Dram.GetString(0);
                lblAM.Text = ApellidoMaterno;
            }
        }

        void mostrargrupo(string matricula)
        {

            string Grupo;
            string consultaG = "SELECT IdGrupo from alumnogrupo where Matricula='" + matricula + "'";

            MySqlConnection CnnG = clsConexion.BaseDeDatos();
            MySqlCommand CmdG = new MySqlCommand(String.Format(consultaG), CnnG);
            MySqlDataReader DrG = CmdG.ExecuteReader();
            while (DrG.Read())
            {
                Grupo = DrG.GetString(0);
                lblGrupo.Text = Grupo;
            }
        }

        void mostrarsemestre(string matricula)
        {
            string semestreanterior;
            string consultasemestreanterior = "select idsemestre from alumnosemestre where Matricula = '" + matricula + "'";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblSemestre.Text = semestreanterior;
            }
        }

        void mostrartutor(string matricula)
        {
            string semestreanterior;
            string consultasemestreanterior = "select tutor from alumno where alumno.Matricula = '"+matricula+"'";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lbltutor.Text = semestreanterior;
            }
        }

        void mostrarpromediosemestre()
        {
            float semestreanterior;
            string consultasemestreanterior = "select avg(PromedioGeneral) from calificaciones,alumnosemestre,materiasemestre where calificaciones.Matricula = '"+cbMatricula.Text+"' and alumnosemestre.idsemestre = '"+cbSemestre.Text+"' and calificaciones.CodigoMateria = materiasemestre.CodigoMaterias";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                try
                {
                    semestreanterior = Drsemestreanterior.GetFloat(0);
                    lblpromedio.Text = semestreanterior.ToString("N2");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error"+e);
                }
            }
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            LlenarMatriculas();
        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarnombre(cbMatricula.Text);
            mostrarapellidopaterno(cbMatricula.Text);
            mostrarapellidomaterno(cbMatricula.Text);
            mostrargrupo(cbMatricula.Text);
            mostrarsemestre(cbMatricula.Text);
            mostrartutor(cbMatricula.Text);
            LlenarSemestres();
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarpromediosemestre();
            LlenarGrupo();
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            frmConstanciaDeEstudios FormularioConstancia = new frmConstanciaDeEstudios();
            FormularioConstancia.lblnombre.Text = lblNombre.Text;
            FormularioConstancia.lblApaterno.Text = lblAP.Text;
            FormularioConstancia.lblAmaterno.Text = lblAM.Text;
            FormularioConstancia.lblpromedio.Text = lblpromedio.Text;
            FormularioConstancia.lblsemestre.Text = lblSemestre.Text;
            FormularioConstancia.lblmatricula.Text = cbMatricula.Text;
            FormularioConstancia.lblgrupo.Text = cbGrupo.Text;
            FormularioConstancia.ShowDialog();
        }

        private void btnboleta_Click(object sender, EventArgs e)
        {
            frmBoleta FormularioBoleta = new frmBoleta();
            FormularioBoleta.lblmatricula.Text = cbMatricula.Text;
            FormularioBoleta.lblgrupo.Text = cbGrupo.Text;
            FormularioBoleta.lblsemestre.Text = cbSemestre.Text;
            FormularioBoleta.lblnombre.Text = lblNombre.Text;
            FormularioBoleta.lblapellidopaterno.Text = lblAP.Text;
            FormularioBoleta.lblapellidomaterno.Text = lblAM.Text;
            FormularioBoleta.lblpromediogeneral.Text = lblpromedio.Text;
            FormularioBoleta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPermisoDeClases FormularioPermisos = new frmPermisoDeClases();
            FormularioPermisos.lblnombre.Text = lblNombre.Text;
            FormularioPermisos.lblApaterno.Text = lblAP.Text;
            FormularioPermisos.lblAmaterno.Text = lblAM.Text;
            FormularioPermisos.lblMatricula.Text = cbMatricula.Text;
            FormularioPermisos.lblSemestre.Text = cbSemestre.Text;
            FormularioPermisos.lbltutor.Text = lbltutor.Text;
            FormularioPermisos.ShowDialog();
        }
    }
}
