using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementOOP
{
  class Student
  {
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName
    {
      get { return _firstName; }
      set
      {
        if (!string.IsNullOrWhiteSpace(value)) _firstName = value;
        else throw new ArgumentException("Ном наметавонад холӣ бошад!");
      }
    }

    public string LastName
    {
      get { return _lastName; }
      set
      {
        if (!string.IsNullOrWhiteSpace(value)) _lastName = value;
        else throw new ArgumentException("Насаб наметавонад холӣ бошад!");
      }
    }

    public int Age
    {
      get { return _age; }
      set
      {
        if (value > 0 && value < 100) _age = value;
        else throw new ArgumentException("Синну сол бояд байни 1 то 100 бошад!");
      }
    }

    public List<int> Grades { get; set; }

    public Student(string firstName, string lastName, int age)
    {
      FirstName = firstName; // Истифодаи хосият барои вализатсия
      LastName = lastName;
      Age = age;
      Grades = new List<int>(); // Инициализатсияи рӯйхати баҳоҳо
    }


    public void AddGrade(int grade)
    {
      if (grade >= 1 && grade <= 5) // Фарз мекунем системаи баҳодиҳии 5-бала аст
      {
        Grades.Add(grade);
        Console.WriteLine($"Баҳои {grade} ба донишҷӯ {FirstName} илова шуд.");
      }
      else
      {
        Console.WriteLine("Хато: Баҳо бояд аз 1 то 5 бошад!");
      }
    }

    public double CalculateAverageGrade()
    {
      if (Grades.Count == 0) return 0; // Агар баҳо надошта бошад

      return Grades.Average();
    }

    public void DisplayInfo()
    {
      string gradesList = Grades.Count > 0 ? string.Join(", ", Grades) : "баҳо надорад";
      Console.WriteLine($"Донишҷӯ: {LastName} {FirstName} | Синну сол: {Age}");
      Console.WriteLine($"Баҳоҳо: [{gradesList}] | Баҳои миёна: {CalculateAverageGrade():F2}");
      Console.WriteLine(new string('-', 40));
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("--- СИСТЕМАИ ИДОРАКУНИИ ДОНИШҶӮЁН (ООП) ---\n");

      try
      {
        Student student1 = new Student("Алишер", "Каримов", 20);
        Student student2 = new Student("Мадина", "Раҳимова", 19);

        Console.WriteLine($"--- Иловаи баҳоҳо барои {student1.FirstName} ---");
        student1.AddGrade(5);
        student1.AddGrade(4);
        student1.AddGrade(5);

        Console.WriteLine($"\n--- Иловаи баҳоҳо барои {student2.FirstName} ---");
        student2.AddGrade(3);
        student2.AddGrade(4);
        student2.AddGrade(4);

        Console.WriteLine("\n--- МАЪЛУМОТИ УМУМИИ ДОНИШҶӮЁН ---\n");
        student1.DisplayInfo();
        student2.DisplayInfo();

        Console.WriteLine("Кӯшиши сохтани донишҷӯ бо синну соли нодуруст:");
        Student badStudent = new Student("Парвиз", "Ҳакимов", -5); // Ин боиси хатогӣ мешавад
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine($"\n[ХАТОГИИ ВАЛИДАТСИЯ]: {ex.Message}");
      }

      Console.ReadLine();
    }
  }
}
