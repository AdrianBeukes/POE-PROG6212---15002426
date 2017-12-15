namespace ProgAss2
{
    partial class frmCreateAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAppointment));
            this.lblHeading = new System.Windows.Forms.Label();
            this.mnuStripTop = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.cboxTime = new System.Windows.Forms.ComboBox();
            this.mnuStripTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(68, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(183, 25);
            this.lblHeading.TabIndex = 26;
            this.lblHeading.Text = "Create Appointment";
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
            this.mnuStripTop.Size = new System.Drawing.Size(343, 24);
            this.mnuStripTop.TabIndex = 27;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(15, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(227, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(15, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSurname.Location = new System.Drawing.Point(15, 39);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 31;
            this.lblSurname.Text = "Surname";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumber.Location = new System.Drawing.Point(15, 65);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 13);
            this.lblNumber.TabIndex = 32;
            this.lblNumber.Text = "Phone Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(15, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(15, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 34;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 35;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 36);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 36;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(98, 62);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(156, 20);
            this.txtNumber.TabIndex = 37;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 142);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 48);
            this.txtDescription.TabIndex = 38;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(98, 88);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(156, 20);
            this.DatePicker.TabIndex = 39;
            this.DatePicker.Value = new System.DateTime(2016, 8, 9, 17, 40, 59, 0);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(121, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 23);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(15, 120);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 41;
            this.lblTime.Text = "Time";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.cboxTime);
            this.panelInfo.Controls.Add(this.txtDescription);
            this.panelInfo.Controls.Add(this.btnExit);
            this.panelInfo.Controls.Add(this.lblTime);
            this.panelInfo.Controls.Add(this.btnCancel);
            this.panelInfo.Controls.Add(this.btnSubmit);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.DatePicker);
            this.panelInfo.Controls.Add(this.lblSurname);
            this.panelInfo.Controls.Add(this.lblNumber);
            this.panelInfo.Controls.Add(this.txtNumber);
            this.panelInfo.Controls.Add(this.lblDate);
            this.panelInfo.Controls.Add(this.txtSurname);
            this.panelInfo.Controls.Add(this.lblDescription);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Location = new System.Drawing.Point(12, 52);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(318, 235);
            this.panelInfo.TabIndex = 43;
            // 
            // cboxTime
            // 
            this.cboxTime.FormattingEnabled = true;
            this.cboxTime.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cboxTime.Location = new System.Drawing.Point(98, 115);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(156, 21);
            this.cboxTime.TabIndex = 42;
            // 
            // frmCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 298);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.mnuStripTop);
            this.Controls.Add(this.lblHeading);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - Create Appointment";
            this.mnuStripTop.ResumeLayout(false);
            this.mnuStripTop.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip mnuStripTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSignOut;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ComboBox cboxTime;
    }
}