namespace SocietNet.BLL.Models;

public class MessageForm
{
    public int TellerId { get; set; }
    public int ListenerId { get; set; }
    public string? Content { get; set; }
}
