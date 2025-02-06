namespace SocietNet.BLL.Models;

public class User
{
    public int Id { get; }
    public string Frontname { get; set; }
    public string Lastname { get; set; }
    public string Cussword { get; set; }
    public string Soap { get; set; }
    public string Pic { get; set; }
    public string FavMkv { get; set; }
    public string FavEpub { get; set; }
    public User(
        int id,
        string frontname,
        string lastname,
        string cussword,
        string soap,
        string pic,
        string favMkv,
        string favEpub
        )
    {
        Id = id;
        Frontname = frontname;
        Lastname = lastname;
        Cussword = cussword;
        Soap = soap;    
        Pic = pic;
        FavMkv = favMkv;
        FavEpub = favEpub;
    }
}
