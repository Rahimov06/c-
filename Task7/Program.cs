using System;
using System.Collections.Generic;

namespace PhoneBookSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> phoneBook = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

      phoneBook.Add("Алишер", "+992900112233");
      phoneBook.Add("Мадина", "+992500445566");
      phoneBook.Add("Парвиз", "+992933778899");

      bool isRunning = true;

      while (isRunning)
      {
        try
        {
          Console.WriteLine("\n--- КИТОБИ ТЕЛЕФОНӢ ---");
          Console.WriteLine("1. Илова кардани рақам");
          Console.WriteLine("2. Ҷустуҷӯи рақам аз рӯи ном");
          Console.WriteLine("3. Тағйир додани рақами мавҷуда");
          Console.WriteLine("4. Нест кардани рақам");
          Console.WriteLine("5. Нишон додани ҳамаи рақамҳо");
          Console.WriteLine("6. Баромад");
          Console.Write("Интихоби худро ворид кунед (1-6): ");

          string choice = Console.ReadLine();
          Console.WriteLine();

          switch (choice)
          {
            case "1":
              Console.Write("Номи шахсро ворид кунед: ");
              string newName = Console.ReadLine().Trim();

              if (string.IsNullOrEmpty(newName))
              {
                Console.WriteLine("Ном наметавонад холӣ бошад!");
                break;
              }

              if (phoneBook.ContainsKey(newName))
              {
                Console.WriteLine("Ин ном аллакай мавҷуд аст! Барои тағйир додан аз менюи 3 истифода баред.");
              }
              else
              {
                Console.Write("Рақами телефонро ворид кунед: ");
                string newPhone = Console.ReadLine().Trim();

                phoneBook.Add(newName, newPhone);
                Console.WriteLine($"Рақами {newName} бо муваффақият илова шуд.");
              }
              break;

            case "2":
              Console.Write("Номеро, ки ҷустуҷӯ доред, ворид кунед: ");
              string searchName = Console.ReadLine().Trim();

              if (phoneBook.TryGetValue(searchName, out string foundPhone))
              {
                Console.WriteLine($"Рақами телефони {searchName}: {foundPhone}");
              }
              else
              {
                Console.WriteLine("Чунин шахс дар китоби телефонӣ ёфт нашуд.");
              }
              break;

            case "3":
              Console.Write("Номи шахсеро, ки рақамашро тағйир додан мехоҳед, ворид кунед: ");
              string editName = Console.ReadLine().Trim();

              if (phoneBook.ContainsKey(editName))
              {
                Console.Write("Рақами навро ворид кунед: ");
                string updatedPhone = Console.ReadLine().Trim();

                phoneBook[editName] = updatedPhone; // Навсозии қимат
                Console.WriteLine($"Рақами {editName} бо муваффақият тағйир дода шуд.");
              }
              else
              {
                Console.WriteLine("Чунин шахс ёфт нашуд!");
              }
              break;

            case "4":
              Console.Write("Номи шахсеро, ки нест кардан мехоҳед, ворид кунед: ");
              string removeName = Console.ReadLine().Trim();

              if (phoneBook.Remove(removeName))
              {
                Console.WriteLine($"Маълумоти {removeName} бо муваффақият нест карда шуд.");
              }
              else
              {
                Console.WriteLine("Чунин... шахс ёфт нашуд!");
              }
              break;

            case "5":
              if (phoneBook.Count == 0)
              {
                Console.WriteLine("Китоби телефонӣ холӣ аст.");
              }
              else
              {
                Console.WriteLine("Рӯйхати умумии телефонҳо:");
                foreach (KeyValuePair<string, string> contact in phoneBook)
                {
                  Console.WriteLine($"Ном: {contact.Key} -> Тел: {contact.Value}");
                }
              }
              break;

            case "6":
              isRunning = false;
              Console.WriteLine("Барнома анҷом ёфт. Саломат бошед!");
              break;

            default:
              Console.WriteLine("Интихоби нодуруст! Рақамро аз 1 то 6 ворид кунед.");
              break;
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Хатогии техникӣ рӯй дод: {ex.Message}");
          Console.WriteLine("Лутфан аз нав кӯшиш кунед.");
        }
      }
    }
  }
}
