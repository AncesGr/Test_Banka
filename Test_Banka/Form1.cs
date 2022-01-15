using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Banka
{
    public partial class Form1 : Form
    {
        Banka banka;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblHodnotaPlatby_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka("Anna Greplová", 6000, "1969/35");
            lblJmeno.Text = banka.jmeno;
            lblCisloUctu.Text = banka.cisloUctu.ToString();
            lblAktualniZustatek.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonVložit_Click(object sender, EventArgs e)
        {
            float vklad = float.Parse(textBoxHodnota.Text);
            banka.Vklad(vklad);
            lblAktualniZustatek.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonVybrat_Click(object sender, EventArgs e)
        {
            float vyber = float.Parse(textBoxHodnota.Text);
            banka.Vyber(vyber);
            lblAktualniZustatek.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonZaplatit_Click(object sender, EventArgs e)
        {
            float platba = float.Parse(textBoxPlatba.Text);
            string cisloUctu = txtPlatbaCisloUctu.Text;
            banka.Platba(platba, cisloUctu);
            lblAktualniZustatek.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonLimit_Click(object sender, EventArgs e)
        {
            int zmenaLimitu = int.Parse(textBoxLimit.Text);
            banka.ZmenaLimitu(zmenaLimitu);
            lblCastkaLimit.Text = zmenaLimitu.ToString();
        }

        private void buttonKontokorent_Click(object sender, EventArgs e)
        {
            float zmenaKontokorent = float.Parse(txtKontokorent.Text);
            banka.Kontokorent(zmenaKontokorent);
            lblKontokorent.Text = zmenaKontokorent.ToString();
        }

        private void btnLimitPlatba_Click(object sender, EventArgs e)
        {
            int zmenaLimituPlatba = int.Parse(txtLimitPlatba.Text);
            banka.ZmenaLimituPlatba(zmenaLimituPlatba);
            labelCastkaVyber.Text = zmenaLimituPlatba.ToString();
        }
    }
}
