using System.Collections.Generic;

namespace NIko_Arar_3_C_projekt
{
    public class zadatak
    {

        public string pitanje { get; set; }
        public List<string> odgovori { get; set; }
        public int tocan_odgovor { get; set; }

        public zadatak(string pitanje, List<string> odgovori, int tocan__odgovor)
        {
            
            this.tocan_odgovor = tocan__odgovor;
            this.pitanje = pitanje;
            this.odgovori = odgovori;


        }


    }

}
