using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcesionarioMVC.Models
{
    public class PiezasCoche
    {
        public int ID { get; set; }

        public int cocheId { get; set; }
        public Coche coche { get; set; }

        public int piezaId { get; set; }
        public Pieza pieza { get; set; }

    }
}