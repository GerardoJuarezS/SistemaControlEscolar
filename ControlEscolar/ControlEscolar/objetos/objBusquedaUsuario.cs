using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.objetos
{
   public class objBusquedaUsuario
    {
       public int IdUsuario { get; set; }
       public int IdDatosPersonales { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Nss { get; set; }
        public string Sexo { get; set; }
        public string NombreGrupoUsuario { get; set; }
        public string FechaNacimiento { get; set; }

        public objBusquedaUsuario() { }
        public objBusquedaUsuario(int pIdUsuario,int pIdDatosPersonales, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pCurp, string pTelefono, string pCelular, string pCorreo, string pNss, string pSexo, string pFechaNacimiento, string pNombreUsuario, string pContraseña, string pNombreGrupoUsuario)
        {
            this.IdUsuario = pIdUsuario;
            this.IdDatosPersonales = pIdDatosPersonales;
            this.NombreUsuario = pNombreUsuario;
            this.Contraseña = pContraseña;
            this.Nombre = pNombre;
            this.ApellidoPaterno = pApellidoPaterno;
            this.ApellidoMaterno = pApellidoMaterno;
            this.Curp = pCurp;
            this.Telefono = pTelefono;
            this.Celular = pCelular;
            this.Correo = pCorreo;
            this.Nss = pNss;
            this.Sexo = pSexo;
            this.FechaNacimiento = pFechaNacimiento;
            this.NombreGrupoUsuario = pNombreGrupoUsuario;
        }
    }
}
