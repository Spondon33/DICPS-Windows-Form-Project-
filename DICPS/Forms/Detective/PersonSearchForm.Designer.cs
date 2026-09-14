namespace DICPS.Forms.Detective
{
    partial class PersonSearchForm
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
            this.lblPersonSearch = new System.Windows.Forms.Label();
            this.grpCaseSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.grpPersonHistory = new System.Windows.Forms.GroupBox();
            this.dgvPersonHistory = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpCaseSearch.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.grpPersonHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonSearch
            // 
            this.lblPersonSearch.AutoSize = true;
            this.lblPersonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPersonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPersonSearch.Location = new System.Drawing.Point(34, 27);
            this.lblPersonSearch.Name = "lblPersonSearch";
            this.lblPersonSearch.Size = new System.Drawing.Size(247, 38);
            this.lblPersonSearch.TabIndex = 3;
            this.lblPersonSearch.Text = "Person Search";
            // 
            // grpCaseSearch
            // 
            this.grpCaseSearch.Controls.Add(this.btnShowAll);
            this.grpCaseSearch.Controls.Add(this.lblName);
            this.grpCaseSearch.Controls.Add(this.txtName);
            this.grpCaseSearch.Controls.Add(this.btnSearch);
            this.grpCaseSearch.Controls.Add(this.lblType);
            this.grpCaseSearch.Controls.Add(this.cmbPersonType);
            this.grpCaseSearch.Location = new System.Drawing.Point(15, 82);
            this.grpCaseSearch.Name = "grpCaseSearch";
            this.grpCaseSearch.Size = new System.Drawing.Size(818, 184);
            this.grpCaseSearch.TabIndex = 14;
            this.grpCaseSearch.TabStop = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(600, 90);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(160, 59);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(27, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 30);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(382, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 59);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(27, 103);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 30);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type:";
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Items.AddRange(new object[] {
            "All",
            "Suspect",
            "Witness"});
            this.cmbPersonType.Location = new System.Drawing.Point(151, 106);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(191, 32);
            this.cmbPersonType.TabIndex = 7;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.cmbPersonType_SelectedIndexChanged);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.dgvPersons);
            this.grpSearchResults.Location = new System.Drawing.Point(15, 272);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(818, 247);
            this.grpSearchResults.TabIndex = 15;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Search Results";
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(19, 41);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 72;
            this.dgvPersons.RowTemplate.Height = 31;
            this.dgvPersons.Size = new System.Drawing.Size(778, 187);
            this.dgvPersons.TabIndex = 12;
            this.dgvPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellContentClick);
            // 
            // grpPersonHistory
            // 
            this.grpPersonHistory.Controls.Add(this.dgvPersonHistory);
            this.grpPersonHistory.Location = new System.Drawing.Point(15, 525);
            this.grpPersonHistory.Name = "grpPersonHistory";
            this.grpPersonHistory.Size = new System.Drawing.Size(818, 247);
            this.grpPersonHistory.TabIndex = 16;
            this.grpPersonHistory.TabStop = false;
            this.grpPersonHistory.Text = "Search Results";
            // 
            // dgvPersonHistory
            // 
            this.dgvPersonHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonHistory.Location = new System.Drawing.Point(19, 41);
            this.dgvPersonHistory.Name = "dgvPersonHistory";
            this.dgvPersonHistory.RowHeadersWidth = 72;
            this.dgvPersonHistory.RowTemplate.Height = 31;
            this.dgvPersonHistory.Size = new System.Drawing.Size(778, 187);
            this.dgvPersonHistory.TabIndex = 12;
            this.dgvPersonHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonHistory_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(345, 802);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 59);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PersonSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 892);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpPersonHistory);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpCaseSearch);
            this.Controls.Add(this.lblPersonSearch);
            this.Name = "PersonSearchForm";
            this.Text = "PersonSearchForm";
            this.Load += new System.EventHandler(this.PersonSearchForm_Load);
            this.grpCaseSearch.ResumeLayout(false);
            this.grpCaseSearch.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.grpPersonHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonSearch;
        private System.Windows.Forms.GroupBox grpCaseSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.GroupBox grpPersonHistory;
        private System.Windows.Forms.DataGridView dgvPersonHistory;
        private System.Windows.Forms.Button btnRefresh;
    }
}