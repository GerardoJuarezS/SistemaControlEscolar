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
    public partial class frmBusquedaDocentesMaterias : Form
    {
        public frmBusquedaDocentesMaterias()
        {
            InitializeComponent();
        }
        public objImparte imparteseleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultadoBusqueda.DataSource = clsImparte.BuscarImparte(txtRFC.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoBusqueda.SelectedRows.Count == 1)
            {
                int IdImpartee = Convert.ToInt32(dgvResultadoBusqueda.CurrentRow.Cells[2].Value);
                imparteseleccionado = clsImparte.ObtenerImparte(IdImpartee);
                this.Close();
            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaDocentesMaterias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
