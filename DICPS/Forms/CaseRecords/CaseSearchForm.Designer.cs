namespace DICPS.Forms.CaseRecords
{
    partial class CaseSearchForm
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
            this.lblCaseSearch = new System.Windows.Forms.Label();
            this.lblSearchbyStatus = new System.Windows.Forms.Label();
            this.cmbSearchbyStatus = new System.Windows.Forms.ComboBox();
            this.lblSearchbyDate = new System.Windows.Forms.Label();
            this.dtpSearchDate = new System.Windows.Forms.TextBox();
            this.lblSearchbyCaseNumber = new System.Windows.Forms.Label();
            this.textSearchbyCaseNo = new System.Windows.Forms.TextBox();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.CaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetectiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaseSearch
            // 
            this.lblCaseSearch.AutoSize = true;
            this.lblCaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseSearch.Location = new System.Drawing.Point(331, 20);
            this.lblCaseSearch.Name = "lblCaseSearch";
            this.lblCaseSearch.Size = new System.Drawing.Size(188, 32);
            this.lblCaseSearch.TabIndex = 0;
            this.lblCaseSearch.Text = "Case Search";
            this.lblCaseSearch.Click += new System.EventHandler(this.lblCaseSearch_Click);
            // 
            // lblSearchbyStatus
            // 
            this.lblSearchbyStatus.AutoSize = true;
            this.lblSearchbyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyStatus.Location = new System.Drawing.Point(118, 116);
            this.lblSearchbyStatus.Name = "lblSearchbyStatus";
            this.lblSearchbyStatus.Size = new System.Drawing.Size(185, 25);
            this.lblSearchbyStatus.TabIndex = 1;
            this.lblSearchbyStatus.Text = "Search by Status:";
            // 
            // cmbSearchbyStatus
            // 
            this.cmbSearchbyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchbyStatus.FormattingEnabled = true;
            this.cmbSearchbyStatus.Location = new System.Drawing.Point(330, 113);
            this.cmbSearchbyStatus.Name = "cmbSearchbyStatus";
            this.cmbSearchbyStatus.Size = new System.Drawing.Size(165, 28);
            this.cmbSearchbyStatus.TabIndex = 2;
            this.cmbSearchbyStatus.SelectedIndexChanged += new System.EventHandler(this.cmbSearchbyStatus_SelectedIndexChanged);
            // 
            // lblSearchbyDate
            // 
            this.lblSearchbyDate.AutoSize = true;
            this.lblSearchbyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyDate.Location = new System.Drawing.Point(118, 204);
            this.lblSearchbyDate.Name = "lblSearchbyDate";
            this.lblSearchbyDate.Size = new System.Drawing.Size(168, 25);
            this.lblSearchbyDate.TabIndex = 3;
            this.lblSearchbyDate.Text = "Search by Date:";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.Location = new System.Drawing.Point(330, 200);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(165, 27);
            this.dtpSearchDate.TabIndex = 4;
            this.dtpSearchDate.TextChanged += new System.EventHandler(this.dtpSearchDate_TextChanged);
            // 
            // lblSearchbyCaseNumber
            // 
            this.lblSearchbyCaseNumber.AutoSize = true;
            this.lblSearchbyCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyCaseNumber.Location = new System.Drawing.Point(118, 278);
            this.lblSearchbyCaseNumber.Name = "lblSearchbyCaseNumber";
            this.lblSearchbyCaseNumber.Size = new System.Drawing.Size(207, 25);
            this.lblSearchbyCaseNumber.TabIndex = 5;
            this.lblSearchbyCaseNumber.Text = "Search by Case No:";
            // 
            // textSearchbyCaseNo
            // 
            this.textSearchbyCaseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchbyCaseNo.Location = new System.Drawing.Point(330, 273);
            this.textSearchbyCaseNo.Name = "textSearchbyCaseNo";
            this.textSearchbyCaseNo.Size = new System.Drawing.Size(165, 27);
            this.textSearchbyCaseNo.TabIndex = 6;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseNumber,
            this.CaseType,
            this.Location,
            this.Status,
            this.Priority,
            this.DateOpened,
            this.DetectiveName});
            this.dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 389);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.Height = 24;
            this.dgvSearchResults.Size = new System.Drawing.Size(930, 250);
            this.dgvSearchResults.TabIndex = 7;
            this.dgvSearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResults_CellContentClick);
            // 
            // CaseNumber
            // 
            this.CaseNumber.HeaderText = "CaseNumber";
            this.CaseNumber.MinimumWidth = 6;
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.ReadOnly = true;
            this.CaseNumber.Width = 125;
            // 
            // CaseType
            // 
            this.CaseType.HeaderText = "CaseType";
            this.CaseType.MinimumWidth = 6;
            this.CaseType.Name = "CaseType";
            this.CaseType.ReadOnly = true;
            this.CaseType.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 125;
            // 
            // DateOpened
            // 
            this.DateOpened.HeaderText = "DateOpened";
            this.DateOpened.MinimumWidth = 6;
            this.DateOpened.Name = "DateOpened";
            this.DateOpened.ReadOnly = true;
            this.DateOpened.Width = 125;
            // 
            // DetectiveName
            // 
            this.DetectiveName.HeaderText = "DetectiveName";
            this.DetectiveName.MinimumWidth = 6;
            this.DetectiveName.Name = "DetectiveName";
            this.DetectiveName.ReadOnly = true;
            this.DetectiveName.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(700, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(700, 200);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(130, 35);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // CaseSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 639);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.textSearchbyCaseNo);
            this.Controls.Add(this.lblSearchbyCaseNumber);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.lblSearchbyDate);
            this.Controls.Add(this.cmbSearchbyStatus);
            this.Controls.Add(this.lblSearchbyStatus);
            this.Controls.Add(this.lblCaseSearch);
            this.Name = "CaseSearchForm";
            this.Text = "CaseSearchForm";
            this.Load += new System.EventHandler(this.CaseSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseSearch;
        private System.Windows.Forms.Label lblSearchbyStatus;
        private System.Windows.Forms.ComboBox cmbSearchbyStatus;
        private System.Windows.Forms.Label lblSearchbyDate;
        private System.Windows.Forms.TextBox dtpSearchDate;
        private System.Windows.Forms.Label lblSearchbyCaseNumber;
        private System.Windows.Forms.TextBox textSearchbyCaseNo;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetectiveName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
    }
}