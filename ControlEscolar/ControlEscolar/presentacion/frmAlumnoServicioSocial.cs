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
using ControlEscolar.objetos;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
namespace ControlEscolar.presentacion
{
    public partial class frmAlumnoServicioSocial : Form
    {
        public frmAlumnoServicioSocial()
        {
            InitializeComponent();
        }

        public objDireccion DireccionActual { get; set; }
        public objServicioSocial Serviciosocialactual { get; set; }
        public objAlumnoServicioSocial AlumnoserviciosocialActual { get; set; }
        public string Clave;
        public string IdMunicipioo;
        public string IdEstado;
        public string IdDistrito;
        public string IdMunicipio;

        public int IdentificadorDireccion;
        public int IdentificadorServicioSocial;

        public string IdDireccion;
        public string IdServicioSocial;
        public int IdAlumnnoServicioSociall;

        void IdentifcadorEstado(string Estadoo)
        {
            string ConsultaIdentificadorEstado = "select IdEstado from estado where NombreEstado = '" + Estadoo + "'";
            MySqlConnection Cnnide = clsConexion.BaseDeDatos();
            MySqlCommand Cmdide = new MySqlCommand(string.Format(ConsultaIdentificadorEstado), Cnnide);
            MySqlDataReader Dride = Cmdide.ExecuteReader();
            while (Dride.Read())
            {
                IdEstado = Dride.GetString(0);
            }
        }

        void IdentifcadorDistrito(string Distritoo)
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

        void IdentificadorMunicipio(string Municipioo)
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

        private void frmAlumnoServicioSocial_Load(object sender, EventArgs e)
        {
            LlenarMatriculas();
            CargarEstados();
        }

        void mostrarnombre(string matricula)
        {
            string nombre;
            string consultanombre = "SELECT datospersonales.Nombre FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnnombre = clsConexion.BaseDeDatos();
            MySqlCommand Cmdnombre = new MySqlCommand(String.Format(consultanombre), Cnnnombre);
            MySqlDataReader Drnombre = Cmdnombre.ExecuteReader();
            while (Drnombre.Read())
            {
                nombre = Drnombre.GetString(0);
                lblNombre.Text = nombre;
            }
        }

        void mostrarapellidopaterno(string matricula)
        {
            string ApellidoPaterno;
            string consultaAP = "SELECT datospersonales.ApellidoPaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnap = clsConexion.BaseDeDatos();
            MySqlCommand Cmdap = new MySqlCommand(String.Format(consultaAP), Cnnap);
            MySqlDataReader Drap = Cmdap.ExecuteReader();
            while (Drap.Read())
            {
                ApellidoPaterno = Drap.GetString(0);
                lblApellidop.Text = ApellidoPaterno;
            }
        }

        void mostrarapellidomaterno(string matricula)
        {
            string ApellidoMaterno;
            string consultaAM = "SELECT datospersonales.ApellidoMaterno FROM alumno,datospersonales where matricula = '" + matricula + "' and alumno.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnam = clsConexion.BaseDeDatos();
            MySqlCommand Cmdam = new MySqlCommand(String.Format(consultaAM), Cnnam);
            MySqlDataReader Dram = Cmdam.ExecuteReader();
            while (Dram.Read())
            {
                ApellidoMaterno = Dram.GetString(0);
                lblApellidom.Text = ApellidoMaterno;
            }
        }

        void mostrargrupo(string matricula)
        {

            string Grupo;
            string consultaG = "SELECT IdGrupo from alumnogrupo where Matricula='" + matricula + "'";

            MySqlConnection CnnG = clsConexion.BaseDeDatos();
            MySqlCommand CmdG = new MySqlCommand(String.Format(consultaG), CnnG);
            MySqlDataReader DrG = CmdG.ExecuteReader();
            while (DrG.Read())
            {
                Grupo = DrG.GetString(0);
                lblGrupo.Text = Grupo;
            }
        }

        void mostrarsemestre(string matricula)
        {
            string semestreanterior;
            string consultasemestreanterior = "select idsemestre from alumnosemestre where Matricula = '" + matricula + "'";

            MySqlConnection Cnnsemestreanterior = clsConexion.BaseDeDatos();
            MySqlCommand Cmdsemestreanterior = new MySqlCommand(String.Format(consultasemestreanterior), Cnnsemestreanterior);
            MySqlDataReader Drsemestreanterior = Cmdsemestreanterior.ExecuteReader();
            while (Drsemestreanterior.Read())
            {
                semestreanterior = Drsemestreanterior.GetString(0);
                lblSemestre.Text = semestreanterior;
            }
        }

