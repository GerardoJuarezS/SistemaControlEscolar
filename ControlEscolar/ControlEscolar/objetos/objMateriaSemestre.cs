using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objMateriaSemestre
    {
         
        public int CodigoMaterias { get; set; }
        public string UAC { get; set; }
        public int IdSemestre { get; set; }
        public int IdMateriaSemestre { get; set; }
        public objMateriaSemestre() { }
        public objMateriaSemestre(int pIdMateriaSemestre, int pCodigoMaterias, int pIdSemestre, string pUAC)
        {
            this.IdMateriaSemestre = pIdMateriaSemestre;
            this.CodigoMaterias = pCodigoMaterias;
            this.IdSemestre = pIdSemestre;
            this.UAC = pUAC;
        }
    }
}
