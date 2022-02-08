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
    public partial class frm_Radnici : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string radnik_id;
        int id_radnika;
        public frm_Radnici()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            cmbVrsta_Radnika.Items.Add("--Selektuj vrstu radnika--");
            cmbVrsta_Radnika.Items.Add("Administrator");
            cmbVrsta_Radnika.Items.Add("Kasir");
            cmbVrsta_Radnika.Items.Add("Magacioner");
            cmbVrsta_Radnika.SelectedIndex = 0;
        }
        public void Dodaj_radnika()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand(" SELECT * "+
                " FROM Radnik" +
                " WHERE JMBG= '"+textJMBG.Text+"'", cn);
                cm.ExecuteNonQuery();
                dr = null;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textJMBG.Text == dr["JMBG"].ToString())
{
                        MessageBox.Show(" Postoji već radnik sa datim JMBG-om, proverite upis ", "Upozorenje!!! ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        textJMBG.Clear();

                        textJMBG.Focus();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textJMBG.Text != " ")
{
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand(" INSERT INTO Radnik(ime_prezime, JMBG, vrsta_radnika, korisnicko_ime, " +
                    " lozinka, adresa,mesecna_zarada) " +
                    " VALUES(@ime_prezime, @JMBG, @vrsta_radnika,@korisnicko_ime, " +
                    " @lozinka, @adresa,@mesecna_zarada) ", cn);
                    cm.Parameters.AddWithValue("@ime_prezime", texIme_Prezime_Radnika.Text);
                    cm.Parameters.AddWithValue("@JMBG", textJMBG.Text.ToString());
                    cm.Parameters.AddWithValue("@vrsta_radnika", cmbVrsta_Radnika.SelectedItem);
                    cm.Parameters.AddWithValue("@korisnicko_ime", textKor_Ime.Text);
                    cm.Parameters.AddWithValue("@lozinka", textLozinka.Text);
                    cm.Parameters.AddWithValue("@adresa", textAdresa.Text);
                    cm.Parameters.AddWithValue("@mesecna_zarada", textMesecna_Zarada.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show(" Uspešno ste sačuvali radnika", " Unos ulica",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texIme_Prezime_Radnika.Clear();
                    textJMBG.Clear();
                    cmbVrsta_Radnika.SelectedIndex = 0;
                    textKor_Ime.Clear();

                    textLozinka.Clear();
                    textAdresa.Clear();
                    textMesecna_Zarada.Clear();
                    texIme_Prezime_Radnika.Focus();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show(" Niste uneli sve propratne podatke ", " Upozorenje!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    texIme_Prezime_Radnika.Focus();
                }
                Ucitaj_Radnike();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Pretrazi_Radnike()
        {
            int i = 0;
            dataGrid_Radnici.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(" Select* from Radnik " +
             " WHERE JMBG LIKE '%"+ textPretraga_JMBG.Text+"%'", cn);

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Radnici.Rows.Add(i, dr["id"].ToString(), dr["ime_prezime"].ToString(),
                dr["JMBG"].ToString(),
                dr["vrsta_radnika"].ToString(),
                dr["korisnicko_ime"].ToString(),
                dr["lozinka"].ToString(),
                dr["adresa"].ToString(),
                dr["mesecna_zarada"].ToString()
            );
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Radnici.Rows.Count != 0 && dataGrid_Radnici.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Radnici.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Radnici.Columns.Count - 1;

                dataGrid_Radnici.Rows[Indeks_Reda].Selected = true;
                dataGrid_Radnici.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Radnici.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }

        }
        public void Ucitaj_Radnike()
        {
            int i = 0;
            dataGrid_Radnici.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(" Select* from Radnik order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Radnici.Rows.Add(i, dr["id"].ToString(), dr["ime_prezime"].ToString(),
                dr["JMBG"].ToString(),
                dr["vrsta_radnika"].ToString(),
                dr["korisnicko_ime"].ToString(),
                dr["lozinka"].ToString(),
                dr["adresa"].ToString(),
                dr["mesecna_zarada"].ToString()
            );
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Radnici.Rows.Count != 0 && dataGrid_Radnici.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Radnici.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Radnici.Columns.Count - 1;

                dataGrid_Radnici.Rows[Indeks_Reda].Selected = true;

                dataGrid_Radnici.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Radnici.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }
        public void Izmeni_Radnika()
        {
            if (MessageBox.Show(" Želite li zaista za izmenite podatke o radniku", " Imena podataka o radniku ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
{
                cn.Open();
                cm = new SqlCommand(" SELECT JMBG" +
                " FROM Radnik " +
                " WHERE id!= " +id_radnika.ToString(), cn);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textJMBG.Text == dr["JMBG"].ToString())
{
                        MessageBox.Show(" Postoji radnik sa datim JMBG, unesite noviJMBG", " Upozorenje!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textJMBG.Clear();
                        break;
                    }

                }
                dr.Close();
                cn.Close();
                if (textJMBG.Text != " ")
{
                    cn.Open();
                    cm = new SqlCommand(" UPDATE Radnik set ime_prezime= @ime_prezime, " +
                      "JMBG= @JMBG," +
                        "vrsta_radnika= @vrsta_radnika, " +
                          "korisnicko_ime= @korisnicko_ime," +
                            "lozinka= @lozinka," +
                              "adresa= @adresa," +
                                "mesecna_zarada=@mesecna_zarada" +
                                   " WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@ime_prezime", texIme_Prezime_Radnika.Text);
                    cm.Parameters.AddWithValue("@JMBG", textJMBG.Text);
                    cm.Parameters.AddWithValue("@vrsta_radnika", cmbVrsta_Radnika.SelectedItem);
                    cm.Parameters.AddWithValue("@korisnicko_ime", textKor_Ime.Text);
                    cm.Parameters.AddWithValue("@lozinka", textLozinka.Text);
                    cm.Parameters.AddWithValue("@adresa", textAdresa.Text);
                    cm.Parameters.AddWithValue("@mesecna_zarada", textMesecna_Zarada.Text);
                    cm.Parameters.AddWithValue("@id", id_radnika);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show(" Podaci su uspesno izmenjeni");
                    Ucitaj_Radnike();
                    texIme_Prezime_Radnika.Clear();
                    textJMBG.Clear();
                    cmbVrsta_Radnika.SelectedIndex = 0;
                    textKor_Ime.Clear();
                    textLozinka.Clear();

                    textAdresa.Clear();
                    textMesecna_Zarada.Clear();
                    texIme_Prezime_Radnika.Focus();
                }
            }
        }
        private void btnUcitaj_Radnika_Click(object sender, EventArgs e)
        {
            Ucitaj_Radnike();
            textPretraga_JMBG.Clear();
        }

        private void btn_Pretrazi_Radnika_Click(object sender, EventArgs e)
        {
            Pretrazi_Radnike();
        }

        private void btnNovi_Radnik_Click(object sender, EventArgs e)
        {
            Dodaj_radnika();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Izmeni_Radnika();
        }

        private void dataGrid_Radnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone = dataGrid_Radnici.Columns[e.ColumnIndex].Name;
            radnik_id = dataGrid_Radnici.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednostiidradnika u int obliku
            id_radnika = Int32.Parse(radnik_id);
            if (ime_kolone == "Edit_Radnika")
{
                texIme_Prezime_Radnika.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[2].Value.ToString();
                textJMBG.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbVrsta_Radnika.SelectedItem = dataGrid_Radnici.Rows[e.RowIndex].Cells[4].Value.ToString();
                textKor_Ime.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[5].Value.ToString();

                textLozinka.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[6].Value.ToString();
                textAdresa.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[7].Value.ToString();
                textMesecna_Zarada.Text = dataGrid_Radnici.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            else if (ime_kolone == "Delete_Radnika")
                {
                try
                {
                    if (MessageBox.Show(" Da li ste sigurni da želite da izbrišete selektovani red?"," Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                        cn.Open();
                        cm = new SqlCommand(" DELETE FROM Radnik " +
                         " WHERE id= " +
                           dataGrid_Radnici.Rows[e.RowIndex].Cells[1].Value.ToString() + " ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show(" Red je uspesno izbrisan", " Obaveštenje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj_Radnike();
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
