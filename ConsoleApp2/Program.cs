using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("Wprowadź wiek: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            
            if (age > 18)
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś niepełnoletni");
            }

            Console.ReadKey();

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            
        }
    }
}
