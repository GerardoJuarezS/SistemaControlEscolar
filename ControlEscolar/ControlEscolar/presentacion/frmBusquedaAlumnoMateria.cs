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
    public partial class frmBusquedaAlumnoMateria : Form
    {
        public frmBusquedaAlumnoMateria()
        {
            InitializeComponent();
        }
        public objAlumnoMaterias AlumnoMateriaSeleccionado { get; set; }

        void CargarMatriculas()
        {
            MySqlCommand Cmd = new MySqlCommand("select distinct alumnomaterias.Matricula from alumnomaterias", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbMatricula.ValueMember = "Matricula";
            cbMatricula.DataSource = Dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsAlumnoMaterias.BuscarAlumnoMateria(cbMatricula.Text);
        }

        private void frmBusquedaAlumnoMateria_Load(object sender, EventArgs e)
        {
            CargarMatriculas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdAlumnoMateriaa = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                AlumnoMateriaSeleccionado = clsAlumnoMaterias.ObtenerAlumnoMateria(IdAlumnoMateriaa);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }
    }
}
