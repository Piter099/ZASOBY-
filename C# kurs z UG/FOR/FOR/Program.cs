using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Petla for nr1");
            for (int a = 0; a < 400; a++)
            {
                for (int b = a; (b % 2 == 2); b++)
                {

                    Console.WriteLine(b);
                    Console.ReadKey();
                }
            }
           

            
            Console.ReadKey();
        }
    }
}
