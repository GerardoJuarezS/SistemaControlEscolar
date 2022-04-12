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
    public partial class frmMateriasSemestre : Form
    {
        public frmMateriasSemestre()
        {
            InitializeComponent();
        }
        objMateriaSemestre MateriaSemestreActual { get; set; }
        public string IdMateria;
        private void frmMateriasSemestre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsIdSemestre.semestre' Puede moverla o quitarla según sea necesario.
            this.semestreTableAdapter.Fill(this.dsIdSemestre.semestre);
            // TODO: esta línea de código carga datos en la tabla 'dsUAC.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.dsUAC.materias);

        }
        void MostrarIdMateria(string materiaa)
        {
            string consultaidmateria = "select CodigoMaterias from materias where UAC = '" + materiaa + "'";

            MySqlConnection Cnnidmateria = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidmateria = new MySqlCommand(String.Format(consultaidmateria), Cnnidmateria);
            MySqlDataReader Dridmateria = Cmdidmateria.ExecuteReader();
            while (Dridmateria.Read())
            {
                IdMateria = Dridmateria.GetString(0);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objMateriaSemestre pobjMateriaSemestre = new objMateriaSemestre();
            pobjMateriaSemestre.CodigoMaterias = Convert.ToInt32(IdMateria);
            pobjMateriaSemestre.IdSemestre = Convert.ToInt32(cbSemestre.Text);
            bool resultado = clsMateriasSemestre.GuardarMateriasEnSemestre(pobjMateriaSemestre);
            if (resultado == true)
            {
                
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();

            Cmd.CommandText = "select materias.CodigoMaterias ,materias.uac, semestre.IdSemestre from materias, materiasemestre, semestre where  semestre.IdSemestre = '" + cbSemestre.Text + "' and materias.CodigoMaterias = materiasemestre.CodigoMaterias and semestre.IdSemestre = materiasemestre.IdSemestre";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIdMateria(cbMateria.Text);

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();

            Cmd.CommandText = "select materias.CodigoMaterias ,materias.uac, semestre.IdSemestre from materias, materiasemestre, semestre where  semestre.IdSemestre = '" + cbSemestre.Text + "' and materias.CodigoMaterias = materiasemestre.CodigoMaterias and semestre.IdSemestre = materiasemestre.IdSemestre";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();

            Cmd.CommandText = "select materias.CodigoMaterias ,materias.uac, semestre.IdSemestre from materias, materiasemestre, semestre where  semestre.IdSemestre = '" + cbSemestre.Text + "' and materias.CodigoMaterias = materiasemestre.CodigoMaterias and semestre.IdSemestre = materiasemestre.IdSemestre";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMateriaSemestre FormularioBusquedaMateriaSemestre = new frmBusquedaMateriaSemestre();
            FormularioBusquedaMateriaSemestre.ShowDialog();
            if (FormularioBusquedaMateriaSemestre.MateriaSemestreSeleccionada != null)
            {
                MateriaSemestreActual = FormularioBusquedaMateriaSemestre.MateriaSemestreSeleccionada;
                cbMateria.Text = Convert.ToString(FormularioBusquedaMateriaSemestre.MateriaSemestreSeleccionada.CodigoMaterias);
                cbSemestre.Text = Convert.ToString(FormularioBusquedaMateriaSemestre.MateriaSemestreSeleccionada.IdSemestre);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objMateriaSemestre pobjMateriaSemestre = new objMateriaSemestre();
            pobjMateriaSemestre.CodigoMaterias = Convert.ToInt32(IdMateria);
            pobjMateriaSemestre.IdSemestre = Convert.ToInt32(cbSemestre.Text);
            pobjMateriaSemestre.IdMateriaSemestre = Convert.ToInt32(MateriaSemestreActual.IdMateriaSemestre);
            bool resultado = clsMateriasSemestre.Actualizar(pobjMateriaSemestre);
            if (resultado == true)
            {

            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (clsAlergias.EliminarAlergia(AlergiaActual.IdAlergias) == true)
            //{
            //    MessageBox.Show("eliminado");
            //}
            if (clsMateriasSemestre.Eliminar(MateriaSemestreActual.IdMateriaSemestre)== true)
            {
                MessageBox.Show("eliminado");
            }
        }

        private void frmMateriasSemestre_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
