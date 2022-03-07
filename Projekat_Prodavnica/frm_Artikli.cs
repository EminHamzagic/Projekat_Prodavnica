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
    public partial class frm_Artikli : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string poslovni_partner_id;
        int id_poslovnog_partnera;
        public frm_Artikli()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            //Dodavanje jedinice mere Artikla u ComboBox()
            cmbJedinica_Mere.Items.Add("--Selektuj Jedinicu Mere--");
            cmbJedinica_Mere.Items.Add("KG");

            cmbJedinica_Mere.Items.Add("M");
            cmbJedinica_Mere.Items.Add("L");
            cmbJedinica_Mere.Items.Add("Kom.");
            //Ispisivanje prvog reda
            cmbJedinica_Mere.SelectedIndex = 0;

            //Dodavanje stope Artikla u ComboBox()
            cmbStopa_Poreska.Items.Add("--Selektuj Stopu Artikla--");
            cmbStopa_Poreska.Items.Add("10");
            cmbStopa_Poreska.Items.Add("15");
            cmbStopa_Poreska.Items.Add("20");
            //Ispisivanje prvog reda
            cmbStopa_Poreska.SelectedIndex = 0;
            //Dodavanje vrsta Artikla u ComboBox()
            cmbVrsta_Artikla.Items.Add("--Selektuj Vrstu Artikla--");
            cmbVrsta_Artikla.Items.Add("Trgovinska roba");
            cmbVrsta_Artikla.Items.Add("Gotov Proizvod");
            cmbVrsta_Artikla.Items.Add("Osnovno Sredstvo");
            //Ispisivanje prvog reda.
            cmbVrsta_Artikla.SelectedIndex = 0;
        }

        public void Ucitaj_Artikle()
        {

            int i = 0;
            dataGrid_Artikli.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from ARTIKAL order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Artikli.Rows.Add(i, dr["id"].ToString(), dr["sifra_artikla"].ToString(),
                dr["naziv_artikla"].ToString(), dr["jedinica_mere"].ToString(),
                dr["stopa_poreska"].ToString(), dr["vrsta_artikla"].ToString(),
                dr["barkod"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Artikli.Rows.Count != 0 && dataGrid_Artikli.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Artikli.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Artikli.Columns.Count - 1;
                dataGrid_Artikli.Rows[Indeks_Reda].Selected = true;
                dataGrid_Artikli.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Artikli.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }

        public void Dodaj_Artikal()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * "+
                "FROM ARTIKAL"+
                $" WHERE sifra_artikla = '{textSifra_Artikla.Text}'", cn);
                cm.ExecuteNonQuery();
                dr = null;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textSifra_Artikla.Text == dr["sifra_artikla"].ToString())
{
                        MessageBox.Show("Postoji već Artikal sa datom šifrom, proverite upis", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        textSifra_Artikla.Clear();
                        textSifra_Artikla.Focus();

                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textSifra_Artikla.Text != "")
{
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO ARTIKAL(naziv_artikla, sifra_artikla, jedinica_mere, stopa_poreska, vrsta_artikla, barkod)" +
                    "VALUES(@naziv_artikla, @sifra_artikla, @jedinica_mere, @stopa_poreska, @vrsta_artikla, @barkod)", cn);
                    cm.Parameters.AddWithValue("@naziv_artikla", textNaziv_Artikla.Text);
                    cm.Parameters.AddWithValue("@sifra_artikla", textSifra_Artikla.Text.ToString());
                    cm.Parameters.AddWithValue("@jedinica_mere", cmbJedinica_Mere.SelectedItem);
                    cm.Parameters.AddWithValue("@stopa_poreska", cmbStopa_Poreska.SelectedItem);
                    cm.Parameters.AddWithValue("@vrsta_artikla", cmbVrsta_Artikla.SelectedItem);
                    cm.Parameters.AddWithValue("@barkod", textBarkod.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste sačuvali radnika", "Unos ulica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textNaziv_Artikla.Clear();
                    textSifra_Artikla.Clear();
                    cmbJedinica_Mere.SelectedIndex = 0;

                    cmbStopa_Poreska.SelectedIndex = 0;
                    cmbVrsta_Artikla.SelectedIndex = 0;
                    textBarkod.Clear();
                    textNaziv_Artikla.Focus();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNaziv_Artikla.Focus();
                }
                //Ucitavanje artikala da bi se odmah video efekat unosa
                Ucitaj_Artikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Pretraga_Artikla()
        {
            int i = 0;
            dataGrid_Artikli.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from ARTIKAL" +
             "WHERE sifra_artikla LIKE '%" + textPretraga_Sifra.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Artikli.Rows.Add(i, dr["id"].ToString(), dr["naziv_artikla"].ToString(),
                dr["sifra_artikla"].ToString(), dr["jedinica_mere"].ToString(),
                dr["stopa_poreska"].ToString(), dr["vrsta_artikla"].ToString(),
                dr["barkod"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Artikli.Rows.Count != 0 && dataGrid_Artikli.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Artikli.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Artikli.Columns.Count - 1;
                dataGrid_Artikli.Rows[Indeks_Reda].Selected = true;
                dataGrid_Artikli.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Artikli.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Izmeni_PP_a()
        {
            if (MessageBox.Show("Želite li zaista za izmenite podatke o Artiklu", "Podaci o Artiklu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("SELECT sifra_artikla " +
                "FROM ARTIKAL " +
                "WHERE id!= " + id_poslovnog_partnera.ToString(), cn);

                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textSifra_Artikla.Text == dr["sifra_artikla"].ToString())
                    {
                        MessageBox.Show("Postoji radnik sa datim sifra_artikla, unesite novi sifra_artikla", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textSifra_Artikla.Clear();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textSifra_Artikla.Text != "")
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE ARTIKAL set naziv_artikla = @naziv_artikla, " +
                      "sifra_artikla = @sifra_artikla," +
                        "jedinica_mere = @jedinica_mere, " +
                          "stopa_poreska = @stopa_poreska, " +
                            "vrsta_artikla = @vrsta_artikla, " +
                              "barkod = @barkod " +
                                 " WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@naziv_artikla", textNaziv_Artikla.Text);
                    cm.Parameters.AddWithValue("@sifra_artikla", textSifra_Artikla.Text);
                    cm.Parameters.AddWithValue("@jedinica_mere", cmbJedinica_Mere.SelectedItem);

                    cm.Parameters.AddWithValue("@stopa_poreska", cmbStopa_Poreska.SelectedItem);
                    cm.Parameters.AddWithValue("@vrsta_artikla", cmbVrsta_Artikla.SelectedItem);
                    cm.Parameters.AddWithValue("@barkod", textBarkod.Text);
                    cm.Parameters.AddWithValue("@id", id_poslovnog_partnera);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Podaci su uspesno izmenjeni");
                    Ucitaj_Artikle();
                    textNaziv_Artikla.Clear();
                    textSifra_Artikla.Clear();
                    cmbJedinica_Mere.SelectedIndex = 0;
                    cmbVrsta_Artikla.SelectedIndex = 0;
                    cmbStopa_Poreska.SelectedIndex = 0;
                    textBarkod.Clear();
                    textNaziv_Artikla.Focus();
                }
            }
        }
        private void btnUcitaj_Radnika_Click(object sender, EventArgs e)
        {
            Ucitaj_Artikle();
            textNaziv_Artikla.Focus();
        }

        private void btn_Pretrazi_Radnika_Click(object sender, EventArgs e)
        {
            Pretraga_Artikla();
        }

        private void btnNovi_Radnik_Click(object sender, EventArgs e)
        {
            Dodaj_Artikal();
            textNaziv_Artikla.Focus();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Izmeni_PP_a();
        }

        private void dataGrid_Artikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone_pp_a = dataGrid_Artikli.Columns[e.ColumnIndex].Name;
            poslovni_partner_id = dataGrid_Artikli.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednosti id radnika u int obliku
            id_poslovnog_partnera = Int32.Parse(poslovni_partner_id);
            if (ime_kolone_pp_a == "Edit_Artikal")
            {
                textNaziv_Artikla.Text = dataGrid_Artikli.Rows[e.RowIndex].Cells[2].Value.ToString();
                textSifra_Artikla.Text = dataGrid_Artikli.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbJedinica_Mere.SelectedItem = dataGrid_Artikli.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbStopa_Poreska.SelectedItem = dataGrid_Artikli.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbVrsta_Artikla.SelectedItem = dataGrid_Artikli.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBarkod.Text = dataGrid_Artikli.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (ime_kolone_pp_a == "Delete_Artikal")
            {
                try
                {

                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM ARTIKAL" +
                         " WHERE id = " + dataGrid_Artikli.Rows[e.RowIndex].Cells[1].Value.ToString() + "", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj_Artikle();
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
