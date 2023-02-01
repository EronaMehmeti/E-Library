namespace ELibrary.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
       
        public DateTime BorrowDate{ get; set; }

        public DateTime ReturnDate { get; set; }

        public int MemberId { get; set; }

        public int BookId { get; set; }

        public Book Book{ get; set; }

        public Member Member{ get; set; }



    }
}
