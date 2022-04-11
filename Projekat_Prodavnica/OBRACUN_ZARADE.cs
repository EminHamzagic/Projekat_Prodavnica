using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekat_Prodavnica
{
    public partial class OBRACUN_ZARADE : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        //Javne promenljive
        int id_radnika, zarada_vrsta_id;
        string ugovorene_mesecna_zarada_radnika, radnik_id;
        double stimulacija, destimulacija, pom_ugovorena_mesecna_zarada,
        ukupna_mesecna_zarada;
        public OBRACUN_ZARADE()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            Ucitaj_Radnike();
            Ucitaj_Vrsta_Zarade();
        }
        public void Ucitaj_Zarade_Radnika()
        {
            int i = 0;
            dataGrid_Obracun_Zarada_Radnika.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select r.id, r.ime_prezime, r.JMBG, ob.period_od, ob.period_do, vz.vrsta_zarade, "+
            "ob.ukupna_zarada, ob.napomena " +
             "from OBRACUN_ZARADA as ob " +
              "left outer join RADNIK as r on ob.id_radnika = r.id " +
               " left outer join VRSTA_ZARADE as vz on ob.id_vrsta_zarade = vz.id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Obracun_Zarada_Radnika.Rows.Add(i, dr["id"].ToString(),
                dr["ime_prezime"].ToString(), dr["JMBG"].ToString(),
                dr["vrsta_zarade"].ToString(),
                dr["period_od"].ToString(), dr["period_do"].ToString(),
                dr["ukupna_zarada"].ToString(),
                dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Obracun_Zarada_Radnika.Rows.Count != 0 && dataGrid_Obracun_Zarada_Radnika.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Obracun_Zarada_Radnika.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Obracun_Zarada_Radnika.Columns.Count - 1;
                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Selected = true;
                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.

                dataGrid_Obracun_Zarada_Radnika.FirstDisplayedScrollingRowIndex =
                Indeks_Reda;
            }
        }
        public void Ucitaj_Radnike()
        {
            //Ucitavanje artikala, ako kasnije bude bilo potrebno
            cn.Open();
            cm = new SqlCommand("SELECT id, ime_prezime " +
            "FROM Radnik", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_artikal = new DataTable();
            data_artikal.Load(dr);
            DataRow Selelct_Osnovi_Detalji = data_artikal.NewRow();
            Selelct_Osnovi_Detalji[0] = 0;
            Selelct_Osnovi_Detalji[1] = "-Select-";
            data_artikal.Rows.InsertAt(Selelct_Osnovi_Detalji, 0);
            cmbIme_Prezime_Radnika.DataSource = data_artikal;
            //Poziv ostalih redova u DataSourse;
            cmbIme_Prezime_Radnika.DisplayMember = "ime_prezime";
            cmbIme_Prezime_Radnika.ValueMember = "id";
            cmbIme_Prezime_Radnika.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbIme_Prezime_Radnika.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Unesi_Zaradu_Radnika()
        {
            try
            {
                if (textUkupna_Zarada.Text != "")
                {   
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO OBRACUN_ZARADA(id_radnika, id_vrsta_zarade, period_od, period_do, ukupna_zarada, napomena)" +
                    "VALUES(@id_radnika, @id_vrsta_zarade, @period_od, @period_do, @ukupna_zarada, @napomena)", cn);
                    cm.Parameters.AddWithValue("@id_radnika", cmbIme_Prezime_Radnika.SelectedValue);
                    cm.Parameters.AddWithValue("@id_vrsta_zarade", cmbVrsta_Zarade.SelectedValue);
                    cm.Parameters.AddWithValue("@period_od", datePeriodOd.Value);
                    cm.Parameters.AddWithValue("@period_do", datePeriodDo.Value);
                    cm.Parameters.AddWithValue("@ukupna_zarada", ukupna_mesecna_zarada);
                    cm.Parameters.AddWithValue("@napomena", textNapomena_Zarada.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste sačuvali obracun_zarade", "Unos Radnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textUgovorena_Mesecna_Zarada.Clear();
                    textStmulacija.Clear();
                    textDestimulacija.Clear();
                    textUkupna_Zarada.Clear();
                    cmbIme_Prezime_Radnika.SelectedIndex = 0;
                    cmbVrsta_Zarade.SelectedIndex = 0;
                    textNapomena_Zarada.Clear();
                    cn.Close();
                }

                else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textUkupna_Zarada.Focus();
                }
                //Ucitavanje artikala da bi se odmah video efekat unosa
                Ucitaj_Sve_Zarade_Radnika();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ucitaj_Vrsta_Zarade()
        {
            //Selekcija Vrste Zarade
            cn.Open();
            cm = new SqlCommand("SELECT id, vrsta_zarade "+
            "FROM VRSTA_ZARADE", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_pp = new DataTable();
            data_pp.Load(dr);
            //Unos reda -Select PP- prije pozivanja ostalih redova
            DataRow Selelct_Osnovni_PP = data_pp.NewRow();
            Selelct_Osnovni_PP[0] = 0;
            Selelct_Osnovni_PP[1] = "-Select Vrsta zarade -";
            data_pp.Rows.InsertAt(Selelct_Osnovni_PP, 0);
            cmbVrsta_Zarade.DataSource = data_pp;
            //Poziv ostalih redova u DataSourse;

            cmbVrsta_Zarade.DisplayMember = "vrsta_zarade";
            cmbVrsta_Zarade.ValueMember = "id";
            cmbVrsta_Zarade.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbVrsta_Zarade.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_Sve_Zarade_Radnika()
        {
            int i = 0;
            dataGrid_Obracun_Zarada_Radnika.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(" select ob.id, r.ime_prezime, r.jmbg, vz.vrsta_zarade, ob.period_od, ob.period_do, ob.ukupna_zarada, ob.napomena " +
                "from OBRACUN_ZARADA as ob " +
                "left outer join Radnik as r on ob.id_radnika = r.id " +
                "left outer join VRSTA_ZARADE as vz on ob.id_vrsta_zarade = vz.id order by ob.id " , cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Obracun_Zarada_Radnika.Rows.Add(i, dr["id"].ToString(), dr["ime_prezime"].ToString(),
                dr["jmbg"].ToString(), dr["vrsta_zarade"].ToString(), dr["period_od"].ToString(),
                dr["period_do"].ToString(), dr["ukupna_zarada"].ToString(), dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Obracun_Zarada_Radnika.Rows.Count != 0 && dataGrid_Obracun_Zarada_Radnika.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Obracun_Zarada_Radnika.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Obracun_Zarada_Radnika.Columns.Count - 1;

                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Selected = true;

                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Obracun_Zarada_Radnika.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }

        private void cmbIme_Prezime_Radnika_SelectionChangeCommitted(object sender, EventArgs e)
        {
                //Selekcija Vrste Zarade
                cn.Open();
                cm = new SqlCommand("SELECT id, vrsta_zarade "+
                "FROM VRSTA_ZARADE ", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_pp = new DataTable();
            data_pp.Load(dr);
            //Unos reda -Select PP- prije pozivanja ostalih redova
            DataRow Selelct_Osnovni_PP = data_pp.NewRow();
            Selelct_Osnovni_PP[0] = 0;
            Selelct_Osnovni_PP[1] = "-Select Vrsta zarade -";
            data_pp.Rows.InsertAt(Selelct_Osnovni_PP, 0);
            cmbVrsta_Zarade.DataSource = data_pp;
            //Poziv ostalih redova u DataSourse;

            cmbVrsta_Zarade.DisplayMember = "vrsta_zarade";
            cmbVrsta_Zarade.ValueMember = "id";
            cmbVrsta_Zarade.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbVrsta_Zarade.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
    

        private void cmbVrsta_Zarade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id_vrste_zarade = cmbVrsta_Zarade.SelectedValue;
            zarada_vrsta_id = (int)id_vrste_zarade;
        }

        private void textDestimulacija_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textUkupna_Zarada.Focus(); //Kontrola sa fokusom
                stimulacija = Double.Parse(textStmulacija.Text.ToString());
                destimulacija = Double.Parse(textDestimulacija.Text.ToString());
                ukupna_mesecna_zarada = pom_ugovorena_mesecna_zarada + stimulacija - destimulacija;
                textUkupna_Zarada.Text = ukupna_mesecna_zarada.ToString();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        public void Search()
        {
            int i = 0;
            dataGrid_Obracun_Zarada_Radnika.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(" select ob.id, r.ime_prezime, r.jmbg, vz.vrsta_zarade, ob.period_od, ob.period_do, ob.ukupna_zarada, ob.napomena " +
                "from OBRACUN_ZARADA as ob " +
                "left outer join Radnik as r on ob.id_radnika = r.id " +
                "left outer join VRSTA_ZARADE as vz on ob.id_vrsta_zarade = vz.id " +
                "where r.jmbg like '%" + textPretrazi.Text + "%' order by ob.id ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Obracun_Zarada_Radnika.Rows.Add(i, dr["id"].ToString(), dr["ime_prezime"].ToString(),
                dr["jmbg"].ToString(), dr["vrsta_zarade"].ToString(), dr["period_od"].ToString(),
                dr["period_do"].ToString(), dr["ukupna_zarada"].ToString(), dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Obracun_Zarada_Radnika.Rows.Count != 0 && dataGrid_Obracun_Zarada_Radnika.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Obracun_Zarada_Radnika.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Obracun_Zarada_Radnika.Columns.Count - 1;

                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Selected = true;

                dataGrid_Obracun_Zarada_Radnika.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Obracun_Zarada_Radnika.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }
        public void Izmeni_Zaradu()
        {
            if (MessageBox.Show(" Želite li zaista za izmenite podatke o obracunu zarade?", " Imena podataka o radniku ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textUkupna_Zarada.Text != " ")
                {
                    cn.Open();
                    cm = new SqlCommand(" UPDATE OBRACUN_ZARADA set id_radnika= @id_radnika, " +
                    "id_vrsta_zarade = @id_vrsta_zarade, " +
                    "period_od = @period_od, " +
                    "period_do= @period_do, " +
                    "ukupna_zarada= @ukupna_zarada,  " +
                    "napomena = @napomena" +
                    " WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id_radnika", cmbIme_Prezime_Radnika.SelectedValue);
                    cm.Parameters.AddWithValue("@id_vrsta_zarade", cmbVrsta_Zarade.SelectedValue);
                    cm.Parameters.AddWithValue("@period_od", datePeriodOd.Value);
                    cm.Parameters.AddWithValue("@period_do", datePeriodDo.Value);
                    cm.Parameters.AddWithValue("@ukupna_zarada", ukupna_mesecna_zarada);
                    cm.Parameters.AddWithValue("@napomena", textNapomena_Zarada.Text);
                    cm.Parameters.AddWithValue("@id", id_radnika);
                    cm.ExecuteNonQuery();
                    MessageBox.Show(" Uspešno ste promenili podatke o zaradu radnika", " Unos ulica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textUgovorena_Mesecna_Zarada.Clear();
                    textStmulacija.Clear();
                    textDestimulacija.Clear();
                    textUkupna_Zarada.Clear();
                    cmbIme_Prezime_Radnika.SelectedIndex = 0;
                    cmbVrsta_Zarade.SelectedIndex = 0;
                    textNapomena_Zarada.Clear();
                    cn.Close();
                    Ucitaj_Sve_Zarade_Radnika();
                }
            }
        }

        private void dataGrid_Obracun_Zarada_Radnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone = dataGrid_Obracun_Zarada_Radnika.Columns[e.ColumnIndex].Name;
            radnik_id = dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednostiidradnika u int obliku
            id_radnika = Int32.Parse(radnik_id);
            if (ime_kolone == "Edit_Radnika")
            {
                cmbIme_Prezime_Radnika.SelectedItem = dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbVrsta_Zarade.SelectedItem = dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[3].Value.ToString();
                datePeriodOd.Value = DateTime.Parse(dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[5].Value.ToString());
                datePeriodDo.Value = DateTime.Parse(dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[6].Value.ToString());
                textUkupna_Zarada.Text = dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[7].Value.ToString();
                textNapomena_Zarada.Text = dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            else if (ime_kolone == "Delete_Radnika")
            {
                try
                {
                    if (MessageBox.Show(" Da li ste sigurni da želite da izbrišete selektovani red?", " Brisanje Obracuna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand(" DELETE FROM OBRACUN_ZARADA " +
                         " WHERE id= " +
                           dataGrid_Obracun_Zarada_Radnika.Rows[e.RowIndex].Cells[1].Value.ToString() + " ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show(" Red je uspesno izbrisan", " Obaveštenje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj_Sve_Zarade_Radnika();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucitaj_Sve_Zarade_Radnika();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Unesi_Zaradu_Radnika();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Izmeni_Zaradu();
        }
    }
}
