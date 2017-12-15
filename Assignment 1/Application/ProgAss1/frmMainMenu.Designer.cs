namespace ProgAss1
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblAnsTimeSignedIn = new System.Windows.Forms.Label();
            this.lblSignedIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.mnuStripTop = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblAnsTimeSignedIn);
            this.pnlInfo.Controls.Add(this.lblSignedIn);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Location = new System.Drawing.Point(12, 28);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(215, 215);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblAnsTimeSignedIn
            // 
            this.lblAnsTimeSignedIn.AutoSize = true;
            this.lblAnsTimeSignedIn.Location = new System.Drawing.Point(84, 151);
            this.lblAnsTimeSignedIn.Name = "lblAnsTimeSignedIn";
            this.lblAnsTimeSignedIn.Size = new System.Drawing.Size(81, 13);
            this.lblAnsTimeSignedIn.TabIndex = 5;
            this.lblAnsTimeSignedIn.Text = "Time Signed-In ";
            // 
            // lblSignedIn
            // 
            this.lblSignedIn.AutoSize = true;
            this.lblSignedIn.Location = new System.Drawing.Point(3, 151);
            this.lblSignedIn.Name = "lblSignedIn";
            this.lblSignedIn.Size = new System.Drawing.Size(84, 13);
            this.lblSignedIn.TabIndex = 4;
            this.lblSignedIn.Text = "Time Signed-In :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(44, 187);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Current Time";
            // 
            // mnuStripTop
            // 
            this.mnuStripTop.BackColor = System.Drawing.Color.Transparent;
            this.mnuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout,
            this.mnuHelp});
            this.mnuStripTop.Location = new System.Drawing.Point(0, 0);
            this.mnuStripTop.Name = "mnuStripTop";
            this.mnuStripTop.Size = new System.Drawing.Size(408, 24);
            this.mnuStripTop.TabIndex = 2;
            this.mnuStripTop.Text = "MenuStripTop";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSignOut,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuSignOut
            // 
            this.mnuSignOut.Name = "mnuSignOut";
            this.mnuSignOut.Size = new System.Drawing.Size(122, 22);
            this.mnuSignOut.Text = "Sign-Out";
            this.mnuSignOut.Click += new System.EventHandler(this.mnuSignOut_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(122, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(252, 76);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create New Appointment";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(252, 114);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Appointments Appointment";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(252, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search For Client";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(308, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(12, 249);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(81, 23);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign-Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(263, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(111, 25);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Main Menu";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 283);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.mnuStripTop);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStripTop;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - Main Menu";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStripTop.ResumeLayout(false);
            this.mnuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip mnuStripTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSignOut;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Label lblSignedIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblAnsTimeSignedIn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Timer timerClock;
    }
}