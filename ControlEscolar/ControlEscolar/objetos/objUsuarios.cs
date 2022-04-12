using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objUsuarios
    {
        public int IdUsuarios { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdGrupoUsuario { get; set; }
        public int IdDatosPersonales { get; set; }
        public objUsuarios() { }
        public objUsuarios(int pIdUsuarios, string pNombreUsuario, string pContraseña, int pIdGrupoUsuario, int pIdDatosPersonales)
        {
            this.IdUsuarios = pIdUsuarios;
            this.NombreUsuario = pNombreUsuario;
            this.Contraseña = pContraseña;
            this.IdGrupoUsuario = pIdGrupoUsuario;
            this.IdDatosPersonales = pIdDatosPersonales;
        }
    }
}
