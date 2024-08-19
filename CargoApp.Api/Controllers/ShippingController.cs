using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoApp.Bll.Abstract;
using CargoApp.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {

        private readonly IShippingService _shippingService;

        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetShipping()
        {
            var values = await _shippingService.TGetListAsync();
            return Ok(values); 
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMemberById(string id)
        {
            var values = await _shippingService.TGetByIdAsync(id);
            return Ok(values); 
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateMember(Shipping shipping)
        {
            if (shipping == null)
            {
                return BadRequest("Shipping data is null.");
            }

            try
            {
                await _shippingService.TCreateAsync(shipping);
                return Ok(shipping);
            }
            catch (Exception ex)
            {
                // Hata durumunda, InternalServerError (500) döndürüyoruz
                return StatusCode(500, "An error occurred while creating the shipping: " + ex.Message);
            }
        }
        
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember(string id)
        {
            try {
                await _shippingService.TDeleteAsync(id);
                return Ok("Shipping deleted successfully.");
                         
            }catch (Exception ex) {
                // Hata durumunda, InternalServerError (500) döndürüyoruz
                return StatusCode(500, "An error occurred while deleting the shipping: " + ex.Message);
            }
        }
        
    }
}
