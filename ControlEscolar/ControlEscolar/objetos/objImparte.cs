using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objImparte
    {
        public string Rfc { get; set; }
        public int CodigoMaterias { get; set; }
        public int IdImparte { get; set; }
        public string UAC { get; set; }
        public objImparte() { }
        public objImparte(string pRfc, int pCodigoMaterias, int pIdImparte, string pUAC)
        {
            this.Rfc = pRfc;
            this.CodigoMaterias = pCodigoMaterias;
            this.IdImparte = pIdImparte;
            this.UAC = pUAC;
        }
    }
}
