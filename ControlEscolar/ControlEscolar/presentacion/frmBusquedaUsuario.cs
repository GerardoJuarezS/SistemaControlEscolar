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
    public partial class frmBusquedaUsuario : Form
    {
       
       
        public frmBusquedaUsuario()
        {
            InitializeComponent();
        }
        public objBusquedaUsuario UsuarioSeleccionado { get; set; }
        public objDatospersonales DatoPersonalSeleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsUsuario.Buscar(comboBox1.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdUsuario = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado = clsUsuario.ObtenerUsuario(IdUsuario);



                this.Close();

            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }

        private void frmBusquedaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
