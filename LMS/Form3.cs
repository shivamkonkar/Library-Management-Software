using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LMS
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );
        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnProfile.Height;
            PnlNav.Top = BtnProfile.Top;
            PnlNav.Left = BtnProfile.Left;

            LblTitle.Text = "Profile";
            this.PnlFormLoader.Controls.Clear();
            Form4 fm4 = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm4.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(fm4);
            fm4.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnProfile.Height;
            PnlNav.Top = BtnProfile.Top;
            PnlNav.Left = BtnProfile.Left;
            BtnProfile.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Profile";
            this.PnlFormLoader.Controls.Clear();
            Form4 fm4 = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm4.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(fm4);
            fm4.Show();
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnLibrary.Height;
            PnlNav.Top = BtnLibrary.Top;
            PnlNav.Left = BtnLibrary.Left;
            BtnLibrary.BackColor = Color.FromArgb(46, 51, 73);
            LblTitle.Text = "Library";

            
            this.PnlFormLoader.Controls.Clear();
            Form5 fm5 = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm5.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(fm5);
            fm5.Show();


        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHistory.Height;
            PnlNav.Top = BtnHistory.Top;
            PnlNav.Left = BtnHistory.Left;
            BtnHistory.BackColor = Color.FromArgb(46, 51, 73);
            LblTitle.Text = "History";

            this.PnlFormLoader.Controls.Clear();
            Form6 fm6 = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fm6.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(fm6);
            fm6.Show();

        }



        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            BtnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnLibrary_Leave(object sender, EventArgs e)
        {
            BtnLibrary.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnHistory_Leave(object sender, EventArgs e)
        {
            BtnHistory.BackColor = Color.FromArgb(24, 30, 54);
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Lblsearch_TextChanged(object sender, EventArgs e)
        {
            do
            {
                Lblsearch.Text = "";
                
            }
            while (false);
        }

        public void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
