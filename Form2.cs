using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{
    public partial class korisnik : Form
    {
        public List<string> kategorijelista = new List<string>() { "Geografija", "Opće znanje", "Videoigrice" };
        public string korisnikovo_ime { get; set; }
        public korisnik(string korisnikovo_ime)
        {
            InitializeComponent();
            this.korisnikovo_ime = korisnikovo_ime;

        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void korisnik_Load(object sender, System.EventArgs e)
        {

            this.Text = "Korisnik: " + this.korisnikovo_ime;
            izborkvizova.DataSource = kategorijelista;

        }

        private void izborkvizova_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            baza_pristup a = new baza_pristup();
            List<igrac> prva3 = new List<igrac>();
            prva3 = a.top_3_igraca(izborkvizova.Text);
            prva3.OrderBy( x => x.bodovi);
            prvi.Text = prva3[2].name + " " + prva3[2].bodovi.ToString();
            drugi.Text = prva3[1].name + " " + prva3[1].bodovi.ToString();
            treci.Text = prva3[0].name + " " + prva3[0].bodovi.ToString();
            


        }

        private void button2_Click(object sender, System.EventArgs e)
        {

            this.Hide();
            Form4 newform = new Form4( izborkvizova.Text, korisnikovo_ime);
            newform.ShowDialog();
            this.Close();

        }
    }
}
