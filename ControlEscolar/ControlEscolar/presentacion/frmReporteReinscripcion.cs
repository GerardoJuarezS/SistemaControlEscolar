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
    public partial class frmReporteReinscripcion : Form
    {
        public frmReporteReinscripcion()
        {
            InitializeComponent();
        }

        private void frmReporteReinscripcion_Load(object sender, EventArgs e)
        {
            lbldia.Text = DateTime.Now.ToString("dd DE MMMMM DEL yyyy");


            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, materias.HorasMaterias, materias.CreditosMaterias,datospersonales.Nombre, datospersonales.ApellidoPaterno, datospersonales.ApellidoMaterno from materias,materiasemestre,alumnomaterias,datospersonales,docentes,imparte where alumnomaterias.Matricula = '"+lblMatriculaa.Text+"' and materiasemestre.IdSemestre='"+lblSemestre.Text+"' and materiasemestre.CodigoMaterias = materias.CodigoMaterias and alumnomaterias.CodigoMaterias = materiasemestre.CodigoMaterias and docentes.IdDatosPersonales = datospersonales.IdDatosPersonales and docentes.rfc = imparte.Rfc and imparte.CodigoMaterias = materias.CodigoMaterias";
            Cmd.Connection = clsConexion.BaseDeDatos();

            DataSet dsMateria = new DataSet();
            MySqlDataAdapter Mda = new MySqlDataAdapter(Cmd);
            Mda.Fill(dsMateria);
            dgvMaterias.DataSource = dsMateria.Tables[0];
            dgvMaterias.AutoResizeColumns();
            dgvMaterias.AutoResizeRows();

            dgvCalificaciones.AutoResizeColumns();
            dgvCalificaciones.AutoResizeRows();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pf1.Print();
        }

        private void frmReporteReinscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
