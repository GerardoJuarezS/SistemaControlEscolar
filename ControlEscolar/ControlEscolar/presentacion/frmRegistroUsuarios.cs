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
    public partial class frmRegistroUsuarios : Form
    {
        public frmRegistroUsuarios()
        {
            InitializeComponent();
        }
        public objDatospersonales ObjetosDatosPersonales { get; set; }
        public objUsuarios ObjetosUsuarios { get; set; }
        public string IdGrupoUsuario;
        public string IdDatosPersonales;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text.Trim() == txtContraseña2.Text.Trim())
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

                bool resultado1 = clsDatosPersonales.GuardarDatosPersonales(pobjDatospersonales);
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

                bool resultado = clsUsuario.GuardarUsuario(pobjUsuarios);
                if (resultado == true)
                {
                    MessageBox.Show("Datos Guardados");
                }
                else
                {
                    MessageBox.Show("error al guardar");
                }
            }
            else
            {
                MessageBox.Show("Las Contraseñas No Coinciden");
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

        private void frmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreGrupoUsuarios.grupousuario' Puede moverla o quitarla según sea necesario.
            this.grupousuarioTableAdapter.Fill(this.dsNombreGrupoUsuarios.grupousuario);
        }

        private void cbGrupoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIdGrupoUsuario(cbGrupoUsuario.Text);
        }

        private void frmRegistroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
