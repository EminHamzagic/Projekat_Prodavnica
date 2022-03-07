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
    public partial class Izlaz_Kalkulacije : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        //Javne promenljive
        string vrsta_dokumenta = "Izlaz-Racun", max_id_detalja,
        naziv_artikla_racun, sifra_artikla_racun, jedinica_mere_racun;
        int id_zaglavlja_dokumenta, id_artikla;
        int id_poslovnog_partnera;

        double kolicina_izlaz, prod_cena_izlaz, prod_vred_izlaz, rabat_stopa, prod_cena_sa_rabatom,
        prod_cena_sa_rabatom_sa_PDV, prod_vred_sa_rabatom, prod_vred_sa_rabatom_sa_PDV,
        vred_pdv_sa_rabatom, vred_marze_sa_rabatom,
        stopa_pdv, nabavna_cena;
        public Izlaz_Kalkulacije()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            //Dodavanje vrsta PP-a u ComboBox()
            cmbNacin_Placanja_Racun.Items.Add("VIRMAN");
            cmbNacin_Placanja_Racun.Items.Add("PLATNA KARTICA");
            cmbNacin_Placanja_Racun.Items.Add("GOTOVINA");
            //Selektovanje prve prednosti
            cmbNacin_Placanja_Racun.SelectedIndex = 0;
            //Ucitavanje inicijalnih vrednosti za Poslovne Partnere i Artikle
            Ucitaj_Poslovne_Partnere();
            Ucitaj_Artikle();
        }
        public void Dodaj_Detalje_Racuna()
        {
            try
            {
                if (textProd_Vred_sa_PDV_Rabat_Racun.Text != "")
                {
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();

                    cm = new SqlCommand(" INSERT INTO DETALJI_DOKUMENTA(id_zaglavlja, id_artikla, izlaz, prod_cena_izlaz, " +
                    " prod_vred_izlaz, rabat_stopa, prod_cena_sa_rabatom, " +
                    " prod_cena_sa_rabatom_sa_PDV, prod_vred_sa_rabatom, " +
                    " prod_vred_sa_rabatom_sa_PDV, vred_pdv_sa_rabatom, " +
                    " vred_marze_sa_rabatom ) " +
                    " VALUES(@id_zaglavlja, @id_artikla, @izlaz, " +
                  " @prod_cena_izlaz, @prod_vred_izlaz, @rabat_stopa," +
                  " @prod_cena_sa_rabatom, @prod_cena_sa_rabatom_sa_PDV, " +
                  " @prod_vred_sa_rabatom, @prod_vred_sa_rabatom_sa_PDV, " +
                  " @vred_pdv_sa_rabatom, @vred_marze_sa_rabatom) ", cn);
                    cm.Parameters.AddWithValue("@id_zaglavlja", id_zaglavlja_dokumenta);
                    cm.Parameters.AddWithValue("@id_artikla", id_artikla);
                    cm.Parameters.AddWithValue("@izlaz", kolicina_izlaz);
                    cm.Parameters.AddWithValue("@prod_cena_izlaz", prod_cena_izlaz);
                    cm.Parameters.AddWithValue("@prod_vred_izlaz", prod_vred_izlaz);
                    cm.Parameters.AddWithValue("@rabat_stopa", rabat_stopa);
                    cm.Parameters.AddWithValue("@prod_cena_sa_rabatom", prod_cena_sa_rabatom);
                    cm.Parameters.AddWithValue("@prod_cena_sa_rabatom_sa_PDV", prod_cena_sa_rabatom_sa_PDV);
                    cm.Parameters.AddWithValue("@prod_vred_sa_rabatom", prod_vred_sa_rabatom);
                    cm.Parameters.AddWithValue("@prod_vred_sa_rabatom_sa_PDV", prod_vred_sa_rabatom_sa_PDV);
                    cm.Parameters.AddWithValue("@vred_pdv_sa_rabatom", vred_pdv_sa_rabatom);
                    cm.Parameters.AddWithValue("@vred_marze_sa_rabatom", vred_marze_sa_rabatom);
                    cm.ExecuteNonQuery();

                    MessageBox.Show(" Uspešno ste sačuvali red detalja dokumenta", " Unos Detalja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbNazivArtikla_Racun.SelectedIndex = 0;
                    textKolicina_Racun.Clear();
                    textNabavna_Cena_Racun.Clear();
                    textProd_Cena_Racun.Clear();
                    textRabat_Racuna.Clear();
                    textProd_Cena_Rabat_Racun.Clear();
                    textPDV_Stopa_Racun.Clear();
                    textProd_Cena_sa_PDV_sa_Rabatom.Clear();
                    textProd_Vred_sa_PDV_Rabat_Racun.Clear();
                    textVred_Marze_sa_Rabat.Clear();
                    //Fokusiramo se na sledeci artikal koji eventulano treba da se unse
                    cmbNazivArtikla_Racun.Focus();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show(" Niste uneli sve propratne podatke", " Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbNazivArtikla_Racun.Focus();
                }

                //Ucitavanje detalja da bi se odmah video efekat unosa
                Ucitaj_Detalje_Racuna();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Ucitaj_Detalje_Racuna()
        {
            int i = 0;
            dataGrid_Detalji_Racun.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT det_dok.id, art.sifra_artikla, art.naziv_artikla, det_dok.izlaz, " +
            "art.jedinica_mere, det_dok.prod_cena_izlaz, det_dok.rabat_stopa, " +
            "det_dok.prod_cena_sa_rabatom, art.stopa_poreska, det_dok.prod_cena_sa_rabatom_sa_PDV, " +
"det_dok.prod_vred_sa_rabatom, det_dok.prod_vred_sa_rabatom_sa_PDV, " +
"det_dok.vred_pdv_sa_rabatom, det_dok.vred_marze_sa_rabatom " +
 "FROM DETALJI_DOKUMENTA det_dok " +
   "LEFT OUTER JOIN ARTIKAL art ON det_dok.id_artikla = art.id " +
      "LEFT OUTER JOIN ZAGLAVLJE_DOKUMENTA zag_dok ON det_dok.id_zaglavlja = zag_dok.id " +
         "WHERE det_dok.id_zaglavlja = " + id_zaglavlja_dokumenta + "" +

           "ORDER BY det_dok.id", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Detalji_Racun.Rows.Add(i, dr["id"].ToString(), dr["sifra_artikla"].ToString(),
                dr["naziv_artikla"].ToString(), dr["izlaz"].ToString(),
                dr["jedinica_mere"].ToString(), dr["prod_cena_izlaz"].ToString(),
                dr["rabat_stopa"].ToString(), dr["prod_cena_sa_rabatom"].ToString(),
                dr["stopa_poreska"].ToString(), dr["prod_cena_sa_rabatom_sa_PDV"].ToString(),
                dr["prod_vred_sa_rabatom"].ToString(),
                dr["prod_vred_sa_rabatom_sa_PDV"].ToString(),
                dr["vred_pdv_sa_rabatom"].ToString(), dr["vred_marze_sa_rabatom"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Detalji_Racun.Rows.Count != 0 && dataGrid_Detalji_Racun.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Detalji_Racun.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Detalji_Racun.Columns.Count - 1;
                dataGrid_Detalji_Racun.Rows[Indeks_Reda].Selected = true;
                dataGrid_Detalji_Racun.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;

                //In case if you want to scroll down as well.
                dataGrid_Detalji_Racun.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        public void Ucitaj_Poslovne_Partnere()
        {
            //Selekcija Psolovnog Partnera
            cn.Open();
            cm = new SqlCommand("SELECT id, naziv_pp " +
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


            cmbNazivPP_Racun.DataSource = data_pp;
            //Poziv ostalih redova u DataSourse;
            cmbNazivPP_Racun.DisplayMember = "naziv_pp";
            cmbNazivPP_Racun.ValueMember = "id";
            cmbNazivPP_Racun.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNazivPP_Racun.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_Artikle()
        {
            //Ucitavanje artikala, ako kasnije bude bilo potrebno
            cn.Open();
            cm = new SqlCommand("SELECT id, naziv_artikla " +
            "FROM ARTIKAL ", cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            DataTable data_artikal = new DataTable();
            data_artikal.Load(dr);

            DataRow Selelct_Osnovi_Detalji = data_artikal.NewRow();
            Selelct_Osnovi_Detalji[0] = 0;
            Selelct_Osnovi_Detalji[1] = "-Select - ";
            data_artikal.Rows.InsertAt(Selelct_Osnovi_Detalji, 0);
            cmbNazivArtikla_Racun.DataSource = data_artikal;
            //Poziv ostalih redova u DataSourse;
            cmbNazivArtikla_Racun.DisplayMember = "naziv_artikla";
            cmbNazivArtikla_Racun.ValueMember = "id";
            cmbNazivArtikla_Racun.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNazivArtikla_Racun.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_Zaglavlje_Racuna()
        {
            int i = 0;
            dataGrid_Zaglavlje_Racuna.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select zd.id as id, zd.broj_dokumenta as broj_dokumenta, zd.nacin_placanja as nacin_placanja, " +
            "pp.naziv_pp as naziv_pp_a, zd.datum_dokumenta as datum_dokumenta, zd.napomena as napomena " +
             "from ZAGLAVLJE_DOKUMENTA as zd " +
               "Left outer join POSLOVNI_PARTNERI as pp ON zd.id_poslovnog_partnera = pp.id " +
                  "Where zd.vrsta_dokumenta = 'Izlaz-Racun' " +
"order by zd.id ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Zaglavlje_Racuna.Rows.Add(i, dr["id"].ToString(), dr["broj_dokumenta"].ToString(),
                dr["nacin_placanja"].ToString(), dr["naziv_pp_a"].ToString(),
                dr["datum_dokumenta"].ToString(), dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Zaglavlje_Racuna.Rows.Count != 0 && dataGrid_Zaglavlje_Racuna.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Zaglavlje_Racuna.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Zaglavlje_Racuna.Columns.Count - 1;
                dataGrid_Zaglavlje_Racuna.Rows[Indeks_Reda].Selected = true;
                dataGrid_Zaglavlje_Racuna.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Zaglavlje_Racuna.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }

        }
        public void Dodaj_Zaglavlje_Racuna()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * " +
                "FROM ZAGLAVLJE_DOKUMENTA " +
                "WHERE broj_dokumenta = '" + textBrojDokumenta_Racun.Text + "' AND vrsta_dokumenta=" + "'Izlaz-Racun'", cn);
                cm.ExecuteNonQuery();
                dr = null;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (textBrojDokumenta_Racun.Text == dr["broj_dokumenta"].ToString())
                    {
                        MessageBox.Show("Postoji već Racun sa datim brojem dokumenta", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        dr.Close();
                        cn.Close();
                        textBrojDokumenta_Racun.Clear();
                        textBrojDokumenta_Racun.Focus();
                        break;
                    }
                }
                dr.Close();
                cn.Close();
                if (textBrojDokumenta_Racun.Text != "")
                {
                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO ZAGLAVLJE_DOKUMENTA(broj_dokumenta, nacin_placanja, id_poslovnog_partnera, datum_dokumenta, napomena, vrsta_dokumenta)" +
                    "VALUES(@broj_dokumenta, @nacin_placanja, @id_poslovnog_partnera, @datum_dokumenta, @napomena, @vrsta_dokumenta)", cn);
                    cm.Parameters.AddWithValue("@broj_dokumenta", textBrojDokumenta_Racun.Text);
                    cm.Parameters.AddWithValue("@nacin_placanja", cmbNacin_Placanja_Racun.SelectedItem);
                    cm.Parameters.AddWithValue("@id_poslovnog_partnera", cmbNazivPP_Racun.SelectedValue);
                    cm.Parameters.AddWithValue("@datum_dokumenta", dtDatumDokumenta_Racun.Value);
                    cm.Parameters.AddWithValue("@napomena", textNapomena_Racun.Text);
                    cm.Parameters.AddWithValue("@vrsta_dokumenta", vrsta_dokumenta);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Uspešno ste sačuvali zaglavlje dokumenta", "Unos Zaglavlja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBrojDokumenta_Racun.Clear();
                    cmbNacin_Placanja_Racun.SelectedIndex = 0;
                    cmbNazivPP_Racun.SelectedIndex = 0;
                    textNapomena_Racun.Clear();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Niste uneli sve propratne podatke", "Upozorenje!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBrojDokumenta_Racun.Focus();
                }
                //Ucitavanje artikala da bi se odmah video efekat unosa
                Ucitaj_Zaglavlje_Racuna();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Izmeni_Zaglavlje()
        {
            if (MessageBox.Show("Želite li zaista za izmenite podatke o Zaglavlju", "Podaci o Artiklu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBrojDokumenta_Racun.Text != "")
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE ZAGLAVLJE_DOKUMENTA set broj_dokumenta = @broj_dokumenta, " +
                      "nacin_placanja = @nacin_placanja," +
                      "id_poslovnog_partnera = @id_poslovnog_partnera, " +
                      "datum_dokumenta = @datum_dokumenta, " +
                      "napomena = @napomena, " +
                      "vrsta_dokumenta = @vrsta_dokumenta " +
                      " WHERE ID = @ID", cn);
                    cm.Parameters.AddWithValue("@ID", id_poslovnog_partnera);
                    cm.Parameters.AddWithValue("@broj_dokumenta", textBrojDokumenta_Racun.Text);
                    cm.Parameters.AddWithValue("@nacin_placanja", cmbNacin_Placanja_Racun.SelectedItem);
                    cm.Parameters.AddWithValue("@id_poslovnog_partnera", cmbNazivPP_Racun.SelectedValue);
                    cm.Parameters.AddWithValue("@datum_dokumenta", dtDatumDokumenta_Racun.Value);
                    cm.Parameters.AddWithValue("@napomena", textNapomena_Racun.Text);
                    cm.Parameters.AddWithValue("@vrsta_dokumenta", vrsta_dokumenta);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Podaci su uspesno izmenjeni");
                    textBrojDokumenta_Racun.Clear();
                    cmbNacin_Placanja_Racun.SelectedIndex = 0;
                    cmbNazivPP_Racun.SelectedIndex = 0;
                    textNapomena_Racun.Clear();
                    cn.Close();
                    Ucitaj_Zaglavlje_Racuna();
                }
            }
        }
        void Izmeni_Detalje()
        {
            if (MessageBox.Show("Želite li zaista za izmenite podatke o Detalju Dokumenta", "Podaci o Artiklu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textKolicina_Racun.Text != "")
                {
                    cn.Open();
                    try
                    {
                        cm = new SqlCommand("UPDATE DETALJI_DOKUMENTA set id_zaglavlja = @id_zaglavlja, " +
                          "id_artikla = @id_artikla," +
                          "izlaz = @izlaz, " +
                          "prod_cena_izlaz = @prod_cena_izlaz, " +
                          "prod_vred_izlaz = @prod_vred_izlaz, " +
                          "rabat_stopa = @rabat_stopa, " +
                          "prod_cena_sa_rabatom = @prod_cena_sa_rabatom, " +
                          "prod_cena_sa_rabatom_sa_PDV = @prod_cena_sa_rabatom_sa_PDV, " +
                          "prod_vred_sa_rabatom = @prod_vred_sa_rabatom, " +
                          "prod_vred_sa_rabatom_sa_PDV = @prod_vred_sa_rabatom_sa_PDV, " +
                          "vred_pdv_sa_rabatom = @vred_pdv_sa_rabatom, " +
                          "vred_mazre_sa_rabatom = @vred_marze_sa_rabatom " +
                          " WHERE ID = @ID", cn);
                        cm.Parameters.AddWithValue("@ID", id_poslovnog_partnera);
                        cm.Parameters.AddWithValue("@id_zaglavlja", id_zaglavlja_dokumenta);
                        cm.Parameters.AddWithValue("@id_artikla", id_artikla);
                        cm.Parameters.AddWithValue("@izlaz", kolicina_izlaz);
                        cm.Parameters.AddWithValue("@prod_cena_izlaz", prod_cena_izlaz);
                        cm.Parameters.AddWithValue("@prod_vred_izlaz", prod_vred_izlaz);
                        cm.Parameters.AddWithValue("@rabat_stopa", rabat_stopa);
                        cm.Parameters.AddWithValue("@prod_cena_sa_rabatom", prod_cena_sa_rabatom);
                        cm.Parameters.AddWithValue("@prod_cena_sa_rabatom_sa_PDV", prod_cena_sa_rabatom_sa_PDV);
                        cm.Parameters.AddWithValue("@prod_vred_sa_rabatom", prod_vred_sa_rabatom);
                        cm.Parameters.AddWithValue("@prod_vred_sa_rabatom_sa_PDV", prod_vred_sa_rabatom_sa_PDV);
                        cm.Parameters.AddWithValue("@vred_pdv_sa_rabatom", vred_pdv_sa_rabatom);
                        cm.Parameters.AddWithValue("@vred_marze_sa_rabatom", vred_marze_sa_rabatom);
                        cm.ExecuteNonQuery();

                        MessageBox.Show(" Uspešno ste sačuvali red detalja dokumenta", " Unos Detalja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbNazivArtikla_Racun.SelectedIndex = 0;
                        textKolicina_Racun.Clear();
                        textNabavna_Cena_Racun.Clear();
                        textProd_Cena_Racun.Clear();
                        textRabat_Racuna.Clear();
                        textProd_Cena_Rabat_Racun.Clear();
                        textPDV_Stopa_Racun.Clear();
                        textProd_Cena_sa_PDV_sa_Rabatom.Clear();
                        textProd_Vred_sa_PDV_Rabat_Racun.Clear();
                        textVred_Marze_sa_Rabat.Clear();
                        //Fokusiramo se na sledeci artikal koji eventulano treba da se unse
                        cmbNazivArtikla_Racun.Focus();
                        cn.Close();
                        Ucitaj_Detalje_Racuna();
                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void UcitajZaglavlje_Racuna_Click(object sender, EventArgs e)
        {
            Ucitaj_Zaglavlje_Racuna();
        }

        private void btn_Pretrazi_Click(object sender, EventArgs e)
        {
            Pretrazi_Dokument();
        }

        private void btn_Dodaj_Zaglavlje_Click(object sender, EventArgs e)
        {
            Dodaj_Zaglavlje_Racuna();
        }

        private void btnIzmeni_Zaglavlje_Click(object sender, EventArgs e)
        {
            Izmeni_Zaglavlje();
        }

        private void btn_Dodaj_Dokument_Click(object sender, EventArgs e)
        {
            Dodaj_Detalje_Racuna();
        }

        private void btn_Izmeni_Dokument_Click(object sender, EventArgs e)
        {
            Izmeni_Detalje();
        }

        private void cmbNazivArtikla_Racun_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cn.Open();
            var artikal_id = cmbNazivArtikla_Racun.SelectedValue;
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
                sifra_artikla_racun = dr["sifra_artikla"].ToString();
                naziv_artikla_racun = dr["naziv_artikla"].ToString();
                jedinica_mere_racun = dr["jedinica_mere"].ToString();
                textPDV_Stopa_Racun.Text = dr["stopa_poreska"].ToString();
                //Potrebna mi je ova stopa radi racunanja kasnije projadajne cene sa PDV-om
                stopa_pdv = Double.Parse(textPDV_Stopa_Racun.Text.ToString());

            }
            dr.Close();
            //Pretraga maksimalnog ID iz tabele detalja za dati artikal
            cm = new SqlCommand("select max(id) as id_detalja_dokumenta, id_artikla " +
             "from DETALJI_DOKUMENTA "+
             "where id_artikla = "+artikal_id + " AND ulaz IS NOT NULL " +
               "group by id_artikla ",cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                max_id_detalja = dr["id_detalja_dokumenta"].ToString();
            }
            /* Potrebno je da se na osnovu projanjednog maksimalnog id_detalja za dati artikal
            pronadju i ostale vrednosti cena potrebne za dalji rad
            */
            dr.Close();
            MessageBox.Show(max_id_detalja);
            cm = new SqlCommand("select id, id_artikla, prod_cena_izlaz, prod_cena "+
            "from DETALJI_DOKUMENTA "+
            "where id = "+Int32.Parse(max_id_detalja), cn);
            cm.ExecuteNonQuery();
            dr = null;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                textNabavna_Cena_Racun.Text = dr["prod_cena_izlaz"].ToString();
                textProd_Cena_Racun.Text = dr["prod_cena"].ToString();
                textRabat_Racuna.Text = "0.00" ;
                textProd_Cena_Rabat_Racun.Text = dr["prod_cena"].ToString();
                //Pomocna promenljiva koja mi je kasnije potrebna radi provere pradajne cene sa PDV-om
                // i nabavne cene, jer ne smem da prodajem u minusu.
                nabavna_cena = Double.Parse(textNabavna_Cena_Racun.Text.ToString());

            }

            dr.Close();
            cn.Close();
        }

        void Pretrazi_Dokument()
        {
            int i = 0;
            dataGrid_Zaglavlje_Racuna.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select zd.id as id, zd.broj_dokumenta as broj_dokumenta, zd.nacin_placanja as nacin_placanja, " +
            "pp.naziv_pp as naziv_pp_a, zd.datum_dokumenta as datum_dokumenta, zd.napomena as napomena " +
             "from ZAGLAVLJE_DOKUMENTA as zd " +
               "Left outer join POSLOVNI_PARTNERI as pp ON zd.id_poslovnog_partnera = pp.id " +
               "WHERE datum_dokumenta BETWEEN '" + dtPretOd.Value.ToString("yyyy-MM-dd") + "' AND '" + dtPretDo.Value.ToString("yyyy-MM-dd") + "' " +
                  "order by zd.id ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGrid_Zaglavlje_Racuna.Rows.Add(i, dr["id"].ToString(), dr["broj_dokumenta"].ToString(),
                dr["nacin_placanja"].ToString(), dr["naziv_pp_a"].ToString(),
                dr["datum_dokumenta"].ToString(), dr["napomena"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Detalji_Racun.Rows.Count != 0 && dataGrid_Detalji_Racun.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Detalji_Racun.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Detalji_Racun.Columns.Count - 1;
                dataGrid_Detalji_Racun.Rows[Indeks_Reda].Selected = true;
                dataGrid_Detalji_Racun.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGrid_Detalji_Racun.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }
        private void textKolicina_Racun_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                textRabat_Racuna.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textRabat_Racuna_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                rabat_stopa = Double.Parse(textRabat_Racuna.Text.ToString());
                nabavna_cena = Double.Parse(textNabavna_Cena_Racun.Text.ToString());
                prod_cena_izlaz = Double.Parse(textProd_Cena_Racun.Text.ToString());
                prod_cena_sa_rabatom = Math.Round(prod_cena_izlaz - (prod_cena_izlaz * rabat_stopa / 100), 2);

                if (nabavna_cena >= prod_cena_sa_rabatom)
                {
                    MessageBox.Show("Prodajna cena sa Rabatom ne smije da bude manja do nabavne cene", "Upozorene");
                    textRabat_Racuna.Focus();
                }
                else
                {
                    kolicina_izlaz = Double.Parse(textKolicina_Racun.Text.ToString());

                    prod_vred_izlaz = kolicina_izlaz * prod_cena_izlaz;
                    prod_cena_sa_rabatom_sa_PDV = Math.Round(prod_cena_sa_rabatom + (prod_cena_sa_rabatom *
                    stopa_pdv / 100), 2);
                    prod_vred_sa_rabatom = Math.Round((prod_cena_sa_rabatom * kolicina_izlaz), 2);
                    prod_vred_sa_rabatom_sa_PDV = Math.Round((prod_cena_sa_rabatom_sa_PDV * kolicina_izlaz), 2);
                    vred_pdv_sa_rabatom = Math.Round((prod_vred_sa_rabatom_sa_PDV - prod_vred_sa_rabatom), 2);

                    vred_marze_sa_rabatom = Math.Round(((prod_cena_sa_rabatom - nabavna_cena) * kolicina_izlaz),
                    2);
                    //Treba ispuniti vrednosti text polja odgovarajucim izracunatim vrednostima
                    textProd_Cena_Rabat_Racun.Text = prod_cena_sa_rabatom.ToString();
                    textProd_Cena_sa_PDV_sa_Rabatom.Text = prod_cena_sa_rabatom_sa_PDV.ToString();
                    textProd_Vred_sa_PDV_Rabat_Racun.Text = prod_vred_sa_rabatom_sa_PDV.ToString();
                    textVred_Marze_sa_Rabat.Text = vred_marze_sa_rabatom.ToString();
                    btn_Dodaj_Dokument.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                // textRabat_Racuna.Focus(); //Kontrola sa fokusom
            }
        }

        private void dataGrid_Zaglavlje_Racuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_zaglavlja_dokumenta = Int32.Parse(dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[1].Value.ToString());
            Ucitaj_Detalje_Racuna();
            string poslovni_partner_id;
            string ime_kolone_pp_a = dataGrid_Zaglavlje_Racuna.Columns[e.ColumnIndex].Name;
            poslovni_partner_id = dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednosti id radnika u int obliku
            id_poslovnog_partnera = Int32.Parse(poslovni_partner_id);
            if (ime_kolone_pp_a == "Edit_Zaglavlje")
            {
                textBrojDokumenta_Racun.Text = dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbNacin_Placanja_Racun.SelectedItem = dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbNazivPP_Racun.SelectedItem = dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtDatumDokumenta_Racun.Value = DateTime.Parse(dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[5].Value.ToString());
                textNapomena_Racun.Text = dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else if (ime_kolone_pp_a == "Delete_Zaglavlje")
            {
                try
                {

                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM ZAGLAVLJE_DOKUMENTA" +
                         " WHERE id = " + dataGrid_Zaglavlje_Racuna.Rows[e.RowIndex].Cells[1].Value.ToString() + "", cn);
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

        private void dataGrid_Detalji_Racun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string poslovni_partner_id;
            string ime_kolone_pp_a = dataGrid_Detalji_Racun.Columns[e.ColumnIndex].Name;
            poslovni_partner_id = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednosti id radnika u int obliku
            id_poslovnog_partnera = Int32.Parse(poslovni_partner_id);
            if (ime_kolone_pp_a == "Edit_Detalji")
            {
                cmbNazivArtikla_Racun.SelectedItem = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[3].Value.ToString();
                textKolicina_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[4].Value.ToString();
                textProd_Cena_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[6].Value.ToString();
                textRabat_Racuna.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[7].Value.ToString();
                textProd_Cena_Rabat_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[8].Value.ToString();
                textPDV_Stopa_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[9].Value.ToString();
                textProd_Cena_sa_PDV_sa_Rabatom.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[10].Value.ToString();
                textProd_Vred_sa_PDV_Rabat_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[11].Value.ToString();
                textProd_Vred_sa_PDV_Rabat_Racun.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[12].Value.ToString();
                textVred_Marze_sa_Rabat.Text = dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[13].Value.ToString();
            }
            else if (ime_kolone_pp_a == "Delete_Detalji")
            {
                try
                {

                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete selektovani red?", "Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM DETALJI_DOKUMENTA" +
                         " WHERE id = " + dataGrid_Detalji_Racun.Rows[e.RowIndex].Cells[1].Value.ToString() + "", cn);
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
