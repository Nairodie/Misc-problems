using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = "stress";
        var results = input.GroupBy(x => x);

        foreach (var value in results)
        {
            Console.WriteLine("Character " + value.Key 
                + ": " + value.Count() + " times");
        }
    }
}
