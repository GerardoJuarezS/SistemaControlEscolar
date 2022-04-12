using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objMunicipio
    {
        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public int IdDistrito { get; set; }
        public objMunicipio() { }
        public objMunicipio(int pIdMunicipio, string pNombreMunicipio, int pIdDistrito)
        {
            this.IdMunicipio = pIdMunicipio;
            this.NombreMunicipio = pNombreMunicipio;
            this.IdDistrito = pIdDistrito;
        }
    }
}
