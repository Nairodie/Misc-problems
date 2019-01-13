using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDups
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                1,
                2,
                2,
                3,
                4,
                4,
                5,
                3,
                7,
                9,
                6,
                1
            };

            foreach (var value in list)
            {
                Console.WriteLine("Before the duplicates are removed: {0}", value);
            }

            List<int> distinct = list.Distinct().ToList();

            foreach (var value in distinct)
            {
                Console.WriteLine("The Result: {0}", value);
            }
        }
    }
}
