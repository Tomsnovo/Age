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
            Console.ReadLine();
            
            if (age <= 0)
            {
                Console.WriteLine("neexistuje");
            }
            else if (age <= 15)
            {
                Console.WriteLine("You are a child!");
            }
            else if (age < )
            




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
            Console.Write("╚════════════════════════════════════════╝");
        }
    }
    

}


