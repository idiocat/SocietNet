using SocietNet.BLL.Services;
using SocietNet.BLL.Models;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class FiendViewingView
{
    FiendService fiendService;
    UserService userService;
    public FiendViewingView(FiendService fiendService, UserService userService)
    { 
        this.fiendService = fiendService;
        this.userService = userService;
    }
    public void Display(User user)
    {
        List<Fiend>? fiendsList = fiendService.GetFiendsList(user);
        if (fiendsList == null)
        {
            InRed.WriteLine("You have no fiends!");
            InYellow.WriteLine("Add a fiend? [y/n] ");
            if (Console.ReadKey(true).Key.ToString() == "89") { Program.fiendAddingView.Display(user); }
        }
        else
        {
            Pages pages = new Pages((int)(fiendsList.Count / 10));

            while (true)
            {
                InYellow.WriteLine("Type fiend's number to view details.\n" +
                    "Type Q or E to navigate.\n" +
                    "Type A to add a fiend.\n" +
                    "Type W to walk away.");
                IEnumerable<Fiend> fiendsListCurrentPage = fiendsList.Skip(10 * pages.Current).Take(10);
                List<string> fiendsListCurrentPageNames = new List<string>();
                foreach (Fiend fiend in fiendsListCurrentPage)
                {
                    User fiendOfUser = userService.FindById(fiend.FiendId);
                    fiendsListCurrentPageNames.Add($"{fiendOfUser.Frontname} {fiendOfUser.Lastname}");
                }
                for (int i = 0; i < fiendsListCurrentPageNames.Count; i++)
                { Console.WriteLine($"{i}. {fiendsListCurrentPageNames[i]}"); }
                
                switch (Console.ReadKey(true).Key.ToString())
                {
                    case "D0" or "NumPad0":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[0].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D1" or "NumPad1":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[1].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D2" or "NumPad2":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[2].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D3" or "NumPad3":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[3].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D4" or "NumPad4":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[4].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D5" or "NumPad5":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[5].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D6" or "NumPad6":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[6].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D7" or "NumPad7":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[7].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D8" or "NumPad8":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[8].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;
                    case "D9" or "NumPad9":
                        try { Program.fiendDetailedView.Display(user, fiendsListCurrentPage.ToList()[9].FiendId); }
                        catch (ArgumentOutOfRangeException) { }
                        break;

                    case "69"/* E */: pages.Current++; break; 
                    case "81"/* Q */: pages.Current--; break; 
                    case "65"/* A */: Program.fiendAddingView.Display(user); break; 
                    
                    case "87"/* W */: return;
                }
            }
        }
    }
}


