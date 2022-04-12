using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objMaterias
    {
        public int CodigoMaterias { get; set; }
        public string UAC { get; set; }
        public int HorasMateria { get; set; }
        public int CreditosMaterias { get; set; }
        public int CodigoMaterias_Anterior { get; set; }
        public objMaterias() { }
        public objMaterias(int pCodigoMaterias, string pUAC, int pCreditosMaterias, int pHorasMateria, int pCodigoMaterias_Anterior)
        {
            this.CodigoMaterias = pCodigoMaterias;
            this.UAC = pUAC;
            this.HorasMateria = pHorasMateria;
            this.CreditosMaterias = pCreditosMaterias;
            this.CodigoMaterias_Anterior = pCodigoMaterias_Anterior;
        }
    }
}
