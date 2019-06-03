using System;
					
public class Program
{
public static void Main()
{
	int[] myArray = {1,4,6,7,9,11};
	
	for (int i = 0; i < myArray.Length / 2; i++)
	{
		//create temp variable with the results from the search
		int temp = myArray[i];
		myArray[i] = myArray[myArray.Length - i - 1];
		myArray[myArray.Length - i - 1] = temp;
	}
	Console.WriteLine(string.Join(",", myArray));
	}
}
