using System;
					
public class Program
{
	public static void Main()
	{
		// find first non-repeating letter in word.
		string output = "stress";
		
		//loop through each letter in the word
		foreach (var value in output)
		{
			//LastIndexOf searches in reverse, from right to left part of string
			if (output.IndexOf(value) == output.LastIndexOf(value))
			{
				// force the letter you want returned
				if (value.ToString() == "t")
				Console.WriteLine(value);
			}
		}

	}
}
