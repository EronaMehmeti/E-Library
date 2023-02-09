using ELibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using ELibrary.Services;
using ELibrary.ViewModel;

namespace ELibrary.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowServices _borrowServices;

        public BorrowController(IBorrowServices borrowServices)
        {
            _borrowServices = borrowServices;
        }

        [HttpPost("addBorrow")]
        public IActionResult Add(BorrowViewModel borrow)
        {
            try
            {     
                _borrowServices.Add(borrow);
                return Ok("Borrow submitted successfully.");
            }
            catch (BookNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (BookAlreadyBorrowException ex)
            {
                return BadRequest(ex.Message);

            }

        }

        [HttpGet]
        public IActionResult Get()
        {
            var allBorrow = _borrowServices.Get();
            return Ok(allBorrow);

        }

        [HttpGet("get-by-id /{borrowId}")]
        public IActionResult GetById(int id)
        {
            var _borrow = _borrowServices.GetById(id);
            return Ok(_borrow);
        }

        [HttpPut("update-by-id/{borrowId}")]
        public IActionResult UpdateById(int BorrowId, [FromBody] BorrowViewModel borrow)
        {
            var updatedBorrow = _borrowServices.UpdatebyId(BorrowId, borrow);
            return Ok(updatedBorrow);
        }

        [HttpDelete("delete-Borrow/{id}")]                       
        public IActionResult Delete(int id)
        {
            _borrowServices.Delete(id);
            return Ok();
        }

    }
}

