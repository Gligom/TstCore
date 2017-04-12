using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TstCore.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TstCore.Controllers
{
    [Route("api/[controller]")]
    public class RezultatController : Controller
    {
        private readonly IRezultatRepository _rezultatRepository;

        public RezultatController(IRezultatRepository rezultatRepository)
        {
            _rezultatRepository = rezultatRepository;
        }

        // GET: api/values
        [HttpGet]
        public  IEnumerable<Rezultat> GetAll()
        {
            return _rezultatRepository.GetAll();
        }
        
    }
}
