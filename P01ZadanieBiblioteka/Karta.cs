using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Karta
    {
        public string Numer;
        public Sygnatura[] Sygnatury;
        public DateTime DataZakupu;
        public Karta Nastepna;
        public Karta Poprzednia;
        public Cena Cena;
        public int Wydanie;
        public Autor[] Autorzy;
        public string Tytul;
    }
}
