namespace SocietNet.PLL.Helpers;

public static class AnyKey
{
    public static void WaitFor()
    {
        InYellow.WriteLine("Press any key to proceed. ");
        Console.ReadKey(true);
    }
}
