namespace DICPS.Forms.Detective
{
    partial class DetectiveDashboardForm
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
            this.lblLoggedInUserId = new System.Windows.Forms.Label();
            this.lblDetectiveDashboard = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaseTitle = new System.Windows.Forms.Label();
            this.lblCaseCount = new System.Windows.Forms.Label();
            this.lblSuspectCount = new System.Windows.Forms.Label();
            this.lblSuspectTitle = new System.Windows.Forms.Label();
            this.lblWitnessCount = new System.Windows.Forms.Label();
            this.lblWitnessTitle = new System.Windows.Forms.Label();
            this.btnCaseLoad = new System.Windows.Forms.Button();
            this.btnPersonSearch = new System.Windows.Forms.Button();
            this.btnRegisterPerson = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoggedInName
            // 
            this.lblLoggedInName.AutoSize = true;
            this.lblLoggedInName.Location = new System.Drawing.Point(39, 105);
            this.lblLoggedInName.Name = "lblLoggedInName";
            this.lblLoggedInName.Size = new System.Drawing.Size(70, 25);
            this.lblLoggedInName.TabIndex = 16;
            this.lblLoggedInName.Text = "Name:";
            // 
            // lblLoggedInUserId
            // 
            this.lblLoggedInUserId.AutoSize = true;
            this.lblLoggedInUserId.Location = new System.Drawing.Point(39, 71);
            this.lblLoggedInUserId.Name = "lblLoggedInUserId";
            this.lblLoggedInUserId.Size = new System.Drawing.Size(78, 25);
            this.lblLoggedInUserId.TabIndex = 15;
            this.lblLoggedInUserId.Text = "UserID:";
            // 
            // lblDetectiveDashboard
            // 
            this.lblDetectiveDashboard.AutoSize = true;
            this.lblDetectiveDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetectiveDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDetectiveDashboard.Location = new System.Drawing.Point(21, 24);
            this.lblDetectiveDashboard.Name = "lblDetectiveDashboard";
            this.lblDetectiveDashboard.Size = new System.Drawing.Size(342, 38);
            this.lblDetectiveDashboard.TabIndex = 14;
            this.lblDetectiveDashboard.Text = "Detective Dashboard";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(532, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 62);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblWitnessCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCaseCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWitnessTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCaseTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSuspectCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSuspectTitle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 85);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblCaseTitle
            // 
            this.lblCaseTitle.AutoSize = true;
            this.lblCaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseTitle.Location = new System.Drawing.Point(3, 0);
            this.lblCaseTitle.Name = "lblCaseTitle";
            this.lblCaseTitle.Size = new System.Drawing.Size(133, 29);
            this.lblCaseTitle.TabIndex = 19;
            this.lblCaseTitle.Text = "My Cases:";
            // 
            // lblCaseCount
            // 
            this.lblCaseCount.AutoSize = true;
            this.lblCaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseCount.Location = new System.Drawing.Point(3, 42);
            this.lblCaseCount.Name = "lblCaseCount";
            this.lblCaseCount.Size = new System.Drawing.Size(27, 29);
            this.lblCaseCount.TabIndex = 19;
            this.lblCaseCount.Text = "0";
            // 
            // lblSuspectCount
            // 
            this.lblSuspectCount.AutoSize = true;
            this.lblSuspectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspectCount.Location = new System.Drawing.Point(197, 42);
            this.lblSuspectCount.Name = "lblSuspectCount";
            this.lblSuspectCount.Size = new System.Drawing.Size(27, 29);
            this.lblSuspectCount.TabIndex = 20;
            this.lblSuspectCount.Text = "0";
            // 
            // lblSuspectTitle
            // 
            this.lblSuspectTitle.AutoSize = true;
            this.lblSuspectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspectTitle.Location = new System.Drawing.Point(197, 0);
            this.lblSuspectTitle.Name = "lblSuspectTitle";
            this.lblSuspectTitle.Size = new System.Drawing.Size(167, 29);
            this.lblSuspectTitle.TabIndex = 21;
            this.lblSuspectTitle.Text = "My Suspects:";
            // 
            // lblWitnessCount
            // 
            this.lblWitnessCount.AutoSize = true;
            this.lblWitnessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitnessCount.Location = new System.Drawing.Point(391, 42);
            this.lblWitnessCount.Name = "lblWitnessCount";
            this.lblWitnessCount.Size = new System.Drawing.Size(27, 29);
            this.lblWitnessCount.TabIndex = 20;
            this.lblWitnessCount.Text = "0";
            // 
            // lblWitnessTitle
            // 
            this.lblWitnessTitle.AutoSize = true;
            this.lblWitnessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitnessTitle.Location = new System.Drawing.Point(391, 0);
            this.lblWitnessTitle.Name = "lblWitnessTitle";
            this.lblWitnessTitle.Size = new System.Drawing.Size(180, 29);
            this.lblWitnessTitle.TabIndex = 21;
            this.lblWitnessTitle.Text = "My Witnesses:";
            // 
            // btnCaseLoad
            // 
            this.btnCaseLoad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCaseLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCaseLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCaseLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaseLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseLoad.Location = new System.Drawing.Point(73, 312);
            this.btnCaseLoad.Name = "btnCaseLoad";
            this.btnCaseLoad.Size = new System.Drawing.Size(259, 74);
            this.btnCaseLoad.TabIndex = 19;
            this.btnCaseLoad.Text = "My Case Load";
            this.btnCaseLoad.UseVisualStyleBackColor = false;
            this.btnCaseLoad.Click += new System.EventHandler(this.btnCaseLoad_Click);
            // 
            // btnPersonSearch
            // 
            this.btnPersonSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPersonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPersonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPersonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonSearch.Location = new System.Drawing.Point(398, 312);
            this.btnPersonSearch.Name = "btnPersonSearch";
            this.btnPersonSearch.Size = new System.Drawing.Size(259, 74);
            this.btnPersonSearch.TabIndex = 20;
            this.btnPersonSearch.Text = "Search Person";
            this.btnPersonSearch.UseVisualStyleBackColor = false;
            this.btnPersonSearch.Click += new System.EventHandler(this.btnPersonSearch_Click);
            // 
            // btnRegisterPerson
            // 
            this.btnRegisterPerson.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegisterPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegisterPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegisterPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPerson.Location = new System.Drawing.Point(244, 450);
            this.btnRegisterPerson.Name = "btnRegisterPerson";
            this.btnRegisterPerson.Size = new System.Drawing.Size(259, 74);
            this.btnRegisterPerson.TabIndex = 21;
            this.btnRegisterPerson.Text = "Register Person";
            this.btnRegisterPerson.UseVisualStyleBackColor = false;
            this.btnRegisterPerson.Click += new System.EventHandler(this.btnRegisterPerson_Click);
            // 
            // DetectiveDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 612);
            this.Controls.Add(this.btnRegisterPerson);
            this.Controls.Add(this.btnPersonSearch);
            this.Controls.Add(this.btnCaseLoad);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoggedInName);
            this.Controls.Add(this.lblLoggedInUserId);
            this.Controls.Add(this.lblDetectiveDashboard);
            this.Name = "DetectiveDashboardForm";
            this.Text = "DetectiveDashboardForm";
            this.Load += new System.EventHandler(this.DetectiveDashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedInName;
        private System.Windows.Forms.Label lblLoggedInUserId;
        private System.Windows.Forms.Label lblDetectiveDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCaseTitle;
        private System.Windows.Forms.Label lblCaseCount;
        private System.Windows.Forms.Label lblSuspectCount;
        private System.Windows.Forms.Label lblSuspectTitle;
        private System.Windows.Forms.Label lblWitnessCount;
        private System.Windows.Forms.Label lblWitnessTitle;
        private System.Windows.Forms.Button btnCaseLoad;
        private System.Windows.Forms.Button btnPersonSearch;
        private System.Windows.Forms.Button btnRegisterPerson;
    }
}