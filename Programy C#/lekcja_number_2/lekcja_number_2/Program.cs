using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja_number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Wprowadz liczbę");
            // int a = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Wprowadz liczbę");
            //  int b= Convert.ToInt32(Console.ReadLine());
            //for (a=0;a<100;a++)
            //{
            //Console.WriteLine(a);
            //}

            //Console.ReadKey();

            //    if (a != 50)
            //          Console.WriteLine("Jest git");
            //
            //   else if (a == 50 && b ==60)
            //  Console.WriteLine("Jest Git");
            //  else if (a == 50 || b ==60)
            //  Console.WriteLine("Jest Git");
            //  else
            //  {
            //  Console.WriteLine("Nie jest git");
            //  }

            for (int i = 0; i < 20; i++)
            {
                if (i>10&&i<15)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("THE END");
 int j = 10;
            while(j < 20)
            {
                j = j + 5;
                Console.WriteLine("Time is over");

                
            }

            int x = 20;
            do
            {
                x = x + 2;
                Console.WriteLine(x);

                if (x == 30)
                    continue;

                if (x == 32)
                    break;
                else
                    Console.WriteLine("Nie spelniono");

            }

            while (x <40);

            Console.ReadLine();

           
        }
    }
}
