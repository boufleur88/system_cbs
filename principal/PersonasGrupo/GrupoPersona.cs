using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
   class GrupoPersona
   {
      // FORMULARIO PERSONAS.
          
      
      public int id_grupo_per { get; set; }
      public string nombre { get; set; }

        // metodo constructor
        public GrupoPersona() 
        { }

        public GrupoPersona(int pId, string pGrupo)
        {
            this.id_grupo_per = pId;
            this.nombre = pGrupo;
        }
   }
}
