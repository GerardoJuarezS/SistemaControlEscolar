using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar.presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcion FormularioInscripcion = new frmInscripcion();
            FormularioInscripcion.ShowDialog();
        }

        private void reinscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReinscripcion FormularioReinscripcion = new frmReinscripcion();
            FormularioReinscripcion.ShowDialog();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalificaciones FormularioCalificaciones = new frmCalificaciones();
            FormularioCalificaciones.ShowDialog();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDocente FormularioAltaDocente = new frmAltaDocente();
            FormularioAltaDocente.ShowDialog();
        }

        private void materiasPorImpartirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocentesMaterias FormularioDocenteMaterias = new frmDocentesMaterias();
            FormularioDocenteMaterias.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaterias FormularioMaterias = new frmMaterias();
            FormularioMaterias.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegistroUsuarios FormularioRegistroUsuario = new frmRegistroUsuarios();
            FormularioRegistroUsuario.ShowDialog();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuario FormularioBusqueda = new frmModificarUsuario();
            FormularioBusqueda.ShowDialog();
        }

        private void materiasPorSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriasSemestre FormularioMateriaSemestre = new frmMateriasSemestre();
            FormularioMateriaSemestre.ShowDialog();
        }

        private void alergiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnoAlergia FormularioAlumnoAlergia = new frmAlumnoAlergia();
            FormularioAlumnoAlergia.ShowDialog();
        }

        private void enfermedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnoEnfermedad FormularioAlumnoEnfermedad = new frmAlumnoEnfermedad();
            FormularioAlumnoEnfermedad.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion Formularioiniciodesesion = new frmInicioSesion();
            Formularioiniciodesesion.ShowDialog();
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enfermedadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEnfermedad FormularioEnfermedades = new frmEnfermedad();
            FormularioEnfermedades.ShowDialog();
        }

        private void alergiasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAlergias FormularioAlergia = new frmAlergias();
            FormularioAlergia.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            if (lblTipoUsuario.Text == "ADMINISTRADOR")
            {
                alumnosToolStripMenuItem.Enabled = true;
                inscripcionToolStripMenuItem.Enabled = true;
                reinscripcionToolStripMenuItem.Enabled = true;
                calificacionesToolStripMenuItem.Enabled = true;
                salubridadToolStripMenuItem.Enabled = true;

                docentesToolStripMenuItem.Enabled = true;
                materiasPorImpartirToolStripMenuItem.Enabled = true;
                altasdocentesToolStripMenuItem.Enabled = true;

                altamateriasToolStripMenuItem1.Enabled = true;
                materiasPorSemestreToolStripMenuItem.Enabled = true;
                altausuarioToolStripMenuItem2.Enabled = true;
                busquedausuarioToolStripMenuItem.Enabled = true;


                enfermedadesToolStripMenuItem.Enabled = true;
                alergiasToolStripMenuItem.Enabled = true;

                respaldarBDToolStripMenuItem.Enabled = true;
                restaurarBDToolStripMenuItem.Enabled = true;
            }

            if (lblTipoUsuario.Text == "Docente")
            {
                alumnosToolStripMenuItem.Enabled = true;
                inscripcionToolStripMenuItem.Enabled = false;
                reinscripcionToolStripMenuItem.Enabled = false;
                calificacionesToolStripMenuItem.Enabled = true;
                salubridadToolStripMenuItem.Enabled = false;

                docentesToolStripMenuItem.Enabled = false;
                materiasPorImpartirToolStripMenuItem.Enabled = false;
                altasdocentesToolStripMenuItem.Enabled = false;

                altamateriasToolStripMenuItem1.Enabled = false;
                materiasPorSemestreToolStripMenuItem.Enabled = false;
                altausuarioToolStripMenuItem2.Enabled = false;
                busquedausuarioToolStripMenuItem.Enabled = false;
                servicioSocialToolStripMenuItem1.Enabled = false;
                documentosAcademicosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                salubridadToolStripMenuItem.Enabled = false;
                semestreToolStripMenuItem.Enabled = false;
                enfermedadesToolStripMenuItem.Enabled = false;
                alergiasToolStripMenuItem.Enabled = false;

                respaldarBDToolStripMenuItem.Enabled = false;
                restaurarBDToolStripMenuItem.Enabled = false;
            }

            if (lblTipoUsuario.Text == "Alumno")
            {
                alumnosToolStripMenuItem.Enabled = true;
                inscripcionToolStripMenuItem.Enabled = false;
                reinscripcionToolStripMenuItem.Enabled = false;
                calificacionesToolStripMenuItem.Enabled = false;
                salubridadToolStripMenuItem.Enabled = false;
                consultarCalificacionesToolStripMenuItem.Enabled = true;
                docentesToolStripMenuItem.Enabled = false;
                materiasPorImpartirToolStripMenuItem.Enabled = false;
                altasdocentesToolStripMenuItem.Enabled = false;

                altamateriasToolStripMenuItem1.Enabled = false;
                materiasPorSemestreToolStripMenuItem.Enabled = false;
                altausuarioToolStripMenuItem2.Enabled = false;
                busquedausuarioToolStripMenuItem.Enabled = false;
                servicioSocialToolStripMenuItem1.Enabled = false;
                documentosAcademicosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                salubridadToolStripMenuItem.Enabled = false;
                semestreToolStripMenuItem.Enabled = false;
                enfermedadesToolStripMenuItem.Enabled = false;
                alergiasToolStripMenuItem.Enabled = false;

                respaldarBDToolStripMenuItem.Enabled = false;
                restaurarBDToolStripMenuItem.Enabled = false;
            }

        }

        private void consultarCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCalificaciones FormularioConsultaCalificaciones = new frmConsultaCalificaciones();
            FormularioConsultaCalificaciones.Show();
        }

        private void servicioSocialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlumnoServicioSocial FormularioSS = new frmAlumnoServicioSocial();
            FormularioSS.ShowDialog();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformesServicioSocial FormularioInformes = new frmInformesServicioSocial();
            FormularioInformes.ShowDialog();
        }

        private void respaldarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea realizar un respaldo de la base de datos?", "Respaldar base de datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                this.respaldo();


            }

            else if (resultado == DialogResult.No)

            {

               // this.Hide();

            }
        }

        public void respaldo()
        {
            try 
                {
               System.Diagnostics.Process.Start(@"C:\RespaldoBD1.bat");
              
            }
           catch (Exception e)
            {
                MessageBox.Show("Error al respaldar la base de datos"+e);
            }
        }

        public void restaurarbd()
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\restaurar.bat");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Restaurar la base de datos" + e);
            }
        }

        private void cFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCFT FormularioCFT = new frmCFT();
            FormularioCFT.ShowDialog();
        }

        private void materiasCFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriasCFT FormularioMateriasCFT = new frmMateriasCFT();
            FormularioMateriasCFT.ShowDialog();
        }

        private void documentosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticas FormularioEstadisticas = new frmEstadisticas();
            FormularioEstadisticas.ShowDialog();
        }

        private void restaurarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea restaurar la informacion de la base de datos?", "Restaurar base de datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                this.restaurarbd();
            }

            else if (resultado == DialogResult.No)

            {
                // this.Hide();
            }
        }
    }
}
