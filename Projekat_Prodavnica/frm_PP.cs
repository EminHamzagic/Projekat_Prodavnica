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
    public partial class frm_PP : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string poslovni_partner_id;
        int id_poslovnog_partnera;
        public frm_PP()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            //Dodavanje vrsta PP-a u ComboBox()
            cmbVrsta_PP_a.Items.Add("--Selektuj vrstu PP--");
            cmbVrsta_PP_a.Items.Add("Pravno lice");
            cmbVrsta_PP_a.Items.Add("Fizicko lice");
            //Ispisivanje prvog reda.
            cmbVrsta_PP_a.SelectedIndex = 0;
        }
        public void Ucitaj_Poslovnog_Partnera()
        {
            int i = 0;
            dataGrid_PP_a.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from POSLOVNI_PARTNERI order by id", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())

            {
                i += 1;
                dataGrid_PP_a.Rows.Add(i, dr["id"].ToString(), dr["naziv_pp"].ToString(),
                dr["PIB"].ToString(), dr["maticni_broj"].ToString(),
                dr["adresa"].ToString(), dr["vrsta_pp"].ToString(),
                dr["detalji_pp"].ToString() );
            }
            dr.Close();
            cn.Close();
            if (dataGrid_PP_a.Rows.Count != 0 && dataGrid_PP_a.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_PP_a.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_PP_a.Columns.Count - 1;

                dataGrid_PP_a.Rows[Indeks_Reda].Selected = true;
                dataGrid_PP_a.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_PP_a.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Unesi_Novog_PP_a()
        {

            try
            {
                cn.Open();
                cm = new SqlCommand($"select * from POSLOVNI_PARTNERI where PIB = '{textPIB_PP_a.Text.ToString()}'", cn);
                cm.ExecuteNonQuery();
                dr = null;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textPIB_PP_a.Text == dr["PIB"].ToString())
{
                        MessageBox.Show("Postoji već PP sa datim PIB-om, proverite upis ", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        textPIB_PP_a.Clear();
                        textPIB_PP_a.Focus();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textPIB_PP_a.Text != "")
                {
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO POSLOVNI_PARTNERI(naziv_pp, PIB, maticni_broj, adresa, vrsta_pp, detalji_pp)" +
                    "VALUES(@naziv_pp, @PIB, @maticni_broj, @adresa, "+
                   "@vrsta_pp, @detalji_pp ) ", cn);
                    cm.Parameters.AddWithValue("@naziv_pp", texNaziv_PP_a.Text);
                    cm.Parameters.AddWithValue("@PIB", textPIB_PP_a.Text.ToString());
                    cm.Parameters.AddWithValue("@maticni_broj", textMaticni_Broj_PP_a.Text);
                    cm.Parameters.AddWithValue("@adresa", textAdresa_PP_a.Text);
                    cm.Parameters.AddWithValue("@vrsta_pp", cmbVrsta_PP_a.SelectedItem);
                    cm.Parameters.AddWithValue("@detalji_pp", textDetalji_PP_a.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste sačuvali radnika", "Unos ulica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texNaziv_PP_a.Clear();
                    textPIB_PP_a.Clear();
                    textMaticni_Broj_PP_a.Clear();
                    cmbVrsta_PP_a.SelectedIndex = 0;
                    textAdresa_PP_a.Clear();
                    textDetalji_PP_a.Clear();
                    texNaziv_PP_a.Focus();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    texNaziv_PP_a.Focus();
                }
                //Ucitavanje radnika da bi se odmah video efekat unosa
                Ucitaj_Poslovnog_Partnera();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Pretraga_PP_a()
        {
            int i = 0;
            dataGrid_PP_a.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from POSLOVNI_PARTNERI" +
             "WHERE PIB LIKE '%"+ textPretraga_PIB.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_PP_a.Rows.Add(i, dr["id"].ToString(), dr["naziv_pp"].ToString(),
                dr["PIB"].ToString(), dr["maticni_broj"].ToString(),
                dr["adresa"].ToString(), dr["vrsta_pp"].ToString(),
                dr["detalji_pp"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_PP_a.Rows.Count != 0 && dataGrid_PP_a.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_PP_a.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_PP_a.Columns.Count - 1;
                dataGrid_PP_a.Rows[Indeks_Reda].Selected = true;
                dataGrid_PP_a.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_PP_a.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Izmeni_PP_a()
        {
            if (MessageBox.Show("Želite li zaista za izmenite podatke o PP-u", "Podaci o PP - u", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("SELECT PIB " +
                "FROM POSLOVNI_PARTNERI " +
                "WHERE id!= " + id_poslovnog_partnera.ToString(), cn);

                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textPIB_PP_a.Text == dr["PIB"].ToString())
                    {
                        MessageBox.Show("Postoji radnik sa datim PIB, unesite novi PIB", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textPIB_PP_a.Clear();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textPIB_PP_a.Text != "")
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE POSLOVNI_PARTNERI set naziv_pp = @naziv_pp, " +
                      "PIB = @PIB," +
                        "maticni_broj = @maticni_broj, " +
                          "adresa = @adresa, " +
                            "vrsta_pp = @vrsta_pp, " +
                              "detalji_pp = @detalji_pp " +
                                 " WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@naziv_pp", texNaziv_PP_a.Text);
                    cm.Parameters.AddWithValue("@PIB", textPIB_PP_a.Text);
                    cm.Parameters.AddWithValue("@maticni_broj", textMaticni_Broj_PP_a.Text);

                    cm.Parameters.AddWithValue("@adresa", textAdresa_PP_a.Text);
                    cm.Parameters.AddWithValue("@vrsta_pp", cmbVrsta_PP_a.SelectedItem);
                    cm.Parameters.AddWithValue("@detalji_pp", textDetalji_PP_a.Text);
                    cm.Parameters.AddWithValue("@id", id_poslovnog_partnera);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Podaci su uspesno izmenjeni");
                    Ucitaj_Poslovnog_Partnera();
                    texNaziv_PP_a.Clear();
                    textPIB_PP_a.Clear();
                    textMaticni_Broj_PP_a.Clear();
                    textAdresa_PP_a.Clear();
                    cmbVrsta_PP_a.SelectedIndex = 0;
                    textDetalji_PP_a.Clear();
                    texNaziv_PP_a.Focus();
                }
            }
        }
        private void btnUcitaj_Radnika_Click(object sender, EventArgs e)
        {
            Ucitaj_Poslovnog_Partnera();
        }

        private void btn_Pretrazi_Radnika_Click(object sender, EventArgs e)
        {
            Pretraga_PP_a();
        }

        private void btnNovi_Radnik_Click(object sender, EventArgs e)
        {
            Unesi_Novog_PP_a();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Izmeni_PP_a();
        }

        private void dataGrid_PP_a_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone_pp_a = dataGrid_PP_a.Columns[e.ColumnIndex].Name;
            poslovni_partner_id = dataGrid_PP_a.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednosti id radnika u int obliku
            id_poslovnog_partnera = Int32.Parse(poslovni_partner_id);
            if (ime_kolone_pp_a == "Edit_PP_a")
            {
                texNaziv_PP_a.Text = dataGrid_PP_a.Rows[e.RowIndex].Cells[2].Value.ToString();
                textPIB_PP_a.Text = dataGrid_PP_a.Rows[e.RowIndex].Cells[3].Value.ToString();
                textMaticni_Broj_PP_a.Text = dataGrid_PP_a.Rows[e.RowIndex].Cells[4].Value.ToString();
                textAdresa_PP_a.Text = dataGrid_PP_a.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbVrsta_PP_a.SelectedItem = dataGrid_PP_a.Rows[e.RowIndex].Cells[6].Value.ToString();
                textDetalji_PP_a.Text = dataGrid_PP_a.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (ime_kolone_pp_a == "Delete_PP_a")
            {
                try
                {

                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM POSLOVNI_PARTNERI" +
                         " WHERE id = "+dataGrid_PP_a.Rows[e.RowIndex].Cells[1].Value.ToString() + "", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Red je uspesno izbrisan", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj_Poslovnog_Partnera();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnIzmeni_PP_a_Click(object sender, EventArgs e)
        {
            Izmeni_PP_a();
        }
    }
}
