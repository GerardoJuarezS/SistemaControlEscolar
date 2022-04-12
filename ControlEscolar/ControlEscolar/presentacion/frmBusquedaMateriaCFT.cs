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
    public partial class frmBusquedaMateriaCFT : Form
    {
        public frmBusquedaMateriaCFT()
        {
            InitializeComponent();
        }
        public objMateriasCFT MateriaCFTseleccionada { get; set; }
        public string CFTT;
        public void IdCFFT(string Nombree)
        {
            string consultaalergia = "select cft.Id_CFT from cft where Nombre = '" + Nombree + "'";

            MySqlConnection Cnnalergia = clsConexion.BaseDeDatos();
            MySqlCommand Cmdalergia = new MySqlCommand(String.Format(consultaalergia), Cnnalergia);
            MySqlDataReader Dralergia = Cmdalergia.ExecuteReader();
            while (Dralergia.Read())
            {
                CFTT = Dralergia.GetString(0);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clsMateriasCFT.BuscarMateriaCFT(Convert.ToInt32(CFTT));
        }

        private void cbCFT_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCFFT(cbCFT.Text);
        }

        private void frmBusquedaMateriaCFT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsNombreCFT.cft' Puede moverla o quitarla según sea necesario.
            this.cftTableAdapter.Fill(this.dsNombreCFT.cft);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                int IdentificadorMateriaCFT = Convert.ToInt32(dgvResultado.CurrentRow.Cells[1].Value);
                MateriaCFTseleccionada = clsMateriasCFT.ObtenerMateriaCFT(IdentificadorMateriaCFT);
                this.Close();
            }
            else
            {
                MessageBox.Show("seleccione fila");
            }
        }
    }
}
