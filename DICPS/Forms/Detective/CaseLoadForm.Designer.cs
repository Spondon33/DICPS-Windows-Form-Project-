namespace DICPS.Forms.Detective
{
    partial class CaseLoadForm
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
            this.lblCaseLoad = new System.Windows.Forms.Label();
            this.lblSearchCase = new System.Windows.Forms.Label();
            this.txtSearchCase = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.grpCaseSearch = new System.Windows.Forms.GroupBox();
            this.grpMyAssignedCases = new System.Windows.Forms.GroupBox();
            this.grpLinkedSuspects = new System.Windows.Forms.GroupBox();
            this.dgvSuspects = new System.Windows.Forms.DataGridView();
            this.grpCaseNotes = new System.Windows.Forms.GroupBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNewNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCaseNotes = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.grpCaseSearch.SuspendLayout();
            this.grpMyAssignedCases.SuspendLayout();
            this.grpLinkedSuspects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspects)).BeginInit();
            this.grpCaseNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaseLoad
            // 
            this.lblCaseLoad.AutoSize = true;
            this.lblCaseLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCaseLoad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseLoad.Location = new System.Drawing.Point(21, 20);
            this.lblCaseLoad.Name = "lblCaseLoad";
            this.lblCaseLoad.Size = new System.Drawing.Size(184, 38);
            this.lblCaseLoad.TabIndex = 2;
            this.lblCaseLoad.Text = "Case Load";
            // 
            // lblSearchCase
            // 
            this.lblSearchCase.AutoSize = true;
            this.lblSearchCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchCase.Location = new System.Drawing.Point(115, 35);
            this.lblSearchCase.Name = "lblSearchCase";
            this.lblSearchCase.Size = new System.Drawing.Size(180, 30);
            this.lblSearchCase.TabIndex = 4;
            this.lblSearchCase.Text = "Search Case:";
            // 
            // txtSearchCase
            // 
            this.txtSearchCase.Location = new System.Drawing.Point(319, 35);
            this.txtSearchCase.Name = "txtSearchCase";
            this.txtSearchCase.Size = new System.Drawing.Size(290, 29);
            this.txtSearchCase.TabIndex = 5;
            this.txtSearchCase.TextChanged += new System.EventHandler(this.txtSearchCase_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(27, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 30);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Open",
            "Closed",
            "Cold"});
            this.cmbStatus.Location = new System.Drawing.Point(132, 106);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 32);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
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
            // dgvCases
            // 
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Location = new System.Drawing.Point(19, 41);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.RowHeadersWidth = 72;
            this.dgvCases.RowTemplate.Height = 31;
            this.dgvCases.Size = new System.Drawing.Size(991, 187);
            this.dgvCases.TabIndex = 12;
            this.dgvCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellContentClick);
            // 
            // grpCaseSearch
            // 
            this.grpCaseSearch.Controls.Add(this.btnShowAll);
            this.grpCaseSearch.Controls.Add(this.lblSearchCase);
            this.grpCaseSearch.Controls.Add(this.txtSearchCase);
            this.grpCaseSearch.Controls.Add(this.btnSearch);
            this.grpCaseSearch.Controls.Add(this.lblStatus);
            this.grpCaseSearch.Controls.Add(this.cmbStatus);
            this.grpCaseSearch.Location = new System.Drawing.Point(28, 76);
            this.grpCaseSearch.Name = "grpCaseSearch";
            this.grpCaseSearch.Size = new System.Drawing.Size(1026, 184);
            this.grpCaseSearch.TabIndex = 13;
            this.grpCaseSearch.TabStop = false;
            // 
            // grpMyAssignedCases
            // 
            this.grpMyAssignedCases.Controls.Add(this.dgvCases);
            this.grpMyAssignedCases.Location = new System.Drawing.Point(28, 266);
            this.grpMyAssignedCases.Name = "grpMyAssignedCases";
            this.grpMyAssignedCases.Size = new System.Drawing.Size(1026, 247);
            this.grpMyAssignedCases.TabIndex = 14;
            this.grpMyAssignedCases.TabStop = false;
            this.grpMyAssignedCases.Text = "My Assigned Cases";
            // 
            // grpLinkedSuspects
            // 
            this.grpLinkedSuspects.Controls.Add(this.dgvSuspects);
            this.grpLinkedSuspects.Location = new System.Drawing.Point(28, 518);
            this.grpLinkedSuspects.Name = "grpLinkedSuspects";
            this.grpLinkedSuspects.Size = new System.Drawing.Size(1026, 250);
            this.grpLinkedSuspects.TabIndex = 15;
            this.grpLinkedSuspects.TabStop = false;
            this.grpLinkedSuspects.Text = "Linked Suspects";
            // 
            // dgvSuspects
            // 
            this.dgvSuspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuspects.Location = new System.Drawing.Point(19, 41);
            this.dgvSuspects.Name = "dgvSuspects";
            this.dgvSuspects.RowHeadersWidth = 72;
            this.dgvSuspects.RowTemplate.Height = 31;
            this.dgvSuspects.Size = new System.Drawing.Size(991, 183);
            this.dgvSuspects.TabIndex = 12;
            this.dgvSuspects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuspects_CellContentClick);
            // 
            // grpCaseNotes
            // 
            this.grpCaseNotes.Controls.Add(this.btnDeleteNote);
            this.grpCaseNotes.Controls.Add(this.btnAddNote);
            this.grpCaseNotes.Controls.Add(this.txtNewNote);
            this.grpCaseNotes.Controls.Add(this.label1);
            this.grpCaseNotes.Controls.Add(this.dgvCaseNotes);
            this.grpCaseNotes.Location = new System.Drawing.Point(28, 773);
            this.grpCaseNotes.Name = "grpCaseNotes";
            this.grpCaseNotes.Size = new System.Drawing.Size(1026, 339);
            this.grpCaseNotes.TabIndex = 16;
            this.grpCaseNotes.TabStop = false;
            this.grpCaseNotes.Text = "Case Notes";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNote.Location = new System.Drawing.Point(772, 257);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(189, 59);
            this.btnDeleteNote.TabIndex = 14;
            this.btnDeleteNote.Text = "Delete Note";
            this.btnDeleteNote.UseVisualStyleBackColor = false;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNote.Location = new System.Drawing.Point(580, 257);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(160, 59);
            this.btnAddNote.TabIndex = 12;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtNewNote
            // 
            this.txtNewNote.Location = new System.Drawing.Point(163, 249);
            this.txtNewNote.Name = "txtNewNote";
            this.txtNewNote.Size = new System.Drawing.Size(368, 67);
            this.txtNewNote.TabIndex = 13;
            this.txtNewNote.Text = "";
            this.txtNewNote.TextChanged += new System.EventHandler(this.txtNewNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Note:";
            // 
            // dgvCaseNotes
            // 
            this.dgvCaseNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaseNotes.Location = new System.Drawing.Point(19, 41);
            this.dgvCaseNotes.Name = "dgvCaseNotes";
            this.dgvCaseNotes.RowHeadersWidth = 72;
            this.dgvCaseNotes.RowTemplate.Height = 31;
            this.dgvCaseNotes.Size = new System.Drawing.Size(991, 179);
            this.dgvCaseNotes.TabIndex = 12;
            this.dgvCaseNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaseNotes_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(438, 1139);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(179, 59);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CaseLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 1222);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpCaseNotes);
            this.Controls.Add(this.grpLinkedSuspects);
            this.Controls.Add(this.grpMyAssignedCases);
            this.Controls.Add(this.grpCaseSearch);
            this.Controls.Add(this.lblCaseLoad);
            this.Name = "CaseLoadForm";
            this.Text = "CaseLoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.grpCaseSearch.ResumeLayout(false);
            this.grpCaseSearch.PerformLayout();
            this.grpMyAssignedCases.ResumeLayout(false);
            this.grpLinkedSuspects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspects)).EndInit();
            this.grpCaseNotes.ResumeLayout(false);
            this.grpCaseNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseLoad;
        private System.Windows.Forms.Label lblSearchCase;
        private System.Windows.Forms.TextBox txtSearchCase;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.GroupBox grpCaseSearch;
        private System.Windows.Forms.GroupBox grpMyAssignedCases;
        private System.Windows.Forms.GroupBox grpLinkedSuspects;
        private System.Windows.Forms.DataGridView dgvSuspects;
        private System.Windows.Forms.GroupBox grpCaseNotes;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.RichTextBox txtNewNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCaseNotes;
        private System.Windows.Forms.Button btnRefresh;
    }
}