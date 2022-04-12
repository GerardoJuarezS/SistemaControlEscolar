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
    public partial class frmBusquedaInscripcion : Form
    {
        public frmBusquedaInscripcion()
        {
            InitializeComponent();
        }
        public objBusquedaInscripcion InscripcionSeleccionada { get; set; }
        public objDatospersonales DatoPersonalSeleccionado { get; set; }
        public objDireccion DireccionSeleccionada { get; set; }
        public objAlumno AlumnoSeleccionado { get; set; }
        public objAlumnoGrupo AlumnoGrupoSeleccionado { get; set; }
        public objAlumnoSemestre AlumnoSemestreSeleccionado { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsAlumno.BuscarAlumno(txtMatricula.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                string Matri = Convert.ToString(dgvResultado.CurrentRow.Cells[0].Value);
                MessageBox.Show(Matri);
                InscripcionSeleccionada = clsAlumno.ObtenerAlumno(Matri);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaInscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
