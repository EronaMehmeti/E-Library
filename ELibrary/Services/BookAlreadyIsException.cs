namespace ELibrary.Interface
{
    public class MemberAlreadyIsException : Exception
     {
        public MemberAlreadyIsException()
        {
        }
    
        public MemberAlreadyIsException(string? message) : base(message) 
        {
        }
    }

}
