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
    public partial class frmAlumnoGrupo : Form
    {
        public objAlumnoGrupo AlumnoGrupoActual { get; set; }
        public frmAlumnoGrupo()
        {
            InitializeComponent();
        }
        public int IdentificadorAlumnoGrupo;

        void CargarGrupos()
        {
            MySqlCommand Cmd = new MySqlCommand("select distinct alumnogrupo.IdGrupo from alumnogrupo", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbGrupo.ValueMember = "IdGrupo";
            cbGrupo.DataSource = Dt;
        }

        void CargarMatriculas()
        {
            MySqlCommand Cmd = new MySqlCommand("select distinct  alumnogrupo.Matricula from alumnogrupo where alumnogrupo.IdGrupo = '" + cbGrupo.Text+ "'", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbMatricula.ValueMember = "Matricula";
            cbMatricula.DataSource = Dt;
        }

        void MostrarIdAlumnoGrupo(string materiaa)
        {
            string consultaidmateria = "select alumnogrupo.IdAlumnoGrupo from alumnogrupo where alumnogrupo.Matricula = '"+cbMatricula.Text+"' and alumnogrupo.IdGrupo = '"+cbGrupo.Text+"'";

            MySqlConnection Cnnidmateria = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidmateria = new MySqlCommand(String.Format(consultaidmateria), Cnnidmateria);
            MySqlDataReader Dridmateria = Cmdidmateria.ExecuteReader();
            while (Dridmateria.Read())
            {
                IdentificadorAlumnoGrupo = Dridmateria.GetInt32(0);
            }
        }

        private void frmAlumnoGrupo_Load(object sender, EventArgs e)
        {
            CargarGrupos();
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMatriculas();

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select distinct datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, alumnogrupo.IdGrupo from datospersonales,alumno,alumnogrupo where alumnogrupo.IdGrupo = '"+cbGrupo.Text+"' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales and alumno.Matricula = alumnogrupo.Matricula or alumnogrupo.Matricula = '"+cbMatricula.Text+"' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales and alumno.Matricula = alumnogrupo.Matricula";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();
        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select distinct datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno, alumnogrupo.IdGrupo from datospersonales,alumno,alumnogrupo where alumnogrupo.IdGrupo = '" + cbGrupo.Text + "' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales and alumno.Matricula = alumnogrupo.Matricula or alumnogrupo.Matricula = '" + cbMatricula.Text + "' and datospersonales.IdDatosPersonales = alumno.IdDatosPersonales and alumno.Matricula = alumnogrupo.Matricula";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlumnoGrupo pobjAlumnoGrupo = new objAlumnoGrupo();
            pobjAlumnoGrupo.IdGrupo = Convert.ToInt32(cbGrupo.Text.Trim());
            pobjAlumnoGrupo.Matricula = cbMatricula.Text.Trim();
            if (clsAlumnoGrupo.GuardarAlumnoGrupo(pobjAlumnoGrupo) == true)
            {

            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            objAlumnoGrupo pobjAlumnoGrupo = new objAlumnoGrupo();
            pobjAlumnoGrupo.Matricula = cbMatricula.Text;
            pobjAlumnoGrupo.IdGrupo = Convert.ToInt32(cbGrupo.Text);
            pobjAlumnoGrupo.IdAlumnoGrupo = AlumnoGrupoActual.IdAlumnoGrupo;
            if (clsAlumnoGrupo.ActualizarAlumnoGrupo(pobjAlumnoGrupo) == true)
            {

            }
            else
            {
                MessageBox.Show("Error al actualizar los datos");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (clsAlumnoGrupo.EliminarAlumnoGrupo(AlumnoGrupoActual.IdAlumnoGrupo) == true)
            {
                MessageBox.Show("Dato Eliminado Correctamente");
            }
            else
                MessageBox.Show("Error al eliminar");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnoGrupo FormularioBusquedaAlumnoGrupo = new frmBusquedaAlumnoGrupo();
            FormularioBusquedaAlumnoGrupo.ShowDialog();
            if (FormularioBusquedaAlumnoGrupo.AlumnoGrupoSeleccionado != null)
            {
                AlumnoGrupoActual = FormularioBusquedaAlumnoGrupo.AlumnoGrupoSeleccionado;
                cbGrupo.Text = Convert.ToString(FormularioBusquedaAlumnoGrupo.AlumnoGrupoSeleccionado.IdGrupo);
                cbMatricula.Text = FormularioBusquedaAlumnoGrupo.AlumnoGrupoSeleccionado.Matricula;
            }
        }
    }
}
