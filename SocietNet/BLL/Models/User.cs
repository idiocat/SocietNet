namespace SocietNet.BLL.Models;

public class User
{
    public virtual int Id { get; }
    public virtual string Frontname { get; set; }
    public virtual string Lastname { get; set; }
    public virtual string Cussword { get; set; }
    public virtual string Soap { get; set; }
    public virtual string Pic { get; set; }
    public virtual string FavMkv { get; set; }
    public virtual string FavEpub { get; set; }
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
