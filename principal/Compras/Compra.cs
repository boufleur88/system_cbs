using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Compra
    {
        // tabla compras utilizar como está en el banco las tablas.
        // compra_id
        public int cid {get; set; } // id compra.
        public int pid { get; set; } // id persona.
        public int uid { get; set; } // id usuario.
        public int moneda { get; set; } // id moeda.
        public int sucursal { get; set; } // id sucursal.
        public int status { get; set; }


        // fecha factura
        public DateTime f_inclusion { get; set; }
        public DateTime f_vencimiento { get; set; }

        // persona_id
        public int persona { get; set; }
        // public String persona_nombre { get; set; }

        // user_id
        public int usuario { get; set; }
        // public String usuario_nombre { get; set; }

        // otros datos tabla compras
        public String factura { get; set; }
        public String timbrado { get; set; }
        public String observacion { get; set; }
        public Double iva00 { get; set; }
        public Double iva05 { get; set; }
        public Double iva10 { get; set; }
        public Double total { get; set; }
        
     
        // tabla cliente
        public string cl_nombre {get; set; }
        public string cl_fantasia {get; set; }
        public string cl_direccion {get; set; }
        public string cl_telelefono {get; set; }
        public string cl_ruc {get; set; }
     
        // tabla item
        public int it_codigo { get; set; }
        public string it_description {get; set; }
        public Double it_cantidad { get; set; }
        public Double it_costocont {get; set; }
        public Double it_costoadm { get; set; }
        public Double it_ventamin {get; set; }
        public Double it_ventamay { get; set; }
        public Double totalCompra { get; set; }


      public Compra()
      { }

      public Compra(int cCodigo, int cPersona, int cUsuario, DateTime fInclusion, String cFactura, String cObs,
          Double cIva00, Double cIva05, Double cIva10, Double cTotal, Double cTotalCompra, int cMoneda, int cSucursal, int cStatus)
      {
         this.cid = cCodigo;
         this.pid = cPersona;
         this.uid = cUsuario;
         this.f_inclusion = fInclusion;
         this.factura = cFactura;
         this.totalCompra = cTotalCompra;
         this.observacion = cObs;
         //
         this.usuario = cUsuario;
         this.factura = cFactura;

         this.iva00 = cIva00;
         this.iva05 = cIva05;
         this.iva10 = cIva10;
         this.total = cTotal;
         this.moneda = cMoneda;
         this.sucursal = cSucursal;
         this.status = cStatus;
      }
    }
}
