using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objAlumno
    {
        public string Matricula { get; set; }
        public string Matricula_anterior { get; set; }
        public string Tutor { get; set; }
        public int IdDatosPersonales { get; set; }
        public int IdDireccion { get; set; }

        public objAlumno() { }

        public objAlumno(string pMatricula, string pMatricula_anterior, string pTutor, int pIdDatosPersonales, int pIdDireccion)
        {
            this.Matricula = pMatricula;
            this.Matricula_anterior = pMatricula_anterior;
            this.Tutor = pTutor;
            this.IdDatosPersonales = pIdDatosPersonales;
            this.IdDireccion = pIdDireccion;
        }
    }
}
