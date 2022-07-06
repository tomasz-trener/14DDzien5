using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    //https://github.com/tomasz-trener/14DDzien4
    // https://github.com/tomasz-trener/14DDzien5
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta();
            k.Tytul = "abc";

            Karta k2 = new Karta()
            {
                Tytul = "O kurdlach dla opornych",
                Numer= "1308/00",
                Wydanie=1,
                Autorzy = new Autor[]
                {
                    new Autor()
                    {
                        Imie="L",
                        Nazwisko="Tarantoga",
                        DrugieImie="A"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko="Tichy"
                    }
                },
                Cena = new Cena()
                {
                    Wartosc = 17.5,
                    Komentarz = "(zakup z 18.08 – 20, 00)"
                },
                Sygnatury = new Sygnatura[] 
                {
                    new Sygnatura()
                    {
                         Numer=12371,
                         Aktywna=false,
                         Komentarz = "(zgłoszona utrata 01.05.2000)",
                         Wypozyczenia = new Wypozyczenie[]
                         {
                             new Wypozyczenie()
                             {
                                 Czytelnik = new Czytelnik()
                                 {
                                     NumerCzytelnika = "B2354",
                                 },
                                 DataWypozyczenia = new DateTime(2000,2,22),
                                 DataPrzewidywanegoZwrotu= new DateTime(2000,3,7),
                                 Uwagi="06.03.2000 Zgoda na przedłużenie",
                                 Przedluzenie = new Wypozyczenie()
                                 {
                                     DataPrzewidywanegoZwrotu = new DateTime(2000,3,15),
                                     DataRzeczywistegoZwrotu = new DateTime(2000,3,5)
                                 }
                             }
                         }  
                    }
                }

            };











        }
    }
}
