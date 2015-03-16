using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Compra
    {
    // tabla compras
        public int codigo {get; set; }
        public int prov_id {get; set; }
        public string observacion {get; set; }
        public int item_id {get; set; }
        
        // tabla proveedor
        public string prov_nombre {get; set; }
        public string prov_fantasia {get; set; }
        public string prov_direccion {get; set; }
        public string prov_telefono {get; set; }
        public string prov_ruc {get; set; }
     
        // tabla item
        public string item_description {get; set; }
        public Double item_costo {get; set; }
        public Double item_venta {get; set; }

      
      

      public Compra()
      { }

      public Compra(int cCodigo)
      {
         this.codigo = cCodigo;
      
      }
    }
}
