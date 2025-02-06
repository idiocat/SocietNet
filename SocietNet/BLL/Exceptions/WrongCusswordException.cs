namespace SocietNet.BLL.Exceptions;

public class WrongCusswordException : Exception
{
    public new string Message { get; set; }
    public WrongCusswordException(string message) { Message = message; }
    public WrongCusswordException() : base() { Message = "Don't cuss like this! So improper."; }
}
