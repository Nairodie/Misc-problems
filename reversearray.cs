using System;
					
public class Program
{
	public static void Main()
	{
		int[] resultsArray = {1,5,15,31,77,101};
	
		for (int i = 0; i < resultsArray.Length/2; i++)
		{
			//create temp variable with the results from the search
			int temp = resultsArray[i];			
			resultsArray[i] = resultsArray[resultsArray.Length - i - 1];			
			resultsArray[resultsArray.Length - i - 1] = temp;
		}
		
		//have to use string join to combine them
		Console.WriteLine(string.Join(",", resultsArray));
	}
}
