
namespace LMS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.Lblsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnLibrary = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Controls.Add(this.BtnLibrary);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BrookLand Bliss";
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblTitle.Location = new System.Drawing.Point(209, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(103, 32);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Profile";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // Lblsearch
            // 
            this.Lblsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsearch.ForeColor = System.Drawing.SystemColors.Info;
            this.Lblsearch.Location = new System.Drawing.Point(574, 12);
            this.Lblsearch.Multiline = true;
            this.Lblsearch.Name = "Lblsearch";
            this.Lblsearch.Size = new System.Drawing.Size(324, 28);
            this.Lblsearch.TabIndex = 3;
            this.Lblsearch.Text = " Search For Book...";
            this.Lblsearch.TextChanged += new System.EventHandler(this.Lblsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(911, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PnlFormLoader.TabIndex = 5;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistory.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnHistory.Image = global::LMS.Properties.Resources.icons8_time_machine_30;
            this.BtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHistory.Location = new System.Drawing.Point(0, 228);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(186, 42);
            this.BtnHistory.TabIndex = 1;
            this.BtnHistory.Text = "History";
            this.BtnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            this.BtnHistory.Leave += new System.EventHandler(this.BtnHistory_Leave);
            // 
            // BtnLibrary
            // 
            this.BtnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLibrary.FlatAppearance.BorderSize = 0;
            this.BtnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibrary.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnLibrary.Image = global::LMS.Properties.Resources.icons8_library_30;
            this.BtnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLibrary.Location = new System.Drawing.Point(0, 186);
            this.BtnLibrary.Name = "BtnLibrary";
            this.BtnLibrary.Size = new System.Drawing.Size(186, 42);
            this.BtnLibrary.TabIndex = 1;
            this.BtnLibrary.Text = "Library";
            this.BtnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLibrary.UseVisualStyleBackColor = true;
            this.BtnLibrary.Click += new System.EventHandler(this.BtnLibrary_Click);
            this.BtnLibrary.Leave += new System.EventHandler(this.BtnLibrary_Leave);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnProfile.Image = global::LMS.Properties.Resources.icons8_male_user_30;
            this.BtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProfile.Location = new System.Drawing.Point(0, 144);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(186, 42);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            this.BtnProfile.Leave += new System.EventHandler(this.BtnProfile_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.icons8_books_64;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lblsearch);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnLibrary;
        private System.Windows.Forms.Panel PnlNav;
        public System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox Lblsearch;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel PnlFormLoader;
    }
}