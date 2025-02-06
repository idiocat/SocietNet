namespace SocietNet.BLL.Exceptions;

public class UserNotFoundException : Exception
{
    public new string Message { get; set; }
    public UserNotFoundException(string message) { Message = message; }
    public UserNotFoundException() : base() { Message = "No societ. Net."; }
}
