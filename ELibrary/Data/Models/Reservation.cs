namespace ELibrary.Data.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public DateTime RezervationData { get; set;}

        public string RezervationStatus { get; set;}

        public int MemberId { get; set; }

        public int Isbn { get; set; }

        public Book book { get; set; }

        public Member member { get; set; }
    }
}
