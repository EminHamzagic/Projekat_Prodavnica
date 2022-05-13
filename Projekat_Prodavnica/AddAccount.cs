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
    public partial class AddAccount : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string acc_id;
        int id_acc;
        public AddAccount()
        {
            cn = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
            cmbTip.Items.Add("Admin");
            cmbTip.Items.Add("Kasir");
            cmbTip.Items.Add("Magacioner");
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (textUsername.Text != " ")
                {

                    // Treba uneti ogranicenja vezano za unos po gradu i mestu
                    cn.Open();
                    cm = new SqlCommand("insert into PROFILI(username, lozinka, tip_profila) values(@username, @lozinka, @tip_profila)", cn);
                    cm.Parameters.AddWithValue("@username", textUsername.Text);
                    cm.Parameters.AddWithValue("@lozinka", textPassword.Text);
                    cm.Parameters.AddWithValue("@tip_profila", cmbTip.SelectedItem.ToString());
                    cm.ExecuteNonQuery();
                    MessageBox.Show(" Uspešno ste sačuvali account", " Unos accounta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textUsername.Clear();
                    textPassword.Clear();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show(" Niste uneli sve propratne podatke ", " Upozorenje!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Ucitaj();
            
        }
        public void Ucitaj()
        {
            int i = 0;
            dataGridAccounts.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select id, username, lozinka, tip_profila from PROFILI", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridAccounts.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(),
                dr["lozinka"].ToString(),
                dr["tip_profila"].ToString());
            }
            dr.Close();
            cn.Close();
            if (dataGridAccounts.Rows.Count != 0 && dataGridAccounts.Rows.Count != 1)
            {
                //Selekcija posledljeg reda i celije po redu, u za u gridu
                int Indeks_Reda = dataGridAccounts.Rows.Count - 1;
                int Indeks_Kolone = dataGridAccounts.Columns.Count - 1;

                dataGridAccounts.Rows[Indeks_Reda].Selected = true;

                dataGridAccounts.Rows[Indeks_Reda].Cells[Indeks_Kolone].Selected = true;
                //In case if you want to scroll down as well.
                dataGridAccounts.FirstDisplayedScrollingRowIndex = Indeks_Reda;

            }
        }
        private void btn_Ucitaj_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dataGridAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ime_kolone = dataGridAccounts.Columns[e.ColumnIndex].Name;
            acc_id = dataGridAccounts.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dodeljivanje vrednostiidradnika u int obliku
            id_acc = Int32.Parse(acc_id);
            if (ime_kolone == "Delete_Radnika")
            {
                try
                {
                    if (MessageBox.Show(" Da li ste sigurni da želite da izbrišete selektovani red?", " Brisanje Radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand(" DELETE FROM PROFILI " +
                         " WHERE id= " +
                           dataGridAccounts.Rows[e.RowIndex].Cells[1].Value.ToString() + " ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show(" Red je uspesno izbrisan", " Obaveštenje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ucitaj();
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
