using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class MainView
{
    public void Display()
    {
        Console.WriteLine("Welcome to the SocietNet!");
        while (true)
        {
            Console.WriteLine("Type 1 to sing up;\n" +
                "Type 2 to sing in;\n" +
                "Type 0 to ride into sunset.");
            switch (Console.ReadKey(true).Key.ToString())
            {
                case "D1" or "NumPad1": Program.registrationView.Display(); break;
                case "D2" or "NumPad2": Program.authenticationView.Display(); break;

                case "D0" or "NumPad0": Console.WriteLine("We live in society!"); AnyKey.WaitFor(); return;
            }
        }
    }
}
