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
    public partial class frmAlumnoMaterias : Form
    {
        public frmAlumnoMaterias()
        {
            InitializeComponent();
        }
        public objAlumnoMaterias AlumnoMateriaActual { get; set; }

        public string idmateria;

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
                lblAP.Text = ApellidoPaterno;
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
                lblAM.Text = ApellidoMaterno;
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
        void MostrarIdMateria(string materiaa)
        {
            string consultaidmateria = "select CodigoMaterias from materias where UAC = '" + materiaa + "'";

            MySqlConnection Cnnidmateria = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidmateria = new MySqlCommand(String.Format(consultaidmateria), Cnnidmateria);
            MySqlDataReader Dridmateria = Cmdidmateria.ExecuteReader();
            while (Dridmateria.Read())
            {
                idmateria = Dridmateria.GetString(0);
            }
        }
        void CargarMatriculas()
        {
            MySqlCommand Cmd = new MySqlCommand("select distinct alumnomaterias.Matricula from alumnomaterias", clsConexion.BaseDeDatos());
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            cbMatricula.ValueMember = "Matricula";
            cbMatricula.DataSource = Dt;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlumnoMaterias pobjAlumnoMaterias = new objAlumnoMaterias();
            pobjAlumnoMaterias.CodigoMaterias = Convert.ToInt32(idmateria);
            pobjAlumnoMaterias.Matricula = cbMatricula.Text;
            if (clsAlumnoMaterias.GuardarAlumnoMateria(pobjAlumnoMaterias) == true)
            {
                MessageBox.Show("Materia agregada correctamente");
            }
            else
            {
                MessageBox.Show("Error al guardar la materia");
            }
        }
        private void frmAlumnoMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMatricula.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dsMatricula.alumno);
        }
        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;

            mostrarnombre(cbMatricula.Text);
            mostrarapellidopaterno(cbMatricula.Text);
            mostrarapellidomaterno(cbMatricula.Text);
            mostrargrupo(cbMatricula.Text);
            mostrarsemestre(cbMatricula.Text);
            cbMateria.Items.Clear();
            if (lblSemestre.Text == "1")
            {
                cbMateria.Items.Add("MATEMÁTICAS I");
                cbMateria.Items.Add("QUÍMICA I");
                cbMateria.Items.Add("ÉTICA Y VALORES I");
                cbMateria.Items.Add("INTRODUCCIÓN A LAS CIENCIAS SOCIALES");
                cbMateria.Items.Add("TALLER DE LECTURA Y REDACCIÓN I");
                cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL I (INGLES)");
                cbMateria.Items.Add("INFORMÁTICA I");
            }

            if (lblSemestre.Text == "2")
            {
                cbMateria.Items.Add("MATEMÁTICAS II");
                cbMateria.Items.Add("QUÍMICA II");
                cbMateria.Items.Add("ÉTICA Y VALORES II");
                cbMateria.Items.Add("HISTORIA DE MÉXICO I");
                cbMateria.Items.Add("TALLER DE LECTURA Y REDACCIÓN II");
                cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL II (INGLES)");
                cbMateria.Items.Add("INFORMÁTICA II");
            }

            if (lblSemestre.Text == "3")
            {
                cbMateria.Items.Add("MATEMÁTICAS III");
                cbMateria.Items.Add("BIOLOGÍA I");
                cbMateria.Items.Add("FÍSICA I");
                cbMateria.Items.Add("LITERATURA I");
                cbMateria.Items.Add("HISTORIA DE MÉXICO II");
                cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL III (INGLES)");
                if (rbHSC.Checked)
                {
                    cbMateria.Items.Add("ESTRUCTURAS Y FUNCIONES BÁSICAS DEL CUERPO HUMANO");
                    cbMateria.Items.Add("ESTRUCTURAS Y FUNCIONES COMPLEJAS DEL CUERPO HUMANO");
                }
                if (rbTICS.Checked)
                {
                    cbMateria.Items.Add("ARQUITECTURAS DE HARDWARE");
                    cbMateria.Items.Add("SOFTWARE DE SISTEMAS OPERATIVOS");
                }
                if (rbADMON.Checked)
                {
                    cbMateria.Items.Add("PLANEACIÓN Y PRESUPUESTACIÓN DE RECURSOS");
                    cbMateria.Items.Add("PLAN DE ACCIÓN");
                }
            }

            if (lblSemestre.Text == "4")
            {
                cbMateria.Items.Add("MATEMÁTICAS IV");
                cbMateria.Items.Add("BIOLOGÍA II");
                cbMateria.Items.Add("FÍSICA II");
                cbMateria.Items.Add("LITERATURA II");
                cbMateria.Items.Add("ESTRUCTURA SOCIOECONÓMICA DE MÉXICO");
                cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL IV (INGLES)");
                cbMateria.Items.Add("ETIMOLOGÍAS");
                if (rbHSC.Checked)
                {
                    cbMateria.Items.Add("VALORACIONES NUTRICIONALES");
                    cbMateria.Items.Add("SALUD MATERNO INFANTIL");
                }
                if (rbTICS.Checked)
                {
                    cbMateria.Items.Add("LÓGICA COMPUTACIONAL Y PROGRAMACIÓN");
                    cbMateria.Items.Add("INTRODUCCIÓN A BASES DE DATOS");
                }
                if (rbADMON.Checked)
                {
                    cbMateria.Items.Add("COMUNICACIÓN DE LA EMPRESA");
                    cbMateria.Items.Add("INFORMACIÓN DOCUMENTAL DE LA EMPRESA");
                    cbMateria.Items.Add("");
                }
            }

            if (lblSemestre.Text == "5")
            {
                cbMateria.Items.Add("GEOGRAFÍA");
                cbMateria.Items.Add("HISTORIA UNIVERSAL CONTEMPORÁNEA");
                if (rbHSC.Checked)
                {
                    cbMateria.Items.Add("TEMAS SELECTOS DE QUÍMICA I");
                    cbMateria.Items.Add("TEMAS SELECTOS DE BIOLOGÍA I");
                    cbMateria.Items.Add("FISICOQUÍMICA");
                    cbMateria.Items.Add("PSICOLOGÍA I");
                    cbMateria.Items.Add("ESTUDIO DE COMUNIDAD");
                    cbMateria.Items.Add("PROGRAMAS DE SALUD PUBLICA");
                }
                if (rbTICS.Checked)
                {
                    cbMateria.Items.Add("ESTADÍSTICA");
                    cbMateria.Items.Add("CALCULO DIFERENCIAL");
                    cbMateria.Items.Add("TEMAS SELECTOS DE FÍSICA I");
                    cbMateria.Items.Add("FISICOQUÍMICA");
                    cbMateria.Items.Add("FUNDAMENTOS DE REDES LAN");
                    cbMateria.Items.Add("TECNOLOGÍAS DE INFORMACIÓN Y COMUNICACIÓN");
                }
                if (rbADMON.Checked)
                {
                    cbMateria.Items.Add("ESTADÍSTICA");
                    cbMateria.Items.Add("MATEMÁTICAS FINANCIERAS");
                    cbMateria.Items.Add("ECONOMÍA I");
                    cbMateria.Items.Add("CIENCIAS DE LA COMUNICACIÓN I");
                    cbMateria.Items.Add("SISTEMAS DE INFORMACIÓN");
                    cbMateria.Items.Add("ATENCIÓN A CLIENTES");
                }
            }

            if (lblSemestre.Text == "6")
            {
                cbMateria.Items.Add("ECOLOGÍA Y MEDIO AMBIENTE");
                cbMateria.Items.Add("FILOSOFÍA");
                cbMateria.Items.Add("METODOLOGÍA DE LA INVESTIGACIÓN");
                if (rbHSC.Checked)
                {
                    cbMateria.Items.Add("TEMAS SELECTOS DE QUÍMICA II");
                    cbMateria.Items.Add("TEMAS SELECTOS DE BIOLOGÍA II");
                    cbMateria.Items.Add("FISICOQUÍMICA");
                    cbMateria.Items.Add("PSICOLOGÍA II");
                    cbMateria.Items.Add("PREVENCIÓN DE ENFERMEDADES");
                    cbMateria.Items.Add("PRINCIPIOS DE EPIDEMIOLOGIA");
                }
                if (rbTICS.Checked)
                {
                    cbMateria.Items.Add("PROBABILIDAD Y ESTADÍSTICA");
                    cbMateria.Items.Add("CALCULO INTEGRAL");
                    cbMateria.Items.Add("TEMAS SELECTOS DE FÍSICA II");
                    cbMateria.Items.Add("TEMAS SELECTOS DE MATEMÁTICAS");
                    cbMateria.Items.Add("PRODUCCIÓN DE MULTIMEDIA");
                    cbMateria.Items.Add("DISEÑO WEB");
                }
                if (rbADMON.Checked)
                {
                    cbMateria.Items.Add("PROBABILIDAD Y ESTADÍSTICA");
                    cbMateria.Items.Add("TEMAS SELECTOS DE DERECHO");
                    cbMateria.Items.Add("ECONOMÍA II");
                    cbMateria.Items.Add("CIENCIAS DE LA COMUNICACIÓN II");
                    cbMateria.Items.Add("SEGUIMIENTO AL CLIENTE");
                    cbMateria.Items.Add("VENTA MEDIANTE TIC’S");
                }
            }

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select alumnomaterias.CodigoMaterias, materias.UAC,materias.CreditosMaterias,materias.HorasMaterias from materiasemestre,alumnomaterias,materias,alumno where alumnomaterias.Matricula = '"+cbMatricula.Text+"' and materias.CodigoMaterias = alumnomaterias.CodigoMaterias and alumno.Matricula = alumnomaterias.Matricula and alumnomaterias.CodigoMaterias = materiasemestre.CodigoMaterias and materiasemestre.IdSemestre = '"+lblSemestre.Text+"' and materias.CodigoMaterias = alumnomaterias.CodigoMaterias and alumno.Matricula = alumnomaterias.Matricula and alumnomaterias.CodigoMaterias = materiasemestre.CodigoMaterias";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIdMateria(cbMateria.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objAlumnoMaterias pobjAlumnoMaterias = new objAlumnoMaterias();
            pobjAlumnoMaterias.Matricula = cbMatricula.Text;
            pobjAlumnoMaterias.CodigoMaterias = Convert.ToInt32(idmateria);
            pobjAlumnoMaterias.IdAlumnoMateria = AlumnoMateriaActual.IdAlumnoMateria;
            if (clsAlumnoMaterias.ActualizarAlumnoMateria(pobjAlumnoMaterias) == true)
            {

            }
            else
            {
                MessageBox.Show("Error al actualizar los datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (clsAlumnoMaterias.EliminarAlumnoMateria(AlumnoMateriaActual.IdAlumnoMateria) == true)
                {
                    MessageBox.Show("Registro Eliminado");
                    CargarMatriculas();
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlumnoMateria FormularioBusquedaAlumnoMateria = new frmBusquedaAlumnoMateria();
            FormularioBusquedaAlumnoMateria.ShowDialog();
            if (FormularioBusquedaAlumnoMateria.AlumnoMateriaSeleccionado != null)
            {
                AlumnoMateriaActual = FormularioBusquedaAlumnoMateria.AlumnoMateriaSeleccionado;
                cbMatricula.Text = FormularioBusquedaAlumnoMateria.AlumnoMateriaSeleccionado.Matricula;
                cbMateria.Text = FormularioBusquedaAlumnoMateria.AlumnoMateriaSeleccionado.UAC;
            }
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }
    }
}
