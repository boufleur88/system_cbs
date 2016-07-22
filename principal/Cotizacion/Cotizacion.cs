using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Cotizacion
    {
        public double codigo { get; set; }
        public double compraReal { get; set; }
        public double ventaReal { get; set; }
        public double compraDolar { get; set; }
        public double ventaDolar { get; set; }
        public int usuario { get; set; }
        public DateTime fecha { get; set; }


        public Cotizacion() { }


        public Cotizacion( double p1, double p2, double p3, double p4, double p5, int p6, DateTime p7) {
            this.codigo = p1;
            this.compraReal = p2;
            this.ventaReal = p3;
            this.compraDolar = p4;
            this.ventaDolar = p5;
            this.usuario = p6;
            this.fecha = p7;
        }
    }
}
