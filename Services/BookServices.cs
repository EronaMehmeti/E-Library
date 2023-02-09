using ELibrary.Interface;
using ELibrary.Models;
using ELibrary.ViewModel;

namespace ELibrary.Services
{
    public class BookServices : IBookServices
    {
        private readonly LibraryDbContext _context;

        public BookServices(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(BookVM book)
        {
            var _book = new Book()
            {
                BookId= book.BookId,
                Isbn = book.Isbn,
                Name = book.Name,
                Publisher = book.Publisher,
                Edition = book.Edition,
                BookNumber = book.BookNumber,
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> Get() => _context.Books.ToList();

        public Book GetById(int bookId) => _context.Books.FirstOrDefault(n => n.BookId == bookId);

        public Book UpdateById(int bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.BookId == bookId);
            if (_book != null)
            {
                _book.Isbn = book.Isbn;
                _book.Name = book.Name;
                _book.Publisher = book.Publisher;
                _book.Edition = book.Edition;
                _book.BookNumber = book.BookNumber;

                _context.SaveChanges();
            }
            return _book;
        }

        public void Delete(int BookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.BookId == BookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}