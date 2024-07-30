namespace CSharp.VCardCreation.Models;

public class ExceptionHandling
{
    public class UserLimitException : Exception
    {
        public UserLimitException(string message) : base(message)
        {
        }
    }
}