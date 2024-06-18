using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{
    public partial class Form4 : Form
    {
        string kategorija { get; set; }
        string igrac { get; set; }

        public int broj_pitanja = 0;
        public int broj_bodova = 0;


        private List<zadatak> zadataks = new List<zadatak>();

       

        public Form4( string kategorija, string igrac )
        {
            InitializeComponent();
            this.igrac = igrac;
            this.kategorija = kategorija;
            List<zadatak> kviz = new List<zadatak> { };
            kviz = baza_pristup.jedan_kviz( kategorija );
            zadataks = kviz;
            pitanje.Text = zadataks[broj_pitanja].pitanje;
            button1.Text = zadataks[broj_pitanja].odgovori[0];
            button2.Text = zadataks[broj_pitanja].odgovori[1];
            button3.Text = zadataks[broj_pitanja].odgovori[2];
            button4.Text = zadataks[broj_pitanja].odgovori[3];

        }


        public void stanje( int kliknuti )
        {

            if( broj_pitanja < 2 & broj_pitanja+1 != zadataks.Count)
            {

                if( kliknuti == zadataks[broj_pitanja].tocan_odgovor)
                {

                    broj_bodova += 1;

                }

                broj_pitanja += 1;

                pitanje.Text = zadataks[broj_pitanja].pitanje;
                button1.Text = zadataks[broj_pitanja].odgovori[0];
                button2.Text = zadataks[broj_pitanja].odgovori[1];
                button3.Text = zadataks[broj_pitanja].odgovori[2];
                button4.Text = zadataks[broj_pitanja].odgovori[3];

            }

            else
            {

                int ID = baza_pristup.IDigraca( igrac );
                Console.WriteLine( ID );
                Console.WriteLine( this.kategorija + ID.ToString() + broj_bodova.ToString() );
                baza_pristup.azuriaj_podataak(this.kategorija, ID, broj_bodova, "korisnici");
                this.Hide();
                korisnik newform = new korisnik(igrac);
                newform.ShowDialog();
                this.Close();

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {


            stanje(1);


        }

        private void button3_Click(object sender, EventArgs e)
        {


            stanje(3);


        }

        private void button2_Click(object sender, EventArgs e)
        {


            stanje( 2 );


        }

        private void button4_Click(object sender, EventArgs e)
        {

            stanje( 4 );


        }
    }
}