        public void LlenarMatriculas ()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select distinct alumnosemestre.Matricula from alumnosemestre where alumnosemestre.idsemestre = 5 or 6", Cnn);
            Myda.Fill(dsMatricula,"alumnosemestre");
            cbMatricula.DataSource = dsMatricula.Tables[0].DefaultView;
            cbMatricula.ValueMember = "matricula";
            cbMatricula.DisplayMember = "matricula";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objDireccion pobjDireccion = new objDireccion();
            pobjDireccion.Colonia = txtcolonia.Text.Trim();
            pobjDireccion.Calle = txtcalle.Text.Trim();
            pobjDireccion.Numero = txtnumero.Text.Trim();
            pobjDireccion.Localidad = cbLocalidad.Text.Trim();
            pobjDireccion.Estado = cbEstado.Text.Trim();
            pobjDireccion.Distrito = cbDistrito.Text.Trim();
            pobjDireccion.Municipio = cbMunicipio.Text.Trim();

            bool resultado = clsDireccion.GuardarDireccion(pobjDireccion);
            if  (resultado == true)
            {

            }
            else
            {
                MessageBox.Show("Error al guardar la direccion");
            }

            MaxIdDireccion();
            MessageBox.Show(IdDireccion);
            objServicioSocial pobjServicioSocial = new objServicioSocial();
            pobjServicioSocial.Dependencia = txtDependencia.Text.Trim();
            pobjServicioSocial.NombreDelPrograma = txtNombreProyecto.Text.Trim();
            pobjServicioSocial.SubPrograma = txtSubprograma.Text.Trim();
            pobjServicioSocial.ActividadBasica = txtactividadbasica.Text.Trim();
            pobjServicioSocial.Modalidad = txtmodalidad.Text.Trim();
            pobjServicioSocial.Areas = txtareadepractica.Text.Trim();
            pobjServicioSocial.FechaInicio = Convert.ToDateTime(dtpfechainicio.Text);
            pobjServicioSocial.FechaFinal = Convert.ToDateTime(dtpfechafin.Text);
            pobjServicioSocial.IdDireccion = Convert.ToInt32(IdDireccion);

            bool resultado2 = clsServicioSocial.GuardarServicioSocial(pobjServicioSocial);
            if(resultado2 == true)
            {

            }
            else
            {
                MessageBox.Show("Error al guardar datos del servicio social");
            }
            MaxIdServicioSocial();
            MessageBox.Show(IdServicioSocial);
            objAlumnoServicioSocial pobjAlumnoServicioSocial = new objAlumnoServicioSocial();
            pobjAlumnoServicioSocial.Matricula = cbMatricula.Text;
            pobjAlumnoServicioSocial.IdServicioSocial = Convert.ToInt32(IdServicioSocial);
            bool resultado3 = clsAlumnoServicioSocial.GuardarAlumnoServicioSocial(pobjAlumnoServicioSocial);
            if(resultado3 == true)
            {

            }
            else
            {
                MessageBox.Show("Error al guardar la Datos del alumno-servico social");
            }

            frmSolicitudServicioSocial ReporteSolicitudSS = new frmSolicitudServicioSocial();
            ReporteSolicitudSS.txtnombre.Text = lblNombre.Text;
            ReporteSolicitudSS.txtapellidopaterno.Text = lblApellidop.Text;
            ReporteSolicitudSS.txtapellidomaterno.Text = lblApellidom.Text;
            ReporteSolicitudSS.txtsemestre.Text = lblSemestre.Text;
            ReporteSolicitudSS.txtgrupo.Text = lblGrupo.Text;
            ReporteSolicitudSS.txtmatricula.Text = cbMatricula.Text;
            ReporteSolicitudSS.txtdependencia.Text = txtDependencia.Text;
            ReporteSolicitudSS.lblestado.Text = cbEstado.Text;
            ReporteSolicitudSS.lblciudad.Text = cbLocalidad.Text;
            ReporteSolicitudSS.lblcolonia.Text = txtcolonia.Text;
            ReporteSolicitudSS.lblcalle.Text = txtcalle.Text;
            ReporteSolicitudSS.lblnumero.Text = txtnumero.Text;
            ReporteSolicitudSS.lblareadeservicio.Text = txtareadepractica.Text;
            ReporteSolicitudSS.lblfechainicio.Text = dtpfechainicio.Text;
            ReporteSolicitudSS.lblfechafin.Text = dtpfechafin.Text;
            ReporteSolicitudSS.ShowDialog();

        }
        void MaxIdDireccion()
        {
            string ConsultaIdD = "select max(IdDireccion) from direccion";
            MySqlConnection Cnnidd = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidd = new MySqlCommand(String.Format(ConsultaIdD), Cnnidd);
            MySqlDataReader Dridd = Cmdidd.ExecuteReader();
            while (Dridd.Read())
            {
                IdDireccion = Dridd.GetString(0);
            }
        }

