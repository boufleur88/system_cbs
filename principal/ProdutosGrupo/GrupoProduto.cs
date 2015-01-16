using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
   class GrupoProduto
   {
       // PRODUTOS: REGISTRO DE GRUPO.
      public int Id { get; set; }
      public string Grupo { get; set; }

      // metodo constuctor
      public GrupoProduto()
      {}

      public GrupoProduto(int pCodigo, string pGrupo)
      {
         this.Id = pCodigo;
         this.Grupo = pGrupo;
      }


   }
}
