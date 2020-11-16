using System;
namespace Adhoc
{
  static void Main()
  {
  string[] array = { "mom" };
  foreach (var item in array)
  {
    Console.WriteLine("{0} = {1}", item, isPalindrome(item));
  }
  
  public static bool IsPalindrome(string x)
  {
    int min = 0;
    int max = x.Length - 1;
    while (true)
    {
      if (min > max)
      {
        return true;
      }
      char a = x[min];
      char b = x[max];
      
      if (char.ToLower(a) != char.ToLower(b))
      {
         return false;
      }
      min += 1;
      max -= 1;
    }
  }
}
