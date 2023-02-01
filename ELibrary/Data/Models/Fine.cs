namespace ELibrary.Data.Models
{
    public class Fine
    {
        public double Ammount { get; set; }

        public DateTime Data { get; set; }

        public int MemberId { get; set; }

        public int BorrowId { get; set; }

        public Book book { get; set; }

        public Borrow borrow{ get; set; }

    }
}
