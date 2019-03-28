using System;
					
public class Program
{
	public static void Main()
	{
		double width, height, woodLength, glassArea;
		
		const double Max_Width = 5.0;
		const double Min_Width = 0.5;
		const double Max_Height = 3.0;
		const double Min_Height = 0.75;
		
		string widthString, heightString;
		
		Console.WriteLine("Width of the window : ");
		widthString = Console.ReadLine();
		width = double.Parse(widthString);
		
		if (width < Min_Width)
		{
			Console.WriteLine("Width is too small. \n");
			Console.WriteLine("Using minium");
			width = Min_Width;
		}
		
		if (width > Max_Width)
		{
			Console.WriteLine("Width is too large.");
			Console.WriteLine("Using Maximun");
			width = Max_Width;
		}
		
		Console.Write("Give the height of the window :");
		heightString = Console.ReadLine();
		height = double.Parse(heightString);
		
		if (height < Min_Height)
		{
			Console.WriteLine("Height is too small");
			Console.WriteLine("Using minimun");
			height = Min_Height;
		}
		
		if (height > Max_Height)
		{
			Console.WriteLine();
			Console.WriteLine();
			height = Max_Height;
		}
		
		woodLength = 2 * (width + height) * 3.25;
		glassArea = 2 * (width * height);
		
	}
}
