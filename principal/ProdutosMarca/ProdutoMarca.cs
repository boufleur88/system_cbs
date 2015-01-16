using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
   class ProdutoMarca
   {
      public int codigo { get; set; }
      public String marca { get; set; }

      public ProdutoMarca()
      { }

      public ProdutoMarca(int pCodigo, String pMarca)
      {
         this.codigo = pCodigo;
         this.marca = pMarca;
      }
   }
}
