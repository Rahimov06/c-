using System;

public class HelloWorld
{
  public static void Main(string[] args)
  {
    int a = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();
    int b = Convert.ToInt32(Console.ReadLine());
    if (s == "+")
    {
      Console.WriteLine(a + b);
    }
    else if (s == "-")
    {
      Console.WriteLine(a - b);
    }
    else if (s == "*")
    {
      Console.WriteLine(a * b);
    }

    else if (s == "/")
    {
      Console.WriteLine(a / b);
    }

    else if ( s== "%")
    {
      Console.WriteLine(a % b);
    }

  }
}
