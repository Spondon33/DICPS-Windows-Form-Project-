namespace DICPS.Forms.Evidence
{
    partial class EvidenceDashboardForm
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
            this.lblLoggedInName = new System.Windows.Forms.Label();
            this.lblLoggedInUserID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEvidenceDashboard = new System.Windows.Forms.Label();
            this.lblSearchByCaseID = new System.Windows.Forms.Label();
            this.txtSearchCaseId = new System.Windows.Forms.TextBox();
            this.btnSearchByCase = new System.Windows.Forms.Button();
            this.lblSearchByType = new System.Windows.Forms.Label();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearchByType = new System.Windows.Forms.Button();
            this.btnShowUnlinked = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvEvidence = new System.Windows.Forms.DataGridView();
            this.btnAddEvidence = new System.Windows.Forms.Button();
            this.btnDeleteEvidence = new System.Windows.Forms.Button();
            this.btnChainOfCustody = new System.Windows.Forms.Button();
            this.btnEvidenceReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidence)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedInName
            // 
            this.lblLoggedInName.AutoSize = true;
            this.lblLoggedInName.Location = new System.Drawing.Point(43, 98);
            this.lblLoggedInName.Name = "lblLoggedInName";
            this.lblLoggedInName.Size = new System.Drawing.Size(70, 25);
            this.lblLoggedInName.TabIndex = 18;
            this.lblLoggedInName.Text = "Name:";
            // 
            // lblLoggedInUserID
            // 
            this.lblLoggedInUserID.AutoSize = true;
            this.lblLoggedInUserID.Location = new System.Drawing.Point(43, 64);
            this.lblLoggedInUserID.Name = "lblLoggedInUserID";
            this.lblLoggedInUserID.Size = new System.Drawing.Size(78, 25);
            this.lblLoggedInUserID.TabIndex = 17;
            this.lblLoggedInUserID.Text = "UserID:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(818, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 62);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEvidenceDashboard
            // 
            this.lblEvidenceDashboard.AutoSize = true;
            this.lblEvidenceDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblEvidenceDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEvidenceDashboard.Location = new System.Drawing.Point(25, 17);
            this.lblEvidenceDashboard.Name = "lblEvidenceDashboard";
            this.lblEvidenceDashboard.Size = new System.Drawing.Size(617, 38);
            this.lblEvidenceDashboard.TabIndex = 14;
            this.lblEvidenceDashboard.Text = "Forensic Officer / Evidence Dashboard";
            // 
            // lblSearchByCaseID
            // 
            this.lblSearchByCaseID.AutoSize = true;
            this.lblSearchByCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByCaseID.Location = new System.Drawing.Point(42, 186);
            this.lblSearchByCaseID.Name = "lblSearchByCaseID";
            this.lblSearchByCaseID.Size = new System.Drawing.Size(266, 32);
            this.lblSearchByCaseID.TabIndex = 19;
            this.lblSearchByCaseID.Text = "Search by CaseID:";
            this.lblSearchByCaseID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearchCaseId
            // 
            this.txtSearchCaseId.Location = new System.Drawing.Point(324, 189);
            this.txtSearchCaseId.Name = "txtSearchCaseId";
            this.txtSearchCaseId.Size = new System.Drawing.Size(443, 29);
            this.txtSearchCaseId.TabIndex = 20;
            // 
            // btnSearchByCase
            // 
            this.btnSearchByCase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchByCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchByCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchByCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearchByCase.Location = new System.Drawing.Point(804, 162);
            this.btnSearchByCase.Name = "btnSearchByCase";
            this.btnSearchByCase.Size = new System.Drawing.Size(153, 61);
            this.btnSearchByCase.TabIndex = 21;
            this.btnSearchByCase.Text = "Search";
            this.btnSearchByCase.UseVisualStyleBackColor = false;
            this.btnSearchByCase.Click += new System.EventHandler(this.btnSearchByCase_Click);
            // 
            // lblSearchByType
            // 
            this.lblSearchByType.AutoSize = true;
            this.lblSearchByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByType.Location = new System.Drawing.Point(42, 273);
            this.lblSearchByType.Name = "lblSearchByType";
            this.lblSearchByType.Size = new System.Drawing.Size(234, 32);
            this.lblSearchByType.TabIndex = 22;
            this.lblSearchByType.Text = "Search by Type:";
            this.lblSearchByType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Physical",
            "Digital"});
            this.cmbSearchType.Location = new System.Drawing.Point(324, 273);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(443, 32);
            this.cmbSearchType.TabIndex = 23;
            // 
            // btnSearchByType
            // 
            this.btnSearchByType.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchByType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchByType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchByType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearchByType.Location = new System.Drawing.Point(804, 257);
            this.btnSearchByType.Name = "btnSearchByType";
            this.btnSearchByType.Size = new System.Drawing.Size(153, 59);
            this.btnSearchByType.TabIndex = 24;
            this.btnSearchByType.Text = "Search";
            this.btnSearchByType.UseVisualStyleBackColor = false;
            this.btnSearchByType.Click += new System.EventHandler(this.btnSearchByType_Click);
            // 
            // btnShowUnlinked
            // 
            this.btnShowUnlinked.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowUnlinked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowUnlinked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowUnlinked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUnlinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowUnlinked.Location = new System.Drawing.Point(311, 754);
            this.btnShowUnlinked.Name = "btnShowUnlinked";
            this.btnShowUnlinked.Size = new System.Drawing.Size(381, 58);
            this.btnShowUnlinked.TabIndex = 25;
            this.btnShowUnlinked.Text = "Show Unlinked Evidence";
            this.btnShowUnlinked.UseVisualStyleBackColor = false;
            this.btnShowUnlinked.Click += new System.EventHandler(this.btnShowUnlinked_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(417, 1044);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(153, 60);
            this.btnShowAll.TabIndex = 26;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvEvidence
            // 
            this.dgvEvidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidence.Location = new System.Drawing.Point(48, 349);
            this.dgvEvidence.Name = "dgvEvidence";
            this.dgvEvidence.RowHeadersWidth = 72;
            this.dgvEvidence.RowTemplate.Height = 31;
            this.dgvEvidence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvidence.Size = new System.Drawing.Size(909, 374);
            this.dgvEvidence.TabIndex = 27;
            // 
            // btnAddEvidence
            // 
            this.btnAddEvidence.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddEvidence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEvidence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddEvidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddEvidence.Location = new System.Drawing.Point(190, 855);
            this.btnAddEvidence.Name = "btnAddEvidence";
            this.btnAddEvidence.Size = new System.Drawing.Size(244, 58);
            this.btnAddEvidence.TabIndex = 28;
            this.btnAddEvidence.Text = "Add Evidence";
            this.btnAddEvidence.UseVisualStyleBackColor = false;
            this.btnAddEvidence.Click += new System.EventHandler(this.btnAddEvidence_Click);
            // 
            // btnDeleteEvidence
            // 
            this.btnDeleteEvidence.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteEvidence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteEvidence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteEvidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEvidence.Location = new System.Drawing.Point(531, 855);
            this.btnDeleteEvidence.Name = "btnDeleteEvidence";
            this.btnDeleteEvidence.Size = new System.Drawing.Size(261, 58);
            this.btnDeleteEvidence.TabIndex = 29;
            this.btnDeleteEvidence.Text = "Delete Evidence";
            this.btnDeleteEvidence.UseVisualStyleBackColor = false;
            this.btnDeleteEvidence.Click += new System.EventHandler(this.btnDeleteEvidence_Click);
            // 
            // btnChainOfCustody
            // 
            this.btnChainOfCustody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChainOfCustody.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnChainOfCustody.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChainOfCustody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChainOfCustody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnChainOfCustody.Location = new System.Drawing.Point(173, 958);
            this.btnChainOfCustody.Name = "btnChainOfCustody";
            this.btnChainOfCustody.Size = new System.Drawing.Size(278, 60);
            this.btnChainOfCustody.TabIndex = 30;
            this.btnChainOfCustody.Text = "Chain of Custody";
            this.btnChainOfCustody.UseVisualStyleBackColor = false;
            this.btnChainOfCustody.Click += new System.EventHandler(this.btnChainOfCustody_Click);
            // 
            // btnEvidenceReport
            // 
            this.btnEvidenceReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEvidenceReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEvidenceReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEvidenceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidenceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEvidenceReport.Location = new System.Drawing.Point(531, 958);
            this.btnEvidenceReport.Name = "btnEvidenceReport";
            this.btnEvidenceReport.Size = new System.Drawing.Size(261, 60);
            this.btnEvidenceReport.TabIndex = 31;
            this.btnEvidenceReport.Text = "Evidence Report";
            this.btnEvidenceReport.UseVisualStyleBackColor = false;
            this.btnEvidenceReport.Click += new System.EventHandler(this.btnEvidenceReport_Click);
            // 
            // EvidenceDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1135);
            this.Controls.Add(this.btnEvidenceReport);
            this.Controls.Add(this.btnChainOfCustody);
            this.Controls.Add(this.btnDeleteEvidence);
            this.Controls.Add(this.btnAddEvidence);
            this.Controls.Add(this.dgvEvidence);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnShowUnlinked);
            this.Controls.Add(this.btnSearchByType);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.lblSearchByType);
            this.Controls.Add(this.btnSearchByCase);
            this.Controls.Add(this.txtSearchCaseId);
            this.Controls.Add(this.lblSearchByCaseID);
            this.Controls.Add(this.lblLoggedInName);
            this.Controls.Add(this.lblLoggedInUserID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEvidenceDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvidenceDashboardForm";
            this.Text = "EvidenceDashboardForm";
            this.Load += new System.EventHandler(this.EvidenceDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoggedInName;
        private System.Windows.Forms.Label lblLoggedInUserID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEvidenceDashboard;
        private System.Windows.Forms.Label lblSearchByCaseID;
        private System.Windows.Forms.TextBox txtSearchCaseId;
        private System.Windows.Forms.Button btnSearchByCase;
        private System.Windows.Forms.Label lblSearchByType;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnSearchByType;
        private System.Windows.Forms.Button btnShowUnlinked;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvEvidence;
        private System.Windows.Forms.Button btnAddEvidence;
        private System.Windows.Forms.Button btnDeleteEvidence;
        private System.Windows.Forms.Button btnChainOfCustody;
        private System.Windows.Forms.Button btnEvidenceReport;
    }
}