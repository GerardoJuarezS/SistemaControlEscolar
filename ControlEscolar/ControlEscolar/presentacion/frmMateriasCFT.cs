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
    public partial class frmMateriasCFT : Form
    {
        public objMateriasCFT MateriaCFTActual { get; set; }
        public int Materiaa;
        public int CFTT;
        public frmMateriasCFT()
        {
            InitializeComponent();
        }
        void LlenarMaterias()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select materias.UAC from materias,materiasemestre where materiasemestre.IdSemestre >= 3 and materias.CodigoMaterias = materiasemestre.CodigoMaterias", Cnn);
            Myda.Fill(dsMatricula, "materias");
            cbmateria.DataSource = dsMatricula.Tables[0].DefaultView;
            cbmateria.ValueMember = "UAC";
            cbmateria.DisplayMember = "UAC";
        }

        void LlenarCFT()
        {
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            DataSet dsMatricula = new DataSet();
            MySqlDataAdapter Myda = new MySqlDataAdapter("select cft.Nombre from cft;", Cnn);
            Myda.Fill(dsMatricula, "cft");
            cbCFT.DataSource = dsMatricula.Tables[0].DefaultView;
            cbCFT.ValueMember = "Nombre";
            cbCFT.DisplayMember = ":::";
        }

        void IdMateriaa(string NombreMateeria)
        {
            string consultaalergia = "select materias.CodigoMaterias from materias where UAC = '"+NombreMateeria+"'";

            MySqlConnection Cnnalergia = clsConexion.BaseDeDatos();
            MySqlCommand Cmdalergia = new MySqlCommand(String.Format(consultaalergia), Cnnalergia);
            MySqlDataReader Dralergia = Cmdalergia.ExecuteReader();
            while (Dralergia.Read())
            {
                Materiaa = Dralergia.GetInt32(0);
            }
        }

        void IdCFFT(string NombreCFT)
        {
            string consultaalergia = "select cft.Id_CFT from cft where Nombre = '"+NombreCFT+"'";

            MySqlConnection Cnnalergia = clsConexion.BaseDeDatos();
            MySqlCommand Cmdalergia = new MySqlCommand(String.Format(consultaalergia), Cnnalergia);
            MySqlDataReader Dralergia = Cmdalergia.ExecuteReader();
            while (Dralergia.Read())
            {
                CFTT = Dralergia.GetInt32(0);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objMateriasCFT pobjMateriasCFT = new objMateriasCFT();
            pobjMateriasCFT.CodigoMaterias = Convert.ToInt32(Materiaa);
            pobjMateriasCFT.IdCFT = Convert.ToInt32(CFTT);

            Boolean resultado = clsMateriasCFT.GuardarMateriaCFT(pobjMateriasCFT);
            if(resultado == true)
            {
                MessageBox.Show("Guardado");

            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, cft.Nombre from materias,cft,materias_cft where materias.CodigoMaterias = materias_cft.CodigoMaterias and cft.Id_CFT = materias_cft.Id_CFT";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();
        }

        private void cbmateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdMateriaa(cbmateria.Text);
        }

        private void cbCFT_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCFFT(cbCFT.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsMateriasCFT.EliminarMateriaCFT(MateriaCFTActual.IdMaterias_CFT) == true)
            {
                MessageBox.Show("Registro Eliminado");
            }
            else
            {
                MessageBox.Show("Error al elmiminar");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objMateriasCFT pobjMateriasCFT = new objMateriasCFT();
            pobjMateriasCFT.IdCFT = Convert.ToInt32(CFTT);
            pobjMateriasCFT.CodigoMaterias = Convert.ToInt32(Materiaa);
            pobjMateriasCFT.IdMaterias_CFT = MateriaCFTActual.IdMaterias_CFT;
            if (clsMateriasCFT.ActualizarMateriaCFT(pobjMateriasCFT) == true)
            {
                MessageBox.Show("Datos Actualizados");
            }
            else
            {
               // MessageBox.Show("Error al actualizar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMateriaCFT FormularioBusquedaMateriaCFT = new frmBusquedaMateriaCFT();
            FormularioBusquedaMateriaCFT.ShowDialog();

            if (FormularioBusquedaMateriaCFT.MateriaCFTseleccionada != null)
            {
                MateriaCFTActual = FormularioBusquedaMateriaCFT.MateriaCFTseleccionada;
                cbmateria.Text = FormularioBusquedaMateriaCFT.MateriaCFTseleccionada.UAC;
                cbCFT.Text = FormularioBusquedaMateriaCFT.MateriaCFTseleccionada.CFT;

                //cbmateria.Text = Convert.ToString(FormularioBusquedaMateriaCFT.MateriaCFTseleccionada.CodigoMaterias);
                //cbCFT.Text = Convert.ToString(FormularioBusquedaMateriaCFT.MateriaCFTseleccionada.IdCFT);
            }
        }

        private void frmMateriasCFT_Load(object sender, EventArgs e)
        {
            LlenarCFT();
            LlenarMaterias();
            MySqlConnection Cnn = clsConexion.BaseDeDatos();
            MySqlCommand Cmd = new MySqlCommand();
            Cmd.CommandText = "select materias.UAC, cft.Nombre from materias,cft,materias_cft where materias.CodigoMaterias = materias_cft.CodigoMaterias and cft.Id_CFT = materias_cft.Id_CFT";
            Cmd.Connection = Cnn;

            DataSet Ds = new DataSet();
            MySqlDataAdapter Da = new MySqlDataAdapter(Cmd);
            Da.Fill(Ds);
            dgvResultado.DataSource = Ds.Tables[0];
            dgvResultado.AutoResizeColumns();
        }
    }
}
