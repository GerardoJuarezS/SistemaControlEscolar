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
    public partial class frmReporteInscripcion : Form
    {
        public frmReporteInscripcion()
        {
            InitializeComponent();
        }

        private void frmReporteInscripcion_Load(object sender, EventArgs e)
        {
            lbldia.Text = DateTime.Now.ToString("dd DE MMMMM DEL yyyy");

            
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, materias.CreditosMaterias, materias.HorasMaterias, datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno from materias, alumnomaterias, datospersonales,docentes,imparte where alumnomaterias.Matricula = '"+lblMatricula.Text+"' and alumnomaterias.CodigoMaterias = materias.CodigoMaterias and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales and docentes.rfc = imparte.Rfc and imparte.CodigoMaterias = materias.CodigoMaterias";
            Cmd.Connection = clsConexion.BaseDeDatos();

            DataSet dsMateria = new DataSet();
            MySqlDataAdapter Mda = new MySqlDataAdapter(Cmd);
            Mda.Fill(dsMateria);
            dgvMaterias.DataSource = dsMateria.Tables[0];
            dgvMaterias.AutoResizeColumns();
            dgvMaterias.AutoResizeRows();
        }

        private void frmReporteInscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pfReporteInscripcion.Print();
        }
    }
}
