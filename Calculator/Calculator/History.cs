using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
            this.Hide();
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.historyTableAdapter.Fill(this.calculatorDataSet.History);
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VGTB6P9;Initial Catalog=Calculator;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM History", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            dgmain.DataSource = dt;
            dgmain.Refresh();
            con.Close();

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VGTB6P9;Initial Catalog=Calculator;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM History", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("All history cleared!");
            dgmain.DataSource = null;
            dgmain.Refresh();
        }
    }
}
