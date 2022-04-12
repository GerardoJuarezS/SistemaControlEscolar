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
    public partial class frmBusquedaDocente : Form
    {
        public frmBusquedaDocente()
        {
            InitializeComponent();
        }
        public objBusquedaDocente DocenteSeleccionado { get; set; }
        public objDatospersonales DatoPersonalSeleccionado { get; set; }
        public objDireccion DireccionSeleccionada { get; set; }
        public objProfesiones ProfesionSeleccionada { get; set; }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaDocente.SelectedRows.Count == 1)
            {
                string Rfcc = Convert.ToString(dgvBusquedaDocente.CurrentRow.Cells[0].Value);
                MessageBox.Show(Rfcc);
                DocenteSeleccionado = clsDocentes.ObtenerDocente(Rfcc);
                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBusquedaDocente.DataSource = clsDocentes.Buscar(txtRfc.Text);
        }

        private void frmBusquedaDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
