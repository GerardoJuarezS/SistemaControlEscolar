using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ControlEscolar.objetos
{
    class objInscripcion
    {
        public string Matricula { get; set; }
        public string Tutor { get; set; }
        public int IdDireccion { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Localidad { get; set; }
        public int IdEstado { get; set; }
        public int IdDistrito { get; set; }
        public int IdMunicipio { get; set; }
        public int IdDatosPersonales { get; set; }
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
        public DateTime FechaNacimiento { get; set; }

        public objInscripcion() { }

        public objInscripcion(string pMatricula, string pTutor, int pIdDatosPersonales, int pIdDireccion, string pColonia, string pCalle, string pNumero, string pLocalidad, int pIdEstado, int pIdDistrito, int pIdMunicipio,string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pCurp, string pTelefono, string pCelular, string pCorreo, string pNss, string pSexo, Image pFoto, DateTime pFechaNacimiento)
        {
            this.Matricula = pMatricula;
            this.Tutor = pTutor;
            this.IdDatosPersonales = pIdDatosPersonales;
            this.IdDireccion = pIdDireccion;
            this.Colonia = pColonia;
            this.Calle = pCalle;
            this.Numero = pNumero;
            this.Localidad = pLocalidad;
            this.IdEstado = pIdEstado;
            this.IdDistrito = pIdDistrito;
            this.IdMunicipio = pIdMunicipio;
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
        }

    }
}
