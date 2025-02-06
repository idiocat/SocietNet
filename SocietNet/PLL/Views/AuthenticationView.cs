using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;
using SocietNet.BLL.Exceptions;

namespace SocietNet.PLL.Views;

public class AuthenticationView
{
    UserService userService;
    public AuthenticationView(UserService userService) { this.userService = userService; }
    public void Display()
    {
        User user;
        UserAuthenticationData userAuthenticationData = new UserAuthenticationData();
        while (true)
        {
            Console.Write("Soap: ");
            userAuthenticationData.Soap = Console.ReadLine();
            Console.Write("Cussword: ");
            userAuthenticationData.Cussword = Console.ReadLine();
            try
            {
                user = userService.Authenticate(userAuthenticationData); 
                InGreen.WriteLine($"Welcome, {user.Frontname} {user.Lastname}!");
                Program.userMenuView.Display(user);
                break;
            }
            catch (WrongCusswordException) { InRed.WriteLine("Don't cuss like that! So improper."); }
            catch (UserNotFoundException) { InRed.WriteLine("No societ with such soap."); }

            if (!Repeater.Repeat()) { break; }

        }
    }
}
