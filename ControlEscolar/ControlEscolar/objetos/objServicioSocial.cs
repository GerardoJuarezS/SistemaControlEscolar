using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
    public class objServicioSocial
    {
        public int IdServicioSocial { get; set; }
        public string Dependencia { get; set; }
        public string NombreDelPrograma { get; set; }
        public string SubPrograma { get; set; }
        public string ActividadBasica { get; set; }
        public string Modalidad { get; set; }
        public string Areas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int IdDireccion { get; set; }
        public string Matricula { get; set; }

        //direccion
        public string Estado { get; set; }
        public string Distrito { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }

        //

        public objServicioSocial() { }

        public objServicioSocial (int pIdServicioSocial, string pDependencia, string pNombreDelPrograma, string pSubprograma, string pActividadBasica, string pModalidad,string pAreas, DateTime pFechaInicio, DateTime pFechaFinal, int pIdDireccion, string pMatricula, string pEstado, string pDistrito, string pMunicipio, string pLocalidad, string pColonia, string pCalle, string pNumero)
        {
            this.IdServicioSocial = pIdServicioSocial;
            this.Dependencia = pDependencia;
            this.NombreDelPrograma = pNombreDelPrograma;
            this.SubPrograma = pSubprograma;
            this.ActividadBasica = pActividadBasica;
            this.Modalidad = pModalidad;
            this.Areas = pAreas;
            this.FechaInicio = pFechaInicio;
            this.FechaFinal = pFechaFinal;
            this.IdDireccion = pIdDireccion;
            this.Matricula = pMatricula;
            this.Estado = pEstado;
            this.Distrito = pDistrito;
            this.Municipio = pMunicipio;
            this.Localidad = pLocalidad;
            this.Colonia = pColonia;
            this.Calle = pCalle;
            this.Numero = pNumero;
        }
     }
}
