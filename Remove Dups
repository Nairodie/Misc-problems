using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    class Program 
    {
        static void Main(string[] args)
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
                4,
                6
            };

            foreach (var value in list)
            {
                Console.WriteLine("Before: {0}", value);
            }

            List<int> distinct = list.Distinct().ToList();

            foreach (var value in distinct)
            {
                Console.WriteLine("After: {0}", value);
            }
        }
    }
}
