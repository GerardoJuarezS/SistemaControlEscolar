using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ControlEscolar.objetos
{
    public class objDatospersonales
    {
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

        public objDatospersonales() { }

        public objDatospersonales(int pIdDatosPersonales, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pCurp, string pTelefono, string pCelular, string pCorreo, string pNss, string pSexo, Image pFoto, DateTime pFechaNacimiento)
        {
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
        }
    }
}
