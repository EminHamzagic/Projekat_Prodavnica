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
    }
}