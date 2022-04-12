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
    public partial class frmConsultaCalificaciones : Form
    {
        public frmConsultaCalificaciones()
        {
            InitializeComponent();
        }
        public string idmateria;
        public string SiCalificacion;
        public string Identificador_Calificaciones;
        double promedioa;
        double promediob;
        double promediogeneral;

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
        void ObtenerIdCalificacion()
        {
            string consultaidmateria = "select IdCalificaciones from calificaciones where Matricula ='" + cbMatricula.Text + "' and CodigoMateria = '" + idmateria + "'";

            MySqlConnection Cnnidcalificacion = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidcalificacion = new MySqlCommand(String.Format(consultaidmateria), Cnnidcalificacion);
            MySqlDataReader Dridcalificacion = Cmdidcalificacion.ExecuteReader();
            while (Dridcalificacion.Read())
            {
                Identificador_Calificaciones = Dridcalificacion.GetString(0);
            }
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
        void mostrar1()
        {
            string c1p;
            string consulta1p = "SELECT 1p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn1p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd1p = new MySqlCommand(String.Format(consulta1p), Cnn1p);
            MySqlDataReader Dr1p = Cmd1p.ExecuteReader();
            while (Dr1p.Read())
            {
                c1p = Dr1p.GetString(0);
                lblp1.Text = c1p;
            }
        }
        void mostrar2()
        {
            string c2p;
            string consulta2p = "SELECT 2p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn2p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd2p = new MySqlCommand(String.Format(consulta2p), Cnn2p);
            MySqlDataReader Dr2p = Cmd2p.ExecuteReader();
            while (Dr2p.Read())
            {
                c2p = Dr2p.GetString(0);
                lblp2.Text = c2p;
            }
        }
        void mostrar3()
        {
            string c2p;
            string consulta1p = "SELECT 3p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn2p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd2p = new MySqlCommand(String.Format(consulta1p), Cnn2p);
            MySqlDataReader Dr2p = Cmd2p.ExecuteReader();
            while (Dr2p.Read())
            {
                c2p = Dr2p.GetString(0);
                lblp3.Text = c2p;
            }
        }
        void mostrar4()
        {
            string c2p;
            string consulta1p = "SELECT 4p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn2p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd2p = new MySqlCommand(String.Format(consulta1p), Cnn2p);
            MySqlDataReader Dr2p = Cmd2p.ExecuteReader();
            while (Dr2p.Read())
            {
                c2p = Dr2p.GetString(0);
                lblp4.Text = c2p;
            }
        }
        void mostrar5()
        {
            string c2p;
            string consulta1p = "SELECT 5p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn2p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd2p = new MySqlCommand(String.Format(consulta1p), Cnn2p);
            MySqlDataReader Dr2p = Cmd2p.ExecuteReader();
            while (Dr2p.Read())
            {
                c2p = Dr2p.GetString(0);
                lblp5.Text = c2p;
            }
        }
        void mostrar6()
        {
            string c2p;
            string consulta1p = "SELECT 6p from cobao.calificaciones, cobao.materias where calificaciones.CodigoMateria = materias.CodigoMaterias and materias.UAC = '" + cbMateria.Text + "' and calificaciones.CodigoMateria = materias.CodigoMaterias and calificaciones.Matricula = '" + cbMatricula.Text + "'";

            MySqlConnection Cnn2p = clsConexion.BaseDeDatos();
            MySqlCommand Cmd2p = new MySqlCommand(String.Format(consulta1p), Cnn2p);
            MySqlDataReader Dr2p = Cmd2p.ExecuteReader();
            while (Dr2p.Read())
            {
                c2p = Dr2p.GetString(0);
                lblp6.Text = c2p;
            }
        }

        void PrimerPromedio ()
        {
            promedioa = (double.Parse(lblp1.Text) + double.Parse(lblp2.Text) + double.Parse(lblp3.Text)) / 3;
            lblpa.Text = promedioa.ToString("N2");
        }

        void SegundoPromedio()
        {
            promediob = (double.Parse(lblp4.Text) + double.Parse(lblp5.Text) + double.Parse(lblp6.Text)) / 3;
            lblpb.Text = promediob.ToString("N2");

            promediogeneral = (promedioa + promediob) / 2;
            lblpg.Text = promediogeneral.ToString("N2");
        }

        private void frmConsultaCalificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMatricula.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dsMatricula.alumno);
            // TODO: esta línea de código carga datos en la tabla 'dsMatricula.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dsMatricula.alumno);

        }

        private void cbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblp1.Text = "0";
            lblp2.Text = "0";
            lblp3.Text = "0";
            lblp4.Text = "0";
            lblp5.Text = "0";
            lblp6.Text = "0";
            lblpa.Text = "0";
            lblpb.Text = "0";
            lblpg.Text = "0";


            mostrar1();
            mostrar2();
            mostrar3();
            mostrar4();
            mostrar5();
            mostrar6();
            MostrarIdMateria(cbMateria.Text);
            ObtenerIdCalificacion();
            PrimerPromedio();
            SegundoPromedio();
        }

        private void frmConsultaCalificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
