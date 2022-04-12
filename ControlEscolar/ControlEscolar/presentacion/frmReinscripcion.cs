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
    public partial class frmReinscripcion : Form
    {
        public frmReinscripcion()
        {
            InitializeComponent();
        }
        public objAlumnoMaterias AlumnoMateriaActual { get; set; }
        public objAlumnoSemestre AlumnoSemestreActual { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            {

                objAlumnoMaterias pobjAlumnoMaterias = new objAlumnoMaterias();
                objAlumnoSemestre pobjAlumnoSemestre = new objAlumnoSemestre();
                pobjAlumnoMaterias.Matricula = cbMatricula.Text.Trim();
                pobjAlumnoSemestre.Matricula = cbMatricula.Text.Trim();
                pobjAlumnoSemestre.IdSemestre = Convert.ToInt32(cbSemestre.Text.Trim());

                objAlumnoGrupo pobjAlumnoGrupo = new objAlumnoGrupo();
                pobjAlumnoGrupo.IdGrupo = Convert.ToInt32(cbGrupo.Text.Trim());
                pobjAlumnoGrupo.Matricula = cbMatricula.Text.Trim();
                if (clsAlumnoGrupo.GuardarAlumnoGrupo(pobjAlumnoGrupo) == true)
                {

                }
                else
                {
                    MessageBox.Show("Error al guardar el grupo");
                }

                if (cbSemestre.SelectedIndex == 0)
                {
                    if (clsAlumnoMaterias.GuardarPrimerSemestre(pobjAlumnoMaterias) == true)
                    {
                       
                    }
                }

                if (cbSemestre.SelectedIndex == 1)
                {
                    if (clsAlumnoMaterias.GuardarSegundoSemestre(pobjAlumnoMaterias) == true)
                    {

                    }
                }

                if (cbSemestre.SelectedIndex == 2)
                {
                    if (rbHSC.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarTercerSemestreHSC(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbTICS.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarTercerSemestreTICS(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbADMON.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarTercerSemestreADMON(pobjAlumnoMaterias) == true)
                        {

                        }
                    }
                }

                if (cbSemestre.SelectedIndex == 3)
                {
                    if (rbHSC.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarCuartoSemestreHSC(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbTICS.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarCuartoSemestreTICS(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbADMON.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarCuartoSemestreADMON(pobjAlumnoMaterias) == true)
                        {

                        }
                    }
                }

                if (cbSemestre.SelectedIndex == 4)
                {
                    if (rbHSC.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarQuintoSemestreHSC(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbTICS.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarQuintoSemestreTICS(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbADMON.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarQuintoSemestreADMON(pobjAlumnoMaterias) == true)
                        {

                        }
                    }
                }

                if (cbSemestre.SelectedIndex == 5)
                {
                    if (rbHSC.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarSextoSemestreHSC(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbTICS.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarSextoSemestreTICS(pobjAlumnoMaterias) == true)
                        {

                        }
                    }

                    if (rbADMON.Checked)
                    {
                        if (clsAlumnoMaterias.GuardarSextoSemestreADMON(pobjAlumnoMaterias) == true)
                        {

                        }
                    }
                }
                bool resultado1 = clsAlumnoSemestre.GuardarAlumnoSemestre(pobjAlumnoSemestre);
                if (resultado1 == true)
                {
                    MessageBox.Show("Alumno Reinscripto Correctamente");
                }
                frmReporteReinscripcion ReporteReinscripcion = new frmReporteReinscripcion();
                ReporteReinscripcion.lblNombree.Text = lblNombre.Text;
                ReporteReinscripcion.lblApellidoPaterno.Text = lblAP.Text;
                ReporteReinscripcion.lblApellidoMaterno.Text = lblAM.Text;
                ReporteReinscripcion.lblMatriculaa.Text = cbMatricula.Text;
                ReporteReinscripcion.lblSemestre.Text = cbSemestre.Text;
                ReporteReinscripcion.dgvCalificaciones.DataSource = dgvMateriasAnteriores.DataSource;
                ReporteReinscripcion.ShowDialog();
            }
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

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                mostrarnombre(cbMatricula.Text);
                mostrarapellidopaterno(cbMatricula.Text);
                mostrarapellidomaterno(cbMatricula.Text);
                mostrargrupo(cbMatricula.Text);
                mostrarsemestre(cbMatricula.Text);

                MySqlConnection Cnn = clsConexion.BaseDeDatos();
                MySqlCommand Cmd = new MySqlCommand();
                Cmd.CommandText = "select 1P, 2p, 3p, 4p ,5p 6p, PromedioGeneral, UAC from calificaciones, materias where Matricula = '"+cbMatricula.Text+"' and calificaciones.CodigoMateria = materias.CodigoMaterias";
                Cmd.Connection = Cnn;

                DataSet Ds = new DataSet();
                MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
                Da.Fill(Ds);
                dgvMateriasAnteriores.DataSource = Ds.Tables[0];
                dgvMateriasAnteriores.AutoResizeColumns();
            }
        }

        private void frmReinscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsIdGrupo.grupo' Puede moverla o quitarla según sea necesario.
            this.grupoTableAdapter.Fill(this.dsIdGrupo.grupo);
            // TODO: esta línea de código carga datos en la tabla 'dsMatricula.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dsMatricula.alumno);
            // TODO: esta línea de código carga datos en la tabla 'dsIdSemestre.semestre' Puede moverla o quitarla según sea necesario.
            this.semestreTableAdapter.Fill(this.dsIdSemestre.semestre);

        }

        private void frmReinscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
