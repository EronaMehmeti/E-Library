using System.Runtime.Serialization;

namespace ELibrary.Services
{
    [Serializable]
    internal class BookNotFoundException : Exception
    {
        public BookNotFoundException()
        {
        }

        public BookNotFoundException(string? message) : base(message)
        {
        }

        public BookNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BookNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}