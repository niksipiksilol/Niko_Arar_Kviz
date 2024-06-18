using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{
    public partial class Prijava : Form
    {



        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<bool> prijava = baza_pristup.bazapristupkorisnici(ime_upis.Text, sifra_textbox.Text);
            if (prijava[1])
            {
                if (prijava[0])
                {
                    this.Hide();
                    admin newform = new admin(ime_upis.Text);
                    newform.ShowDialog();
                    this.Close();

                }
                else
                {
                    this.Hide();
                    korisnik newform = new korisnik(ime_upis.Text);
                    newform.ShowDialog();
                    this.Close();
                }



            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sifra_textbox.UseSystemPasswordChar)
            {

                sifra_textbox.UseSystemPasswordChar = false;

            }
            else
            {

                sifra_textbox.UseSystemPasswordChar = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Registracija novaforma = new Registracija();
            novaforma.Show();

        }
    }
}
