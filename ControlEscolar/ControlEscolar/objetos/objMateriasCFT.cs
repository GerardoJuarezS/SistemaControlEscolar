using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objMateriasCFT
    {
        public int IdCFT { get; set; }
        public int IdMaterias_CFT { get; set; }
        public int CodigoMaterias { get; set; }
        public string UAC { get; set; }
        public string CFT { get; set; }
        public objMateriasCFT() { }
        public objMateriasCFT(int pIdCFT, int pIdMaterias_CFT, int pCodigoMaterias, string pUAC, string pCFT)
        {
            this.IdCFT = pIdCFT;
            this.IdMaterias_CFT = pIdMaterias_CFT;
            this.CodigoMaterias = pCodigoMaterias;
            this.UAC = pUAC;
            this.CFT = pCFT;
        }
    }
}
