using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warunek_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Wynik mnożenia wynosi {a * b}");

            if (a + b >= 15)
            {
                Console.WriteLine($"Wynik {a + b} jest większy od 15");
            }
            else
            {
                Console.WriteLine($"Suma mniejsza od 15");
            }

            Console.ReadKey();
        }
    }
}
