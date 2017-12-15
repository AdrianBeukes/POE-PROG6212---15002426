namespace ProgFinal
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblVersioin = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxreturn = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(12, 12);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(138, 216);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(270, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(65, 25);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "About";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(187, 55);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(218, 52);
            this.lblInfo.TabIndex = 27;
            this.lblInfo.Text = "Durban First Health is an client appointment\r\nProgram which let you book, view, u" +
    "pdate, \r\ndelete, search or even print all appointments \r\nthat you have.";
            // 
            // lblVersioin
            // 
            this.lblVersioin.AutoSize = true;
            this.lblVersioin.BackColor = System.Drawing.Color.Transparent;
            this.lblVersioin.Location = new System.Drawing.Point(187, 122);
            this.lblVersioin.Name = "lblVersioin";
            this.lblVersioin.Size = new System.Drawing.Size(154, 65);
            this.lblVersioin.TabIndex = 28;
            this.lblVersioin.Text = "Version            :  0.29\r\n\r\nRelease date   : 8 August 2016\r\n\r\nCreator          " +
    "  : Adrian Beukes";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(320, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(61, 22);
            this.btnSubmit.TabIndex = 57;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(156, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "return to :";
            // 
            // cboxreturn
            // 
            this.cboxreturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxreturn.FormattingEnabled = true;
            this.cboxreturn.Items.AddRange(new object[] {
            "Main menu",
            "Sign-out"});
            this.cboxreturn.Location = new System.Drawing.Point(232, 207);
            this.cboxreturn.Name = "cboxreturn";
            this.cboxreturn.Size = new System.Drawing.Size(82, 21);
            this.cboxreturn.TabIndex = 55;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(387, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 22);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 239);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxreturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVersioin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - About";
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblVersioin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxreturn;
        private System.Windows.Forms.Button btnExit;
    }
}