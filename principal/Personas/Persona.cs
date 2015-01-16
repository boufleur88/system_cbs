using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
   class Persona
   {
      public int id { get; set; }
      public string nombre { get; set; }
      public string ruc { get; set; }
      public string fantasia { get; set; }
      public string cedula { get; set; }
      public string direccion { get; set; }
      public string ciudad { get; set; }
      public string pais { get; set; }
      public string tel1 { get; set; }
      public string tel2 { get; set; }
      public string email { get; set; }
      public string cliente { get; set; }
      public string proveedor { get; set; }
      public string funcionario { get; set; }
      public string observacion { get; set; }
      public string nacimento { get; set; }


        // metodo constructor
        public Persona() 
        { }

        public Persona(int pId, string pNombre, string pRuc, string pFantasia, string pCedula, string pDireccion, string pCiudad, string pPais, string pTel1, string pTel2, string pEmail, string pCliente, string pProveedor, string pFuncionario, string pObservacion, string pNacimiento)
        {
            this.id = pId;
            this.nombre = pNombre;
            this.ruc = pRuc;
            this.fantasia = pFantasia;
            this.cedula = pCedula;
            this.direccion = pDireccion;
            this.ciudad = pCiudad;
            this.pais = pPais;
            this.tel1 = pTel1;
            this.tel2 = pTel2;
            this.email = pEmail;
            this.cliente = pCliente;
            this.proveedor = pProveedor;
            this.funcionario = pFuncionario;
            this.observacion = pObservacion;
           this.nacimento = pNacimiento;
        }
   }
}
