using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objEnfermedad
    {
       public int IdEnfermedad { get; set; }
       public string NombreEnfermedad { get; set; }

       public objEnfermedad() { }


       public objEnfermedad(int pIdEnfermedad, string pNombreEnfermedad)
       {
           this.IdEnfermedad = pIdEnfermedad;
           this.NombreEnfermedad = pNombreEnfermedad;
       }
    }
}
