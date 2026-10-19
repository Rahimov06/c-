using System;
using System.Globalization;

public class HelloWorld
{
  public static void Main(string[] args)
  {
    // Истифодаи double.Parse бо CultureInfo.InvariantCulture
    double hourWork = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double hourlyRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (hourWork <= 40)
    {
      Console.WriteLine("Muzdy korgar: " + (hourWork * hourlyRate));
    }
    else if (hourWork > 40)
    {
      double overtimeHours = hourWork - 40;
      double overtimeRate = hourlyRate * 1.5;

      double totalSalary = (overtimeHours * overtimeRate) + (40 * hourlyRate);
      Console.WriteLine("Muzdy korgar bo soathoi ilovagy: " + totalSalary);
    }
  }
}
