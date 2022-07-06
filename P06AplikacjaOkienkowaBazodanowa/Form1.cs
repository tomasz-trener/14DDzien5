using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06AplikacjaOkienkowaBazodanowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSql_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSql.Checked)
            {
                lblHaslo.Visible = true;
                lblNazwaUzytkownika.Visible = true;
                txtHaslo.Visible = true;
                txtNazwaUzytkownika.Visible = true;
            }
            else
            {
                lblHaslo.Visible = false;
                lblNazwaUzytkownika.Visible = false;
                txtHaslo.Visible = false;
                txtNazwaUzytkownika.Visible = false;
            }
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb;

            if (rbSql.Checked)
                pzb = new PolaczenieZBaza(txtAdresSerwera.Text, txtNazwaBazyDanych.Text, txtNazwaUzytkownika.Text, txtHaslo.Text);
            else
                pzb = new PolaczenieZBaza(txtAdresSerwera.Text, txtNazwaBazyDanych.Text);

            object[][] wynik= pzb.WykonajPolecenieSQL(txtSql.Text);

            dgvDane.Rows.Clear();
            dgvDane.ColumnCount = wynik[0].Length;
            for (int i = 0; i < wynik.Length; i++)
                dgvDane.Rows.Add(wynik[i]);

        }
    }
}
