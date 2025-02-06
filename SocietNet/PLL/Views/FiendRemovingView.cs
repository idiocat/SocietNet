using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class FiendRemovingView
{
    FiendService fiendService;
    public FiendRemovingView(FiendService fiendService) { this.fiendService = fiendService; }
    public void Display(User user, User fiend)
    {
        InYellow.WriteLine("Are you certain? [y/n] ");
        if (Console.ReadKey().Key.ToString() == "Y")
        {
            fiendService.RemoveFiend(user, fiend);
            InGreen.WriteLine("Begone, fiend!");
        }
        else { InGreen.WriteLine("Operation succesfully abandoned."); }
    }
}
