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
    public partial class frmSolicitudServicioSocial : Form
    {
        public frmSolicitudServicioSocial()
        {
            InitializeComponent();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf1.Print();
        }

        private void frmSolicitudServicioSocial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
