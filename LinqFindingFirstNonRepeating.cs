using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string results = "Stressed";
		
		//have to use string comparer for capitilization.
        var result = results.GroupBy(y => y.ToString(), StringComparer.CurrentCultureIgnoreCase)
            .Where(y => y.Count() == 1)
            .Select(y => y.Key)
            .FirstOrDefault();

        Console.WriteLine(result);
    }
}
