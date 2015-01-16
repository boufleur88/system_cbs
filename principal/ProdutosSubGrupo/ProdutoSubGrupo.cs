﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cbs_sistema
{
   class ProdutoSubGrupo
   {
      public int Id { get; set; }
      public String Subgrupo { get; set; }

      public ProdutoSubGrupo()
      { }

      public ProdutoSubGrupo(int pCodigo, String pSubgrupo)
      {
         this.Id = pCodigo;
         this.Subgrupo = pSubgrupo;
      }

   }
}
