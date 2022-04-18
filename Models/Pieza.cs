using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcesionarioMVC.Models
{
    public class Pieza
    {
        public int ID { get; set; }
        public string modelo { get; set; }
        public double tamano_cm { get; set; }
        public double coste { get; set; }

        public List<int> piezasCocheId { get; set; }
        public List<PiezasCoche> piezasCoche { get; set; }

    }
}