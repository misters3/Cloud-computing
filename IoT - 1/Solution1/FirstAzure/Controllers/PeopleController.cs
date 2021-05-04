using FirstAzure.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        private readonly PeopleDb db;
        public PeopleController(PeopleDb db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var people = db.People.ToList();
            return Ok(people);
        }
    }
}
