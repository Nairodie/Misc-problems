using System;
using System.Linq;

public class Program
{
	public static void Main()
	{	
		//easy enough. Set variable to integer. create enum range from 1-999.
		//search through the var using where clause then add them together followed by printing out result.
		//very similar to popular FizzBuzz.
		
		int result;		
		result = Enumerable.Range(1,999)
		.Where(x => x % 3 == 0 || x % 5 == 0).Sum();		
		Console.WriteLine(result);
	}
}
