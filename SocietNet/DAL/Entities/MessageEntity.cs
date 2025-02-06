namespace SocietNet.DAL.Entities;

public class MessageEntity
{
    public int id { get; set; }
    public string? content { get; set; }
    public int teller_id { get; set; }
    public int listener_id { get; set; }
}
