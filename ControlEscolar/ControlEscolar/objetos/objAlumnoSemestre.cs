using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objAlumnoSemestre
    {
        public int IdAlumnoSemestre { get; set; }
        public int IdSemestre { get; set; }
        public string Matricula { get; set; }
        public objAlumnoSemestre() { }
        public objAlumnoSemestre(int pIdAlumnoSemestre, int pIdSemestre, string pMatricula)
        {
            this.IdAlumnoSemestre = pIdAlumnoSemestre;
            this.IdSemestre = pIdSemestre;
            this.Matricula = pMatricula;
        }
    }
}
