using ELibrary.Models;
using ELibrary.ViewModel;

namespace ELibrary.Interface
{
    public interface IBookServices
    {
        public List<Book> Get();
        public Book GetById(int bookId);
        public void Add(BookVM book);
        public Book UpdateById(int BookId, BookVM book);
        public void Delete(int bookId);
        
    }
}
