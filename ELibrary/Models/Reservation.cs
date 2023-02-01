namespace ELibrary.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public DateTime RezervationData { get; set;}

        public string RezervationStatus { get; set;}

        public int MemberId { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public Member Member { get; set; }
    }
}
