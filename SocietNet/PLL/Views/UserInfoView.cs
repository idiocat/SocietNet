using SocietNet.BLL.Models;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class UserInfoView
{
    public void Display(User user)
    {
        InGreen.WriteLine($"ID: {user.Id};\n" +
                                                $"Frontname: {user.Frontname};\n" +
                                                $"Lastname: {user.Lastname};\n" +
                                                $"Soap: {user.Soap};\n" +
                                                $"Pic: {user.Pic};\n" +
                                                $"Favourite MKV: {user.FavMkv};\n" +
                                                $"Favoutire EPUB: {user.FavEpub}.\n");
        AnyKey.WaitFor();
    }
}
