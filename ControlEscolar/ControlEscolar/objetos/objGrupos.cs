using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    class objGrupos
    {
        public int Idgrupo { get; set; }
        public string NombreGrupo { get; set; }
        public objGrupos() { }
        public objGrupos(int pIdGrupo, string pNombreGrupo)
        {
            this.Idgrupo = pIdGrupo;
            this.NombreGrupo = pNombreGrupo;
        }
    }
}
