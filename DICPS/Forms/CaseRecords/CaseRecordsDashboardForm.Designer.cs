namespace DICPS.Forms.CaseRecords
{
    partial class CaseRecordsDashboardForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLoggedInName = new System.Windows.Forms.Label();
            this.lblLoggedInUserId = new System.Windows.Forms.Label();
            this.lblCaseRecordDashboard = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClosedCaseCount = new System.Windows.Forms.Label();
            this.lblCaseCount = new System.Windows.Forms.Label();
            this.lblClosedCases = new System.Windows.Forms.Label();
            this.lblTotalCases = new System.Windows.Forms.Label();
            this.lblOpenCaseCount = new System.Windows.Forms.Label();
            this.lblOpenCases = new System.Windows.Forms.Label();
            this.lblColdCaseCount = new System.Windows.Forms.Label();
            this.lblColdCases = new System.Windows.Forms.Label();
            this.btnCaseFile = new System.Windows.Forms.Button();
            this.btnCaseSearch = new System.Windows.Forms.Button();
            this.btnColdCases = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(917, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 62);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblLoggedInName
            // 
            this.lblLoggedInName.AutoSize = true;
            this.lblLoggedInName.Location = new System.Drawing.Point(39, 100);
            this.lblLoggedInName.Name = "lblLoggedInName";
            this.lblLoggedInName.Size = new System.Drawing.Size(70, 25);
            this.lblLoggedInName.TabIndex = 20;
            this.lblLoggedInName.Text = "Name:";
            // 
            // lblLoggedInUserId
            // 
            this.lblLoggedInUserId.AutoSize = true;
            this.lblLoggedInUserId.Location = new System.Drawing.Point(39, 66);
            this.lblLoggedInUserId.Name = "lblLoggedInUserId";
            this.lblLoggedInUserId.Size = new System.Drawing.Size(78, 25);
            this.lblLoggedInUserId.TabIndex = 19;
            this.lblLoggedInUserId.Text = "UserID:";
            // 
            // lblCaseRecordDashboard
            // 
            this.lblCaseRecordDashboard.AutoSize = true;
            this.lblCaseRecordDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCaseRecordDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseRecordDashboard.Location = new System.Drawing.Point(21, 19);
            this.lblCaseRecordDashboard.Name = "lblCaseRecordDashboard";
            this.lblCaseRecordDashboard.Size = new System.Drawing.Size(531, 38);
            this.lblCaseRecordDashboard.TabIndex = 18;
            this.lblCaseRecordDashboard.Text = "Case Records Officer Dashboard";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblColdCases, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblColdCaseCount, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClosedCaseCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCaseCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClosedCases, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCases, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOpenCaseCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOpenCases, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 103);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // lblClosedCaseCount
            // 
            this.lblClosedCaseCount.AutoSize = true;
            this.lblClosedCaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedCaseCount.Location = new System.Drawing.Point(491, 51);
            this.lblClosedCaseCount.Name = "lblClosedCaseCount";
            this.lblClosedCaseCount.Size = new System.Drawing.Size(27, 29);
            this.lblClosedCaseCount.TabIndex = 20;
            this.lblClosedCaseCount.Text = "0";
            // 
            // lblCaseCount
            // 
            this.lblCaseCount.AutoSize = true;
            this.lblCaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseCount.Location = new System.Drawing.Point(3, 51);
            this.lblCaseCount.Name = "lblCaseCount";
            this.lblCaseCount.Size = new System.Drawing.Size(27, 29);
            this.lblCaseCount.TabIndex = 19;
            this.lblCaseCount.Text = "0";
            // 
            // lblClosedCases
            // 
            this.lblClosedCases.AutoSize = true;
            this.lblClosedCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedCases.Location = new System.Drawing.Point(491, 0);
            this.lblClosedCases.Name = "lblClosedCases";
            this.lblClosedCases.Size = new System.Drawing.Size(176, 29);
            this.lblClosedCases.TabIndex = 21;
            this.lblClosedCases.Text = "Closed Cases";
            // 
            // lblTotalCases
            // 
            this.lblTotalCases.AutoSize = true;
            this.lblTotalCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCases.Location = new System.Drawing.Point(3, 0);
            this.lblTotalCases.Name = "lblTotalCases";
            this.lblTotalCases.Size = new System.Drawing.Size(153, 29);
            this.lblTotalCases.TabIndex = 19;
            this.lblTotalCases.Text = "Total Cases";
            // 
            // lblOpenCaseCount
            // 
            this.lblOpenCaseCount.AutoSize = true;
            this.lblOpenCaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCaseCount.Location = new System.Drawing.Point(247, 51);
            this.lblOpenCaseCount.Name = "lblOpenCaseCount";
            this.lblOpenCaseCount.Size = new System.Drawing.Size(27, 29);
            this.lblOpenCaseCount.TabIndex = 20;
            this.lblOpenCaseCount.Text = "0";
            // 
            // lblOpenCases
            // 
            this.lblOpenCases.AutoSize = true;
            this.lblOpenCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCases.Location = new System.Drawing.Point(247, 0);
            this.lblOpenCases.Name = "lblOpenCases";
            this.lblOpenCases.Size = new System.Drawing.Size(157, 29);
            this.lblOpenCases.TabIndex = 21;
            this.lblOpenCases.Text = "Open Cases";
            // 
            // lblColdCaseCount
            // 
            this.lblColdCaseCount.AutoSize = true;
            this.lblColdCaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColdCaseCount.Location = new System.Drawing.Point(735, 51);
            this.lblColdCaseCount.Name = "lblColdCaseCount";
            this.lblColdCaseCount.Size = new System.Drawing.Size(27, 29);
            this.lblColdCaseCount.TabIndex = 22;
            this.lblColdCaseCount.Text = "0";
            // 
            // lblColdCases
            // 
            this.lblColdCases.AutoSize = true;
            this.lblColdCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColdCases.Location = new System.Drawing.Point(735, 0);
            this.lblColdCases.Name = "lblColdCases";
            this.lblColdCases.Size = new System.Drawing.Size(148, 29);
            this.lblColdCases.TabIndex = 23;
            this.lblColdCases.Text = "Cold Cases";
            // 
            // btnCaseFile
            // 
            this.btnCaseFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCaseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCaseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCaseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseFile.Location = new System.Drawing.Point(72, 314);
            this.btnCaseFile.Name = "btnCaseFile";
            this.btnCaseFile.Size = new System.Drawing.Size(259, 74);
            this.btnCaseFile.TabIndex = 23;
            this.btnCaseFile.Text = "Case File";
            this.btnCaseFile.UseVisualStyleBackColor = false;
            // 
            // btnCaseSearch
            // 
            this.btnCaseSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCaseSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCaseSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCaseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseSearch.Location = new System.Drawing.Point(397, 314);
            this.btnCaseSearch.Name = "btnCaseSearch";
            this.btnCaseSearch.Size = new System.Drawing.Size(259, 74);
            this.btnCaseSearch.TabIndex = 24;
            this.btnCaseSearch.Text = "Case Search";
            this.btnCaseSearch.UseVisualStyleBackColor = false;
            // 
            // btnColdCases
            // 
            this.btnColdCases.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnColdCases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnColdCases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnColdCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColdCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColdCases.Location = new System.Drawing.Point(722, 314);
            this.btnColdCases.Name = "btnColdCases";
            this.btnColdCases.Size = new System.Drawing.Size(259, 74);
            this.btnColdCases.TabIndex = 25;
            this.btnColdCases.Text = "Cold Cases";
            this.btnColdCases.UseVisualStyleBackColor = false;
            // 
            // CaseRecordsDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 460);
            this.Controls.Add(this.btnColdCases);
            this.Controls.Add(this.btnCaseSearch);
            this.Controls.Add(this.btnCaseFile);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoggedInName);
            this.Controls.Add(this.lblLoggedInUserId);
            this.Controls.Add(this.lblCaseRecordDashboard);
            this.Name = "CaseRecordsDashboardForm";
            this.Text = "CaseRecordsDashboardForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLoggedInName;
        private System.Windows.Forms.Label lblLoggedInUserId;
        private System.Windows.Forms.Label lblCaseRecordDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblClosedCaseCount;
        private System.Windows.Forms.Label lblCaseCount;
        private System.Windows.Forms.Label lblClosedCases;
        private System.Windows.Forms.Label lblTotalCases;
        private System.Windows.Forms.Label lblOpenCaseCount;
        private System.Windows.Forms.Label lblOpenCases;
        private System.Windows.Forms.Label lblColdCaseCount;
        private System.Windows.Forms.Label lblColdCases;
        private System.Windows.Forms.Button btnCaseFile;
        private System.Windows.Forms.Button btnCaseSearch;
        private System.Windows.Forms.Button btnColdCases;
    }
}