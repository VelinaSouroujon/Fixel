namespace Fixel.Core.RepairTickets.Exceptions
{
    public class DuplicateReferenceNumberException : Exception
    {
        public DuplicateReferenceNumberException()
        {

        }

        public DuplicateReferenceNumberException(string? message)
            : base(message)
        {

        }

        public DuplicateReferenceNumberException(string? message, Exception? innerException)
            : base(message, innerException)
        {

        }
    }
}
