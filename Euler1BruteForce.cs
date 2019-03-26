using System;
					
public class Program
{
	public static void Main()
	{
		//variable result starts @ 0
		var result = 0;
		
		//loop through 1000, starting at 0
		for (var i = 0; i < 1000; i++)
		{
			if (i % 3 == 0 || i % 5 == 0)
			{
			result += i;
			}
		}
		Console.WriteLine(result);
	}
}
