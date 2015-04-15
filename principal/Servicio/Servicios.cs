using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Servicios
    {
        // Variables de la clase servicios.
        public int id_servicio { get; set; } // codigo único de la tabla servicio.
        public int id_grupo { get; set; } // codigo único de la tabla grupo servicio.

        public String descripcion { get; set; } // descripcion de la tabla servicio.
        public String grupo { get; set; } // descripcion de la tabla grupo servicio.
        public String observacion { get; set; } // observacion de la tabla servicio.

        // tabla servicio costo, precio minimo y precio normal.
        public double costo { get; set; }
        public double preciomin { get; set; }
        public double precio { get; set; }

        // Crea un Método Constructor Vacío.
        public Servicios()
        { }
        
        // Metodo constructor registro de servicios.
        public Servicios(int idServicio, int idGrupo, string Descripcion, string Grupo, string Observacion, double Costo, double Precio, double PrecioMin)
        {
          this.id_servicio = idServicio;
          this.id_grupo = idGrupo;
          this.descripcion = Descripcion;
          this.grupo = Grupo;
          this.observacion = Observacion;
          this.costo = Costo;
          this.precio = Precio;
          this.preciomin = PrecioMin;
        }
    }
}
