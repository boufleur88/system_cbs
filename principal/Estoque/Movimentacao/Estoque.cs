using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs.Estoque.Movimento_Entrada
{
    class Estoque
    {
        // INSERT INTO movEst (id_produto, qtdEnt, qtdSai, vlrEnt, vlrSai, estObs, id_user) VALUES (00001,1,0,5000,0,'Teste movimento de estoque',0001);
      public Double codPro {get; set; }
      public Double qtdEnt {get; set; }
      public Double qtdSai { get; set; }
      public Double vlrEnt { get; set; }
      public Double vlrSai { get; set; }
      public int codUsu { get; set; }
      public String movObs { get; set; }
      


    }
}
