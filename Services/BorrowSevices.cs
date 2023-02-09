using ELibrary.Interface;
using ELibrary.Models;
using ELibrary.ViewModel;

namespace ELibrary.Services
{
    public class BorrowSevices : IBorrowServices 
    {
        private readonly LibraryDbContext _context;

        public BorrowSevices(LibraryDbContext context)
        {
            _context = context;
        }
        public Book GetBookById(int Id)
        {

            return _context.Books.FirstOrDefault(s => s.BookId == Id);

        }

        // check if the student has already applied
        public bool HasBookAlreadyBorrow(int Id)
        {
            var existingBorrow = _context.Borrows.FirstOrDefault(a => a.BorrowId == Id);
            return existingBorrow != null;
        }

      
        public void Add(BorrowViewModel borrow)
        {
            var book = GetBookById(borrow.BookId);
            if (book == null)
            {
                throw new BookNotFoundException("You can't borrow!");
            }
            var isAlreadyBorrow = _context.Borrows.Any(a => a.BookId == borrow.BookId);
            if (isAlreadyBorrow)
            {
                throw new BookNotFoundException("You have already borrow.");
            }
            var _borrow = new Borrow()
            {
                BorrowDate = borrow.BorrowDate,
                ReturnDate = borrow.ReturnDate,
                BookId = borrow.BookId,
                MemberId = borrow.MemberId
            };
            _context.Borrows.Add(_borrow);
            _context.SaveChanges();
        }

    public List<Borrow>Get() => _context.Borrows.ToList();
        public Borrow GetById(int BorrowId) => _context.Borrows.FirstOrDefault(n => n.BorrowId == BorrowId);

        public Borrow UpdatebyId(int BorrowId, BorrowViewModel borrow)
        {
            var _borrow = _context.Borrows.FirstOrDefault(n => n.BorrowId == BorrowId);
            if (_borrow != null)
            {
                _borrow.BorrowDate = borrow.BorrowDate;
                _borrow.ReturnDate = borrow.ReturnDate;
                _borrow.BookId = borrow.BookId;
                _borrow.MemberId = borrow.MemberId;

                _context.SaveChanges();
            }
            return _borrow;
        }

        public void Delete(int id)
        {
            var _borrow = _context.Borrows.FirstOrDefault(x => x.BorrowId == id);
            if (_borrow != null)
            {
                _context.Borrows.Remove(_borrow);
                _context.SaveChanges();
            }
}

    
     
    }
}
