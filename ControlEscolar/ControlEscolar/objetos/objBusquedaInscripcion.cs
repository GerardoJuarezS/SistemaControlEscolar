using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ControlEscolar.objetos
{
    public class objBusquedaInscripcion
    {
        public string Matricula { get; set; }
        public string Tutor { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Nss { get; set; }
        public string Sexo { get; set; }
        public Image Foto { get; set; }
        public string FechaNacimiento { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Localidad { get; set; }
        public string NombreMunicipio { get; set; }
        public string NombreDistrito { get; set; }
        public string NombreEstado { get; set; }
        public int IdAlumnoGrupo { get; set; }
        public int IdGrupo { get; set; }
        public int IdAlumnoSemestre { get; set; }
        public int IdSemestre { get; set; }
        public int IdDireccion { get; set; }
        public int IdDatosPersonales { get; set; }
        public objBusquedaInscripcion() { }

        public objBusquedaInscripcion(string pMatricula, string pTutor, int pIdDatosPersonales, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pCurp, string pTelefono, string pCelular, string pCorreo, string pNss, string pSexo, Image pFoto, string pFechaNacimiento, int pIdDireccion, string pColonia, string pCalle, string pNumero, string pLocalidad, string pNombreMunicipio, string pNombreDistrito, string pNombreEstado, int pIdAlumnoGrupo, int pIdGrupo, int pIdAlumnoSemestre, int pIdSemestre)
        {
            this.Matricula = pMatricula;
            this.Tutor = pTutor;

            this.IdDatosPersonales = pIdDatosPersonales;
            this.Nombre = pNombre;
            this.ApellidoPaterno = pApellidoPaterno;
            this.ApellidoMaterno = pApellidoMaterno;
            this.Curp = pCurp;
            this.Telefono = pTelefono;
            this.Celular = pCelular;
            this.Correo = pCorreo;
            this.Nss = pNss;
            this.Sexo = pSexo;
            this.Foto = pFoto;
            this.FechaNacimiento = pFechaNacimiento;

            this.IdDireccion = pIdDireccion;
            this.Colonia = pColonia;
            this.Calle = pCalle;
            this.Numero = pNumero;
            this.Localidad = pLocalidad;
            this.NombreMunicipio = pNombreMunicipio;
            this.NombreMunicipio = pNombreDistrito;
            this.NombreEstado = pNombreEstado;

            this.IdAlumnoGrupo = pIdAlumnoGrupo;
            this.IdGrupo = pIdGrupo;

            this.IdAlumnoSemestre = pIdAlumnoSemestre;
            this.IdSemestre = pIdSemestre;

        }
    }
}
