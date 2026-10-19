using System;

public class HelloWorld
{
  public static void Main(string[] args)
  {
    int baho = Convert.ToInt32(Console.ReadLine());
    if (baho >= 90 && baho <= 100)
    {
      Console.WriteLine("Аъло");
    }
    else if (baho >= 75 && baho < 90)
    {
      Console.WriteLine("Хуб");
    }
    else if (baho >= 50 && baho < 75 )
    {
      Console.WriteLine("Қаноатбахш");
    }

    else if (baho < 50 )
    {
      Console.WriteLine("Ноком");
    }

  }
}

