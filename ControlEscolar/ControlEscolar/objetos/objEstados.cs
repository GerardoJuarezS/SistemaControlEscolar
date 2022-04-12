using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objEstados
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }

        public objEstados () { }
        public objEstados (int pIdEstados, string pNombreEstado)
        {
            this.IdEstado = pIdEstados;
            this.NombreEstado = pNombreEstado;
        }
    }
}
