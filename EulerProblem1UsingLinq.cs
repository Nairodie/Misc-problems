using System;
using System.Linq;

public class Program
{
	public static void Main()
	{	int result;
		result = Enumerable.Range(1,999).Where(item => item % 3 == 0 || item % 5 == 0).Sum();
		Console.WriteLine(result);
	}
}
