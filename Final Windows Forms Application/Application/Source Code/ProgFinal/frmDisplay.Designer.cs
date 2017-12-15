namespace ProgFinal
{
    partial class frmDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplay));
            this.mnuStripTop = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.appointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dFHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dFHDataSet = new ProgFinal.DFHDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new ProgFinal.DFHDataSetTableAdapters.AppointmentsTableAdapter();
            this.aPPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFHDataSet)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.mnuStripTop.Size = new System.Drawing.Size(775, 24);
            this.mnuStripTop.TabIndex = 3;
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
            this.lblHeading.Location = new System.Drawing.Point(316, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(133, 25);
            this.lblHeading.TabIndex = 26;
            this.lblHeading.Text = "Appointments";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(13, 283);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(626, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(13, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(663, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.AutoGenerateColumns = false;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPPNODataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn});
            this.dataGridViewInfo.DataSource = this.appointmentsBindingSource1;
            this.dataGridViewInfo.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(741, 240);
            this.dataGridViewInfo.TabIndex = 28;
            // 
            // appointmentsBindingSource1
            // 
            this.appointmentsBindingSource1.DataMember = "Appointments";
            this.appointmentsBindingSource1.DataSource = this.dFHDataSetBindingSource;
            // 
            // dFHDataSetBindingSource
            // 
            this.dFHDataSetBindingSource.DataSource = this.dFHDataSet;
            this.dFHDataSetBindingSource.Position = 0;
            // 
            // dFHDataSet
            // 
            this.dFHDataSet.DataSetName = "DFHDataSet";
            this.dFHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(317, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add New Entry";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 20);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search Name";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(106, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(16, 13);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "->";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(90, 271);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(582, 13);
            this.lblUpdate.TabIndex = 33;
            this.lblUpdate.Text = "* for updating, just double click on the desired cell, and edit it, after update " +
    "select the updated row and press Save Update";
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.btnUpdate);
            this.panelInfo.Controls.Add(this.lblUpdate);
            this.panelInfo.Controls.Add(this.lblSearch);
            this.panelInfo.Controls.Add(this.btnSearch);
            this.panelInfo.Controls.Add(this.txtSearch);
            this.panelInfo.Controls.Add(this.btnAdd);
            this.panelInfo.Controls.Add(this.dataGridViewInfo);
            this.panelInfo.Controls.Add(this.btnExit);
            this.panelInfo.Controls.Add(this.btnBack);
            this.panelInfo.Controls.Add(this.btnDelete);
            this.panelInfo.Controls.Add(this.btnPrint);
            this.panelInfo.Location = new System.Drawing.Point(13, 52);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(749, 350);
            this.panelInfo.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(317, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Save Updates";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.dFHDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // aPPNODataGridViewTextBoxColumn
            // 
            this.aPPNODataGridViewTextBoxColumn.DataPropertyName = "APP_NO";
            this.aPPNODataGridViewTextBoxColumn.HeaderText = "APP_NO";
            this.aPPNODataGridViewTextBoxColumn.Name = "aPPNODataGridViewTextBoxColumn";
            this.aPPNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnuStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban First Health - Display";
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            this.mnuStripTop.ResumeLayout(false);
            this.mnuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFHDataSet)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSignOut;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Panel panelInfo;
        private DFHDataSet dFHDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private DFHDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsBindingSource1;
        private System.Windows.Forms.BindingSource dFHDataSetBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
    }
}