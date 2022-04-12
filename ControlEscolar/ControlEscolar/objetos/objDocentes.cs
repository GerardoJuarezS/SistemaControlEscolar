using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objDocentes
    {
        public string Rfc { get; set; }
        public int IdDireccion { get; set; }
        public int IdDatosPersonales { get; set; }
        public int IdProfesion { get; set; }
        public string antRfc { get; set; }

        public objDocentes() { }

        public objDocentes(string pRfc, int pIdDireccion, int pIdDatosPersonales, int pIdProfesion)
        {
            this.Rfc = pRfc;
            this.IdDireccion = pIdDireccion;
            this.IdDatosPersonales = pIdDatosPersonales;
            this.IdProfesion = pIdProfesion;
        }
    }
}
