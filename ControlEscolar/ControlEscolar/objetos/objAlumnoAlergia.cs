using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objAlumnoAlergia
    {
        public int IdAlumnoAlergia { get; set; }
        public int IdAlergia { get; set; }
       public string Matricula { get; set; }

       public objAlumnoAlergia() { }

       public objAlumnoAlergia(int pIdAlumnoAlergia, int pIdAlergia, string pMatricula)
        {
            this.IdAlumnoAlergia = pIdAlumnoAlergia;
            this.IdAlergia = pIdAlergia;
            this.Matricula = pMatricula;
        }
    }
}
