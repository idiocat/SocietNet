namespace SocietNet.BLL.Models;

public class Fiend
{
    public int Id { get; }
    public int UserId { get; set; }
    public int FiendId { get; set; }
    public Fiend(int id, int userId, int fiendId)
    {
        Id = id;
        UserId = userId;
        FiendId = fiendId;
    }
}
