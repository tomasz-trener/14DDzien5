using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08SlowoParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 3, 5, 6, 7 };
           
            Suma(liczby);
            Suma(4, 6, 7);
            Suma(7);


        }

        static void Suma(params int[] liczby)
        {
            int suma = 0;
            for (int i = 0; i < liczby.Length; i++)
                suma += liczby[i];

            Console.WriteLine(suma);
        }
    }
}
