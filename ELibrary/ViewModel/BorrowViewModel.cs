using ELibrary.Models;

namespace ELibrary.ViewModel
{
    public class BorrowViewModel
    {
        public DateTime BorrowDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int MemberId { get; set; }

        public int BookId { get; set; }


    }
}
    