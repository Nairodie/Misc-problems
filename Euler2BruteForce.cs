using System;

//less than four million, find the sum of the even-valued terms.
public class Program
{
	public static void Main()
	{
		int fib1 = 1;
		int fib2 = 1;
		int result = 0;
		int sum = 0;
		
		// loop through 4 million
		while (result <= 4000000)
		{
			if (result % 2 == 0)
			{
			sum = sum + result;
			}
			
			//note that F(n) = F(n - 1) - F(n - 2) is the same as F(n) - F(n - 1) + F(n - 2) = 0
			result = fib1 + fib2;
			//*showing what is happening behind the scenes.
			Console.WriteLine(result);
			fib2 = fib1;
			//*
			Console.WriteLine(fib2);
			fib1 = result;
			//*
			Console.WriteLine(fib1);
		}
		Console.WriteLine(sum);		
	}
}
