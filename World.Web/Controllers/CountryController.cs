using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using World.Web.Data;
using World.Web.Models;

namespace World.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CountryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var country= _dbContext.Countries.ToList();
            return Ok(country);
        }

        [HttpGet]
        [Route("Details")]
        public IActionResult Get(int id)
        { 
           var country1= _dbContext.Countries.FirstOrDefault(x => x.Id == id);

            if (country1 == null)
            {
                return NotFound($"Value not found for -{id}");
            }
            return Ok(country1);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Country country)
        {
            _dbContext.Countries.Add(country);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Country country) 
        { 
            _dbContext.Countries.Update(country);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            var Country =_dbContext.Countries.Find(id);
            _dbContext.Countries.Remove(Country);
            _dbContext.SaveChanges();
            return Ok();
        }  


    }
}
