using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar.presentacion
{
    public partial class frmPermisoDeClases : Form
    {
        public frmPermisoDeClases()
        {
            InitializeComponent();
        }
        string abc;
        private void frmPermisoDeClases_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd DE MMMM DEL yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf1.Print();
        }
    }
}
