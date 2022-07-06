using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaBazodanowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // sluzy do komunikacji z baza 
            SqlCommand command; // przechowywanie polecen sql
            SqlDataReader dataReader; // czytanie wyniku z bazy danych 

            string sciezka = "abc\\abc";
            string sciezka2 = @"abc\abc";
            string sciezka3 = "abc\nbc";

            string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";
            connection = new SqlConnection(connString);

            command = new SqlCommand("select * from zawodnicy", connection);
            connection.Open();

            dataReader= command.ExecuteReader(); // wysylamy polecenie do bazy danych 


            while (dataReader.Read())
            {
                string wynik = (string)dataReader.GetValue(2);
                Console.WriteLine(wynik);
            }     
            
            Console.ReadKey();



        }
    }
}
