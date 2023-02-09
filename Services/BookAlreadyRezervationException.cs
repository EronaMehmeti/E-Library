namespace ELibrary.Services
{
    public class BookAlreadyRezervationException : Exception
    {
        public BookAlreadyRezervationException()
        {
        }
        public BookAlreadyRezervationException(string? message) : base(message)
        {
        }

    }

}
