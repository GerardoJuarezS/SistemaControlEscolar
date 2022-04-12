using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ControlEscolar.objetos
{
   public class objBusquedaDocente
    {
        public string Rfc { get; set; }
        public int IdDireccion { get; set; }
        public int IdDatosPersonales { get; set; }
        public int IdProfesion { get; set; }
        public string NombreProfesion { get; set; }
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
        public string NombreEstado { get; set; }
        public string NombreDistrito { get; set; }
        public string NombreMunicipio { get; set; }
        public objBusquedaDocente() { }

        public objBusquedaDocente(string pRfc, int pIdDireccion, int pIdDatosPersonales, int pIdProfesion, string pNombreProfesion, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pCurp, string pTelefono, string pCelular, string pCorreo, string pNss, string pSexo, Image pFoto, string pFechaNacimiento, string pColonia, string pCalle, string pNumero, string pLocalidad, string pNombreEstado, string pNombreDistrito, string pNombreMunicipio)
        {
            this.Rfc = pRfc;
            this.IdDireccion = pIdDireccion;
            this.IdDatosPersonales = pIdDatosPersonales;
            this.IdProfesion = pIdProfesion;
            this.NombreProfesion = pNombreProfesion;
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
            this.Colonia = pColonia;
            this.Calle = pCalle;
            this.Numero = pNumero;
            this.Localidad = pLocalidad;
            this.NombreDistrito = pNombreDistrito;
            this.NombreEstado = pNombreEstado;
            this.NombreMunicipio = pNombreMunicipio;
        }
    }
}
