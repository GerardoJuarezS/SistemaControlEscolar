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
    public partial class frmCartadepresentacion : Form
    {
        public frmCartadepresentacion()
        {
            InitializeComponent();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf1.Print();
        }

        private void frmCartadepresentacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
