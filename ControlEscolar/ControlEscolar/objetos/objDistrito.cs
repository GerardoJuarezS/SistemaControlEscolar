using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objDistrito
    {
        public int IdDistrito { get; set; }
        public string NombreDistrito { get; set; }
        public int IdEstado { get; set; }
        public objDistrito() { }
        public objDistrito(int pIdDistrito, string pNombreEstado, int pIdEstado)
        {
            this.IdDistrito = pIdDistrito;
            this.NombreDistrito = pNombreEstado;
            this.IdEstado = pIdEstado;
        }
    }
}
