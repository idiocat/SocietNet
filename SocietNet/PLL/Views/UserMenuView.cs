using SocietNet.BLL.Models;

namespace SocietNet.PLL.Views;

public class UserMenuView
{
    public void Display(User user)
    {
        while (true)
        {
            Console.WriteLine("Type 1 to view your info;\n" +
                "Type 2 to edit your info;\n" +
                "Type 3 to view your fiends;\n" + //net yet
                "Type 4 to send a message;\n" +
                "Type 5 to view recieved messages;\n" +
                "Type 6 to view sent messages;\n" +
                "Type 0 to sign out.");
            switch (Console.ReadKey(true).Key.ToString())
            {
                case "D1" or "NumPad1": Program.userInfoView.Display(user); break;
                case "D2" or "NumPad2": Program.userUpdateView.Display(user); break;
                case "D3" or "NumPad3": Program.fiendViewingView.Display(user); break;
                case "D4" or "NumPad4": Program.messageSendingView.Display(user); break;
                case "D5" or "NumPad5": Program.messageIncomingView.Display(user); break;
                case "D6" or "NumPad6": Program.messageOutcomingView.Display(user); break; // <= social stairway

                case "D0" or "NumPad0": return;
            }
        }
    }
}
