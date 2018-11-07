using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_objętość
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz spośród wyborów : 1-delta , 2-objętość , 3-kalkulator");
            int wybor = Convert.ToInt32(Console.ReadLine()) ;
            switch (wybor)
            {
                case 1:
                    int a, b, c;
                    double del, x1, x2;
                    Console.WriteLine("Wprowadż współczynnik a");
                    a = System.Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Wprowadż współczynnik b");
                    b = System.Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Wprowadż współczynnik c");
                    c = System.Int32.Parse(Console.ReadLine());

                    del = Math.Pow(b, 2) - 4 * a * c;
                    Console.WriteLine($"Delta wynosi: {del}");

                    if (del == 0)
                    {
                        x1 = -b / 2 * a;
                        Console.WriteLine($"Miejsce zerowe wynosi: {x1}");
                    }
                    else if (del > 0)
                    {
                        x1 = -b - Math.Sqrt(del) / 2 * a;
                        x2 = -b + Math.Sqrt(del) / 2 * a;
                        Console.WriteLine($"Miejsca zerowe funkcji wynoszą x1 ={x1} , x2={x2}");
                    }
                    else
                    {
                        Console.WriteLine("Nie miejsc zerowych");
                    }
                    break;
                case 2:

                    break;
                case 3:
                    Console.WriteLine("Wprowadz pierwszą liczbę");
                    double liczba1=System.Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Wprowadz drugą liczbę");
                    double liczba2 = System.Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj znak działania : 1.[+] 2.[-] 3/[/] 4.[*] 5.[%]");

                    int wyb=Convert.ToInt32(Console.ReadLine());

                    double wyn;
                    switch (wyb)
                    {
                        case 1:
                            wyn = liczba1 + liczba2;
                            Console.Write($"Wynik dodawania wynosi: {wyn}");
                            break;
                    }


                    break;
            }
           
            Console.ReadKey();
        }
    }
}
