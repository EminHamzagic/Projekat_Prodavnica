namespace Projekat_Prodavnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Radnici Radnici = new frm_Radnici();
            Radnici.Show();
        }

        private void poslovniPArtneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PP PP = new frm_PP();
            PP.Show();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Artikli Artikli = new frm_Artikli();
            Artikli.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ulaz_Kalkulacija Uk = new Ulaz_Kalkulacija();
            Uk.Show();
        }

        private void racunOtpremniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izlaz_Kalkulacije izlaz = new Izlaz_Kalkulacije();
            izlaz.Show();
        }

        private void karticaArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kartica_Artikla kartica_artikla = new Kartica_Artikla();
            kartica_artikla.Show();
        }

        private void ostaliTroskoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Troskovi troskovi = new Troskovi();
            troskovi.Show();
        }

        private void zaradeRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zarade_Radnika zaradeRadnika = new Zarade_Radnika();
            zaradeRadnika.Show();
        }

        private void obracunZaradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OBRACUN_ZARADE obracun = new OBRACUN_ZARADE();
            obracun.Show();
        }

        private void evidencijaProdajeTroskovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvidencijaProdajeTroskova evidencija = new EvidencijaProdajeTroskova();
            evidencija.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Login.TipProfila == "admin")
            {
                profiliToolStripMenuItem.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Login);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount add = new AddAccount();
            add.Show();
        }
    }
}