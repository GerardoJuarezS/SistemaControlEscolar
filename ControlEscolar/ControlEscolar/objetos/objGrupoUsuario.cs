using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objGrupoUsuario
    {
        public int IdGrupoUsuario { get; set; }
        public string NombreGrupoUsuario { get; set; }
        public objGrupoUsuario() { }

        public objGrupoUsuario(int pIdgrupoUsuario, string pNombreGrupoUsuario)
        {
            this.IdGrupoUsuario = pIdgrupoUsuario;
            this.NombreGrupoUsuario = pNombreGrupoUsuario;
        }

    }
}
