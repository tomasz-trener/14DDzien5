using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02ZadanieZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            mz = new ManagerZawodnikow();
            lbDane.DataSource = (Zawodnik[])mz.WczytajZawodnikow();
            lbDane.DisplayMember = "DaneZeWzrostem";

            //for (int i = 0; i < zawodnicy.Length; i++)
            //    lbDane.Items.Add(zawodnicy[i].Nazwisko);

            //txtSredniWzrost.Text =
            //    Convert.ToString(mz.PodajSredniWzrost());
            txtSredniWzrost.Text =
                String.Format("{0:000.00}",mz.PodajSredniWzrost());

        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik z = lbDane.SelectedItem as Zawodnik;
            // MessageBox.Show(z.Nazwisko);
            UzupelnijPolaZawodnika(z);
        }

        private void UzupelnijPolaZawodnika(Zawodnik z)
        {
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            dtpDataUrodzenia.Value = z.DataUrodzenia;
            numWaga.Value = z.Waga;
            numWzrost.Value = z.Wzrost;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "c:\\dane";
            sfd.Title = "Wskaż miejsce zapisu zawodnikow";
            // sfd.DefaultExt = ".txt";
            sfd.Filter = "Txt files (*.txt)|*.txt";
            sfd.FileName = "Zawodnicy.txt";
            if(sfd.ShowDialog()== DialogResult.OK)
                mz.Zapisz(sfd.FileName);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpDataUrodzenia.Value;
            z.Wzrost = Convert.ToInt32(numWzrost.Value);
            z.Waga = Convert.ToInt32(numWaga.Value);

            mz.Edytuj(z);
            Odswiez();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik z = (Zawodnik)lbDane.SelectedItem;
            mz.Usun(z);
            Odswiez();
        }

        private void Odswiez()
        {
            lbDane.DataSource = mz.Zawodnicy;
            lbDane.DisplayMember = "";
            lbDane.DisplayMember = "DaneZeWzrostem";
        }
    }
}


//www.tomaszles.pl/db