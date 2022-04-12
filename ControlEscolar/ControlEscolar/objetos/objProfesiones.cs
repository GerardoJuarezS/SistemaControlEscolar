using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objProfesiones
    {
        public int IdProfesion { get; set; }
        public string NombreProfesion { get; set; }

        public objProfesiones()
        {

        }
        objProfesiones(int pIdProfesion, string pNombreProfesion)
        {
            this.IdProfesion = pIdProfesion;
            this.NombreProfesion = pNombreProfesion;
        }
    }
}
