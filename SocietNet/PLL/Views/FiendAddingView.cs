using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class FiendAddingView
{
    UserService userService;
    FiendService fiendService;
    public FiendAddingView(UserService userService, FiendService fiendService)
    {
        this.userService = userService;
        this.fiendService = fiendService;
    }
    public void Display(User user)
    {
        FiendApplication fiendApplication = new FiendApplication();
        fiendApplication.UserId = user.Id;
        InYellow.Write("Enter future fiend's soap: ");
        fiendApplication.FiendSoap = Console.ReadLine();
        fiendService.AddFiend(fiendApplication);
        InGreen.WriteLine("Fiend added.");
    }
}
