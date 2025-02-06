using SocietNet.BLL.Models;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class UserUpdateView
{
    public void Display(User user)
    {
        InYellow.WriteLine("Type your info as requested, leave empty to skip.");
        string? userInput;
        Console.Write("Frontame: ");
        userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput)) { user.Frontname = userInput; }

        Console.Write("Lastname: ");
        userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput)) { user.Lastname = userInput; }

        Console.Write("Pic: ");
        userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput)) { user.Pic = userInput; }

        Console.Write("Favourite MKV: ");
        userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput)) { user.FavMkv = userInput; }

        Console.Write("Favourite EPUB: ");
        userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput)) { user.FavEpub = userInput; }
    }
}
