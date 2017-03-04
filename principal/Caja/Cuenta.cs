using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Cuenta
    {
        
        public string codigo { get; set; }
        public string cuenta { get; set; }
        public string moeda { get; set; }
        public string imput { get; set; }
        public string user { get; set; }
      
        public Cuenta() 
        { }

        public Cuenta(string codigo, string cuenta)
        {
            this.codigo = codigo;
            this.cuenta = cuenta;
            this.moeda = moeda;
            this.imput = imput;
            this.user = user;
        }
    }
}
