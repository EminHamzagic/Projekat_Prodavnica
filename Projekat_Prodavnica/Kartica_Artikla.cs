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
    public partial class Kartica_Artikla : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public int id_artikla;
        public Kartica_Artikla()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
            Ucitaj_Artikle();
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
            Selelct_Osnovi_Detalji[1] = "-Select-";
            data_artikal.Rows.InsertAt(Selelct_Osnovi_Detalji, 0);
            cmbNazivArtikla_Kartica.DataSource = data_artikal;
            //Poziv ostalih redova u DataSourse;
            cmbNazivArtikla_Kartica.DisplayMember = "naziv_artikla";
            cmbNazivArtikla_Kartica.ValueMember = "id";
            cmbNazivArtikla_Kartica.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNazivArtikla_Kartica.AutoCompleteSource = AutoCompleteSource.ListItems;
            dr.Close();
            cn.Close();
        }
        public void Ucitaj_Istoriju_Artikala()
        {
            int i = 0, priv_stanje = 0, stanje = 0;
            dataGrid_Kartica_Artikla.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select d.id, z.broj_dokumenta, z.datum_dokumenta, d.ulaz, d.izlaz, sum(cast(d.ulaz as int) - cast(d.izlaz as int)) as stanje " +
            "from ZAGLAVLJE_DOKUMENTA z "+
            "left outer join DETALJI_DOKUMENTA d on z.ID = d.id_zaglavlja " +
            "where d.id_artikla = " + id_artikla + " and datum_dokumenta < '" + dtDo.Value.ToString("yyyy-MM-dd") + "' and datum_dokumenta > '" + dtOd.Value.ToString("yyyy-MM-dd") + "' " +
            "group by d.id, z.broj_dokumenta, z.datum_dokumenta, d.ulaz, d.izlaz ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                if (i == 1)
                {
                    priv_stanje = Int32.Parse(dr["ulaz"].ToString()) - Int32.Parse(dr["izlaz"].ToString());
                    stanje = priv_stanje;
                }
                else
                {
                    stanje += Int32.Parse(dr["ulaz"].ToString()) - Int32.Parse(dr["izlaz"].ToString());
                }
                dataGrid_Kartica_Artikla.Rows.Add(i, dr["id"].ToString(),
                dr["broj_dokumenta"].ToString(),
                dr["datum_dokumenta"].ToString(),
                dr["ulaz"].ToString(),
                dr["izlaz"].ToString(), stanje);
            }
            dr.Close();
            cn.Close();
            if (dataGrid_Kartica_Artikla.Rows.Count != 0 && dataGrid_Kartica_Artikla.Rows.Count != 1)
{
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGrid_Kartica_Artikla.Rows.Count - 1;
                int Indeks_Kolone = dataGrid_Kartica_Artikla.Columns.Count - 1;
                dataGrid_Kartica_Artikla.Rows[Indeks_Reda].Selected = true;
                dataGrid_Kartica_Artikla.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected
                = true;
                //In case if you want to scroll down as well.
                dataGrid_Kartica_Artikla.FirstDisplayedScrollingRowIndex = Indeks_Reda;
            }
        }

        private void cmbNazivArtikla_Kartica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var artikal_id = cmbNazivArtikla_Kartica.SelectedValue;
            id_artikla = (int)artikal_id;
        }

        private void btnPretraga_Artikala_Click(object sender, EventArgs e)
        {
            Ucitaj_Istoriju_Artikala();
        }
    }
}
