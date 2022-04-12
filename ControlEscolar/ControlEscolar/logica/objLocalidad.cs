using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.logica
{
    public class objLocalidad
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public int IdMunicipio { get; set; }
        public objLocalidad() { }
        public objLocalidad(int pIdLocalidad, string pNombreLocalidad, int pIdMunicipio)
        {
            this.IdLocalidad = pIdLocalidad;
            this.NombreLocalidad = pNombreLocalidad;
            this.IdMunicipio = pIdMunicipio;
        }
    }
}
