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
    public partial class frmBusquedaServicioSocial : Form
    {
        public frmBusquedaServicioSocial()
        {
            InitializeComponent();
        }

        public objServicioSocial Serviciosocialseleccionado { get; set; }
        public objDireccion Direccionseleccionada { get; set; }
        public objAlumnoServicioSocial Alumnoserviciosocialseleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultadoBusqueda.DataSource = clsServicioSocial.BuscarServicioSocial(txtMatricula.Text,txtNombreDependencia.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoBusqueda.SelectedRows.Count == 1)
            {
                int IdServicioosocial = Convert.ToInt32(dgvResultadoBusqueda.CurrentRow.Cells[0].Value);
                Serviciosocialseleccionado = clsServicioSocial.ObtenerServicioSocial(IdServicioosocial);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaServicioSocial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
