using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objAlumnoGrupo
    {
        public int IdAlumnoGrupo { get; set; }
        public string Matricula { get; set; }
        public int IdGrupo { get; set; }

        public objAlumnoGrupo() { }

        public objAlumnoGrupo(int pIdAlumnoGrupo, string pMetricula, int PIdGrupo)
        {
            this.IdAlumnoGrupo = pIdAlumnoGrupo;
            this.Matricula = pMetricula;
            this.IdGrupo = PIdGrupo;
        }
    }
}
