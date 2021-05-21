using GcDealership.Models;
using GcDealership.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GcDealership.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {        
        private readonly IVehicleRepository _repository;

        public VehicleController(IVehicleRepository repository)
        {
            _repository = repository;
        }

        // GET: api/vehicle
        [HttpGet]
        public async Task<ActionResult<IList<Vehicle>>> GetAllVehicles()
        {
            var results = await _repository.GetVehiclesAsync();

            if (results.Count > 0)
            {
                return Ok(results); 
            }

            return NoContent();
        }

        // GET api/vehicle/5
        [HttpGet("{id}")]
        public async Task<Vehicle> GetVehicleById(int id)
        {
            return await _repository.GetVehiclesByIdAsync(id);
        }

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
