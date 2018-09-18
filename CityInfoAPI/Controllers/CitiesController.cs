using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfoAPI.Controllers
{
    [Route("api/cities")] // gerenalised route to our resources, so we can use only [HttpGet()] instead of [HttpGet("api/cities")] on our methods. 
    //It is also name of the controller, so we can replace cities with [controller], good for websites but for API better as it is
    public class CitiesController : Controller
    {
        [HttpGet()] // we used attribute based routing, recommendet for API
        public IActionResult GetCities() //  JsonResult was replaced with IActionResult
        {          
            return Ok(CitiesDataStore.Current.Cities); 
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound(); 
            }

            return Ok(cityToReturn);
        }        
           
    }
}
