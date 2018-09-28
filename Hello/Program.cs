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
            valueTypes();

            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        /// <summary>
        /// Wypisuje min i max wartości typów.
        /// </summary>
        private static void valueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt + "\nminInt = " + minInt + "\nmaxLong = " + maxLong + "\nminLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia.
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        
        /// <summary>
        /// Wypisuje komunikat zależnie od wieku.
        /// </summary>
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

        /// <summary>
        /// Wpisujemy powitanie użytkownika i pytam o Imię.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
