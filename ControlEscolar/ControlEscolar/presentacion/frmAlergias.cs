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
    public partial class frmAlergias : Form
    {
        public frmAlergias()
        {
            InitializeComponent();
        }
        public objAlergias AlergiaActual { get; set; }
        private void frmAlergias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreAlergia.alergias' Puede moverla o quitarla según sea necesario.
            this.alergiasTableAdapter.Fill(this.dsNombreAlergia.alergias);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlergias pobjAlergias = new objAlergias();
            pobjAlergias.NombreAlergia = txtNombreAlergia.Text.Trim();

            bool resultado1 = clsAlergias.GuardarAlergia(pobjAlergias);
            if (resultado1 == true)
            {
                MessageBox.Show("Datos Guardados");
                this.alergiasTableAdapter.Fill(this.dsNombreAlergia.alergias);
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlergia FormularioBuscarAlergia = new frmBusquedaAlergia();
            FormularioBuscarAlergia.ShowDialog();

            if (FormularioBuscarAlergia.AlergiaSeleccionada != null)
            {
                AlergiaActual = FormularioBuscarAlergia.AlergiaSeleccionada;
                txtNombreAlergia.Text = FormularioBuscarAlergia.AlergiaSeleccionada.NombreAlergia;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            objAlergias pobjAlergias = new objAlergias();

            pobjAlergias.NombreAlergia = txtNombreAlergia.Text.Trim();
            pobjAlergias.IdAlergias = AlergiaActual.IdAlergias;

            if (clsAlergias.ActualizarAlergia(pobjAlergias) == true)
            {
                MessageBox.Show("datos actualizados");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (clsAlergias.EliminarAlergia(AlergiaActual.IdAlergias)==true)
            {
                MessageBox.Show("eliminado");
            }
        }

        private void frmAlergias_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuPrincipal FormularioMenuPrincipal = new frmMenuPrincipal();
            this.Dispose();
            
        }
    }
}
