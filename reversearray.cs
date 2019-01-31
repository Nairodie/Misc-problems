using System;
					
public class Program
{
public static void Main()
{
	//create int array
	int[] myArray = {1,3,5,7,9,11};
	
	//search through new array created
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
