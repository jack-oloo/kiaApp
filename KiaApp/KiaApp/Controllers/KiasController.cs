//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

using KiaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace KiaApp.Controllers
{
    public class KiasController : ApiController
    {
        Kia[] cars = new Kia[]
        {
            new Kia { Id = 1, Name = "Optima", Category = "Hybrid", Price = 20000 },
            new Kia { Id = 2, Name = "Soul", Category = "EV", Price = 25000 },
            new Kia { Id = 3, Name = "cee'd", Category = "Hybrid", Price = 30000 }
        };

        public IEnumerable<Kia> GetAllKias()
        {
            return cars;
        }

        public IHttpActionResult GetKia(int id)
        {
            var kia = cars.FirstOrDefault((p) => p.Id == id);
            if (kia == null)
            {
                return NotFound();
            }
            return Ok(kia);
        }
    }
}
