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
    public partial class Zarade_Radnika : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string radnik_id;
        int id_radnika;
        public Zarade_Radnika()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            Ucitaj_Radnike();
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
            cmbRadnik.DataSource = data_artikal;
            //Poziv ostalih redova u DataSourse;
            cmbRadnik.DisplayMember = "ime_prezime";
            cmbRadnik.ValueMember = "id";
            cmbRadnik.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbRadnik.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_ZaradeRadnika()
        {
            int i = 0;
            dataGrid_ZaradeRadnika.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(" Select zd.id, r.ime_prezime, zd.period_od, zd.period_do, zd.iznos_zarade " +
                "from ZARADA_RADNIKA as zd " +
                "left outer join Radnik as r on zd.id_radnika = r.id " +
                "order by zd.id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_ZaradeRadnika.Rows.Add(i, dr["id"].ToString(), dr["ime_prezime"].ToString(),
                dr["period_od"].ToString(),
                dr["period_do"].ToString(),
                dr["iznos_zarade"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_ZaradeRadnika.Rows.Count != 0 && dataGrid_ZaradeRadnika.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_ZaradeRadnika.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_ZaradeRadnika.Columns.Count - 1;

                dataGrid_ZaradeRadnika.Rows[Indeks_Reda].Selected = true;

                dataGrid_ZaradeRadnika.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_ZaradeRadnika.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }
        public void Dodaj_ZaraduRadnika()
        {
            try
            {
                if (textZarada.Text != " ")
                {
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand(" INSERT INTO ZARADA_RADNIKA(id_radnika, period_od, period_do, iznos_zarade) " +
                    " VALUES(@id_radnika, @period_od, @period_do, @iznos_zarade)", cn);
                    cm.Parameters.AddWithValue("@id_radnika", cmbRadnik.SelectedValue);
                    cm.Parameters.AddWithValue("@period_od", dtPeriodOd.Value);
                    cm.Parameters.AddWithValue("@period_do", dtPeriodDo.Value);
                    cm.Parameters.AddWithValue("@iznos_zarade", textZarada.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show(" Uspešno ste sačuvali zaradu radnika", " Unos ulica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbRadnik.SelectedIndex = 0;
                    textZarada.Clear();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show(" Niste uneli sve propratne podatke ", " Upozorenje!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Ucitaj_ZaradeRadnika();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void izmeni_ZaraduRadnika()
        {
            if (MessageBox.Show(" Želite li zaista za izmenite podatke o zaradi radnika?", " Imena podataka o radniku ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textZarada.Text != " ")
                {
                    cn.Open();
                    cm = new SqlCommand(" UPDATE ZARADA_RADNIKA set id_radnika= @id_radnika, " +
                    "period_od = @period_od," +
                    "period_do= @period_do, " +
                    "iznos_zarade= @iznos_zarade" +
                    " WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id_radnika", cmbRadnik.SelectedValue);
                    cm.Parameters.AddWithValue("@period_od", dtPeriodOd.Value);
                    cm.Parameters.AddWithValue("@period_do", dtPeriodDo.Value);
                    cm.Parameters.AddWithValue("@iznos_zarade", textZarada.Text);
                    cm.Parameters.AddWithValue("@id", id_radnika);
                    cm.ExecuteNonQuery();
                    MessageBox.Show(" Uspešno ste promenili podatke o zaradu radnika", " Unos ulica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbRadnik.SelectedIndex = 0;
                    textZarada.Clear();
                    cn.Close();
                    Ucitaj_ZaradeRadnika();
                }
            }
        }

        private void cmbRadnik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Ucitaj_ZaradeRadnika();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj_ZaraduRadnika();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            izmeni_ZaraduRadnika();
        }

        private void dataGrid_ZaradeRadnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone = dataGrid_ZaradeRadnika.Columns[e.ColumnIndex].Name;
            radnik_id = dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednostiidradnika u int obliku
            id_radnika = Int32.Parse(radnik_id);
            if (ime_kolone == "Edit_Radnika")
            {
                cmbRadnik.SelectedItem = dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtPeriodOd.Value = DateTime.Parse(dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[3].Value.ToString());
                dtPeriodDo.Value = DateTime.Parse(dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[4].Value.ToString());
                textZarada.Text = dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (ime_kolone == "Delete_Radnika")
            {
                try
                {
                    if (MessageBox.Show(" Da li ste sigurni da želite da izbrišete selektovani red?", " Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand(" DELETE FROM ZARADA_RADNIKA " +
                         " WHERE id= " +
                           dataGrid_ZaradeRadnika.Rows[e.RowIndex].Cells[1].Value.ToString() + " ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show(" Red je uspesno izbrisan", " Obaveštenje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj_ZaradeRadnika();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
