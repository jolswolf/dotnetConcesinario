using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcesionarioMVC.Models
{
    public class Marca
    {
        public int ID { get; set; }
        public string nomMarca { get; set; }

        public List<int> cocheId { get; set; }
        public List<Coche> coche { get; set; }
    }
}