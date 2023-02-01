namespace ELibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string? Name { get; set; }
        public string Publisher { get; set; }
        public int Edition { get; set; }
        public int  BookNumber { get; set; }
    }
}
