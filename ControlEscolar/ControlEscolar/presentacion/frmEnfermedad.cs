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
    public partial class frmEnfermedad : Form
    {
        public frmEnfermedad()
        {
            InitializeComponent();
        }

        public objEnfermedad Enfermedadactual { get; set; }

        private void frmEnfermedad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreEnfermedad.enfermedad' Puede moverla o quitarla según sea necesario.
            this.enfermedadTableAdapter.Fill(this.dsNombreEnfermedad.enfermedad);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEnfermedad pobjEnfermedad = new objEnfermedad();
            pobjEnfermedad.NombreEnfermedad = txtNombreEnfermedad.Text.Trim();

            bool resultado1 = clsEnfermedad.GuardarEnfermedad(pobjEnfermedad);
            if (resultado1 == true)
            {
                MessageBox.Show("Datos Guardados");
                this.enfermedadTableAdapter.Fill(this.dsNombreEnfermedad.enfermedad);
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaEnfermedad FormularioBuscarEnfermedad = new frmBusquedaEnfermedad();
            FormularioBuscarEnfermedad.ShowDialog();

            if (FormularioBuscarEnfermedad.EnfermedadSeleccionada != null)
            {
                Enfermedadactual = FormularioBuscarEnfermedad.EnfermedadSeleccionada;
                txtNombreEnfermedad.Text = FormularioBuscarEnfermedad.EnfermedadSeleccionada.NombreEnfermedad;
           
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            objEnfermedad pobjEnfermedad = new objEnfermedad();
            pobjEnfermedad.NombreEnfermedad = txtNombreEnfermedad.Text.Trim();
            pobjEnfermedad.IdEnfermedad = Enfermedadactual.IdEnfermedad;
            if (clsEnfermedad.Actualizar(pobjEnfermedad) == true )
            {
                MessageBox.Show("datos actualizados");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void frmEnfermedad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
