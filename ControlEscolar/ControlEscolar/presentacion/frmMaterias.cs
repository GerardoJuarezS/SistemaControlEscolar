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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }
        objMaterias MateriaActual { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objMaterias pobjMaterias = new objMaterias();
            pobjMaterias.CodigoMaterias = Convert.ToInt32(txtCodigoMateria.Text);
            pobjMaterias.UAC = txtUAC.Text;
            pobjMaterias.HorasMateria = Convert.ToInt32(txtHoras.Text);
            pobjMaterias.CreditosMaterias = Convert.ToInt32(txtCreditos.Text);

            bool resultado = clsMaterias.GuardarMateria(pobjMaterias);
            if(resultado == true )
            {
                MessageBox.Show("Materia Guardada");
            }
            this.materiasTableAdapter.Fill(this.dsMaterias.materias);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objMaterias pobjMaterias = new objMaterias();
            pobjMaterias.CodigoMaterias_Anterior = MateriaActual.CodigoMaterias;
            pobjMaterias.CodigoMaterias = Convert.ToInt32(txtCodigoMateria.Text);
            pobjMaterias.UAC = txtUAC.Text;
            pobjMaterias.HorasMateria = Convert.ToInt32(txtHoras.Text);
            pobjMaterias.CreditosMaterias = Convert.ToInt32(txtCreditos.Text);
            bool resultado = clsMaterias.Actualizar(pobjMaterias);
            if (resultado == true)
            {
                MessageBox.Show("Materia Guardada");
            }
            this.materiasTableAdapter.Fill(this.dsMaterias.materias);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMateria FormularioBuscarMateria = new frmBusquedaMateria();
            FormularioBuscarMateria.ShowDialog();

            if(FormularioBuscarMateria.MateriaSeleccionada != null)
            {  
                MateriaActual = FormularioBuscarMateria.MateriaSeleccionada;
                txtCodigoMateria.Text =Convert.ToString(FormularioBuscarMateria.MateriaSeleccionada.CodigoMaterias);
                txtUAC.Text = FormularioBuscarMateria.MateriaSeleccionada.UAC;
                txtHoras.Text = Convert.ToString(FormularioBuscarMateria.MateriaSeleccionada.HorasMateria);
                txtCreditos.Text = Convert.ToString(FormularioBuscarMateria.MateriaSeleccionada.CreditosMaterias);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsMaterias.EliminarMateria(MateriaActual.CodigoMaterias) == true)
            {
                MessageBox.Show("Materia Eliminada");
            }
            else
            {
                MessageBox.Show("Error al eliminar la materia"+MessageBoxButtons.AbortRetryIgnore + MessageBoxIcon.Error + MessageBoxOptions.ServiceNotification);
            }
            this.materiasTableAdapter.Fill(this.dsMaterias.materias);
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMaterias.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.dsMaterias.materias);

        }

        private void frmMaterias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
