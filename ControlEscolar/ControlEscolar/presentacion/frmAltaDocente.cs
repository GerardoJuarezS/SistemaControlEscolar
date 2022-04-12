using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.logica;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using MySql.Data.MySqlClient;
namespace ControlEscolar.presentacion
{
    public partial class frmAltaDocente : Form
    {
        public frmAltaDocente()
        {
            InitializeComponent();
        }
        public objBusquedaDocente DocenteActual { get; set; }
        public objDatospersonales DatoPersonalActual { get; set; }
        public objDireccion DireccionActual { get; set; }
        public objProfesiones ProfesionActual { get; set; }

        public string Clave;

        //Calculo de la Curp
        private int estado = 0;
        private int genero = 0;
        private string EntidadFederativa = string.Empty;
        private char GeneroSolicitante;
        private char PL_PApellido;
        private char PV_PApellido;
        private char PL_SApellido;
        private char PL_Nombre;
        private char PC_PApellido;
        private char PC_SApellido;
        private char PC_Nombre;
        private string dia = string.Empty;
        private string mes = string.Empty;
        private string año = string.Empty;
        private string CURP = string.Empty;

        public int IdentificadorDireccion;
        public int IdentificadorDatosPersonales;
        public string IdDatosPersonales;
        public string IdDireccionn;
        public string Profesion;
        public string IdEstadoo;
        public string IdMunicipioo;
        public string IdEstado;
        public string IdDistrito;
        public string IdMunicipio;
        String Ubicacion;
        String Id;
        OpenFileDialog Open = new OpenFileDialog();
        int ImgInser = 0;

        public void Posicion_5_10(string fecha)
        {


            int barrido = 0;
            int contador = 0;
            char verificador;
            char[] DofB = fecha.ToCharArray();
            int longitud = DofB.Length;
            while (barrido < longitud)
            {
                verificador = DofB[barrido];
                if (verificador == '/')
                {
                    contador++;
                }
                else if (contador == 0 && verificador != '/')
                {

                    dia = dia + DofB[barrido];

                }
                else if (contador == 1 && verificador != '/')
                {
                    mes = mes + DofB[barrido];

                }
                else if ((contador == 2 && verificador != '/') && (barrido == 8 || barrido == 9))
                {
                    año = año + DofB[barrido];
                }
                barrido++;
            }
        }

