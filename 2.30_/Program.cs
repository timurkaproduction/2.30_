using System;
public class Mainclass
{
    public static void Main()
    {
        int x = 456;
        int n = x - (x % 100) + ((x % 10) * 10) + (((x % 100) - (x % 10)) / 10);
        Console.WriteLine(n);
    }
}