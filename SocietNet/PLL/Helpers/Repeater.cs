namespace SocietNet.PLL.Helpers;

public static class Repeater
{
    public static bool Repeat()
    {
        InYellow.WriteLine("Repeat? [y/n] ");
        if (Console.ReadKey(true).Key.ToString() == "89") { return true; }
        else { return false; }
    }
}
