using SocietNet.BLL.Services;
using SocietNet.BLL.Models;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class FiendDetailedView
{
    UserService userService;
    public FiendDetailedView(UserService userService) { this.userService = userService; }
    public void Display(User user, int fiendId)
    {
        User fiend = userService.FindById(fiendId);
        Console.WriteLine($"Name: {fiend.Frontname} {fiend.Lastname};\n" +
            $"Pic: {fiend.Pic};\n" +
            $"Favourite MKV: {fiend.FavMkv};\n" +
            $"Favourite EPUB: {fiend.FavEpub};\n" +
            $"Soap: {fiend.Soap};\n");
        InYellow.WriteLine("Type 1 to send a message;\n" +
            "Type 3 to remove fiend;\n" +
            "Type 0 to go back.");
        switch (Console.ReadKey(true).Key.ToString())
        {
            case "D1" or "NumPad1": Program.messageSendingView.Display(user, fiendId); break;
            case "D3" or "NumPad3": Program.fiendRemovingView.Display(user, fiend); break;

            case "D0" or "NumPad0": return;
        }
    }
}
