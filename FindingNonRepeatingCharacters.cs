using System;
					
public class Program
{
	public static void Main()
	{
		string output = "stress";
		
		foreach (var value in output)
		{
			if (output.IndexOf(value) == output.LastIndexOf(value))
			{
				if (value.ToString() == "t")
				Console.WriteLine(value);
			}
		}

	}
}
