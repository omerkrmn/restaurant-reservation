using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RR.Entities.DTOs.Restourant;
using RR.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController(IServiceManager service) : ControllerBase
    {
        private readonly IServiceManager _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAllRestaurants()
        {
            var restaurants = await _service.RestaurantService.GetAllRestaurantsAsync(trackChanges: false);
            return Ok(restaurants);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurantById(Guid id)
        {
            var restaurant = await _service.RestaurantService.GetRestaurantByIdAsync(id, trackChanges: false);
            if (restaurant is null)
                return NotFound();
            return Ok(restaurant);
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchRestaurants(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return BadRequest("Search term cannot be empty.");
            var restaurants = await _service.RestaurantService.GetAllRestourantFromCity(city, trackChanges: false);
            if (!restaurants.Any())
                return NotFound("No restaurants found matching the search term.");
            return Ok(restaurants);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Owner")]
        public async Task<IActionResult> CreateRestaurant([FromBody] RestaurantForCreationDto restaurantForCreationDto)
        {
            if (restaurantForCreationDto is null)
                return BadRequest("Restaurant data cannot be null.");
            var createdRestaurant = await _service.RestaurantService.CreateRestaurantAsync(restaurantForCreationDto);
            return CreatedAtAction(nameof(GetRestaurantById), new { id = createdRestaurant.Id }, createdRestaurant);
        }
        [Authorize(Roles = "Admin,Owner")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRestaurant(int id, [FromBody] RestaurantForUpdateDto restaurantForUpdateDto)
        {
            if (restaurantForUpdateDto is null)
                return BadRequest("Restaurant data cannot be null.");
            await _service.RestaurantService.UpdateRestaurantAsync(restaurantForUpdateDto);
            return NoContent();
        }


    }
}
