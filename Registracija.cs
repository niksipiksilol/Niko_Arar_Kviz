using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIko_Arar_3_C_projekt
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            baza_pristup.upisi_u_tablicu( "korisnici ([ime],[sifra],[Admin],[Geografija],[Opće znanje],[Videoigrice]) ", "("+ "'" + textBox1.Text + "'" + "," + "'" + textBox2.Text + "'" + "," + "false" + "," +  " 0,0,0)");
            this.Close();

        }
    }
}
