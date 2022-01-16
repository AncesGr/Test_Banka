using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Banka
{
    public class Banka
    {
        public string jmeno;
        public float aktualniZustatek;
        public string cisloUctu;
        public float kontokorent;

        public int max = 250000;
        public int tydenniLimit = 10000;
        public int platebniLimit = 7500;

        public Banka(string jmeno, float aktualniZustatek, string cisloUctu)
        {
            this.jmeno = jmeno;
            this.aktualniZustatek = aktualniZustatek;
            this.cisloUctu = cisloUctu;
        }

        public void ZmenaLimitu(int zmenaLimitu)
        {

            platebniLimit = zmenaLimitu;
        }
        public void ZmenaLimituPlatba(int zmenaLimituPlatba)
        {

            tydenniLimit = zmenaLimituPlatba;
        }

        public void Kontokorent(float zmenaKontokorent)
        {
            if (aktualniZustatek >= kontokorent)
            {
                kontokorent = zmenaKontokorent;
            }
            else
            {
                float vypisZustatku = aktualniZustatek - (2 * aktualniZustatek);
                MessageBox.Show("Nejde změnit musíte vložit" + vypisZustatku);
            }
        }

        public void Vklad(float vklad)
        {
            if (vklad + aktualniZustatek <= max)
            {
                aktualniZustatek += vklad;
                MessageBox.Show("Bylo vloženo: " + vklad.ToString());
            }
            else if (vklad + aktualniZustatek >= max)
            {
                MessageBox.Show("Nepodařilo se vložit z důvodu překročení limitu");
                MessageBox.Show("Váš maximální limit je: " + max);
            }
        }


        public void Vyber(float vyber)
        {

            if (vyber - aktualniZustatek -kontokorent <= 0 && vyber <= tydenniLimit)
            {
                aktualniZustatek -= vyber;
                MessageBox.Show("Bylo vybráno: " + vyber.ToString());
            }
            else if (vyber - aktualniZustatek > 0)
            {
                MessageBox.Show("Nemáte dostatek peněz na výběr z účtu");
            }
            else
            {
                MessageBox.Show("Nepodařilo se vybrat, došlo k překročení týdenního limitu");
            }
        }

        public void Platba(float platba, string cisloUctu)
        {
            if (platba - aktualniZustatek - kontokorent <= 0 && platba <= platebniLimit)
            {
                aktualniZustatek -= platba;
                MessageBox.Show("Transakce byla provedena na číslo učtu: " + cisloUctu + " s částkou:" + platba);
                MessageBox.Show("Aktualní zůstatek na účtě: " + aktualniZustatek);
            }
            else if (platba - aktualniZustatek > 0)
            {
                MessageBox.Show("Nemáte dostatek peněz na provedení transakce");
            }
            else
            {
                MessageBox.Show("Nepodařilo se akci dokončit, došlo k překročení platebního limitu");
            }
        }
    }
}
