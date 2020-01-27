using System;
					
public class Program
{
	public static void Main()
	{
		var input = "Stress";
		
		foreach (var result in input)
		{
			Console.WriteLine(result);
			if (result.ToString() == "t")
			{
				Console.WriteLine("True");
			}
			else if (result.ToString() != "t")
			{
				Console.WriteLine("False");
			}				
		}
	}
}
