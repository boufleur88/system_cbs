using System;

namespace sistema_cbs
{
   class Produto
   {
      
      public int codigo {get; set; }
      public int moneda {get; set; }
      public int iva {get; set; }
      public int st_minimo { get; set; }
      
      public int marca { get; set; }
      public int grupo { get; set; }
      public int subgrupo { get; set; }
      
      public String descr { get; set; }
      public String unidad { get; set; }
      public String observacion { get; set; }
      
      // nombre marca, grupo y subgrupo
      public String Nmarcar { get; set; }
      public String Ngrupo { get; set; }
      public String Nsubgrupo { get; set; }
      
      public Double costoadm { get; set; }
      public Double costocon { get; set; }
      public Double ventamin { get; set; }
      public Double ventamay { get; set; }


      public Produto()
      { }

      public Produto(int pCodigo, int pMoneda, int pIva, int pStminimo, int pMarca, int pGrupo, int pSubGrupo, String pDescr, String pUnidad, String pObs, Double pCostoAdm, Double pCostocon, Double pVentamay, Double pVentamin, String Nmarca, String Ngrupo, String Nsubgrupo)
      {
         this.codigo = pCodigo;
         this.moneda = pMoneda;
         this.iva = pIva;
         this.st_minimo = pStminimo;
         this.marca = pMarca;
         this.grupo = pGrupo;
         this.subgrupo = pSubGrupo;         
         this.descr = pDescr;
         this.unidad = pUnidad;
         this.observacion = pObs;
         this.costoadm = pCostoAdm;
         this.costocon = pCostocon;
         this.ventamay = pVentamay;
         this.ventamin = pVentamin;
         this.Nmarcar = Nmarca;
         this.Ngrupo = Ngrupo;
         this.Nsubgrupo = Nsubgrupo;
      }

   }
}
