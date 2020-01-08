using System;
					
public class Program
{
	public static void Main()
	{
		string output = "Stress";
		
		foreach (var value in output)
		{
			//using index of to compare first and last of the string
			if (output.IndexOf(value) == output.LastIndexOf(value))
			{
				//needs to be manipulated as returns blank string if double value found (s)
				if (value.ToString() == "s")
				Console.WriteLine(value);
			}
		}

	}
}
