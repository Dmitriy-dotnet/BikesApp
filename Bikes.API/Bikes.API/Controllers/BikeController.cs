using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bikes.BLL.Services;
using Bikes.DAL.Context;
using Bikes.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bikes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {   //https://localhost:44309 to enviroment in angular app
        private BikeService _bikeService;

        public BikeController(BikeService bikeService)
        {
            _bikeService = bikeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bike>>>GetAll()
        {
            var bikes = await _bikeService.GetALLBikesAsync();
            return Ok(bikes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var bike = await _bikeService.GetBikeAsync(id);
                return Ok(bike);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _bikeService.DeleteBikeAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Bike bike)
        {
            var addedBike = await _bikeService.CreateBikeAsync(bike);
            return Ok(addedBike);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Bike bike)
        {
            await _bikeService.UpdateBikeAsync(bike);
            return Ok(bike);
        }
    }
}
