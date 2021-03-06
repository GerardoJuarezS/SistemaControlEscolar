
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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }
        public objCalificaciones Calificacionactual { get; set; }
        public string idmateria;
        public string SiCalificacion;
        public string Identificador_Calificaciones;
        double promedioa;
        double promediob;
        double promediogeneral;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objCalificaciones pobjCalificaciones = new objCalificaciones();
            pobjCalificaciones.PrimerParcial = Convert.ToDouble(txt1P.Text.Trim());
            pobjCalificaciones.SegundoParcial = Convert.ToDouble(txt2P.Text.Trim());
            pobjCalificaciones.TercerParcial = Convert.ToDouble(txt3P.Text.Trim());
            pobjCalificaciones.CuartoParcial = Convert.ToDouble(txt4P.Text.Trim());
            pobjCalificaciones.QuintoParcial = Convert.ToDouble(txt5P.Text.Trim());
            pobjCalificaciones.SextoParcial = Convert.ToDouble(txt6P.Text.Trim());
            pobjCalificaciones.Matricula = cbMatricula.Text;
            pobjCalificaciones.CodigoMateria = Convert.ToInt32(idmateria);
            pobjCalificaciones.PromedioGeneral = Convert.ToDouble(txtPromedioGeneral.Text);

            int resultado = clsCalificaciones.GuardarCalificacion(pobjCalificaciones);
            if (resultado > 0)
            {
                MessageBox.Show("Datos de calificaciones almacenados");
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
                txt1P.Text = c1p;
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
                txt2P.Text = c2p;
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
                txt3P.Text = c2p;
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
                txt4P.Text = c2p;
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
                txt5P.Text = c2p;
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
                txt6P.Text = c2p;
            }
        }

        void VacioCalificaciones()
        {
            string consulta = "select count(*) from calificaciones where Matricula ='" + cbMatricula.Text + "' and CodigoMateria = '" + idmateria + "'";
            MySqlConnection Cnnvc = clsConexion.BaseDeDatos();
            MySqlCommand Cmdvc = new MySqlCommand(String.Format(consulta), Cnnvc);
            MySqlDataReader Drvc = Cmdvc.ExecuteReader();
            while (Drvc.Read())
            {
                SiCalificacion = Drvc.GetString(0);
                lblvacio.Text = SiCalificacion;
                if (SiCalificacion == "0")
                {
                    btnGuardar.Show();
                    btnActualizar.Hide();
                }
                else
                {
                    btnGuardar.Hide();
                    btnActualizar.Show();
                }
                //txt6P.Text = c2p;
            }
        }
        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
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

        private void txtPrimerPromedio_Click(object sender, EventArgs e)
        {
            promedioa = (double.Parse(txt1P.Text) + double.Parse(txt2P.Text) + double.Parse(txt3P.Text)) / 3;
            txtPrimerPromedio.Text = promedioa.ToString("N2");
        }

        private void txtSegundoPromedio_MouseClick(object sender, MouseEventArgs e)
        {
            promediob = (double.Parse(txt4P.Text) + double.Parse(txt5P.Text) + double.Parse(txt6P.Text)) / 3;
            txtSegundoPromedio.Text = promediob.ToString("N2");

            promediogeneral = (promedioa + promediob) / 2;
            txtPromedioGeneral.Text = promediogeneral.ToString("N2");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmBusquedaCalificaciones FormularioBusquedaCalificaciones = new frmBusquedaCalificaciones();
            FormularioBusquedaCalificaciones.ShowDialog();

            if (FormularioBusquedaCalificaciones.CalificacionSeleccionada != null)
            {
                Calificacionactual = FormularioBusquedaCalificaciones.CalificacionSeleccionada;
                txt1P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.PrimerParcial);
                txt2P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.SegundoParcial);
                txt3P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.TercerParcial);
                txt4P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.CuartoParcial);
                txt5P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.QuintoParcial);
                txt6P.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.SextoParcial);
                txtPromedioGeneral.Text = Convert.ToString(FormularioBusquedaCalificaciones.CalificacionSeleccionada.PromedioGeneral);



            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SiCalificacion) > 0)
            {
                objCalificaciones pobjCalificaciones = new objCalificaciones();

                pobjCalificaciones.PrimerParcial = Convert.ToDouble(txt1P.Text.Trim());
                pobjCalificaciones.SegundoParcial = Convert.ToDouble(txt2P.Text.Trim());
                pobjCalificaciones.TercerParcial = Convert.ToDouble(txt3P.Text.Trim());
                pobjCalificaciones.CuartoParcial = Convert.ToDouble(txt4P.Text.Trim());
                pobjCalificaciones.QuintoParcial = Convert.ToDouble(txt5P.Text.Trim());
                pobjCalificaciones.SextoParcial = Convert.ToDouble(txt6P.Text.Trim());
                pobjCalificaciones.PromedioGeneral = Convert.ToDouble(txtPromedioGeneral.Text);
                pobjCalificaciones.Matricula = cbMatricula.Text;
                pobjCalificaciones.IdCalificaciones = Convert.ToInt32(Identificador_Calificaciones);

                if (clsCalificaciones.ActualizarCalificacion(pobjCalificaciones) == true)
                {
                    MessageBox.Show("Datos de calificaciones actualizados correctamente");
                }
                else
                { MessageBox.Show("error al actualizar los datos de calificacion"); }
            }
            else
            {
                objCalificaciones pobjCalificaciones = new objCalificaciones();

                pobjCalificaciones.PrimerParcial = Convert.ToDouble(txt1P.Text.Trim());
                pobjCalificaciones.SegundoParcial = Convert.ToDouble(txt2P.Text.Trim());
                pobjCalificaciones.TercerParcial = Convert.ToDouble(txt3P.Text.Trim());
                pobjCalificaciones.CuartoParcial = Convert.ToDouble(txt4P.Text.Trim());
                pobjCalificaciones.QuintoParcial = Convert.ToDouble(txt5P.Text.Trim());
                pobjCalificaciones.SextoParcial = Convert.ToDouble(txt6P.Text.Trim());
                pobjCalificaciones.PromedioGeneral = Convert.ToDouble(txtPromedioGeneral.Text);
                pobjCalificaciones.Matricula = cbMatricula.Text;
                pobjCalificaciones.IdCalificaciones = Calificacionactual.IdCalificaciones;

                if (clsCalificaciones.ActualizarCalificacion(pobjCalificaciones) == true)
                {
                    MessageBox.Show("Datos de calificaciones actualizados correctamente");
                }
                else
                { MessageBox.Show("error al actualizar los datos de calificacion"); }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsCalificaciones.EliminarCalificacion(Calificacionactual.IdCalificaciones) == true)
            {
                MessageBox.Show("Eliminado Correctamente");
            }
            else { MessageBox.Show("error al eliminar"); }
        }

        private void frmCalificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuPrincipal FormularioMenuPrincipal = new frmMenuPrincipal();
            this.Hide();
            FormularioMenuPrincipal.ShowDialog();
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1P.Text = "0";
            txt2P.Text = "0";
            txt3P.Text = "0";
            txt4P.Text = "0";
            txt5P.Text = "0";
            txt6P.Text = "0";
            txtPrimerPromedio.Text = "0";
            txtSegundoPromedio.Text = "0";
            txtPromedioGeneral.Text = "0";

            mostrar1();
            mostrar2();
            mostrar3();
            mostrar4();
            mostrar5();
            mostrar6();
            MostrarIdMateria(cbMateria.Text);
            VacioCalificaciones();
            ObtenerIdCalificacion();
        }
    }
}
