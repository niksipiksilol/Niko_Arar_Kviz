using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{

    public static class baza_pristup
    {
        public static string poveznica = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:..\\..\\kviz_podatci.mdb";




        public static void upisi_u_tablicu(string tablica, string unos)
        {

            OleDbConnection konekcija;
            konekcija = new OleDbConnection(poveznica);
            OleDbCommand komadna = new OleDbCommand("INSERT INTO " + tablica + " VALUES " + unos);
            komadna.Connection = konekcija;
            try
            {

                konekcija.Open();
                komadna.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        public static OleDbDataReader citac(string komanda)
        {

            OleDbConnection konekcija;
            konekcija = new OleDbConnection(poveznica);
            konekcija.Open();

            OleDbDataReader reader;
            OleDbCommand cmd = new OleDbCommand(komanda, konekcija);
            reader = cmd.ExecuteReader();

            return reader;
        }


        public static List<igrac> top_3_igraca( string kategorija)
        {
            string ime;
            int rezultat;

            List<string> list = new List<string>() { "Geografija", "Opće", "Videoigrice" };
            int index = list.IndexOf(kategorija);
            index = index + 4;


            List<igrac> top_3_ = new List<igrac>();
            OleDbDataReader reader = null;
            reader = citac("SELECT * from korisnici");
            igrac a;
            while ( reader.Read() )
            {
                ime = reader[1].ToString();
                rezultat = int.Parse(reader[index].ToString());
                a = new igrac(ime, rezultat);
                top_3_.Add(a);

            }

            return top_3_; 

        } 

        public static int IDigraca( string ime )
        {
            int ID = 0;

            OleDbDataReader oleDbDataReader = null;
            oleDbDataReader = citac("SELECT ID from  korisnici WHERE ime='" + ime + "'");

            while ( oleDbDataReader.Read()) 
            {

                ID = int.Parse(oleDbDataReader[0].ToString());

            }

            return ID;

        }


        public static void azuriaj_podataak( string kategorija, int ID, int bodovi, string tablica )
        {


            OleDbConnection konekcija;
            konekcija = new OleDbConnection(poveznica);
            string naredba  = "UPDATE " + tablica + " SET " + kategorija + " ='" + bodovi + "' WHERE ID=" + ID;
            OleDbCommand komadna = new OleDbCommand("UPDATE " + tablica + " SET " + kategorija+ " ='" + bodovi + "' WHERE ID="+ID);
            komadna.Connection = konekcija;
            try
            {

                konekcija.Open();
                komadna.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }

        public static List<zadatak> jedan_kviz( string kategorija ) 
        {
            zadatak p;
            string pitanj;
            int tocan;
            List<zadatak> zad = new List<zadatak>();
            OleDbDataReader r = null;
            r = citac("SELECT * from kvizovi WHERE Ime_Kviza='" + kategorija + "'");
            while (r.Read())
            {

                List<string> odgovori = new List<string>();
                odgovori.Add(r[1].ToString());
                odgovori.Add(r[2].ToString());
                odgovori.Add(r[3].ToString());
                odgovori.Add(r[4].ToString());
                tocan = int.Parse(r[5].ToString());
                pitanj = r[0].ToString();
                p = new zadatak(pitanj, odgovori, tocan);
                zad.Add(p);

            }

            return zad;
        }

    

        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<bool> bazapristupkorisnici(string ime, string sifra)
        {
            bool postoji = false;
            List<bool> bools = new List<bool>();
            bools.Add(false);
            bools.Add(false);
            OleDbDataReader reader = null;
            reader = citac("SELECT Admin from  korisnici WHERE ime='" + ime + "'");
            while (reader.Read())
            {
                postoji = true;
                if (reader[0].ToString() == "True")
                {
                    bools[0] = true;

                }

            }
            if (!postoji)
            {

                MessageBox.Show("Korisnik ne postoji!");
                return bools;
            }

            OleDbDataReader citac2 = null;
            citac2 = citac("SELECT sifra from  korisnici WHERE ime='" + ime + "'");

            while (citac2.Read())
            {

                if (citac2[0].ToString() == sifra)
                {

                    bools[1] = true;
                }
                else
                {

                    MessageBox.Show("Pogrešna šifra!");
                    return bools;
                }

            }

            return bools;

        }


    }
}
