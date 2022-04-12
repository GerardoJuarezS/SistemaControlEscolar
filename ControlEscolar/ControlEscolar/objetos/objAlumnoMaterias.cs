using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objAlumnoMaterias
    {
        public int IdAlumnoMateria { get; set; }
        public int CodigoMaterias { get; set; }
        public string Matricula { get; set; }
        public string UAC { get; set; }
        public objAlumnoMaterias() { }
        public objAlumnoMaterias(int pIdAlumnoMateria, int pCodigoMaterias, string pMatricula, string pUAC)
        {
            this.IdAlumnoMateria = pIdAlumnoMateria;
            this.CodigoMaterias = pCodigoMaterias;
            this.Matricula = pMatricula;
            this.UAC = pUAC;
        }
    }
}
