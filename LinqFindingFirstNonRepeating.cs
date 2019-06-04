using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = "Stressed";

        var result = input.GroupBy(y => y.ToString(), StringComparer.CurrentCultureIgnoreCase)
            .Where(y => y.Count() == 1)
            .Select(y => y.Key)
            .FirstOrDefault();

        Console.WriteLine(result);
    }
}
