using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    class objRegistrados
    {
        public int IdRegistrados { get; set; }
        public string NombreRegistrados { get; set; }
        public int IdDatosPersonales { get; set; }
        public objRegistrados() { }
        public objRegistrados(int pIdRegistrados, string pNombreRegistrados, int pIdDatosPersonales)
        {
            this.IdRegistrados = pIdRegistrados;
            this.NombreRegistrados = pNombreRegistrados;
            this.IdDatosPersonales = pIdDatosPersonales;
        }
    }
}
