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
    public partial class frmBuaquedaAlumnoAlergia : Form
    {
        public frmBuaquedaAlumnoAlergia()
        {
            InitializeComponent();
        }
        public objAlumnoAlergia AlumnoAlergicoSeleccionado { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsAlumnoAlergia.BuscarAlumnoAlergia(txtmatricula.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdAlergia = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                AlumnoAlergicoSeleccionado = clsAlumnoAlergia.ObtenerAlumnoAlergia(IdAlergia);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBuaquedaAlumnoAlergia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
