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
    public partial class frmAlumnoAlergia : Form
    {
        public frmAlumnoAlergia()
        {
            InitializeComponent();
        }
        public objAlumnoAlergia AlumnoAlergicoActual { get; set; }
        public string Alergia;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlumnoAlergia pobjAlumnoAlergia = new objAlumnoAlergia();
            pobjAlumnoAlergia.IdAlergia = Convert.ToInt32(Alergia);
            pobjAlumnoAlergia.Matricula = lblMatricula.Text.Trim();

            int resultado = clsAlumnoAlergia.GuardarAlumnoAlergia(pobjAlumnoAlergia);
            if (resultado > 0)
            {
                MessageBox.Show("guardado");
            }
        }

        void IdAlergia(string Alergiaa)
        {
            string consultaalergia = "select IdAlergias from alergias where NombreAlergia = '" + Alergiaa + "'";

            MySqlConnection Cnnalergia = clsConexion.BaseDeDatos();
            MySqlCommand Cmdalergia = new MySqlCommand(String.Format(consultaalergia), Cnnalergia);
            MySqlDataReader Dralergia = Cmdalergia.ExecuteReader();
            while (Dralergia.Read())
            {
                Alergia = Dralergia.GetString(0);
            }
        }

        private void frmAlumnoAlergia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreAlergiaa.alergias' Puede moverla o quitarla según sea necesario.
            this.alergiasTableAdapter.Fill(this.dsNombreAlergiaa.alergias);

        }

        private void cbAlergia_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdAlergia(cbAlergia.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuaquedaAlumnoAlergia FormularioBusquedaAlumnoAlergico = new frmBuaquedaAlumnoAlergia();
            FormularioBusquedaAlumnoAlergico.ShowDialog();

            if (FormularioBusquedaAlumnoAlergico.AlumnoAlergicoSeleccionado != null)
            {
                AlumnoAlergicoActual = FormularioBusquedaAlumnoAlergico.AlumnoAlergicoSeleccionado;
                
                lblMatricula.Text = FormularioBusquedaAlumnoAlergico.AlumnoAlergicoSeleccionado.Matricula;
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objAlumnoAlergia pobjAlumnoAlergia = new objAlumnoAlergia();
            pobjAlumnoAlergia.IdAlumnoAlergia = AlumnoAlergicoActual.IdAlumnoAlergia;
            pobjAlumnoAlergia.IdAlergia = Convert.ToInt32(Alergia);
            pobjAlumnoAlergia.Matricula = lblMatricula.Text.Trim();

            if (clsAlumnoAlergia.ActualizarAlumnoAlergia(pobjAlumnoAlergia) == true)
            {
                MessageBox.Show("datos actualizados");
            }
            else
            {
              //  MessageBox.Show("Error al actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsAlumnoAlergia.EliminarAlumnoAlergia(AlumnoAlergicoActual.IdAlumnoAlergia)==true)
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void frmAlumnoAlergia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
