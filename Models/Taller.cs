using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcesionarioMVC.Models
{
    public class Taller
    {
        public int ID { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public double coste { get; set; }

        public List<int> cocheId { get; set; }
        public List<Coche> coche { get; set; }
    }
}