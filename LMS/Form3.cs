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
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnLibrary.Height;
            PnlNav.Top = BtnLibrary.Top;
            PnlNav.Left = BtnLibrary.Left;
            BtnLibrary.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHistory.Height;
            PnlNav.Top = BtnHistory.Top;
            PnlNav.Left = BtnHistory.Left;
            BtnHistory.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnStaff.Height;
            PnlNav.Top = BtnStaff.Top;
            PnlNav.Left = BtnStaff.Left;
            BtnStaff.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAdmin.Height;
            PnlNav.Top = BtnAdmin.Top;
            PnlNav.Left = BtnAdmin.Left;
            BtnAdmin.BackColor = Color.FromArgb(46, 51, 73);
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

        private void BtnStaff_Leave(object sender, EventArgs e)
        {
            BtnStaff.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAdmin_Leave(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
