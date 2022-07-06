using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05TestowaniePolaczeniaZBaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik= pzb.WykonajPolecenieSQL("select * from zawodnicy");

            for (int i = 0; i < wynik.Length; i++)
                Console.WriteLine(String.Join(" ", wynik[i]));

            Console.ReadKey();
        }
    }
}
