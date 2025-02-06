namespace SocietNet.PLL.Helpers;

public static class InYellow
{
    public static void Write(string text)
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
        Console.ForegroundColor = originalColor;
    }

    public static void WriteLine(string text) { Write(text + Environment.NewLine); }
}