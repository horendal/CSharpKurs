using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }


        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo. Jesteś pełnoletni, możesz pić piwo.");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek.");
            }
            else
            {
                Console.WriteLine("Możemy Ci zaoferować mleko.");
            }
        }

        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
