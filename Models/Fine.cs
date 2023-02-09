namespace ELibrary.Models
{
    public class Fine
    {
        public int FineId { get; set; }
        public double Ammount { get; set; }

        public DateTime Data { get; set; }

       public int MemberId { get; set; }

        public int BorrowId { get; set; }

        public Member Member { get; set; }

        public Borrow Borrow{ get; set; }

    }
}
