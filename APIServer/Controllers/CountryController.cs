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
    public class CountryController : ControllerBase
    {
        readonly CountryContext CountryDetails;
        public CountryController(CountryContext countryContext)
        {
            CountryDetails = countryContext;
        }
        
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            var data = CountryDetails.Country.ToList();
            return data;
        } 
         
        [HttpPost]
        public IActionResult Post([FromBody] Country obj)
        {
            var data = CountryDetails.Country.Add(obj);
            CountryDetails.SaveChanges();
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Country obj)
        {
            var data = CountryDetails.Country.Update(obj);
            CountryDetails.SaveChanges();
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = CountryDetails.Country.Where(a => a.Id == id).FirstOrDefault();
            CountryDetails.Country.Remove(data);
            CountryDetails.SaveChanges();
            return Ok();

        }
    }
}
 