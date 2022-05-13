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
    public partial class Login : Form
    {
        Form1 frm = new Form1();
        public static string TipProfila = "";
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public Login()
        {
            cn = new SqlConnection(dbcon.MyConection());
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loggedin = false;
            if (textPassword.Text != "" && textUsername.Text != "")
            {
                cn.Open();
                cm = new SqlCommand("select username, lozinka, tip_profila from PROFILI", cn);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["username"].ToString() == textUsername.Text && dr["lozinka"].ToString() == textPassword.Text)
                    {
                        textPassword.Clear();
                        textUsername.Clear();
                        TipProfila = dr["tip_profila"].ToString();
                        cn.Close();
                        dr.Close();
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                        loggedin = true;
                        break;
                    }
                }
                if (!loggedin)
                {
                    info.ForeColor = Color.Red;
                    info.Text = "Incorrect username or password!";
                }
            }
        }
    }
}
