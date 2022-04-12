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
    public partial class frmCFT : Form
    {
        public frmCFT()
        {
            InitializeComponent();
        }
        public objCFT CFTActual { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objCFT pobjCFT = new objCFT();
            pobjCFT.NombreCFT = txtNombreCFT.Text.Trim();

            bool resultado = clsCFT.GuardarCFT(pobjCFT);
            if (resultado == true)
            {
                MessageBox.Show("Datos Guardados");
                this.cftTableAdapter.Fill(this.dsNombreCFT.cft);
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        private void frmCFT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreCFT.cft' Puede moverla o quitarla según sea necesario.
            this.cftTableAdapter.Fill(this.dsNombreCFT.cft);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            objAlergias pobjAlergias = new objAlergias();
            objCFT pobjCFT = new objCFT();
            pobjCFT.NombreCFT = txtNombreCFT.Text.Trim();
            pobjCFT.IdCFT = CFTActual.IdCFT;

            if (clsCFT.ActualizarCFT(pobjCFT) == true)
            {
                MessageBox.Show("datos actualizados");
                this.cftTableAdapter.Fill(this.dsNombreCFT.cft);
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (clsCFT.EliminarCFT(CFTActual.IdCFT) == true)
            {
                MessageBox.Show("eliminado");
                this.cftTableAdapter.Fill(this.dsNombreCFT.cft);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCFT FormularioBusquedaCFT = new frmBusquedaCFT();
            FormularioBusquedaCFT.ShowDialog();
            if (FormularioBusquedaCFT.CFTSeleccionada != null)
            {
                CFTActual = FormularioBusquedaCFT.CFTSeleccionada;
                txtNombreCFT.Text = FormularioBusquedaCFT.CFTSeleccionada.NombreCFT;
            }
        }
    }
}
