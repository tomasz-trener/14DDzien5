using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Wypozyczenie
    {
         public DateTime DataWypozyczenia;
         public DateTime DataPrzewidywanegoZwrotu;
         public DateTime DataRzeczywistegoZwrotu;
         public string Uwagi;
         public Czytelnik Czytelnik;
         public Sygnatura Sygnatura;
         public Wypozyczenie Przedluzenie;
    }
}
