using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04BibliotekaPolaczenieZBaza
{
    public class PolaczenieZBaza
    {
        string connString;

        public PolaczenieZBaza()
        {
            connString = "Data Source =.; Initial Catalog = A_Zawodnicy; User ID = sa; Password = alx";
        }

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public PolaczenieZBaza(string adresServera, string nazwaBazy)
        {
            connString = string.Format("Data Source ={0}; Initial Catalog = {1}; Integrated Security=true",
                adresServera, nazwaBazy);
        }
        public PolaczenieZBaza(string adresServera, string nazwaBazy, string nazwaUzytkownika, string haslo)
        {
            connString = string.Format("Data Source ={0}; Initial Catalog = {1};  User ID = {2}; Password = {3}",
                adresServera, nazwaBazy, nazwaUzytkownika, haslo);
        }


        public WynikRozbudowany WykonajPolecenieSQLZLiczbaStron(string sql, SqlParameter[] parametry = null, CommandType commandType = CommandType.Text)
        {
            SqlConnection connection; // sluzy do komunikacji z baza 
            SqlCommand command; // przechowywanie polecen sql
            SqlDataReader dataReader; // czytanie wyniku z bazy danych 

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);
            command.CommandType = commandType;

            if (parametry != null)
                command.Parameters.AddRange(parametry);

            //command.Parameters.Add("@paramKraj", System.Data.SqlDbType.VarChar);
            //command.Parameters["@paramKraj"].Value = "pol";

            connection.Open();

            dataReader = command.ExecuteReader(); // wysylamy polecenie do bazy danych 

            List<object[]> listaWierszy = new List<object[]>();
            int liczbaKolumn = dataReader.FieldCount;

            while (dataReader.Read())
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = dataReader.GetValue(i); 

                listaWierszy.Add(komorki);
            }

            dataReader.NextResult(); // teraz przechodzimy do drugiego SELECT 
            dataReader.Read(); 

            WynikRozbudowany wynikRozbudowany = new WynikRozbudowany();
            wynikRozbudowany.Wynik = listaWierszy.ToArray();
             wynikRozbudowany.LiczbaStron = (int)dataReader["ile"];
            
            connection.Close();

            return wynikRozbudowany;
        }


        public object[][] WykonajPolecenieSQL(string sql,  SqlParameter[] parametry=null, CommandType commandType = CommandType.Text)
        {
            
            SqlConnection connection; // sluzy do komunikacji z baza 
            SqlCommand command; // przechowywanie polecen sql
            SqlDataReader dataReader; // czytanie wyniku z bazy danych 

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);
            command.CommandType = commandType;
            
            if(parametry != null)
                command.Parameters.AddRange(parametry);
            
            //command.Parameters.Add("@paramKraj", System.Data.SqlDbType.VarChar);
            //command.Parameters["@paramKraj"].Value = "pol";

            connection.Open();

            dataReader = command.ExecuteReader(); // wysylamy polecenie do bazy danych 

            List<object[]> listaWierszy = new List<object[]>();
            int liczbaKolumn = dataReader.FieldCount;

            while (dataReader.Read())
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = dataReader.GetValue(i);

                listaWierszy.Add(komorki);
            }
            connection.Close();

            return listaWierszy.ToArray();

        }
    }
}
