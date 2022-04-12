using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objAlumnoEnfermedad
    {
         public int IdAlumnoEnfermedad { get; set; }
      public int IdEnfermedad { get; set; }
      public string Matricula { get; set; }

      public objAlumnoEnfermedad() { }
      public objAlumnoEnfermedad(int pIdAlumnoEnfermedad, int pIdEnfermedad, string pMatricula)
       {
           this.IdAlumnoEnfermedad = pIdAlumnoEnfermedad;
           this.IdEnfermedad = pIdEnfermedad;
           this.Matricula = pMatricula;
       }
    }
}
