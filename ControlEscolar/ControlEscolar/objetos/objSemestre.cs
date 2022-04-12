using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    class objSemestre
    {
         public int IdSemestre { get; set; }
        public string NombreSemestre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public objSemestre() { }
        public objSemestre(int pIdSemestre, string pNombreSemestre, DateTime pFechaInicio, DateTime pFechaFinal)
        {
            this.IdSemestre = pIdSemestre;
            this.NombreSemestre = pNombreSemestre;
            this.FechaInicio = pFechaInicio;
            this.FechaFinal = pFechaFinal;
        }
    }
}
