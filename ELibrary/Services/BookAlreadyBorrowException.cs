namespace ELibrary.Services
{
    public class BookAlreadyBorrowException : Exception
    {
        public BookAlreadyBorrowException()
        {
        }
        public BookAlreadyBorrowException(string? message) : base(message)
        {
        }
    }
}
