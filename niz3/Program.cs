using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[] { 2, 4, 6, 8, 10, 12 };
            int[] c = new int[] { 5, 9, 16, 25, 30, 12 };
            double rezultat = suma(b);
            double rezultat2 = suma2(c);
            Console.WriteLine("Suma unetih brojeva je {0}", rezultat);
            Console.WriteLine("Suma unetih brojeva je {0}", rezultat2);
           

            if (rezultat<rezultat2)
            {
                Console.WriteLine("Suma drugog niza je veca od prvog");
            }
            else if (rezultat== rezultat2)
            {
                Console.WriteLine("Sume su jednake");
            }
            else
            {
                Console.WriteLine("Suma prvog niza je veca od drugog");
            }
            Console.ReadKey();
        }


        static double suma(int[] brojevi)
        {
            double sum = 0;
            foreach (int broj in brojevi)
            {
                sum += broj;
            }
            return sum;
        }

        static double suma2(int[] brojevi)
        {
            double sum = 0;
            foreach (int broj in brojevi)
            {
                sum += broj;
            }
            return sum;
        }

    }
}