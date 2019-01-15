using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		string input = "Stress";
		
		var result = input
			.GroupBy(x => x.ToString(),StringComparer.CurrentCultureIgnoreCase)
			.Where(y => y.Count()==1)
			.Select(y => y.Key)
			.FirstOrDefault();
		Console.WriteLine(result);
	}
}
