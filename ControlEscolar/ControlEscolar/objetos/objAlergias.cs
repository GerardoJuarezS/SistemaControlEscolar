using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objAlergias
    {
        public int IdAlergias { get; set; }
        public string NombreAlergia { get; set; }

        public objAlergias() { }
        public objAlergias(int pIdAlergias, string pNombreAlergia)
        {
            this.IdAlergias = pIdAlergias;
            this.NombreAlergia = pNombreAlergia;
        }
    }
}
