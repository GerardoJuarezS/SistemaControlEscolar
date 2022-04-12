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
    public partial class frmBusquedaMateria : Form
    {
        public frmBusquedaMateria()
        {
            InitializeComponent();
        }
        public objMaterias MateriaSeleccionada { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsMaterias.Buscar(txtCodigoMateria.Text, txtNombreMateria.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int CodigoMateriaa = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                MateriaSeleccionada = clsMaterias.ObtenerMateria(CodigoMateriaa);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }

        private void frmBusquedaMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
