using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
using ControlEscolar.logica;
using ControlEscolar.objetos;
namespace ControlEscolar.presentacion
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            Thread tardar = new Thread(new ThreadStart(Pantalla));
            tardar.Start();
            Thread.Sleep(8000);
            InitializeComponent();
            tardar.Abort();
        }

        public void Pantalla() { Application.Run(new splashscreen()); }

        objUsuarios Usuarioactual { get; set; }
        objGrupoUsuario GrupoUsuarioActual { get; set; }
        string idtipousuario;
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            objUsuarios pobjUsuarios = new objUsuarios();
            pobjUsuarios.NombreUsuario = txtUsuario.Text;
            pobjUsuarios.Contraseña = txtContraseña.Text;

            objGrupoUsuario pobjGrupoUsuario = new objGrupoUsuario();
            pobjGrupoUsuario.NombreGrupoUsuario = cbTipoUsuario.Text;
            bool resultado = clsInicioSesion.IniciarSesion(pobjUsuarios, pobjGrupoUsuario);
            if (resultado == true)
            {
                frmMenuPrincipal FormularioMenuPrincipal = new frmMenuPrincipal();
                this.Hide();
                FormularioMenuPrincipal.lblNombreUsuario.Text = txtUsuario.Text;
                FormularioMenuPrincipal.lblTipoUsuario.Text = cbTipoUsuario.Text;
                FormularioMenuPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sin Acceso");
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
