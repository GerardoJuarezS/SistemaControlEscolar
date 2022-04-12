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
    public partial class frmBusquedaCalificaciones : Form
    {
        public frmBusquedaCalificaciones()
        {
            InitializeComponent();
        }
        int Idmateria;
        
        public objCalificaciones CalificacionSeleccionada { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Idmateria = Convert.ToInt32(txtCodigoMateria.Text);
            dgvResultadoBusqueda.DataSource = clsCalificaciones.BuscarCalificacion(txtMatricula.Text, Idmateria);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoBusqueda.SelectedRows.Count == 1)
            {
                int IdCalificaciones = Convert.ToInt32(dgvResultadoBusqueda.CurrentRow.Cells[0].Value);
                CalificacionSeleccionada = clsCalificaciones.ObtenerCalificacion(IdCalificaciones);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaCalificaciones_Load(object sender, EventArgs e)
        {
            txtCodigoMateria.Text = "0000";
        }

        private void frmBusquedaCalificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
