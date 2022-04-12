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
    public partial class frmBusquedaAlumnoGrupo : Form
    {
        public frmBusquedaAlumnoGrupo()
        {
            InitializeComponent();
        }
        public objAlumnoGrupo AlumnoGrupoSeleccionado { get; set; }
        
        private void frmBusquedaAlumnoGrupo_Load(object sender, EventArgs e)
        {
            CargarMatriculas();
        }

        void CargarMatriculas()
        {
            MySqlCommand Cmd = new MySqlCommand("select distinct Matricula from alumnogrupo", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbMatricula.ValueMember = "Matricula";
            cbMatricula.DataSource = Dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsAlumnoGrupo.BuscarAlumnoGrupo(cbMatricula.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdAlumnoGrupoo = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                AlumnoGrupoSeleccionado = clsAlumnoGrupo.ObtenerAlumnoGrupo(IdAlumnoGrupoo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }
    }
}
