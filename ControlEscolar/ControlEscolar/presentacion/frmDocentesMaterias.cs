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
    public partial class frmDocentesMaterias : Form
    {
        public frmDocentesMaterias()
        {
            InitializeComponent();
        }

        public objImparte imparteactual { get; set; }

        public string IdMateria;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objImparte pobjImparte = new objImparte();
            pobjImparte.CodigoMaterias = Convert.ToInt32(IdMateria);
            pobjImparte.Rfc = cbRFC.Text.Trim();
            bool resultado = clsImparte.GuardarImparte(pobjImparte);
            if (resultado == true)
            {
                MessageBox.Show("Registro Almacenado");
            }
            else { MessageBox.Show("error al almacenar el registro"); }

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, imparte.Rfc from materias, imparte where imparte.Rfc='"+cbRFC.Text+"' and imparte.CodigoMaterias = materias.CodigoMaterias";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvDocenteMateria.DataSource = Ds.Tables[0];
        }

        void MostrarIdMateria(string materiaa)
        {
            string consultaidmateria = "select CodigoMaterias from materias where UAC = '" + materiaa + "'";

            MySqlConnection Cnnidmateria = clsConexion.BaseDeDatos();
            MySqlCommand Cmdidmateria = new MySqlCommand(String.Format(consultaidmateria), Cnnidmateria);
            MySqlDataReader Dridmateria = Cmdidmateria.ExecuteReader();
            while (Dridmateria.Read())
            {
                IdMateria = Dridmateria.GetString(0);
            }
        }

        void mostrarnombre(string rfc)
        {
            string nombre;
            string consultanombre = "SELECT datospersonales.Nombre FROM docentes,datospersonales where rfc = '" + rfc + "' and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnnombre = clsConexion.BaseDeDatos();
            MySqlCommand Cmdnombre = new MySqlCommand(String.Format(consultanombre), Cnnnombre);
            MySqlDataReader Drnombre = Cmdnombre.ExecuteReader();
            while (Drnombre.Read())
            {
                nombre = Drnombre.GetString(0);
                lblNombre.Text = nombre;
            }
        }

        void mostrarapellidopaterno(string rfc)
        {
            string ApellidoPaterno;
            string consultaAP = "SELECT datospersonales.ApellidoPaterno FROM docentes,datospersonales where rfc = '" + rfc + "' and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnap = clsConexion.BaseDeDatos();
            MySqlCommand Cmdap = new MySqlCommand(String.Format(consultaAP), Cnnap);
            MySqlDataReader Drap = Cmdap.ExecuteReader();
            while (Drap.Read())
            {
                ApellidoPaterno = Drap.GetString(0);
                lblAPaterno.Text = ApellidoPaterno;
            }
        }

        void mostrarapellidomaterno(string rfc)
        {
            string ApellidoMaterno;
            string consultaAM = "SELECT datospersonales.ApellidoMaterno FROM docentes,datospersonales where rfc = '" + rfc + "' and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales";

            MySqlConnection Cnnam = clsConexion.BaseDeDatos();
            MySqlCommand Cmdam = new MySqlCommand(String.Format(consultaAM), Cnnam);
            MySqlDataReader Dram = Cmdam.ExecuteReader();
            while (Dram.Read())
            {
                ApellidoMaterno = Dram.GetString(0);
                lblAMaterno.Text = ApellidoMaterno;
            }
        }

        private void cbRFC_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarnombre(cbRFC.Text);
            mostrarapellidopaterno(cbRFC.Text);
            mostrarapellidomaterno(cbRFC.Text);

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, imparte.Rfc from materias, imparte where imparte.Rfc='" + cbRFC.Text + "' and imparte.CodigoMaterias = materias.CodigoMaterias";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvDocenteMateria.DataSource = Ds.Tables[0];
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                MostrarIdMateria(cbMateria.Text);
                cbMateria.Items.Clear();
                if (cbSemestre.Text == "1")
                {
                    cbMateria.Items.Add("MATEMÁTICAS I");
                    cbMateria.Items.Add("QUÍMICA I");
                    cbMateria.Items.Add("ÉTICA Y VALORES I");
                    cbMateria.Items.Add("INTRODUCCIÓN A LAS CIENCIAS SOCIALES");
                    cbMateria.Items.Add("TALLER DE LECTURA Y REDACCIÓN I");
                    cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL I (INGLES)");
                    cbMateria.Items.Add("INFORMÁTICA I");
                }

                if (cbSemestre.Text == "2")
                {
                    cbMateria.Items.Add("MATEMÁTICAS II");
                    cbMateria.Items.Add("QUÍMICA II");
                    cbMateria.Items.Add("ÉTICA Y VALORES II");
                    cbMateria.Items.Add("HISTORIA DE MÉXICO I");
                    cbMateria.Items.Add("TALLER DE LECTURA Y REDACCIÓN II");
                    cbMateria.Items.Add("LENGUA ADICIONAL AL ESPAÑOL II (INGLES)");
                    cbMateria.Items.Add("INFORMÁTICA II");
                }

                if (cbSemestre.Text == "3")
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

                if (cbSemestre.Text == "4")
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

                if (cbSemestre.Text == "5")
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

                if (cbSemestre.Text == "6")
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
        }

        private void frmDocentesMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsRfc.docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.dsRfc.docentes);
            // TODO: esta línea de código carga datos en la tabla 'dsIdSemestre.semestre' Puede moverla o quitarla según sea necesario.
            this.semestreTableAdapter.Fill(this.dsIdSemestre.semestre);
            
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarIdMateria(cbMateria.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaDocentesMaterias FormularioBuscarDocentesMaterias = new frmBusquedaDocentesMaterias();
            FormularioBuscarDocentesMaterias.ShowDialog();

            if (FormularioBuscarDocentesMaterias.imparteseleccionado != null)
            {
                imparteactual = FormularioBuscarDocentesMaterias.imparteseleccionado;
                lb1.Text = FormularioBuscarDocentesMaterias.imparteseleccionado.Rfc;
                lb2.Text = Convert.ToString(FormularioBuscarDocentesMaterias.imparteseleccionado.CodigoMaterias);
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objImparte pobjImparte = new objImparte();

            pobjImparte.CodigoMaterias = Convert.ToInt32(IdMateria);
            
            
            pobjImparte.IdImparte = imparteactual.IdImparte;
            if (clsImparte.ActualizarImparte(pobjImparte) == true)
            {
                MessageBox.Show("datos actualizados");
            }
            else
            {
               MessageBox.Show("Error al actualizar");
            }

            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, docentes.Rfc from materias, imparte, docentes where imparte.rfc = '" + cbRFC.Text + "' and materias.CodigoMaterias = imparte.CodigoMaterias";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvDocenteMateria.DataSource = Ds.Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsImparte.EliminarImparte(imparteactual.IdImparte) ==true)
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void frmDocentesMaterias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
