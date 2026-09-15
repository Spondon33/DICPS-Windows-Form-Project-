namespace DICPS.Forms.CaseRecords
{
    partial class CaseFileForm
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
            this.grpCaseInfo = new System.Windows.Forms.GroupBox();
            this.lblCaseFile = new System.Windows.Forms.Label();
            this.lblCaseNumber = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.lblCaseType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.grpLinkedSuspects = new System.Windows.Forms.GroupBox();
            this.dgvSuspects = new System.Windows.Forms.DataGridView();
            this.btnUnlinkSuspect = new System.Windows.Forms.Button();
            this.btnLinkSuspect = new System.Windows.Forms.Button();
            this.grpCaseSummary = new System.Windows.Forms.GroupBox();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCaseSummary = new System.Windows.Forms.RichTextBox();
            this.txtDetectiveId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpCaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.grpLinkedSuspects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspects)).BeginInit();
            this.grpCaseSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCaseInfo
            // 
            this.grpCaseInfo.Controls.Add(this.btnDelete);
            this.grpCaseInfo.Controls.Add(this.txtDetectiveId);
            this.grpCaseInfo.Controls.Add(this.label4);
            this.grpCaseInfo.Controls.Add(this.dgvCases);
            this.grpCaseInfo.Controls.Add(this.btnShowAll);
            this.grpCaseInfo.Controls.Add(this.btnUpdate);
            this.grpCaseInfo.Controls.Add(this.btnCreate);
            this.grpCaseInfo.Controls.Add(this.cmbStatus);
            this.grpCaseInfo.Controls.Add(this.label2);
            this.grpCaseInfo.Controls.Add(this.txtCaseType);
            this.grpCaseInfo.Controls.Add(this.txtLocation);
            this.grpCaseInfo.Controls.Add(this.label1);
            this.grpCaseInfo.Controls.Add(this.lblCaseType);
            this.grpCaseInfo.Controls.Add(this.lblCaseNumber);
            this.grpCaseInfo.Controls.Add(this.txtCaseNumber);
            this.grpCaseInfo.Location = new System.Drawing.Point(12, 84);
            this.grpCaseInfo.Name = "grpCaseInfo";
            this.grpCaseInfo.Size = new System.Drawing.Size(778, 696);
            this.grpCaseInfo.TabIndex = 0;
            this.grpCaseInfo.TabStop = false;
            this.grpCaseInfo.Text = "Case Information";
            // 
            // lblCaseFile
            // 
            this.lblCaseFile.AutoSize = true;
            this.lblCaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCaseFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseFile.Location = new System.Drawing.Point(12, 19);
            this.lblCaseFile.Name = "lblCaseFile";
            this.lblCaseFile.Size = new System.Drawing.Size(164, 38);
            this.lblCaseFile.TabIndex = 19;
            this.lblCaseFile.Text = "Case File";
            // 
            // lblCaseNumber
            // 
            this.lblCaseNumber.AutoSize = true;
            this.lblCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCaseNumber.Location = new System.Drawing.Point(49, 55);
            this.lblCaseNumber.Name = "lblCaseNumber";
            this.lblCaseNumber.Size = new System.Drawing.Size(191, 30);
            this.lblCaseNumber.TabIndex = 6;
            this.lblCaseNumber.Text = "Case Number:";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Location = new System.Drawing.Point(253, 55);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(405, 29);
            this.txtCaseNumber.TabIndex = 7;
            this.txtCaseNumber.TextChanged += new System.EventHandler(this.txtCaseNumber_TextChanged);
            // 
            // lblCaseType
            // 
            this.lblCaseType.AutoSize = true;
            this.lblCaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCaseType.Location = new System.Drawing.Point(49, 104);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(154, 30);
            this.lblCaseType.TabIndex = 8;
            this.lblCaseType.Text = "Case Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(253, 158);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(405, 29);
            this.txtLocation.TabIndex = 11;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtCaseType
            // 
            this.txtCaseType.Location = new System.Drawing.Point(253, 107);
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(405, 29);
            this.txtCaseType.TabIndex = 12;
            this.txtCaseType.TextChanged += new System.EventHandler(this.txtCaseType_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cmbStatus.Location = new System.Drawing.Point(253, 207);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(405, 32);
            this.cmbStatus.TabIndex = 14;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(28, 333);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 59);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(396, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 59);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(579, 333);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(160, 59);
            this.btnShowAll.TabIndex = 22;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvCases
            // 
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Location = new System.Drawing.Point(28, 434);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.RowHeadersWidth = 72;
            this.dgvCases.RowTemplate.Height = 31;
            this.dgvCases.Size = new System.Drawing.Size(711, 227);
            this.dgvCases.TabIndex = 23;
            this.dgvCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellContentClick);
            // 
            // grpLinkedSuspects
            // 
            this.grpLinkedSuspects.Controls.Add(this.dgvSuspects);
            this.grpLinkedSuspects.Controls.Add(this.btnUnlinkSuspect);
            this.grpLinkedSuspects.Controls.Add(this.btnLinkSuspect);
            this.grpLinkedSuspects.Location = new System.Drawing.Point(796, 84);
            this.grpLinkedSuspects.Name = "grpLinkedSuspects";
            this.grpLinkedSuspects.Size = new System.Drawing.Size(778, 354);
            this.grpLinkedSuspects.TabIndex = 24;
            this.grpLinkedSuspects.TabStop = false;
            this.grpLinkedSuspects.Text = "Linked Suspects";
            // 
            // dgvSuspects
            // 
            this.dgvSuspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuspects.Location = new System.Drawing.Point(28, 55);
            this.dgvSuspects.Name = "dgvSuspects";
            this.dgvSuspects.RowHeadersWidth = 72;
            this.dgvSuspects.RowTemplate.Height = 31;
            this.dgvSuspects.Size = new System.Drawing.Size(711, 184);
            this.dgvSuspects.TabIndex = 23;
            this.dgvSuspects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuspects_CellContentClick);
            // 
            // btnUnlinkSuspect
            // 
            this.btnUnlinkSuspect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUnlinkSuspect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUnlinkSuspect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUnlinkSuspect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlinkSuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnlinkSuspect.Location = new System.Drawing.Point(413, 269);
            this.btnUnlinkSuspect.Name = "btnUnlinkSuspect";
            this.btnUnlinkSuspect.Size = new System.Drawing.Size(256, 59);
            this.btnUnlinkSuspect.TabIndex = 22;
            this.btnUnlinkSuspect.Text = "Unlink Suspect";
            this.btnUnlinkSuspect.UseVisualStyleBackColor = false;
            this.btnUnlinkSuspect.Click += new System.EventHandler(this.btnUnlinkSuspect_Click);
            // 
            // btnLinkSuspect
            // 
            this.btnLinkSuspect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLinkSuspect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLinkSuspect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLinkSuspect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkSuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLinkSuspect.Location = new System.Drawing.Point(103, 269);
            this.btnLinkSuspect.Name = "btnLinkSuspect";
            this.btnLinkSuspect.Size = new System.Drawing.Size(231, 59);
            this.btnLinkSuspect.TabIndex = 19;
            this.btnLinkSuspect.Text = "Link Suspect";
            this.btnLinkSuspect.UseVisualStyleBackColor = false;
            this.btnLinkSuspect.Click += new System.EventHandler(this.btnLinkSuspect_Click);
            // 
            // grpCaseSummary
            // 
            this.grpCaseSummary.Controls.Add(this.txtCaseSummary);
            this.grpCaseSummary.Controls.Add(this.btnClear);
            this.grpCaseSummary.Controls.Add(this.btnExportReport);
            this.grpCaseSummary.Controls.Add(this.btnGenerateSummary);
            this.grpCaseSummary.Location = new System.Drawing.Point(796, 444);
            this.grpCaseSummary.Name = "grpCaseSummary";
            this.grpCaseSummary.Size = new System.Drawing.Size(778, 336);
            this.grpCaseSummary.TabIndex = 25;
            this.grpCaseSummary.TabStop = false;
            this.grpCaseSummary.Text = "Case Summary";
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExportReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.Location = new System.Drawing.Point(349, 232);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(232, 59);
            this.btnExportReport.TabIndex = 22;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerateSummary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerateSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateSummary.Location = new System.Drawing.Point(39, 232);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(290, 59);
            this.btnGenerateSummary.TabIndex = 19;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = false;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(599, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 59);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCaseSummary
            // 
            this.txtCaseSummary.Location = new System.Drawing.Point(19, 41);
            this.txtCaseSummary.Name = "txtCaseSummary";
            this.txtCaseSummary.Size = new System.Drawing.Size(737, 162);
            this.txtCaseSummary.TabIndex = 25;
            this.txtCaseSummary.Text = "";
            this.txtCaseSummary.TextChanged += new System.EventHandler(this.txtCaseSummary_TextChanged);
            // 
            // txtDetectiveId
            // 
            this.txtDetectiveId.Location = new System.Drawing.Point(253, 263);
            this.txtDetectiveId.Name = "txtDetectiveId";
            this.txtDetectiveId.Size = new System.Drawing.Size(405, 29);
            this.txtDetectiveId.TabIndex = 25;
            this.txtDetectiveId.TextChanged += new System.EventHandler(this.txtDetectiveId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(49, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Detective ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(212, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 59);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CaseFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 802);
            this.Controls.Add(this.grpCaseSummary);
            this.Controls.Add(this.grpLinkedSuspects);
            this.Controls.Add(this.lblCaseFile);
            this.Controls.Add(this.grpCaseInfo);
            this.Name = "CaseFileForm";
            this.Text = "CaseFileForm";
            this.Load += new System.EventHandler(this.CaseFileForm_Load);
            this.grpCaseInfo.ResumeLayout(false);
            this.grpCaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.grpLinkedSuspects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspects)).EndInit();
            this.grpCaseSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCaseInfo;
        private System.Windows.Forms.Label lblCaseFile;
        private System.Windows.Forms.Label lblCaseNumber;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.GroupBox grpLinkedSuspects;
        private System.Windows.Forms.DataGridView dgvSuspects;
        private System.Windows.Forms.Button btnUnlinkSuspect;
        private System.Windows.Forms.Button btnLinkSuspect;
        private System.Windows.Forms.GroupBox grpCaseSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.RichTextBox txtCaseSummary;
        private System.Windows.Forms.TextBox txtDetectiveId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
    }
}