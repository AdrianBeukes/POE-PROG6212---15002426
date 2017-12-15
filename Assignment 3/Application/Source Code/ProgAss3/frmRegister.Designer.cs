namespace ProgAss3
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNewInfo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(197, 256);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(135, 20);
            this.txtConfirm.TabIndex = 51;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Location = new System.Drawing.Point(87, 259);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(91, 13);
            this.lblConfirm.TabIndex = 50;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNote.Location = new System.Drawing.Point(66, 30);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(286, 13);
            this.lblNote.TabIndex = 49;
            this.lblNote.Text = "*Note that this information will be saved for security reasons";
            // 
            // lblNewInfo
            // 
            this.lblNewInfo.AutoSize = true;
            this.lblNewInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewInfo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNewInfo.Location = new System.Drawing.Point(86, 146);
            this.lblNewInfo.Name = "lblNewInfo";
            this.lblNewInfo.Size = new System.Drawing.Size(268, 22);
            this.lblNewInfo.TabIndex = 48;
            this.lblNewInfo.Text = "Please enter the new users information";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Location = new System.Drawing.Point(30, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(366, 22);
            this.lblInfo.TabIndex = 47;
            this.lblInfo.Text = "Please enter an alreaddy registered users information";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(197, 222);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(135, 20);
            this.txtNewPass.TabIndex = 46;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Location = new System.Drawing.Point(87, 225);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(53, 13);
            this.lblNewPass.TabIndex = 45;
            this.lblNewPass.Text = "Password";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(197, 189);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(135, 20);
            this.txtNewName.TabIndex = 44;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewName.Location = new System.Drawing.Point(87, 189);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(57, 13);
            this.lblNewName.TabIndex = 43;
            this.lblNewName.Text = "UserName";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Location = new System.Drawing.Point(179, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(80, 25);
            this.lblHeading.TabIndex = 42;
            this.lblHeading.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(120, 296);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(199, 26);
            this.btnRegister.TabIndex = 40;
            this.btnRegister.Text = "Register User";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(325, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 26);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 38;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(87, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(13, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 26);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(87, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "UserName";
            // 
            // PanelInfo
            // 
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInfo.Controls.Add(this.lblNewInfo);
            this.PanelInfo.Controls.Add(this.txtConfirm);
            this.PanelInfo.Controls.Add(this.lblName);
            this.PanelInfo.Controls.Add(this.lblConfirm);
            this.PanelInfo.Controls.Add(this.txtName);
            this.PanelInfo.Controls.Add(this.lblNote);
            this.PanelInfo.Controls.Add(this.btnClear);
            this.PanelInfo.Controls.Add(this.lblPassword);
            this.PanelInfo.Controls.Add(this.lblInfo);
            this.PanelInfo.Controls.Add(this.txtPassword);
            this.PanelInfo.Controls.Add(this.txtNewPass);
            this.PanelInfo.Controls.Add(this.btnBack);
            this.PanelInfo.Controls.Add(this.lblNewPass);
            this.PanelInfo.Controls.Add(this.btnRegister);
            this.PanelInfo.Controls.Add(this.txtNewName);
            this.PanelInfo.Controls.Add(this.lblNewName);
            this.PanelInfo.Location = new System.Drawing.Point(12, 37);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(433, 334);
            this.PanelInfo.TabIndex = 52;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 384);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.lblHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - Register";
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNewInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel PanelInfo;
    }
}