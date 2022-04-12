using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objCalificaciones
    {
       public int IdCalificaciones { get; set; }
       public double PrimerParcial { get; set; }
       public double SegundoParcial { get; set; }
       public double TercerParcial { get; set; }
       public double CuartoParcial { get; set; }
       public double QuintoParcial { get; set; }
       public double SextoParcial { get; set; }
       public string Matricula { get; set; }
       public int CodigoMateria { get; set; }
       public double PromedioGeneral { get; set; }

       public objCalificaciones() { }

       public objCalificaciones(int pIdCalificaciones, double pPrimerParcial, double pSegundoParcial, double pTercerParcial, double pCuartoParcial, double pQuintoParcial, double pSextoParcial, string pMatricula, int pCodigoMateria, double pPromedioGeneral)
            {
                this.IdCalificaciones = pIdCalificaciones;
                this.PrimerParcial = pPrimerParcial;
                this.SegundoParcial = pSegundoParcial;
                this.TercerParcial = pTercerParcial;
                this.CuartoParcial = pCuartoParcial;
                this.QuintoParcial = pQuintoParcial;
                this.SextoParcial = pSextoParcial;
                this.Matricula = pMatricula;
                this.CodigoMateria = pCodigoMateria;
                this.PromedioGeneral = pPromedioGeneral;
            }
    }
}
