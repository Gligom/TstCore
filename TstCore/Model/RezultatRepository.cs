using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TstCore.Model
{
    public class RezultatRepository : IRezultatRepository
    {
        private readonly RezultatContext _context;

        public RezultatRepository(RezultatContext context)
        {
            _context = context;
        }


        public IEnumerable<Rezultat> GetAll()
        {
            return _context.Rezultate.FromSql("usp_clGetRezultatePacient").ToList();
        }
    }
}


