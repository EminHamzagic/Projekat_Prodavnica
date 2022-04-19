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
    public partial class EvidencijaProdajeTroskova : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public EvidencijaProdajeTroskova()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConection());
        }
        public void Ucitaj_EvidencijuTroskova()
        {
            int trosak, marza, ukupna_zarada;
            dataGrid_EvidencijaTroskova.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select SUM(CAST(dd.trosak as int)) as trosak, SUM(CAST(dd.marza as int)) as marza " +
                "from DETALJI_DOKUMENTA as dd " +
                "left outer join ZAGLAVLJE_DOKUMENTA as zg on dd.id_zaglavlja = zg.ID " +
                "where zg.datum_dokumenta between '" + dtPeriodOd.Value + "' and '" + dtPeriodDo.Value + "' \n\n", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            dr.Read();
            trosak = Int32.Parse(dr["trosak"].ToString());
            marza = Int32.Parse(dr["marza"].ToString());
            dr.Close();
            cm = new SqlCommand("select SUM(CAST(oz.ukupna_zarada as int)) as ukupna_zarada " +
                "from OBRACUN_ZARADA as oz " +
                "where oz.period_od > '" + dtPeriodOd.Value + "' and period_do < '" + dtPeriodDo.Value + "'", cn);
            cm.ExecuteNonQuery();
            dr = cm.ExecuteReader();
            dr.Read();
            ukupna_zarada = Int32.Parse(dr["ukupna_zarada"].ToString());
            dr.Close();
            string poslovanje;
            if(marza - (trosak + ukupna_zarada) >= 0)
            {
                poslovanje = "U plusu";
            }
            else
            {
                poslovanje = "U minusu";
            }

            dataGrid_EvidencijaTroskova.Rows.Add(1, trosak.ToString(), ukupna_zarada.ToString(), marza.ToString(), poslovanje);
            cn.Close();
        }
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Ucitaj_EvidencijuTroskova();
        }
    }
}
