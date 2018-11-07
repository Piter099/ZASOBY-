using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr
{
    class Program
    {
        static void Main(string[] args)
        {

            string logo = "PROGRAM SZYFR";
            Console.SetCursorPosition((Console.WindowWidth - logo.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo);


            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = Int32.Parse(Console.ReadLine());
            string c = "JAN";
            if (a==20 && b == 40)
            {
                Console.WriteLine($"Wpisałeś prawidłowe liczby a hasło to: {c}");
            }
            else
            {
                Console.WriteLine("ZŁE HASŁO");
            }

            for (int d = 0; d < 400; d++)
            {
                for (int e = d;(e%2==2); e++)
                

                
                   Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
