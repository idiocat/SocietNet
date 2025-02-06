namespace SocietNet.BLL.Models;

public class Message
{
    public int Id { get; }
    public int TellerId { get; set; }
    public int ListenerId { get; set; }
    public string Content { get; set; }
    public Message(int id, int tellerId, int listenerId, string content)
    {
        Id = id;
        TellerId = tellerId;
        ListenerId = listenerId;
        Content = content;
    }
}
