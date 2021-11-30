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
using System.Windows.Forms.DataVisualization.Charting;

namespace DASPP
{
    public partial class ADMIN_COMPANIES : Form
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
        SqlDataAdapter adp;
        SqlDataReader sdr;

        public ADMIN_COMPANIES(string value, string fn, string ln, string email, string cnt, string pass)
        {
            InitializeComponent();
            this.value = value;
            un.Text = value;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.cnt = cnt;
            this.pass = pass;
        }

        private void ADMIN_COMPANIES_Load(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_L = new ADMIN_LOGIN();
            AD_L.Show();
        }

        private void END_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void USR_PROFILE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_P = new ADMIN_PROFILE(value, fn, ln, email, cnt, pass);
            AD_P.Show();
        }

        private void KES_IND_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_kse = new ADMIN_KSE_ANALYSIS(value, fn, ln, email, cnt, pass);
            AD_kse.Show();
        }

        private void COMPANIES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AD_CMP = new ADMIN_COMPANIES(value, fn, ln, email, cnt, pass);
            AD_CMP.Show();

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HM = new HOME();
            HM.Show();
        }
    }
}
