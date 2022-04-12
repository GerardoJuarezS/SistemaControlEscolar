using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.logica;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using MySql.Data.MySqlClient;
namespace ControlEscolar.presentacion
{
    public partial class frmAlumnoEnfermedad : Form
    {
        public frmAlumnoEnfermedad()
        {
            InitializeComponent();
        }
        public objAlumnoEnfermedad AlumnoEnfermoActual { get; set; }
        public string Enfermedad;
        private void frmAlumnoEnfermedad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreEnfermedad.enfermedad' Puede moverla o quitarla según sea necesario.
            this.enfermedadTableAdapter.Fill(this.dsNombreEnfermedad.enfermedad);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlumnoEnfermedad pobjAlumnoEnfermedad = new objAlumnoEnfermedad();
            pobjAlumnoEnfermedad.IdEnfermedad = Convert.ToInt32(Enfermedad);
            pobjAlumnoEnfermedad.Matricula = lblMatricula.Text.Trim();

            int resultado = clsAlumnoEnfermedad.GuardarAlumnoEnfermedad(pobjAlumnoEnfermedad);
            if (resultado > 0)
            {
                MessageBox.Show("guardado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objAlumnoEnfermedad pobjAlumnoEnfermedad = new objAlumnoEnfermedad();
            pobjAlumnoEnfermedad.IdAlumnoEnfermedad = AlumnoEnfermoActual.IdAlumnoEnfermedad;
            pobjAlumnoEnfermedad.IdEnfermedad = Convert.ToInt32(Enfermedad);
            pobjAlumnoEnfermedad.Matricula = lblMatricula.Text.Trim();

            if (clsAlumnoEnfermedad.ActualizarAlumnoEnfermedad(pobjAlumnoEnfermedad) == true)
            {
                MessageBox.Show("datos actualizados");
            }
            else
            {
                //  MessageBox.Show("Error al actualizar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnoEnfermedad FormularioBusquedaAlumnoEnfermo = new frmBusquedaAlumnoEnfermedad();
            FormularioBusquedaAlumnoEnfermo.ShowDialog();

            if (FormularioBusquedaAlumnoEnfermo.AlumnoEnfermoSeleccionado != null)
            {
                AlumnoEnfermoActual = FormularioBusquedaAlumnoEnfermo.AlumnoEnfermoSeleccionado;
                lblMatricula.Text = FormularioBusquedaAlumnoEnfermo.AlumnoEnfermoSeleccionado.Matricula;

            }
        }

        void IdEnfermedad(string Enfermedadd)
        {
            string consultaalergia = "select IdEnfermedad from enfermedad where NombreEnfermedad = '" + Enfermedadd + "'";

            MySqlConnection Cnnalergia = clsConexion.BaseDeDatos();
            MySqlCommand Cmdalergia = new MySqlCommand(String.Format(consultaalergia), Cnnalergia);
            MySqlDataReader Dralergia = Cmdalergia.ExecuteReader();
            while (Dralergia.Read())
            {
                Enfermedad = Dralergia.GetString(0);
            }
        }

        private void cbAlergia_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEnfermedad(cbEnfermedad.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsAlumnoEnfermedad.EliminarAlumnoEnfermedad(AlumnoEnfermoActual.IdAlumnoEnfermedad) == true)
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void frmAlumnoEnfermedad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
