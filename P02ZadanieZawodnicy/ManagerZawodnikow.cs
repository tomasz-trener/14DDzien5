using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieZawodnicy
{
    internal class ManagerZawodnikow
    {
        //const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        const string url = "c:\\dane\\zawodnicy.txt";
        const string naglowek = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";
        

        public Zawodnik[] Zawodnicy;
      

        public Zawodnik[] WczytajZawodnikow()
        {
            string[] wiersze = new WebClient().DownloadString(url).Split('\n');

            int liczbaWierszy = wiersze.Length - 1;
            Zawodnik[] zawodnicy = new Zawodnik[liczbaWierszy];

            for (int i = 1; i <= liczbaWierszy; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                Zawodnik z = new Zawodnik(komorki);
                zawodnicy[i - 1] = z;
            }

            // zawodnicy z ciała klasy : this
            // domyślnie z metody 
            this.Zawodnicy = zawodnicy;
            return zawodnicy;
        }

        public double PodajSredniWzrost()
        {
            double suma = 0;
            foreach (var z in Zawodnicy)
                suma += z.Wzrost;
            
           // return Math.Round(suma / zawodnicy.Length,2);
            return suma / Zawodnicy.Length;
        }

        internal void Zapisz(string sciezka = "c:\\dane\\zawodnicy.txt")
        {
            StringBuilder sb = new StringBuilder(naglowek);

            foreach (Zawodnik z in Zawodnicy)
                sb.Append(Environment.NewLine+ $"{z.Id_zawodnika};{z.Id_trenera};{z.Imie};{z.Nazwisko};{z.Kraj};{z.DataUrodzenia};{z.Wzrost};{z.Waga}");

            File.WriteAllText(sciezka, sb.ToString());
        }

        internal void Edytuj(Zawodnik z)
        {
            for (int i = 0; i < Zawodnicy.Length; i++)
                if (Zawodnicy[i].Id_zawodnika == z.Id_zawodnika)
                    Zawodnicy[i] = z;
        }

        internal void Usun(Zawodnik z)
        {
            List<Zawodnik> tmpZaw = Zawodnicy.ToList();
            tmpZaw.Remove(z);
            Zawodnicy = tmpZaw.ToArray();
        }
    }
}
