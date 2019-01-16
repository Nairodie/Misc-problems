using System;
					
public class Program
{
	public static void Main()
	{
		//fibonci even numbers under 4000000
		int fib1 = 1;
		int fib2 = 1;
		int result = 0;
		int sum = 0;
		
    		//loop through all number under 4000000
		while(result < 4000000)
		{
			if (result % 2 == 0)
			{
				sum = sum + result;
			}
			
			//F(n)=F(n-1)+F(n-2)
			result = fib1 + fib2;
			fib2 = fib1;
			fib1 = result;
		}
		Console.WriteLine(sum);		
	}
}
