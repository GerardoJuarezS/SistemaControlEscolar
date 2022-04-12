using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objCFT
    {
        public int IdCFT { get; set; }
        public string NombreCFT { get; set; }

        public objCFT() { }
        public objCFT(int pIdCFT, string pNombreCFT)
        {
            this.IdCFT = pIdCFT;
            this.NombreCFT = pNombreCFT;
        }
    }
}
