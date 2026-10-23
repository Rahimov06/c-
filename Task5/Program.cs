using System;

class Program
{
  static void Main()
  {
    int toTalSTudent = 20;
    int PassingGradeLimit = 50;
    int maxGrade = 0;
    int minGrade = 100;
    int avaregeGarde = 0;
    int passedCount = 0;
    int failedCount = 0;
    for (int i = 0; i < toTalSTudent; i++)
    {
      int grade = Convert.ToInt32(Console.ReadLine());

      avaregeGarde += grade;

      if (grade > PassingGradeLimit)
      {
        passedCount++;
      }
      else
      {
        failedCount++;
      }
      if (grade > maxGrade)
      {
        maxGrade = grade;
      }
      if(grade < minGrade)
      {
        minGrade = grade;
      }
    }

    Console.WriteLine("Shumorai Donishjuyony Komyob: " + passedCount);
    Console.WriteLine("Shumorai Donishjuyony Nokom: " + failedCount);
    Console.WriteLine("Bahoi Pasttarin: " + minGrade);
    Console.WriteLine("Bahoi miyona: " + avaregeGarde / toTalSTudent);
    Console.WriteLine("Bahoi balandtarin: " + maxGrade);

  }
}
