using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
namespace ControlEscolar.objetos
{
    public class objAlumnoServicioSocial
    {
        public int IdAlumnoServicioSocial { get; set; }
        public Image PrimerInforme { get; set; }
        public Image SegundoInforme { get; set; }
        public Image TercerInforme { get; set; }
        public Image InformeFinal { get; set; }
        public string Matricula { get; set; }
        public string Matricula_Anterior { get; set; }
        public int IdServicioSocial { get; set; }

        public objAlumnoServicioSocial () { }

        public objAlumnoServicioSocial (int pIdAlumnoServicioSocial, Image pPrimerInforme, Image pSegundoInforme, Image pTercerInforme, Image pInformeFinal, string pMatricula, string pMatricula_Anterior,int pIdServicioSocial)
        {
            IdAlumnoServicioSocial = pIdAlumnoServicioSocial;
            PrimerInforme = pPrimerInforme;
            SegundoInforme = pSegundoInforme;
            TercerInforme = pTercerInforme;
            InformeFinal = pInformeFinal;
            Matricula = pMatricula;
            Matricula_Anterior = pMatricula_Anterior;
            IdServicioSocial = pIdServicioSocial;
        }
    }
}
