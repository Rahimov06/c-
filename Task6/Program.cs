using System;
using System.Collections.Generic;

namespace StudentSearchSystem
{
  // Синф (Class) барои сохтани намуди додаи "Донишҷӯ"
  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
      Id = id;
      Name = name;
      Age = age;
    }

    // Метод барои зебо нишон додани маълумоти донишҷӯ
    public void DisplayInfo()
    {
      Console.WriteLine($"ID: {Id} | Ном: {Name} | Синну сол: {Age}");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      List<Student> students = new List<Student>();

      students.Add(new Student(1, "Алишер", 20));
      students.Add(new Student(2, "Мадина", 19));
      students.Add(new Student(3, "Парвиз", 21));

      bool isRunning = true;

      while (isRunning)
      {
        Console.WriteLine("1. Илова кардани донишҷӯ");
        Console.WriteLine("2. Нест кардани донишҷӯ (аз рӯи ID)");
        Console.WriteLine("3. Ҷустуҷӯ аз рӯи ном");
        Console.WriteLine("4. Нишон додани ҳамаи донишҷӯён");
        Console.WriteLine("5. Баромад");
        Console.Write("Интихоби худро ворид кунед (1-5): ");

        string choice = Console.ReadLine();
        Console.WriteLine(); // Барои ҷои холӣ

        switch (choice)
        {
          case "1":
            Console.Write("ID-и донишҷӯро ворид кунед: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Номи донишҷӯро ворид кунед: ");
            string name = Console.ReadLine();

            Console.Write("Синну соли донишҷӯро ворид кунед: ");
            int age = int.Parse(Console.ReadLine());

            students.Add(new Student(id, name, age));
            Console.WriteLine("Донишҷӯ бо муваффақият илова шуд!");
            break;

          case "2":
            Console.Write("ID-и донишҷӯеро, ки нест кардан мехоҳед, ворид кунед: ");
            int removeId = int.Parse(Console.ReadLine());

            // Ҷустуҷӯи донишҷӯ аз рӯи ID барои несткунӣ
            Student studentToRemove = students.Find(s => s.Id == removeId);

            if (studentToRemove != null)
            {
              students.Remove(studentToRemove);
              Console.WriteLine("Донишҷӯ аз рӯи рӯйхат нест карда шуд.");
            }
            else
            {
              Console.WriteLine("Донишҷӯ бо чунин ID ёфт нашуд!");
            }
            break;

          case "3":
            Console.Write("Ном ё қисми номро барои ҷустуҷӯ ворид кунед: ");
            string searchName = Console.ReadLine();

            List<Student> foundStudents = students.FindAll(s => s.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase));

            if (foundStudents.Count > 0)
            {
              Console.WriteLine("\nНатиҷаҳои ҷустуҷӯ:");
              foreach (var student in foundStudents)
              {
                student.DisplayInfo();
              }
            }
            else
            {
              Console.WriteLine("Ҳеҷ як донишҷӯ бо чунин ном ёфт нашуд.");
            }
            break;

          case "4":
            if (students.Count == 0)
            {
              Console.WriteLine("Рӯйхати донишҷӯён холӣ аст.");
            }
            else
            {
              Console.WriteLine("Рӯйхати умумии донишҷӯён:");
              foreach (var student in students)
              {
                student.DisplayInfo();
              }
            }
            break;

          case "5":
            isRunning = false;
            Console.WriteLine("Барнома анҷом ёфт. Рӯзи хуш!");
            break;

          default:
            Console.WriteLine("Интихоби нодуруст! Лутфан рақамро аз 1 то 5 ворид кунед.");
            break;
        }
      }
    }
  }
}
