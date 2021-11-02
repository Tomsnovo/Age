using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearStr = DateTime.UtcNow.ToString("yyyy");
            int year = int.Parse(yearStr);
            int birth;

            Console.Clear();
            frame(10, 10);
            Console.SetCursorPosition(12, 11);
            Console.WriteLine("Age calculator");
            Console.WriteLine();
            Console.SetCursorPosition(11, 12);
            Console.WriteLine($" Current year is {year}");
            Console.SetCursorPosition(11, 13);
            Console.WriteLine(" Enter year of birth ");
            Console.SetCursorPosition(12, 14);
            birth = int.Parse(Console.ReadLine());
            int age = (year - birth);
            Console.SetCursorPosition(12, 15);
            Console.WriteLine($"You are {age} years old!");

            Console.SetCursorPosition(12, 16);
            if (age <= 0 && age > 120)
            {
                Console.WriteLine("neexistuje");
            }
            else if (age <= 18 && age > 0)
            {
                Console.WriteLine("You are a child!");
            }
            else if (age <= 65 && age > 18)
            {
                Console.WriteLine("You are an adult!");
            }
            else if (age > 65 && age < 120)
            {
                Console.WriteLine("You are a pensioner!");
            }
            

        }
        static void frame(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.SetCursorPosition(left, top);
            Console.Write("╔════════════════════════════════════════╗");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 2);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 3);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 5);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 6);
            Console.Write("║                                        ║");
            Console.SetCursorPosition(left, top + 7);
            Console.Write("╚════════════════════════════════════════╝");
        }
    }
    

}


