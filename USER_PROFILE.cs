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

namespace DASPP
{
    public partial class USER_PROFILE : Form
    {
        public string value { get; set; }
        public string fn { get; set; }
        public string ln { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string cnt { get; set; }

        public string STRING = "Data Source=DESKTOP-SP96GJ2\\SQLEXPRESS;Initial Catalog=DASPP;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader dr;
        SqlDataAdapter adp;

        public USER_PROFILE(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            this.value = value;
            un.Text = value;
            u_n.Text = value;
            f_n.Text = fn;
            l_n.Text = ln;
            em.Text = email;
            cntc.Text = cnt;
            passw.Text = pass;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_P = new USER_PROFILE(value, fn, ln, email, cnt, pass);
            US_P.Show();

        }

        private void KES_IND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_kse = new USER_KSE_ANALYSIS(value, fn, ln, email, cnt, pass);
            US_kse.Show();
        }

        private void COMPANIES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_CMP = new USER_COMPANIES(value, fn, ln, email, cnt, pass);
            US_CMP.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form US_L = new USER_LOGIN();
            US_L.Show();
        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }
    }
}
