using ELibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using ELibrary.Services;
using ELibrary.ViewModel;

namespace ELibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase
    {
        //dependency injection 
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

       
        [HttpPost("add-book")]
        public IActionResult Add(BookVM book)
        {
            try
            {
                _bookServices.Add(book);
                return Ok("Add submitted successfully!");
            }
            catch (BookAlreadyIsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            var allBooks = _bookServices.Get();
            return Ok(allBooks);
        }


        [HttpGet("get-book-by-id/{BookId}")]
        public IActionResult GetById(int Id)
        {
            var _book = _bookServices.GetById(Id);
            return Ok(_book);
        }
        [HttpPut("update-book/{BookId}")]
        public IActionResult UpdateById(int BookId, [FromBody] BookVM book)
        {
            var updatedBook = _bookServices.UpdateById(BookId, book);
            return Ok(updatedBook);
        }

        [HttpDelete("delete-book-by-id/{BookId}")]
        public IActionResult Delete(int id)
        {
            _bookServices.Delete(id);
            return Ok();
        }
    }
}

