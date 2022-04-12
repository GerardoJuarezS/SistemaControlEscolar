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
    public partial class frmBusquedaCFT : Form
    {
        public frmBusquedaCFT()
        {
            InitializeComponent();
        }
        public objCFT CFTSeleccionada { get; set; }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsCFT.BuscarCFT(txtNombreCFT.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdCFTT = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                CFTSeleccionada = clsCFT.ObtenerCFT(IdCFTT);
                this.Close();
            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }
    }
}