        void MaxIdServicioSocial()
        {
            string ConsultaIdD = "select max(IdServicioSocial) from serviciosocial";
            MySqlConnection Cnnidd = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidd = new MySqlCommand(String.Format(ConsultaIdD), Cnnidd);
            MySqlDataReader Dridd = Cmdidd.ExecuteReader();
            while (Dridd.Read())
            {
                    IdServicioSocial = Dridd.GetString(0);
            }
        }

        void SeleccionIdAS()
        {
            string ConsultaIdD = "select alumnoserviciosocial.idAlumnoServicioSocial from alumnoserviciosocial where Matricula = '"+cbMatricula.Text+"'";
            MySqlConnection Cnnidd = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidd = new MySqlCommand(String.Format(ConsultaIdD), Cnnidd);
            MySqlDataReader Dridd = Cmdidd.ExecuteReader();
            while (Dridd.Read())
            {
                IdAlumnnoServicioSociall = Dridd.GetInt32(0);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaServicioSocial FormularioBusquedaServicioSocial = new frmBusquedaServicioSocial();
            FormularioBusquedaServicioSocial.ShowDialog();

            if (FormularioBusquedaServicioSocial.Serviciosocialseleccionado != null)
            {
                DireccionActual = FormularioBusquedaServicioSocial.Direccionseleccionada;
                Serviciosocialactual = FormularioBusquedaServicioSocial.Serviciosocialseleccionado;
                AlumnoserviciosocialActual = FormularioBusquedaServicioSocial.Alumnoserviciosocialseleccionado;

                txtDependencia.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Dependencia;
                txtNombreProyecto.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.NombreDelPrograma;
                txtSubprograma.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.SubPrograma;
                txtactividadbasica.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.ActividadBasica;
                txtmodalidad.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Modalidad;
                txtareadepractica.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Areas;
                dtpfechainicio.Text = Convert.ToString(FormularioBusquedaServicioSocial.Serviciosocialseleccionado.FechaInicio);
                dtpfechafin.Text = Convert.ToString(FormularioBusquedaServicioSocial.Serviciosocialseleccionado.FechaFinal);

                IdentificadorServicioSocial = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.IdServicioSocial;

                cbMatricula.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Matricula;

                cbEstado.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Estado;
                cbDistrito.Text  = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Distrito;
                cbMunicipio.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Municipio;
                cbLocalidad.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Localidad;
                txtcolonia.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Colonia;
                txtcalle.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Calle;
                txtnumero.Text = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.Numero;
                IdentificadorDireccion = FormularioBusquedaServicioSocial.Serviciosocialseleccionado.IdDireccion;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objDireccion pobjDireccion = new objDireccion();
            pobjDireccion.Colonia = txtcolonia.Text.Trim();
            pobjDireccion.Calle = txtcalle.Text.Trim();
            pobjDireccion.Numero = txtnumero.Text.Trim();
            pobjDireccion.Localidad = cbLocalidad.Text.Trim();
            pobjDireccion.Estado = cbEstado.Text.Trim();
            pobjDireccion.Distrito = cbDistrito.Text.Trim();
            pobjDireccion.Municipio = cbMunicipio.Text.Trim();
            MessageBox.Show(""+IdentificadorDireccion);
            pobjDireccion.IdDireccion = IdentificadorDireccion;
            bool resultado = clsDireccion.Actualizar(pobjDireccion);
            if (resultado == true)
            {

            }
            else
            {
                MessageBox.Show("Error al actualizar los datos de la direccion");
            }

            objServicioSocial pobjServicioSocial = new objServicioSocial();
            pobjServicioSocial.Dependencia = txtDependencia.Text.Trim();
            pobjServicioSocial.NombreDelPrograma = txtNombreProyecto.Text.Trim();
            pobjServicioSocial.SubPrograma = txtSubprograma.Text.Trim();
            pobjServicioSocial.ActividadBasica = txtactividadbasica.Text.Trim();
            pobjServicioSocial.Modalidad = txtmodalidad.Text.Trim();
            pobjServicioSocial.Areas = txtareadepractica.Text.Trim();
            pobjServicioSocial.FechaInicio = Convert.ToDateTime(dtpfechainicio.Text);
            pobjServicioSocial.FechaFinal = Convert.ToDateTime(dtpfechafin.Text);
            pobjServicioSocial.IdDireccion = IdentificadorDireccion;
            pobjServicioSocial.IdServicioSocial = IdentificadorServicioSocial;
            bool resultado2 = clsServicioSocial.ActualizarServicioSocial(pobjServicioSocial);
            if (resultado2 == true)
            {

            }
            else
            {
                MessageBox.Show("Error al actualizar el servicio social");
            }

            SeleccionIdAS();
            objAlumnoServicioSocial pobjAlumnoServicioSocial = new objAlumnoServicioSocial();
            pobjAlumnoServicioSocial.Matricula = cbMatricula.Text;
            pobjAlumnoServicioSocial.IdServicioSocial = IdentificadorServicioSocial;
            pobjAlumnoServicioSocial.IdAlumnoServicioSocial =IdAlumnnoServicioSociall;
            bool resultado3 = clsAlumnoServicioSocial.ActualizarAlumnoServicioSocial(pobjAlumnoServicioSocial);
            if (resultado3 == true)
            {

            }
            else
            {
                MessageBox.Show("Error al guardar la Datos del alumno servicio social");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objAlumnoServicioSocial pobjAlumnoServicioSocial = new objAlumnoServicioSocial();
            SeleccionIdAS();
            if (clsAlumnoServicioSocial.EliminarServicioSocial(IdAlumnnoServicioSociall) == true)
            {
                MessageBox.Show("Eliminado ASS");
            }

            objServicioSocial pobjServicioSocial = new objServicioSocial();
            if (clsServicioSocial.EliminarServicioSocial (IdentificadorServicioSocial) == true)
            {
                MessageBox.Show("SS eliminado");
            }

            objDireccion pobjDireccion = new objDireccion();
            if (clsDireccion.EliminarDireccion (IdentificadorDireccion) == true)
            {
                MessageBox.Show("D eliminada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCartadepresentacion Cartadepresentacion = new frmCartadepresentacion();
            Cartadepresentacion.txtnombre.Text = lblNombre.Text;
            Cartadepresentacion.txtapellidopaterno.Text = lblApellidop.Text;
            Cartadepresentacion.txtapellidomaterno.Text = lblApellidom.Text;
            Cartadepresentacion.lblNombreDelProyecto.Text = txtNombreProyecto.Text;
            Cartadepresentacion.lblfechainicio.Text = dtpfechainicio.Text;
            Cartadepresentacion.lblfechafin.Text = dtpfechafin.Text;
            Cartadepresentacion.ShowDialog();
        }

        private void frmAlumnoServicioSocial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarnombre(cbMatricula.Text);
            mostrarapellidopaterno(cbMatricula.Text);
            mostrarapellidomaterno(cbMatricula.Text);
            mostrargrupo(cbMatricula.Text);
            mostrarsemestre(cbMatricula.Text);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentifcadorEstado(cbEstado.Text);
            CargarNombreDistrito(cbEstado.Text);
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

        private void btnEstado_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDistrito_Click(object sender, EventArgs e)
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

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            objMunicipio pobjMunicipio = new objMunicipio();
            pobjMunicipio.NombreMunicipio = cbMunicipio.Text.Trim();
            pobjMunicipio.IdDistrito = Convert.ToInt32(IdDistrito);

            bool resultado = clsMunicipio.GuardarMunicipio(pobjMunicipio);
            if (resultado == true)
            {
                MessageBox.Show("Municipio Almacenado");
            }
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            objLocalidad pobjLocalidad = new objLocalidad();
            pobjLocalidad.NombreLocalidad = cbLocalidad.Text;
            pobjLocalidad.IdMunicipio = Convert.ToInt32(IdMunicipio);

            bool resulado = clsLocalidad.GuardarLocalidad(pobjLocalidad);
            if (resulado == true)
            {
                MessageBox.Show("Localidad Almacenada");
            }
        }
    }
}
