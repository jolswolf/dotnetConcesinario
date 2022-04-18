using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConcesionarioMVC.Models
{
    public class Coche
    {
        public int ID { get; set; }
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string titular { get; set; }

        public int marcaId { get; set; }
        public Marca marca { get; set; }

        public List<int> piezasCocheId { get; set; }
        public List<PiezasCoche> piezasCoche { get; set; }

        public List<int> tallerId { get; set; }
        public List<Taller> taller { get; set; }
    }
}