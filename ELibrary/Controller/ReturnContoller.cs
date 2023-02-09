/*using ELibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;
using ELibrary.ViewModel;


namespace ELibrary.Controller
{
 
    public class ReturnController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public ReturnController(IBookServices bookServices)
        {
            _bookServices = bookServices;
 
        }

        [Route("Return")]
        public IActionResult List()
        {
            // load all borrowed books
            var borrowedBooks = _bookServices.Get();
            // Check the books collection
            if (borrowedBooks == null || borrowedBooks.ToList().Count() == 0)
            {
                return Ok("Empty");
            }
            return Ok(borrowedBooks);
        }

        public IActionResult ReturnABook(int BookId, BookVM book)
        {
            // load the current book
            var books = _bookServices.GetById(BookId);
            return Ok(books);
            // remove borrower

            _bookServices.Delete(BookId);
            return Ok();
            // update database
            var updatedBook = _bookServices.UpdateById(BookId,book);

            return Ok(updatedBook);
            // redirect to list method
            return RedirectToAction("List");
        }
    }
}

*/