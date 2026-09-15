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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearchByStatus = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpCases = new System.Windows.Forms.GroupBox();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaseSearch
            // 
            this.lblCaseSearch.AutoSize = true;
            this.lblCaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCaseSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseSearch.Location = new System.Drawing.Point(12, 23);
            this.lblCaseSearch.Name = "lblCaseSearch";
            this.lblCaseSearch.Size = new System.Drawing.Size(218, 38);
            this.lblCaseSearch.TabIndex = 20;
            this.lblCaseSearch.Text = "Case Search";
            // 
            // lblSearchbyStatus
            // 
            this.lblSearchbyStatus.AutoSize = true;
            this.lblSearchbyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchbyStatus.Location = new System.Drawing.Point(37, 102);
            this.lblSearchbyStatus.Name = "lblSearchbyStatus";
            this.lblSearchbyStatus.Size = new System.Drawing.Size(231, 30);
            this.lblSearchbyStatus.TabIndex = 21;
            this.lblSearchbyStatus.Text = "Search by Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Cold"});
            this.cmbStatus.Location = new System.Drawing.Point(42, 147);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(296, 32);
            this.cmbStatus.TabIndex = 22;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnSearchByStatus
            // 
            this.btnSearchByStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchByStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchByStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchByStatus.Location = new System.Drawing.Point(375, 120);
            this.btnSearchByStatus.Name = "btnSearchByStatus";
            this.btnSearchByStatus.Size = new System.Drawing.Size(160, 59);
            this.btnSearchByStatus.TabIndex = 23;
            this.btnSearchByStatus.Text = "Search";
            this.btnSearchByStatus.UseVisualStyleBackColor = false;
            this.btnSearchByStatus.Click += new System.EventHandler(this.btnSearchByStatus_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchByDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchByDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchByDate.Location = new System.Drawing.Point(375, 225);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(160, 59);
            this.btnSearchByDate.TabIndex = 26;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search by Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 29);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grpCases
            // 
            this.grpCases.Controls.Add(this.dgvCases);
            this.grpCases.Controls.Add(this.btnShowAll);
            this.grpCases.Controls.Add(this.btnRefresh);
            this.grpCases.Location = new System.Drawing.Point(10, 338);
            this.grpCases.Name = "grpCases";
            this.grpCases.Size = new System.Drawing.Size(778, 354);
            this.grpCases.TabIndex = 28;
            this.grpCases.TabStop = false;
            this.grpCases.Text = "Cases";
            // 
            // dgvCases
            // 
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Location = new System.Drawing.Point(28, 51);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.RowHeadersWidth = 72;
            this.dgvCases.RowTemplate.Height = 31;
            this.dgvCases.Size = new System.Drawing.Size(711, 184);
            this.dgvCases.TabIndex = 23;
            this.dgvCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellContentClick);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(413, 269);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(256, 59);
            this.btnShowAll.TabIndex = 22;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(103, 269);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 59);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CaseSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 739);
            this.Controls.Add(this.grpCases);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchByStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblSearchbyStatus);
            this.Controls.Add(this.lblCaseSearch);
            this.Name = "CaseSearchForm";
            this.Text = "CaseSearchForm";
            this.Load += new System.EventHandler(this.CaseSearchForm_Load);
            this.grpCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseSearch;
        private System.Windows.Forms.Label lblSearchbyStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearchByStatus;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpCases;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnRefresh;
    }
}