        public void Posición_1_4_14_16(string nombre, string primer_apellido, string segundo_apellido)
        {
            char[] name = nombre.ToCharArray();
            char[] Lastname1 = primer_apellido.ToCharArray();
            char[] Lastname2 = segundo_apellido.ToCharArray();
            int lenght1 = name.Length;
            int lenght2 = Lastname1.Length;
            int lenght3 = Lastname2.Length;
            bool vocal = false;
            bool consonante_1 = false;
            bool consonante_2 = false;
            bool consonante_3 = false;
            for (int i = 0; i < lenght2; i++)
            {
                //La letra inicial del primer apellido
                if (i == 0)
                {
                    PL_PApellido = Lastname1[i];
                }
                //La primera vocal interna del primer apellido (a,e,i,o,u)
                else if (Lastname1[i] == 'A' && vocal == false)
                {
                    PV_PApellido = Lastname1[i];
                    vocal = true;
                }
                else if (Lastname1[i] == 'E' && vocal == false)
                {
                    PV_PApellido = Lastname1[i];
                    vocal = true;
                }
                else if (Lastname1[i] == 'I' && vocal == false)
                {
                    PV_PApellido = Lastname1[i];
                    vocal = true;
                }
                else if (Lastname1[i] == 'O' && vocal == false)
                {
                    PV_PApellido = Lastname1[i];
                    vocal = true;
                }
                else if (Lastname1[i] == 'U' && vocal == false)
                {
                    PV_PApellido = Lastname1[i];
                    vocal = true;
                }
                /*******La primera consonante del primer apellido******/
                else if (Lastname1[i] == 'B' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'C' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'D' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'F' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'G' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'H' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'J' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'K' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'L' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'M' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'N' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'P' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'Q' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'R' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'S' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'T' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'V' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'X' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'Y' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
                else if (Lastname1[i] == 'Z' && consonante_1 == false)
                {
                    PC_PApellido = Lastname1[i];
                    consonante_1 = true;
                }
            }
            /******La letra inicial del segundo apellido******/
            for (int k = 0; k < lenght3; k++)
            {
                if (k == 0)
                {
                    PL_SApellido = Lastname2[k];
                }
                /*******La primera consonante del segundo apellido******/
                else if (Lastname2[k] == 'B' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'C' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'D' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'F' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'G' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'H' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'J' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'K' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'L' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'M' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'N' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'P' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'Q' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'R' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'S' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'T' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'V' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'X' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'Y' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
                else if (Lastname2[k] == 'Z' && consonante_2 == false)
                {
                    PC_SApellido = Lastname2[k];
                    consonante_2 = true;
                }
            }
            /******La letra inicial del nombre******/
            for (int j = 0; j < lenght1; j++)
            {
                if (j == 0)
                {
                    PL_Nombre = name[j];
                }
                /*******La primera consonante del segundo apellido******/
                else if (name[j] == 'B' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'C' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'D' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'F' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'G' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'H' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'J' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'K' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'L' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'M' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'N' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'P' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'Q' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'R' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'S' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'T' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'V' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'W' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'X' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'Y' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
                else if (name[j] == 'Z' && consonante_3 == false)
                {
                    PC_Nombre = name[j];
                    consonante_3 = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objDatospersonales pobjDatospersonales = new objDatospersonales();
            pobjDatospersonales.Nombre = txtNombre.Text.Trim();
            pobjDatospersonales.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
            pobjDatospersonales.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
            pobjDatospersonales.Curp = txtCurp.Text.Trim();
            pobjDatospersonales.Telefono = txtTelefono.Text.Trim();
            pobjDatospersonales.Celular = txtCelular.Text.Trim();
            pobjDatospersonales.Correo = txtCorreo.Text.Trim();
            pobjDatospersonales.Nss = txtNss.Text.Trim();
            pobjDatospersonales.Sexo = cbSexo.Text.Trim();
            pobjDatospersonales.Foto = pbFotografia.Image;
            pobjDatospersonales.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);

            objDireccion pobjDireccion = new objDireccion();
            pobjDireccion.Colonia = txtColonia.Text.Trim();
            pobjDireccion.Calle = txtCalle.Text.Trim();
            pobjDireccion.Numero = txtNumeroDeCasa.Text.Trim();
            pobjDireccion.Localidad = cbLocalidad.Text.Trim();
            pobjDireccion.Estado = cbEstado.Text.Trim();
            pobjDireccion.Distrito = cbDistrito.Text.Trim();
            pobjDireccion.Municipio = cbMunicipio.Text.Trim();
            

            bool resultado = clsDatosPersonales.GuardarDatosPersonales(pobjDatospersonales);
            if (resultado == true)
            {
                
            }
            else { MessageBox.Show("Error al almacenar los datos personales"); }

            bool resultado2 = clsDireccion.GuardarDireccion(pobjDireccion);
            if (resultado == true)
            {
               
            }
            else { MessageBox.Show("Error al almacenar la direccion"); }
            MaxIdDireccion();
            MaxIdDatosPersonales();
           
            NombreProfesion(Profesion);

            objDocentes pobjDocentes = new objDocentes();
            pobjDocentes.Rfc = txtRFC.Text.Trim();
            pobjDocentes.IdDireccion = Convert.ToInt32(IdDireccionn);
            pobjDocentes.IdDatosPersonales = Convert.ToInt32(IdDatosPersonales);
            pobjDocentes.IdProfesion = Convert.ToInt32(Profesion);

            bool resultado3 = clsDocentes.GuardarDocente(pobjDocentes);
            if (resultado3 == true)
            {
                MessageBox.Show("Datos del Docente Almacenados Correctamente");
            }
            else { MessageBox.Show("Error al almacenar los datos del Docente"); }
        }

        private void pbFotografia_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files(*.jpg)|*jpg|Gif files(*.gif)|*gif|Bitmap  files(*.Bmp)|*.bmp|PNG files(*.png)|*.png|All files(*.*)|*.*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                Bitmap Picture = new Bitmap(Ubicacion);
                pbFotografia.Image = (Image)Picture;
                ImgInser = 1;
                Id = Open.SafeFileName;
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

        void MaxIdDireccion()
        {
            string ConsultaIdD = "select max(IdDireccion) from direccion";
            MySqlConnection Cnnidd = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidd = new MySqlCommand(String.Format(ConsultaIdD), Cnnidd);
            MySqlDataReader Dridd = Cmdidd.ExecuteReader();
            while (Dridd.Read())
            {
                IdDireccionn = Dridd.GetString(0);
            }
        }

        void NombreProfesion(string Profesionn)
        {
            string ConsultaProfesion = "select IdProfesion from profesiones where NombreProfesion = '" + Profesionn + "'";
            MySqlConnection Cnnidp = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidp = new MySqlCommand(string.Format(ConsultaProfesion), Cnnidp);
            MySqlDataReader Dridp = Cmdidp.ExecuteReader();
            while (Dridp.Read())
            {
                Profesion = Dridp.GetString(0);
            }
        }

        void IdentifcadorEstado (string Estadoo)
        {
            string ConsultaIdentificadorEstado = "select IdEstado from estado where NombreEstado = '"+Estadoo+"'";
            MySqlConnection Cnnide = clsConexion.BaseDeDatos();
            MySqlCommand Cmdide = new MySqlCommand(string.Format(ConsultaIdentificadorEstado), Cnnide);
            MySqlDataReader Dride = Cmdide.ExecuteReader();
            while (Dride.Read())
            {
                IdEstado = Dride.GetString(0);
            }
        }

        void IdentifcadorDistrito(string Distritoo )
        {
            string ConsultaIdentificadorDistrito = "select IdDistrito from distrito where NombreDistrito = '" + Distritoo + "'";
            MySqlConnection Cnnidd = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidd = new MySqlCommand(string.Format(ConsultaIdentificadorDistrito), Cnnidd);
            MySqlDataReader Dridd = Cmdidd.ExecuteReader();
            while (Dridd.Read())
            {
                IdDistrito = Dridd.GetString(0);
            }
        }

        void IdentificadorMunicipio (string Municipioo)
        {
            string ConsultaIdentificadorMunicipio = "select IdMunicipio from municipio where NombreMunicipio = '" + Municipioo + "'";
            MySqlConnection Cnnidm = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidm = new MySqlCommand(string.Format(ConsultaIdentificadorMunicipio), Cnnidm);
            MySqlDataReader Dridm = Cmdidm.ExecuteReader();
            while (Dridm.Read())
            {
                IdMunicipio = Dridm.GetString(0);
            }
        }

        private void cbIdProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreProfesion(cbIdProfesion.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtCalle.Text = "";
            txtCelular.Text = "";
            txtColonia.Text = "";
            txtCorreo.Text = "";
            txtCurp.Text = "";
            cbLocalidad.Text = "";
            txtRFC.Text = "";
            txtNombre.Text = "";
            txtNss.Text = "";
            txtNumeroDeCasa.Text = "";
            txtTelefono.Text = "";
            cbDistrito.Text = "";
            cbEstado.Text = "";
            cbMunicipio.Text = "";
            cbSexo.Text = "";
            pbFotografia.Image = null;
            dtpFechaNacimiento.Text = "";
        }

        private void frmAltaDocente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreProfesion.profesiones' Puede moverla o quitarla según sea necesario.
            this.profesionesTableAdapter.Fill(this.dsNombreProfesion.profesiones);
            CargarEstados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaDocente BuscarDocente = new frmBusquedaDocente();
            BuscarDocente.ShowDialog();

            if (BuscarDocente.DocenteSeleccionado != null)
            {
                DatoPersonalActual = BuscarDocente.DatoPersonalSeleccionado;
                DireccionActual = BuscarDocente.DireccionSeleccionada;
                ProfesionActual = BuscarDocente.ProfesionSeleccionada;
                DocenteActual = BuscarDocente.DocenteSeleccionado;

                txtNombre.Text = BuscarDocente.DocenteSeleccionado.Nombre;
                txtApellidoPaterno.Text = BuscarDocente.DocenteSeleccionado.ApellidoPaterno;
                txtApellidoMaterno.Text = BuscarDocente.DocenteSeleccionado.ApellidoMaterno;
                txtNss.Text = BuscarDocente.DocenteSeleccionado.Nss;
                cbEstado.Text = BuscarDocente.DocenteSeleccionado.NombreEstado;
                dtpFechaNacimiento.Text = BuscarDocente.DocenteSeleccionado.FechaNacimiento;
                cbSexo.Text = BuscarDocente.DocenteSeleccionado.Sexo;
                txtCelular.Text = BuscarDocente.DocenteSeleccionado.Celular;
                txtTelefono.Text = BuscarDocente.DocenteSeleccionado.Telefono;
                txtCorreo.Text = BuscarDocente.DocenteSeleccionado.Correo;
                txtCurp.Text = BuscarDocente.DocenteSeleccionado.Curp;
                IdentificadorDatosPersonales = BuscarDocente.DocenteSeleccionado.IdDatosPersonales;

                cbDistrito.Text = BuscarDocente.DocenteSeleccionado.NombreDistrito;
                cbEstado.Text = BuscarDocente.DocenteSeleccionado.NombreEstado;
                cbMunicipio.Text = BuscarDocente.DocenteSeleccionado.NombreMunicipio;
                cbLocalidad.Text = BuscarDocente.DocenteSeleccionado.Localidad;
                txtColonia.Text = BuscarDocente.DocenteSeleccionado.Colonia;
                txtCalle.Text = BuscarDocente.DocenteSeleccionado.Calle;
                txtNumeroDeCasa.Text = BuscarDocente.DocenteSeleccionado.Numero;
                IdentificadorDireccion = BuscarDocente.DocenteSeleccionado.IdDireccion;

                LBLRFC.Text = BuscarDocente.DocenteSeleccionado.Rfc;
                cbIdProfesion.Text = BuscarDocente.DocenteSeleccionado.NombreProfesion;
                pbFotografia.Image = BuscarDocente.DocenteSeleccionado.Foto;
                txtRFC.Text = LBLRFC.Text;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objDatospersonales pobjDatospersonales = new objDatospersonales();
            pobjDatospersonales.Nombre = txtNombre.Text.Trim();
            pobjDatospersonales.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
            pobjDatospersonales.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
            pobjDatospersonales.Curp = txtCurp.Text.Trim();
            pobjDatospersonales.Telefono = txtTelefono.Text.Trim();
            pobjDatospersonales.Celular = txtCelular.Text.Trim();
            pobjDatospersonales.Correo = txtCorreo.Text.Trim();
            pobjDatospersonales.Nss = txtNss.Text.Trim();
            pobjDatospersonales.Sexo = cbSexo.Text.Trim();
            pobjDatospersonales.Foto = pbFotografia.Image;
            pobjDatospersonales.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);
            pobjDatospersonales.IdDatosPersonales = Convert.ToInt32(IdDatosPersonales);

            objDireccion pobjDireccion = new objDireccion();
            pobjDireccion.Estado = cbEstado.Text.Trim();
            pobjDireccion.Distrito = cbDistrito.Text.Trim();
            pobjDireccion.Municipio = cbMunicipio.Text.Trim();
            pobjDireccion.Localidad = cbLocalidad.Text.Trim();
            pobjDireccion.Colonia = txtColonia.Text.Trim();
            pobjDireccion.Calle = txtCalle.Text.Trim();
            pobjDireccion.Numero = txtNumeroDeCasa.Text.Trim();
            pobjDireccion.IdDireccion = IdentificadorDireccion;

            

            bool resultado = clsDatosPersonales.ActualizarDatosPersonales(pobjDatospersonales);
            if (resultado == true)
            {
                
            }
            else { MessageBox.Show("Error al actualizar los datos personales"); }

            bool resultado2 = clsDireccion.Actualizar(pobjDireccion);
            if (resultado2 == true)
            {
                
            }
               else { MessageBox.Show("Error al actualizar los datos de direccion"); }
            
            objDocentes pobjDocentes = new objDocentes();
            pobjDocentes.antRfc = DocenteActual.Rfc;
            pobjDocentes.Rfc = txtRFC.Text.Trim();
            pobjDocentes.IdProfesion = Convert.ToInt32(Profesion);

            bool resultado3 = clsDocentes.Actualizar(pobjDocentes);
            if (resultado3 == true)
            {
                MessageBox.Show("Datos Del Docente Actualizados");
            }
            else { MessageBox.Show("Error al actualizar los datos del docente"); }

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentifcadorEstado(cbEstado.Text);
            CargarNombreDistrito(cbEstado.Text);
            estado = cbEstado.SelectedIndex + 1;
            cbMunicipio.Text = "";
            cbDistrito.Text = "";
            cbLocalidad.Text = "";
            switch (estado)
            {
                //AGUASCALIENTES
                case 1:
                    EntidadFederativa = "AS";
                    break;
                //BAJA CALIFORNIA
                case 2:
                    EntidadFederativa = "BC";
                    break;
                //BAJA CALIFORNIA SUR
                case 3:
                    EntidadFederativa = "BS";
                    break;
                //CAMPECHE
                case 4:
                    EntidadFederativa = "CC";
                    break;
                //COAHUILA
                case 5:
                    EntidadFederativa = "CL";
                    break;
                //COLIMA
                case 6:
                    EntidadFederativa = "CM";
                    break;
                //CHIAPAS
                case 7:
                    EntidadFederativa = "CS";
                    break;
                //CHIHUAHUA
                case 8:
                    EntidadFederativa = "CH";
                    break;
                //DISTRITO FEDERAL
                case 9:
                    EntidadFederativa = "DF";
                    break;
                //DURANGO
                case 10:
                    EntidadFederativa = "DG";
                    break;
                //GUANAJUATO
                case 11:
                    EntidadFederativa = "GT";
                    break;
                //GUERRERO
                case 12:
                    EntidadFederativa = "GR";
                    break;
                //HIDALGO
                case 13:
                    EntidadFederativa = "HG";
                    break;
                //JALISCO
                case 14:
                    EntidadFederativa = "JC";
                    break;
                //MEXICO
                case 15:
                    EntidadFederativa = "MC";
                    break;
                //MICHOACAN
                case 16:
                    EntidadFederativa = "MN";
                    break;
                //MORELOS
                case 17:
                    EntidadFederativa = "MS";
                    break;
                //NAYARIT
                case 18:
                    EntidadFederativa = "NT";
                    break;
                //NUEVO LEON
                case 19:
                    EntidadFederativa = "NL";
                    break;
                //OAXACA
                case 20:
                    EntidadFederativa = "OC";
                    break;
                //PUEBLA
                case 21:
                    EntidadFederativa = "PL";
                    break;
                //QUERETARO
                case 22:
                    EntidadFederativa = "QT";
                    break;
                //QUINTANA ROO
                case 23:
                    EntidadFederativa = "QR";
                    break;
                //SAN LUIS POTOSI
                case 24:
                    EntidadFederativa = "SP";
                    break;
                //SINALOA
                case 25:
                    EntidadFederativa = "SL";
                    break;
                //SONORA
                case 26:
                    EntidadFederativa = "SR";
                    break;
                //TABASCO
                case 27:
                    EntidadFederativa = "TC";
                    break;
                //TAMAULIPAS
                case 28:
                    EntidadFederativa = "TS";
                    break;
                //TLAXCALA
                case 29:
                    EntidadFederativa = "TL";
                    break;
                //VERACRUZ
                case 30:
                    EntidadFederativa = "VZ";
                    break;
                //YUATAN
                case 31:
                    EntidadFederativa = "YN";
                    break;
                //ZACATECAS
                default:
                    EntidadFederativa = "ZS";
                    break;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objDocentes pobjDocentes = new objDocentes();
            if (clsDocentes.EliminarDocente(DocenteActual.Rfc) == true)
            {
                MessageBox.Show(DocenteActual.Rfc);
                MessageBox.Show("Docente Eliminado");
            }
        }

        private void frmAltaDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuPrincipal FormularioMenuPrincipal = new frmMenuPrincipal();
            this.Hide();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            genero = cbSexo.SelectedIndex + 1;
            switch (genero)
            {
                case 1:
                    GeneroSolicitante = 'H';
                    break;
                default:
                    GeneroSolicitante = 'M';
                    break;
            }



            CURP = string.Empty;
            dia = string.Empty;
            mes = string.Empty;
            año = string.Empty;
            {
                if (txtNombre.Text.Length == 0)
                {
                    MessageBox.Show("Debes introducir tu nombre", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtApellidoPaterno.Text.Length == 0)
                {
                    MessageBox.Show("Debes introducir tu Apellido Paterno", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtApellidoMaterno.Text.Length == 0)
                {
                    MessageBox.Show("Debes introducir tu Apellido Materno", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //string fecha = Convert.ToString(dtpFecha.Value.Day)+"/"+Convert.ToString(dtpFecha.Value.Month)+"/"+Convert.ToString(dtpFecha.Value.Year);
                    string nombre = txtNombre.Text;
                    string ApellidoPaterno = txtApellidoPaterno.Text;
                    string ApellidoMaterno = txtApellidoMaterno.Text;

                    //MessageBox.Show(nombre +" "+ ApellidoPaterno +" "+ ApellidoMaterno);

                    Posición_1_4_14_16(nombre, ApellidoPaterno, ApellidoMaterno);

                    string fecha = dtpFechaNacimiento.Value.ToShortDateString();
//                    MessageBox.Show(fecha);

                    Posicion_5_10(fecha);
                    CURP = CURP + PL_PApellido + PV_PApellido + PL_SApellido + PL_Nombre + año + mes + dia + GeneroSolicitante + EntidadFederativa
                        + PC_PApellido + PC_SApellido + PC_Nombre;
                    txtCurp.Text = CURP;
                }
            }
        }

        void CargarEstados()
        {
            MySqlCommand Cmd = new MySqlCommand("select NombreEstado from estado", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbEstado.ValueMember = "NombreEstado";
            cbEstado.DataSource = Dt;
        }

        void CargarNombreDistrito(string nombre)
        {
            MySqlCommand Cmd = new MySqlCommand("select IdEstado from Estado where NombreEstado = '" + nombre + "'", clsConexion.BaseDeDatos());
            MySqlDataReader DrIdEstado = Cmd.ExecuteReader();
            while (DrIdEstado.Read())
            {
                Clave = DrIdEstado.GetString(0);
            }
            MySqlCommand Cmd2 = new MySqlCommand("select NombreDistrito from distrito where IdEstado = " + Clave + "", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd2);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbDistrito.ValueMember = "NombreDistrito";
            cbDistrito.DataSource = Dt;
        }

        void CargarNombreMunicipio(string nombre)
        {
            MySqlCommand Cmd = new MySqlCommand("select IdDistrito from distrito where NombreDistrito = '" + nombre + "'", clsConexion.BaseDeDatos());
            MySqlDataReader DrIdDistrito = Cmd.ExecuteReader();
            while (DrIdDistrito.Read())
            {
                Clave = DrIdDistrito.GetString(0);
            }
            MySqlCommand Cmd2 = new MySqlCommand("select NombreMunicipio from municipio where IdDistrito =" + Clave + "", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd2);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbMunicipio.ValueMember = "NombreMunicipio";
            cbMunicipio.DataSource = Dt;
        }

        void CargarNombreLocalidad(string nombre)
        {
            MySqlCommand Cmd = new MySqlCommand("select IdMunicipio from municipio where NombreMunicipio = '" + nombre + "'", clsConexion.BaseDeDatos());
            MySqlDataReader DrIdMunicipio = Cmd.ExecuteReader();
            while (DrIdMunicipio.Read())
            {
                Clave = DrIdMunicipio.GetString(0);
            }
            MySqlCommand Cmd2 = new MySqlCommand("select NombreLocalidad from localidad where IdMunicipio =" + Clave + "", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd2);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbLocalidad.ValueMember = "NombreLocalidad";
            cbLocalidad.DataSource = Dt;
        }

        void CargarLocalidadNombre(string nom)
        {
            MySqlCommand cmd = new MySqlCommand("select IdMunicipio from municipio where NombreMunicipio='" + nom + "'", clsConexion.BaseDeDatos());
            MySqlDataReader Dridm = cmd.ExecuteReader();
            while (Dridm.Read())
            {
                Clave = Dridm.GetString(0);
            }
            MySqlCommand cmd2 = new MySqlCommand("select NombreLocalidad fROM localidad where IdMunicipio=" + Clave + "", clsConexion.BaseDeDatos());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbLocalidad.ValueMember = "localidad";
            cbLocalidad.DataSource = dt;
        }

        private void cbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentifcadorDistrito(cbDistrito.Text);
            CargarNombreMunicipio(cbDistrito.Text);
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentificadorMunicipio(cbMunicipio.Text);
            CargarNombreLocalidad(cbMunicipio.Text);
        }

        private void btnAgregarDistrito_Click(object sender, EventArgs e)
        {
            objDistrito pobjDistrito = new objDistrito();
            pobjDistrito.NombreDistrito = cbDistrito.Text.Trim();
            pobjDistrito.IdEstado = Convert.ToInt32(IdEstado);

            bool resultado = clsDistrito.GuardarDistrito(pobjDistrito);
            if (resultado == true)
            {
                MessageBox.Show("Distrito Almacenado");
            }
        }

        private void btnAgregarMunicipio_Click(object sender, EventArgs e)
        {
            objMunicipio pobjMunicipio = new objMunicipio();
            pobjMunicipio.NombreMunicipio = cbMunicipio.Text.Trim();
            pobjMunicipio.IdDistrito =Convert.ToInt32(IdDistrito);

            bool resultado = clsMunicipio.GuardarMunicipio(pobjMunicipio);
            if (resultado==true)
            {
                MessageBox.Show("Municipio Almacenado");
            }
        }

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            objLocalidad pobjLocalidad = new objLocalidad();
            pobjLocalidad.NombreLocalidad = cbLocalidad.Text;
            pobjLocalidad.IdMunicipio = Convert.ToInt32(IdMunicipio);

            bool resulado = clsLocalidad.GuardarLocalidad(pobjLocalidad);
            if(resulado==true)
            {
                MessageBox.Show("Localidad Almacenada");
            }
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
