using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal result = 0;
        string operation = "";
        bool operationPressed = false;
        bool errorOccurred = false; 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VGTB6P9;Initial Catalog=Calculator;Integrated Security=True;TrustServerCertificate=True");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtscreen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            this.txtscreen.Text = this.txtscreen.Text + "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (this.errorOccurred)
            {
                this.txtscreen.Text = "";
                this.errorOccurred = false;
            }

            if (this.operationPressed)
            {
                this.txtscreen.Text = "";
            }
            this.operationPressed = false;
            if (this.txtscreen.Text.Contains(".") == false)
            {
                this.txtscreen.Text = this.txtscreen.Text + ".";
            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            this.result = Convert.ToDecimal(this.txtscreen.Text);
            this.operation = "+";
            this.operationPressed = true;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            this.result = Convert.ToDecimal(this.txtscreen.Text);
            this.operation = "-";
            this.operationPressed = true;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            this.result = Convert.ToDecimal(this.txtscreen.Text);
            this.operation = "*";
            this.operationPressed = true;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            this.result = Convert.ToDecimal(this.txtscreen.Text);
            this.operation = "/";
            this.operationPressed = true;
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            this.txtscreen.Text = "";
            this.result = 0;
            this.operation = "";
            this.errorOccurred = false;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            con.Open();
            decimal secondOperand = Convert.ToDecimal(this.txtscreen.Text);
            if (this.operation == "+")
            {
                this.result = this.result + secondOperand;
            }
            else if (this.operation == "-")
            {
                this.result = this.result - secondOperand;
            }
            else if (this.operation == "*")
            {
                this.result = this.result * secondOperand;
            }
            else if (this.operation == "/")
            {
                if (secondOperand == 0)
                {
                    this.txtscreen.Text = "Error";
                    this.errorOccurred = true; 
                    //this.txtscreen.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                this.result = this.result / secondOperand;
            }
            this.txtscreen.Text = this.result.ToString();
            string query = "INSERT INTO History (Answer) VALUES (@Result)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Result", this.result);
            cmd.ExecuteNonQuery();
            this.operationPressed = true;
            con.Close();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show(this);
            this.Hide();
        }
    }
}
