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
    public partial class frmBusquedaMateriaSemestre : Form
    {
        public frmBusquedaMateriaSemestre()
        {
            InitializeComponent();
        }

        public objMateriaSemestre MateriaSemestreSeleccionada { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsMateriasSemestre.Buscar(txtCodigoMateria.Text,txtIdSemestre.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdMateriaSemestre = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                MateriaSemestreSeleccionada = clsMateriasSemestre.ObtenerMateria(IdMateriaSemestre);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaMateriaSemestre_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
