using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;





namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost:1521/XE;User Id = ADMIN1; Password = 08092002; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string username = txtUserName.Text;
            string password = textpassword.Text;
            if (txtUserName.Text == "" || textpassword.Text == "")
            {
                MessageBox.Show("Please Enter your User Name and Passowrd");
            }
            else
            {
                cmd.CommandText = "select * from REGISTRATION where username='" + username + "' and password = '" + password + "'";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                   
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }

            }
            conn.Dispose();
        }




        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            textpassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();
        }
    }
}
