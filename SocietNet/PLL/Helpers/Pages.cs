namespace SocietNet.PLL.Helpers;

public class Pages
{
    public int current;
    public int Current
    {
        get { return current; }
        set
        {
            current = value;
            if (current < 0) { current = Total; }
            if (current > Total) { current = 0; }
        }
    }
    public int Total { get; set; }
    public Pages(int totalPages)
    {
        Total = totalPages;
        Current = 0;
    }
}