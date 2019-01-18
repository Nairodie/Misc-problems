using System;

public class Program
{
    enum Cards
    {
        None,
        Hearts,
        Clubs,
        Spades,
        Diamonds
    }

    public static void Main()
    {
        Cards value = Cards.Diamonds;

        if (value == Cards.Hearts)
        {
            Console.WriteLine("False");
        }
        else if (value == Cards.Diamonds)
        {
            Console.WriteLine("True");
        }
    }
}
