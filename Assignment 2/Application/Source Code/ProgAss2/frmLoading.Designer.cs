namespace ProgAss2
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.lblPercentage = new System.Windows.Forms.Label();
            this.progBarLoad = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(464, 366);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(53, 35);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "0%";
            // 
            // progBarLoad
            // 
            this.progBarLoad.Location = new System.Drawing.Point(285, 338);
            this.progBarLoad.Name = "progBarLoad";
            this.progBarLoad.Size = new System.Drawing.Size(397, 25);
            this.progBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBarLoad.TabIndex = 6;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(384, 9);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(240, 63);
            this.lblLoading.TabIndex = 5;
            this.lblLoading.Text = "Loading...";
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 425);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progBarLoad);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar progBarLoad;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timerLoad;
    }
}