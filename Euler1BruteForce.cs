using System;
					
public class Program
{
	public static void Main()
	{
		int result = 0;
		for (int i = 0; i < 1000; i++){
			if (i % 3 == 0 || i % 5 == 0)
			{
				result += i;
			}
		}
		Console.WriteLine(result);
	}
}
