using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class Servicios
    {
        // Variables de la clase servicios.
        public int codigo { get; set; }
        public int id_grupo { get; set; }

        public String descripcion { get; set; }
        public String grupo { get; set; }
        public String observacion { get; set; }

        public double precio { get; set; }

        
        public Servicios()
        { }
        
        // Metodo constructor registro de servicios.
        public Servicios(int Codigo, int idGrupo, string Descripcion, string Grupo, string Observacion, double Precio)
        {
          this.codigo = Codigo;
          this.id_grupo = idGrupo;
          this.descripcion = Descripcion;
          this.grupo = Grupo;
          this.observacion = Observacion;
          this.precio = Precio;
        }


    }
}
