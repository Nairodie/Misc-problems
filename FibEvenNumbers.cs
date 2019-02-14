using System;
					
public class Program
{
	//fibonci even numbers under 4000000 added together
	public static void Main()
	{
		//variables 
		int fib1 = 1, fib2 = 1, result = 0, sum = 0;
		
    		//loop through all number under 4000000
		while (result < 4000000)
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
