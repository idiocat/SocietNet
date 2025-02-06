using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class RegistrationView
{
    UserService userService;
    public RegistrationView(UserService userService) { this.userService = userService; }

    public void Display()
    {
        while (true)
        {
            Console.Write("Frontname: ");
            string? frontname = Console.ReadLine();

            Console.Write("Lastname: ");
            string? lastname = Console.ReadLine();

            Console.Write("Cussword: ");
            string? cussword = Console.ReadLine();

            Console.Write("Soap: ");
            string? soap = Console.ReadLine();

            UserRegistrationData userRegistrationData = new UserRegistrationData()
            {
                Frontname = frontname,
                Lastname = lastname,
                Cussword = cussword,
                Soap = soap
            };
            try
            {
                userService.Register(userRegistrationData);
                Console.WriteLine("Registration complete.");
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is MemberAccessException) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine("Something went awfully wrong. Please consult your shrink."); Console.WriteLine(ex.Message); }

            if (!Repeater.Repeat()) { break; }
        }
    }
}
