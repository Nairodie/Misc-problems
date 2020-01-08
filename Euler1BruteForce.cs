using System;
					
public class Program
{
	public static void Main()
	{
		var results = 0;		
		
		//iterative through 1000
		for (var i = 0; i < 1000; i++)
		{			
			if (i % 3 == 0 || i % 5 == 0)
			{
			results = results + i;
			}
		}
		Console.WriteLine(results);
	}
}
