using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SqlInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
          
            Console.WriteLine("Podaj nazwę kraju");
            string kraj = Console.ReadLine();   //pol' or kraj='ger' --

            object[][] wynik=  pzb.WykonajPolecenieSQL(
                $"select * from zawodnicy where kraj = @paramKraj"
                    ,new SqlParameter[] { new SqlParameter() { ParameterName = "@paramKraj", Value = kraj, SqlDbType = System.Data.SqlDbType.VarChar } });


            for (int i = 0; i < wynik.Length; i++)
                Console.WriteLine(String.Join(" ",wynik[i]));
            
            Console.ReadKey();


            // zabezpieczenia aplkiacji bazdownowej przez sql injection:
            // 1) paramametry 
            // 2) procedury wbudowane 
            // 3) mapowanie obiektowo relacyjne 
        }
    }
}
