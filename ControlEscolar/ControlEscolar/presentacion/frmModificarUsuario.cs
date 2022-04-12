using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using ControlEscolar.logica;
using ControlEscolar.presentacion;
using MySql.Data.MySqlClient;
namespace ControlEscolar.presentacion
{
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }
        public objUsuarios UsuariooActual { get; set; }
        public objDatospersonales DatoPersonalActual { get; set; }
        public string IdGrupoUsuario;
        public string IdDatosPersonales;
        public int IdUsuariox;
        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistroUsuarios FormularioRegistroUsuario = new frmRegistroUsuarios();
            FormularioRegistroUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario FormularioModificar = new frmBusquedaUsuario();
            FormularioModificar.ShowDialog();

            if (FormularioModificar.UsuarioSeleccionado != null)
            {
                DatoPersonalActual = FormularioModificar.DatoPersonalSeleccionado;

                txtNombre.Text = FormularioModificar.UsuarioSeleccionado.Nombre;
                txtApellidoPaterno.Text = FormularioModificar.UsuarioSeleccionado.ApellidoPaterno;
                txtApellidoMaterno.Text = FormularioModificar.UsuarioSeleccionado.ApellidoMaterno;
                cbSexo.Text = FormularioModificar.UsuarioSeleccionado.Sexo;
                dtpFechaNacimiento.Text = FormularioModificar.UsuarioSeleccionado.FechaNacimiento;
                txtCelular.Text = FormularioModificar.UsuarioSeleccionado.Celular;
                txtTelefono.Text = FormularioModificar.UsuarioSeleccionado.Telefono;
                txtCurp.Text  = FormularioModificar.UsuarioSeleccionado.Curp;
                txtNss.Text = FormularioModificar.UsuarioSeleccionado.Nss;
                txtCorreo.Text = FormularioModificar.UsuarioSeleccionado.Correo;
                txtNombreUsuario.Text = FormularioModificar.UsuarioSeleccionado.NombreUsuario;
                txtContraseña1.Text  = FormularioModificar.UsuarioSeleccionado.Contraseña;
                cbGrupoUsuario.Text = FormularioModificar.UsuarioSeleccionado.NombreGrupoUsuario;
                labelidusuario.Text = ""+FormularioModificar.UsuarioSeleccionado.IdUsuario;
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreGrupoUsuarios.grupousuario' Puede moverla o quitarla según sea necesario.
            this.grupousuarioTableAdapter.Fill(this.dsNombreGrupoUsuarios.grupousuario);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objDatospersonales pobjDatospersonales = new objDatospersonales();
            pobjDatospersonales.Nombre = txtNombre.Text.Trim();
            pobjDatospersonales.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
            pobjDatospersonales.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
            pobjDatospersonales.Celular = txtCelular.Text.Trim();
            pobjDatospersonales.Curp = txtCurp.Text.Trim();
            pobjDatospersonales.Telefono = txtTelefono.Text.Trim();
            pobjDatospersonales.Correo = txtCorreo.Text.Trim();
            pobjDatospersonales.Nss = txtNss.Text.Trim();
            pobjDatospersonales.Sexo = cbSexo.Text.Trim();
            pobjDatospersonales.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text.Trim());

            bool resultado1 = clsDatosPersonales.ActualizarDatosPersonales(pobjDatospersonales);
                if (resultado1 == true)
                {
                    MessageBox.Show("Datos Guardados");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }

               MaxIdDatosPersonales();
                objUsuarios pobjUsuarios = new objUsuarios();
                pobjUsuarios.NombreUsuario = txtNombreUsuario.Text.Trim();
                pobjUsuarios.Contraseña = txtContraseña1.Text.Trim();
                pobjUsuarios.IdGrupoUsuario = Convert.ToInt32(IdGrupoUsuario);
                pobjUsuarios.IdDatosPersonales = Convert.ToInt32(IdDatosPersonales);
              
         pobjUsuarios.IdUsuarios = Convert.ToInt32(labelidusuario.Text.Trim());
               
               
                    bool resultado = clsUsuario.ActualizarUsuario(pobjUsuarios);
                    if (resultado == true)
                    {
                        MessageBox.Show("Datos Guardados**");
                    }
                    else
                    {
                        MessageBox.Show("error al guardar**");
                    }
                
              
                
            
        }

        void MaxIdDatosPersonales()
        {
            string ConsultaIdP = "select max(IdDatosPersonales) from datospersonales";
            MySqlConnection Cnnidp = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidp = new MySqlCommand(String.Format(ConsultaIdP), Cnnidp);
            MySqlDataReader Dridp = Cmdidp.ExecuteReader();
            while (Dridp.Read())
            {
                IdDatosPersonales = Dridp.GetString(0);
            }
          
        }
        void MostrarIdGrupoUsuario(string idgu)
        {
            string Consultaidgu = "SELECT IdGrupoUsuario from grupousuario where NombreGrupoUsuario = '" + idgu + "'";
            MySqlConnection Cnnidgu = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidgu = new MySqlCommand(string.Format(Consultaidgu), Cnnidgu);
            MySqlDataReader Dridgu = Cmdidgu.ExecuteReader();
            while (Dridgu.Read())
            {
                IdGrupoUsuario = Dridgu.GetString(0);
            }
          
        }

        private void cbGrupoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIdGrupoUsuario(cbGrupoUsuario.Text);
        }

        private void frmModificarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuPrincipal FormularioMenuPrincipal = new frmMenuPrincipal();
            this.Hide();
            FormularioMenuPrincipal.ShowDialog();
        }

    }
}
