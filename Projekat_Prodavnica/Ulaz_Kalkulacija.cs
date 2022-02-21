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
    public partial class Ulaz_Kalkulacija : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string vrsta_dokumenta = "Ulaz-Kalkulacija";
        int id_zaglavlja_dokumenta, id_artikla;

        //Promenljive koje su potrebne za unos novog reda u detaljima
        string naziv_artikla, sifra_artikla, jedinica_mere;
        double kolicina, nabavna_cena, nabavna_vrednost, marza, vrednost_marze,
        ukupna_vrednost_marze, prodajna_cena,
        poreska_stopa, prod_cena_pdv, prod_vrednost_pdv,
        vrednost_pdv, ukupna_vrednost_pdv;

        private void dataGrid_Zaglavlje_Kalkulacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_zaglavlja_dokumenta =
            Int32.Parse(dataGrid_Zaglavlje_Kalkulacije.Rows[e.RowIndex].Cells[1].Value.ToString());
            Ucitaj_Detalje_Dokumenta();
        }

        private void cmbNazivArtikla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cn.Open();
            var artikal_id = cmbNazivArtikla.SelectedValue;
            id_artikla = (int)artikal_id;

            cm = new SqlCommand("SELECT id, sifra_artikla, "+
            "naziv_artikla, jedinica_mere, stopa_poreska " +
             "FROM ARTIKAL "+
             "WHERE id = "+artikal_id, cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //Dodeljivanje poreske stope oznacenom artiklu
                sifra_artikla = dr["sifra_artikla"].ToString();
                naziv_artikla = dr["naziv_artikla"].ToString();
                jedinica_mere = dr["jedinica_mere"].ToString();
                textPDV_Stopa.Text = dr["stopa_poreska"].ToString();

            }
            dr.Close();
            cn.Close();
        }
    

        private void textMarza_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textProd_Cena.Focus(); //Kontrola sa fokusom
                kolicina = Double.Parse(textKolicina.Text.ToString());
                nabavna_cena = Double.Parse(textNab_Cena.Text.ToString());
                nabavna_vrednost = nabavna_cena * kolicina;
                textNab_Vrednost.Text = nabavna_vrednost.ToString();
                marza = Double.Parse(textMarza.Text.ToString());
                vrednost_marze = Math.Round(nabavna_cena * (marza / 100), 2);
                prodajna_cena = Math.Round(nabavna_cena + vrednost_marze, 2);
                //Definisanje prodajne cene
                textProd_Cena.Text = prodajna_cena.ToString("#.##");
                //Definisanje ostalih cena sa PDV-om

                poreska_stopa = Math.Round(Double.Parse(textPDV_Stopa.Text.ToString()), 2);
                vrednost_pdv = prodajna_cena * (poreska_stopa / 100);
                prod_cena_pdv = prodajna_cena + vrednost_pdv;
                //Predstavljanje prodajne cene sa PDV-om
                textProd_Cena_sa_PDV.Text = prod_cena_pdv.ToString();
                prod_vrednost_pdv = kolicina * prod_cena_pdv;
                textProd_Vred_sa_PDV.Text = prod_vrednost_pdv.ToString();
                //Ukupne vrednosti
                ukupna_vrednost_pdv = vrednost_pdv * kolicina;
                ukupna_vrednost_marze = vrednost_marze * kolicina;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        public void Ucitaj_Poslovne_Partnere()
        {
            //Selekcija Psolovnog Partnera
            cn.Open();

            cm = new SqlCommand("SELECT id, naziv_pp "+
            "FROM POSLOVNI_PARTNERI ", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_pp = new DataTable();
            data_pp.Load(dr);
            //Unos reda -Select PP- prije pozivanja ostalih redova
            
            DataRow Selelct_Osnovni_PP = data_pp.NewRow();
            Selelct_Osnovni_PP[0] = 0;
            Selelct_Osnovni_PP[1] = "- Select PP - ";
            data_pp.Rows.InsertAt(Selelct_Osnovni_PP, 0);
            
            cmbNazivPP.DataSource = data_pp;
            //Poziv ostalih redova u DataSourse;
            cmbNazivPP.DisplayMember = "naziv_pp";
            cmbNazivPP.ValueMember = "id";
            cmbNazivPP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNazivPP.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_Artikle()
        {
            //Ucitavanje artikala, ako kasnije bude bilo potrebno
            cn.Open();
            cm = new SqlCommand("SELECT id, naziv_artikla "+
            "FROM ARTIKAL", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_artikal = new DataTable();
            data_artikal.Load(dr);
            DataRow Selelct_Osnovi_Detalji = data_artikal.NewRow();
            Selelct_Osnovi_Detalji[0] = 0;
            Selelct_Osnovi_Detalji[1] = "-Select - ";
            data_artikal.Rows.InsertAt(Selelct_Osnovi_Detalji, 0);
            cmbNazivArtikla.DataSource = data_artikal;
            //Poziv ostalih redova u DataSourse;
            cmbNazivArtikla.DisplayMember = "naziv_artikla";
            cmbNazivArtikla.ValueMember = "id";
            cmbNazivArtikla.AutoCompleteMode = AutoCompleteMode.Suggest;

            cmbNazivArtikla.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Unesi_Zaglavlje()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * "+
                "FROM ZAGLAVLJE_DOKUMENTA "+
                "WHERE broj_dokumenta = '"+ textBrojDokumenta.Text + "'", cn);
                cm.ExecuteNonQuery();
                dr = null;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textBrojDokumenta.Text == dr["broj_dokumenta"].ToString())
                    {
                        MessageBox.Show("Postoji već Kalkulacija sa datim brojem dokumenta", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        textBrojDokumenta.Clear();

                        textBrojDokumenta.Focus();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textBrojDokumenta.Text != "")
                {
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO ZAGLAVLJE_DOKUMENTA(broj_dokumenta, nacin_placanja, id_poslovnog_partnera, datum_dokumenta, napomena, vrsta_dokumenta)" +
                    "VALUES(@broj_dokumenta, @nacin_placanja, @id_poslovnog_partnera, @datum_dokumenta, @napomena, @vrsta_dokumenta)", cn);
                    cm.Parameters.AddWithValue("@broj_dokumenta", textBrojDokumenta.Text);
                    cm.Parameters.AddWithValue("@nacin_placanja", cmbNacin_Placanja.SelectedItem);
                    cm.Parameters.AddWithValue("@id_poslovnog_partnera", cmbNazivPP.SelectedValue);
                    cm.Parameters.AddWithValue("@datum_dokumenta", dtDatumDokumenta.Value);
                    cm.Parameters.AddWithValue("@napomena", textNapomena.Text);
                    cm.Parameters.AddWithValue("@vrsta_dokumenta", vrsta_dokumenta);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste sačuvali zaglavlje dokumenta", "Unos Zaglavlja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBrojDokumenta.Clear();
                    cmbNacin_Placanja.SelectedIndex = 0;

                    cmbNazivPP.SelectedIndex = 0;
                    textNapomena.Clear();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBrojDokumenta.Focus();
                }
                //Ucitavanje artikala da bi se odmah video efekat unosa
                Ucitaj_Zaglavlje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ucitaj_Zaglavlje()
        {
            int i = 0;
            dataGrid_Zaglavlje_Kalkulacije.Rows.Clear();

            cn.Open();
            cm = new SqlCommand("Select zd.id as id, zd.broj_dokumenta as broj_dokumenta, zd.nacin_placanja as nacin_placanja, "+
            "pp.naziv_pp as naziv_pp_a, zd.datum_dokumenta as datum_dokumenta, zd.napomena as napomena " +
             "from ZAGLAVLJE_DOKUMENTA as zd " +
               "Left outer join POSLOVNI_PARTNERI as pp ON zd.id_poslovnog_partnera = pp.id " +
                  "order by zd.id ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Zaglavlje_Kalkulacije.Rows.Add(i, dr["id"].ToString(), dr["broj_dokumenta"].ToString(),
                dr["nacin_placanja"].ToString(), dr["naziv_pp_a"].ToString(),
                dr["datum_dokumenta"].ToString(), dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Zaglavlje_Kalkulacije.Rows.Count != 0 && dataGrid_Zaglavlje_Kalkulacije.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Zaglavlje_Kalkulacije.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Zaglavlje_Kalkulacije.Columns.Count - 1;
                dataGrid_Zaglavlje_Kalkulacije.Rows[Indeks_Reda].Selected = true;
                dataGrid_Zaglavlje_Kalkulacije.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;

                //In case if you want to scroll down as well.
                dataGrid_Zaglavlje_Kalkulacije.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Ucitaj_Detalje_Dokumenta()
        {
            int i = 0;
            dataGrid_Detalji_Kalkulacije.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT det_dok.id, art.sifra_artikla, art.naziv_artikla, det_dok.ulaz, "+
            "art.jedinica_mere, det_dok.nab_cena, det_dok.nab_vred, det_dok.marza, det_dok.prod_cena, art.stopa_poreska, "+
            "det_dok.prod_cena_pdv, det_dok.prod_vred_pdv, det_dok.vred_pdv, det_dok.marza_vred" +
            " FROM DETALJI_DOKUMENTA det_dok" +
              " LEFT OUTER JOIN ARTIKAL art ON det_dok.id_artikla = art.id" +
                 " LEFT OUTER JOIN ZAGLAVLJE_DOKUMENTA zag_dok ON det_dok.id_zaglavlja = zag_dok.id" +
                    " WHERE det_dok.id_zaglavlja = "+id_zaglavlja_dokumenta + ""+
                      " ORDER BY det_dok.id", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;

                dataGrid_Detalji_Kalkulacije.Rows.Add(i, dr["id"].ToString(), dr["sifra_artikla"].ToString(),
                dr["naziv_artikla"].ToString(), dr["ulaz"].ToString(),
                dr["jedinica_mere"].ToString(), dr["nab_cena"].ToString(),
                dr["nab_vred"].ToString(), dr["marza"].ToString(),
                dr["prod_cena"].ToString(), dr["stopa_poreska"].ToString(),
                dr["prod_cena_pdv"].ToString(), dr["prod_vred_pdv"].ToString(),
                dr["vred_pdv"].ToString(), dr["marza_vred"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Detalji_Kalkulacije.Rows.Count != 0 && dataGrid_Detalji_Kalkulacije.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Detalji_Kalkulacije.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Detalji_Kalkulacije.Columns.Count - 1;
                dataGrid_Detalji_Kalkulacije.Rows[Indeks_Reda].Selected = true;
                dataGrid_Detalji_Kalkulacije.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Detalji_Kalkulacije.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Unesi_Detalje_Dokumenta()

        {
            try
            {
                if (textProd_Vred_sa_PDV.Text != "")
{
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO DETALJI_DOKUMENTA(id_zaglavlja, id_artikla, ulaz, nab_cena, "+
                    "nab_vred, marza, prod_cena, prod_cena_pdv, "+
                    "prod_vred_pdv, vred_pdv, marza_vred ) "+
                    "VALUES(@id_zaglavlja, @id_artikla, @ulaz, "+
                  "@nab_cena, @nab_vred, @marza, @prod_cena, @prod_cena_pdv, "+
                  "@prod_vred_pdv, @vred_pdv, @marza_vred )", cn);
                    cm.Parameters.AddWithValue("@id_zaglavlja", id_zaglavlja_dokumenta );
                    cm.Parameters.AddWithValue("@id_artikla", id_artikla);
                    cm.Parameters.AddWithValue("@ulaz", kolicina );
                    cm.Parameters.AddWithValue("@nab_cena", nabavna_cena );
                    cm.Parameters.AddWithValue("@nab_vred", nabavna_vrednost);
                    cm.Parameters.AddWithValue("@marza", marza);
                    cm.Parameters.AddWithValue("@prod_cena", prodajna_cena);
                    cm.Parameters.AddWithValue("@prod_cena_pdv", prod_cena_pdv);
                    cm.Parameters.AddWithValue("@prod_vred_pdv", prod_vrednost_pdv);
                    cm.Parameters.AddWithValue("@vred_pdv", ukupna_vrednost_pdv);
                    cm.Parameters.AddWithValue("@marza_vred", ukupna_vrednost_marze);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Uspešno ste sačuvali red detalja dokumenta", "Unos Detalja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbNazivArtikla.SelectedIndex = 0;
                    textKolicina.Clear();
                    textNab_Cena.Clear();
                    textMarza.Clear();
                    textNab_Vrednost.Clear();
                    textProd_Cena.Clear();
                    textPDV_Stopa.Clear();
                    textProd_Cena_sa_PDV.Clear();
                    textProd_Vred_sa_PDV.Clear();
                    cn.Close();
                }
                   else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBrojDokumenta.Focus();
                }
                //Ucitavanje detalja da bi se odmah video efekat unosa
                Ucitaj_Detalje_Dokumenta();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Ulaz_Kalkulacija()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            //Dodavanje vrsta PP-a u ComboBox()
            cmbNacin_Placanja.Items.Add("VIRMAN");
            cmbNacin_Placanja.Items.Add("PLATNA KARTICA");
            cmbNacin_Placanja.Items.Add("GOTOVINA");
            //Selektovanje prve prednosti
            cmbNacin_Placanja.SelectedIndex = 0;

            //Ucitavanje inicijalnih vrednosti za Poslovne Partnere i Artikle
            Ucitaj_Poslovne_Partnere();
            Ucitaj_Artikle();
        }

        private void Ucitaj_Zaglavlje_Kalkulacije_Click(object sender, EventArgs e)
        {
            Ucitaj_Zaglavlje();
        }

        private void btn_Pretrazi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dodaj_Dokument_Click(object sender, EventArgs e)
        {
            Unesi_Detalje_Dokumenta();
            cmbNazivArtikla.Focus();
        }

        private void btn_Izmeni_Dokument_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dodaj_Zaglavlje_Click(object sender, EventArgs e)
        {
            Unesi_Zaglavlje();
        }

        private void btnIzmeni_Zaglavlje_Click(object sender, EventArgs e)
        {

        }
    }
}
