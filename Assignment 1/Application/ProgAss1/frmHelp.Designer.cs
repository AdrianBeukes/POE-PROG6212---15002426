namespace ProgAss1
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblVersioin = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxreturn = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picHelp
            // 
            this.picHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(12, 12);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(138, 243);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 1;
            this.picHelp.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(271, 3);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(52, 25);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Help";
            // 
            // lblVersioin
            // 
            this.lblVersioin.AutoSize = true;
            this.lblVersioin.BackColor = System.Drawing.Color.Transparent;
            this.lblVersioin.Location = new System.Drawing.Point(159, 149);
            this.lblVersioin.Name = "lblVersioin";
            this.lblVersioin.Size = new System.Drawing.Size(279, 65);
            this.lblVersioin.TabIndex = 30;
            this.lblVersioin.Text = "Contact Number    :  031 555 5555\r\n\r\nWebsite                 : www.DurbanFirstHea" +
    "lth555.co.za\r\n\r\nEmail                      : DurbanFirstHealth555@myMail.co.za";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(180, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(241, 104);
            this.lblInfo.TabIndex = 29;
            this.lblInfo.Text = "You can find help by contacting customer support\r\n\r\nbefore contacting us, be sure" +
    " to have read the\r\ndocumentation for solutions\r\n\r\nIf you can\'t get a hold on us," +
    " contact us via email\r\n\r\nThank you\r\n";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(323, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(61, 22);
            this.btnSubmit.TabIndex = 53;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(159, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "return to :";
            // 
            // cboxreturn
            // 
            this.cboxreturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboxreturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxreturn.FormattingEnabled = true;
            this.cboxreturn.Items.AddRange(new object[] {
            "Main menu",
            "Sign-out"});
            this.cboxreturn.Location = new System.Drawing.Point(235, 234);
            this.cboxreturn.Name = "cboxreturn";
            this.cboxreturn.Size = new System.Drawing.Size(82, 21);
            this.cboxreturn.TabIndex = 51;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(390, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 22);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxreturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVersioin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - Help";
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblVersioin;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxreturn;
        private System.Windows.Forms.Button btnExit;
    }
}