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
    public partial class frmConstanciaDeEstudios : Form
    {
        public frmConstanciaDeEstudios()
        {
            InitializeComponent();
        }

        private void frmConstanciaDeEstudios_Load(object sender, EventArgs e)
        {
            
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf1.Print();
        }
    }
}
