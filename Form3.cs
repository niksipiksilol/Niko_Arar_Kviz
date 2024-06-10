using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{
    public partial class admin : Form
    {

        public string korisnikovo_ime { get; set; }
        public List<string> kategorijelista = new List<string>() { "Geografija", "Opće znanje", "Videoigrice" };

        public admin(string korisnikovo_ime)
        {
            InitializeComponent();
            this.korisnikovo_ime = korisnikovo_ime;
        }

        private void admin_Load(object sender, EventArgs e)
        {

            this.Text = "Admin: " + this.korisnikovo_ime;

            izbor_kategorije.DataSource = kategorijelista;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            korisnik newform = new korisnik(this.korisnikovo_ime);
            newform.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void potvrda_unosa_Click(object sender, EventArgs e)
        {

            if (pitanje.Text.Trim() != "" & odg1.Text.Trim() != "" & odg2.Text.Trim() != "" & odg3.Text.Trim() != "" & odg4.Text.Trim() != "" & izbor_kategorije.Text.Trim() != "")
            {


                baza_pristup a = new baza_pristup();
                a.upisi_u_tablicu("kvizovi ([Pitanje], [Odgovor1], [Odgovor2], [Odgovor3], [Odgovor4], Tocan_odgovor, [Ime_kviza])", "('" + pitanje.Text + "', '" + odg1.Text + "', '" + odg2.Text + "', '" + odg3.Text + "', '" + odg4.Text + "', " + broj_odgovora.Text + ", '" + izbor_kategorije.Text + "')");
                pitanje.Text = "";
                odg1.Text = "";
                odg2.Text = "";
                odg3.Text = "";
                odg4.Text = "";
                broj_odgovora.Text = "";

            }
            else
            {

                MessageBox.Show("Neuspješan unos, postoje prazna mjesta!");

            }
        }
    }
}
