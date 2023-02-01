namespace ELibrary.Data.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
       
        public DateTime BorrowDate{ get; set; }

        public DateTime ReturnDate { get; set; }

        public int MemberId { get; set; }

        public int Isbn { get; set; }

        public Book book{ get; set; }

        public Member member{ get; set; }



    }
}
