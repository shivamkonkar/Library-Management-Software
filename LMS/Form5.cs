using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            Form5 fm5 = new Form5();
            fm5.Hide();
            fm3.LblTitle.Text = "Profile";
            fm3.PnlFormLoader.Controls.Clear();
            Form8 fm8 = new Form8() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm8.FormBorderStyle = FormBorderStyle.None;
            fm3.PnlFormLoader.Controls.Add(fm8);
            fm8.Show();
            
        }
        
    }
}
