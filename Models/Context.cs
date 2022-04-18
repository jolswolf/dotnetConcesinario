using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConcesionarioMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Coche> Coches { get; set; }
        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Taller> Taller { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<PiezasCoche> piezasCoches { get; set; }

    }
}