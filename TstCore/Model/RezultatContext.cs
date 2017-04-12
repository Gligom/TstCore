using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TstCore.Model;

namespace TstCore
{
    public class RezultatContext : DbContext
    {
        public RezultatContext(DbContextOptions<RezultatContext> options)
            : base(options)
        { }

        public DbSet<Rezultat> Rezultate { get; set; }
      
    }
}
