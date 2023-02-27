using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIServer.Context;
using APIServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateMasterController : Controller
    {
        readonly CountryContext CountryDetails;
        public StateMasterController(CountryContext StateMasterContext)
        {
            CountryDetails = StateMasterContext;
        }

        [HttpGet]
        public IEnumerable<StateMaster> Get()
        {
            var data = CountryDetails.StateMaster.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] StateMaster obj)
        {
            var data = CountryDetails.StateMaster.Add(obj);
            CountryDetails.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] StateMaster obj)
        {
            var data = CountryDetails.StateMaster.Update(obj);
            CountryDetails.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = CountryDetails.StateMaster.Where(a => a.Id == id).FirstOrDefault();
            CountryDetails.StateMaster.Remove(data);
            CountryDetails.SaveChanges();
            return Ok();

        }
    }
}
