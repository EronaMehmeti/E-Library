using ELibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using ELibrary.Services;
using ELibrary.ViewModel;

namespace ELibrary.Controller
{
        [Route("api/[controller]")]
        [ApiController]
    public class MemberController : ControllerBase
    {
        //dependency injection 
        private readonly IMemberServices _memberServices;
        public MemberController(IMemberServices memberServices)
        {
            _memberServices = memberServices;
        }
        [HttpPost("addMember")]
        public IActionResult Add(MemberViewModel member)
        {
            try
            {
                _memberServices.Add(member);
                return Ok("Add submitted successfully!");
            }
            catch (MemberAlreadyIsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            var allMember = _memberServices.Get();
            return Ok(allMember);
        }
      
    }
}
