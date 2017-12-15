namespace ProgAss3
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblMovingMessage = new System.Windows.Forms.Label();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.rbtnExit = new ProgAss3.RoundButton();
            this.rbtnCreate = new ProgAss3.RoundButton();
            this.rbtnSignOut = new ProgAss3.RoundButton();
            this.rbtnView = new ProgAss3.RoundButton();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStripTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblAnsTimeSignedIn);
            this.pnlInfo.Controls.Add(this.lblSignedIn);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(195, 224);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblAnsTimeSignedIn
            // 
            this.lblAnsTimeSignedIn.AutoSize = true;
            this.lblAnsTimeSignedIn.Location = new System.Drawing.Point(30, 165);
            this.lblAnsTimeSignedIn.Name = "lblAnsTimeSignedIn";
            this.lblAnsTimeSignedIn.Size = new System.Drawing.Size(81, 13);
            this.lblAnsTimeSignedIn.TabIndex = 5;
            this.lblAnsTimeSignedIn.Text = "Time Signed-In ";
            // 
            // lblSignedIn
            // 
            this.lblSignedIn.AutoSize = true;
            this.lblSignedIn.Location = new System.Drawing.Point(47, 148);
            this.lblSignedIn.Name = "lblSignedIn";
            this.lblSignedIn.Size = new System.Drawing.Size(84, 13);
            this.lblSignedIn.TabIndex = 4;
            this.lblSignedIn.Text = "Time Signed-In :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 17);
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
            this.lblTime.Location = new System.Drawing.Point(44, 202);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 16);
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
            this.mnuStripTop.Size = new System.Drawing.Size(402, 24);
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
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(135, 29);
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
            // lblMovingMessage
            // 
            this.lblMovingMessage.AutoSize = true;
            this.lblMovingMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMovingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovingMessage.Location = new System.Drawing.Point(7, 239);
            this.lblMovingMessage.Name = "lblMovingMessage";
            this.lblMovingMessage.Size = new System.Drawing.Size(557, 16);
            this.lblMovingMessage.TabIndex = 26;
            this.lblMovingMessage.Text = "Always Be Thankfull....Every Smile Can Change A Life....Changing The World Throug" +
    "h Smiles";
            // 
            // timerMessage
            // 
            this.timerMessage.Tick += new System.EventHandler(this.timerMessage_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelOptions);
            this.panelMain.Controls.Add(this.pnlInfo);
            this.panelMain.Controls.Add(this.lblMovingMessage);
            this.panelMain.Location = new System.Drawing.Point(12, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(375, 264);
            this.panelMain.TabIndex = 27;
            // 
            // panelOptions
            // 
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.rbtnExit);
            this.panelOptions.Controls.Add(this.rbtnCreate);
            this.panelOptions.Controls.Add(this.rbtnSignOut);
            this.panelOptions.Controls.Add(this.rbtnView);
            this.panelOptions.Location = new System.Drawing.Point(204, 3);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(167, 224);
            this.panelOptions.TabIndex = 27;
            // 
            // rbtnExit
            // 
            this.rbtnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnExit.Location = new System.Drawing.Point(38, 162);
            this.rbtnExit.Name = "rbtnExit";
            this.rbtnExit.Size = new System.Drawing.Size(93, 45);
            this.rbtnExit.TabIndex = 32;
            this.rbtnExit.Text = "Exit";
            this.rbtnExit.UseVisualStyleBackColor = false;
            this.rbtnExit.Click += new System.EventHandler(this.rbtnExit_Click);
            // 
            // rbtnCreate
            // 
            this.rbtnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnCreate.Location = new System.Drawing.Point(13, 9);
            this.rbtnCreate.Name = "rbtnCreate";
            this.rbtnCreate.Size = new System.Drawing.Size(138, 45);
            this.rbtnCreate.TabIndex = 28;
            this.rbtnCreate.Text = "Create New Appointment";
            this.rbtnCreate.UseVisualStyleBackColor = false;
            this.rbtnCreate.Click += new System.EventHandler(this.rbtnCreate_Click);
            // 
            // rbtnSignOut
            // 
            this.rbtnSignOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnSignOut.Location = new System.Drawing.Point(38, 111);
            this.rbtnSignOut.Name = "rbtnSignOut";
            this.rbtnSignOut.Size = new System.Drawing.Size(93, 45);
            this.rbtnSignOut.TabIndex = 31;
            this.rbtnSignOut.Text = "Sign-Out";
            this.rbtnSignOut.UseVisualStyleBackColor = false;
            this.rbtnSignOut.Click += new System.EventHandler(this.rbtnSignOut_Click);
            // 
            // rbtnView
            // 
            this.rbtnView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnView.Location = new System.Drawing.Point(13, 60);
            this.rbtnView.Name = "rbtnView";
            this.rbtnView.Size = new System.Drawing.Size(138, 45);
            this.rbtnView.TabIndex = 29;
            this.rbtnView.Text = "View Appointments";
            this.rbtnView.UseVisualStyleBackColor = false;
            this.rbtnView.Click += new System.EventHandler(this.rbtnView_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnuStripTop);
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
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOptions.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAnsTimeSignedIn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblMovingMessage;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelOptions;
        private RoundButton rbtnCreate;
        private RoundButton rbtnView;
        private RoundButton rbtnSignOut;
        private RoundButton rbtnExit;
    }
}