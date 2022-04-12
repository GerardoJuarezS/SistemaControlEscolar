using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.presentacion;
using MySql.Data.MySqlClient;
using ControlEscolar.bd;
using ControlEscolar.objetos;
using ControlEscolar.logica;
namespace ControlEscolar
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            clsUsuario p = new clsUsuario();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!p.HabraPerfiles())
            {
                Application.Run(new frmRegistroUsuarios());
            }
            else
            {
              Application.Run(new frmInicioSesion());
            }
        }
    }
}
