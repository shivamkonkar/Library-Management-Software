using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace LMS
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                string oradb = "Data Source=localhost:1521/XE;User Id = ADMIN1; Password = 08092002; ";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();

                cmd.CommandText = "insert into REGISTRATION (rid,username,password) values('"+ txtID.Text + "','" + textuser.Text + "','" + textpass.Text + "')";

                cmd.Connection = conn;

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    MessageBox.Show("Success!");
                    this.Close();
                    Form1 login = new Form1();
                    login.Show();
                }
                conn.Dispose();
            
        }
    }
}
