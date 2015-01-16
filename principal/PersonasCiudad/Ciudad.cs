using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
   class Ciudad
   {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // metodo constructor
        public Ciudad() 
        { }

        public Ciudad(int pId, string pCiudad)
        {
            this.Id = pId;
            this.Nombre = pCiudad;
        }

   }
}
