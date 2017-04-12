using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TstCore.Model
{
    public interface IRezultatRepository
    {
        IEnumerable<Rezultat> GetAll();
    }
}
