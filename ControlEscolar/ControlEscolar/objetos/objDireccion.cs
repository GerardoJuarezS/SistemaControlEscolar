using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objDireccion
    {
        public int IdDireccion { get; set; }
        public string Estado { get; set; }
        public string Distrito { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }

        public objDireccion() { }
        public objDireccion(int pIdDireccion, string pColonia, string pCalle, string pNumero, string pLocalidad, string pEstado, string pMunicipio, string pDistrito)
        {
            this.IdDireccion = pIdDireccion;
            this.Colonia = pColonia;
            this.Calle = pCalle;
            this.Numero = pNumero;
            this.Localidad = pLocalidad;
            this.Estado = pEstado;
            this.Municipio = pMunicipio;
            this.Distrito = pDistrito;
        }
    }
}
