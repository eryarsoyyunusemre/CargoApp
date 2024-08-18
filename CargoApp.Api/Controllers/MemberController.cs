using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoApp.Bll.Abstract;
using CargoApp.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace CargoApp.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
            
        [HttpGet]
        public async Task<IActionResult> GetMember()
        {
            var values = await _memberService.TGetListAsync();
            return Ok(values); // veya uygun bir IActionResult döndürme yöntemi
        }

        [HttpPost]
        public async Task<IActionResult> CreateMember(Member memberDto)
        {
            if (memberDto == null)
            {
                return BadRequest("Member data is null.");
            }

            try
            {
                await _memberService.TCreateAsync(memberDto);
                return Ok(memberDto);
            }
            catch (Exception ex)
            {
                // Hata durumunda, InternalServerError (500) döndürüyoruz
                return StatusCode(500, "An error occurred while creating the member: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember(string id)
                 {
              
                     try
                     {
                         await _memberService.TDeleteAsync(id);
                         return Ok("Member deleted successfully.");
                     }
                     catch (Exception ex)
                     {
                         // Hata durumunda, InternalServerError (500) döndürüyoruz
                         return StatusCode(500, "An error occurred while deleting the member: " + ex.Message);
                     }
                 }



    }
}
