namespace ELibrary.Interface
{
    public class BookAlreadyIsException : Exception
     {
        public BookAlreadyIsException()
        {
        }
    
        public BookAlreadyIsException(string? message) : base(message) 
        {
        }
    }

}
