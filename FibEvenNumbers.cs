using System;
					
public class Program
{
	public static void Main()
	{ 
		int fib1 = 1;
		int fib2 = 1;
		int result = 0;
		int sum = 0;
		
		while (result < 4000000)
		{
			if (result % 2 == 0)
			{
				sum += result;
			}
			
			result = fib1 + fib2;
			fib2 = fib1;
			fib1 = result;
		}
		Console.WriteLine(sum);		
	}
}
