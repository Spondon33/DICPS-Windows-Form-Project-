namespace DICPS.Forms.ChiefInvestigator
{
    partial class ChiefInvestigatorDashboardForm
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
            this.lblDICPS = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalProfilingReports = new System.Windows.Forms.Label();
            this.lblUnlinkedEvidence = new System.Windows.Forms.Label();
            this.lblPendingEvidence = new System.Windows.Forms.Label();
            this.lblTotalWitnesses = new System.Windows.Forms.Label();
            this.lblTotalSuspects = new System.Windows.Forms.Label();
            this.lblClosedCases = new System.Windows.Forms.Label();
            this.lblColdCases = new System.Windows.Forms.Label();
            this.lblOpenCases = new System.Windows.Forms.Label();
            this.lblTotalCases = new System.Windows.Forms.Label();
            this.dgvAllCases = new System.Windows.Forms.DataGridView();
            this.btnRefreshDashboard = new System.Windows.Forms.Button();
            this.buttonReassignDetective = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCases)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(12, 18);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(467, 38);
            this.lblDICPS.TabIndex = 1;
            this.lblDICPS.Text = "Chief Investigator Dashboard";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalProfilingReports, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUnlinkedEvidence, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPendingEvidence, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalWitnesses, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSuspects, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClosedCases, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblColdCases, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOpenCases, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCases, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 233);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTotalProfilingReports
            // 
            this.lblTotalProfilingReports.AutoSize = true;
            this.lblTotalProfilingReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfilingReports.Location = new System.Drawing.Point(522, 154);
            this.lblTotalProfilingReports.Name = "lblTotalProfilingReports";
            this.lblTotalProfilingReports.Size = new System.Drawing.Size(185, 58);
            this.lblTotalProfilingReports.TabIndex = 11;
            this.lblTotalProfilingReports.Text = "Total Profiling Reports: 0";
            this.lblTotalProfilingReports.Click += new System.EventHandler(this.lblTotalProfilingReports_Click);
            // 
            // lblUnlinkedEvidence
            // 
            this.lblUnlinkedEvidence.AutoSize = true;
            this.lblUnlinkedEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlinkedEvidence.Location = new System.Drawing.Point(262, 154);
            this.lblUnlinkedEvidence.Name = "lblUnlinkedEvidence";
            this.lblUnlinkedEvidence.Size = new System.Drawing.Size(251, 58);
            this.lblUnlinkedEvidence.TabIndex = 10;
            this.lblUnlinkedEvidence.Text = "Unlinked Evidences: 0";
            // 
            // lblPendingEvidence
            // 
            this.lblPendingEvidence.AutoSize = true;
            this.lblPendingEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingEvidence.Location = new System.Drawing.Point(3, 154);
            this.lblPendingEvidence.Name = "lblPendingEvidence";
            this.lblPendingEvidence.Size = new System.Drawing.Size(252, 58);
            this.lblPendingEvidence.TabIndex = 9;
            this.lblPendingEvidence.Text = "Pending Evidences: 0";
            // 
            // lblTotalWitnesses
            // 
            this.lblTotalWitnesses.AutoSize = true;
            this.lblTotalWitnesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWitnesses.Location = new System.Drawing.Point(522, 77);
            this.lblTotalWitnesses.Name = "lblTotalWitnesses";
            this.lblTotalWitnesses.Size = new System.Drawing.Size(228, 29);
            this.lblTotalWitnesses.TabIndex = 8;
            this.lblTotalWitnesses.Text = "Total Witnesses: 0";
            // 
            // lblTotalSuspects
            // 
            this.lblTotalSuspects.AutoSize = true;
            this.lblTotalSuspects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuspects.Location = new System.Drawing.Point(262, 77);
            this.lblTotalSuspects.Name = "lblTotalSuspects";
            this.lblTotalSuspects.Size = new System.Drawing.Size(215, 29);
            this.lblTotalSuspects.TabIndex = 7;
            this.lblTotalSuspects.Text = "Total Suspects: 0";
            // 
            // lblClosedCases
            // 
            this.lblClosedCases.AutoSize = true;
            this.lblClosedCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedCases.Location = new System.Drawing.Point(3, 77);
            this.lblClosedCases.Name = "lblClosedCases";
            this.lblClosedCases.Size = new System.Drawing.Size(204, 29);
            this.lblClosedCases.TabIndex = 6;
            this.lblClosedCases.Text = "Closed Cases: 0";
            this.lblClosedCases.Click += new System.EventHandler(this.lblClosedCases_Click);
            // 
            // lblColdCases
            // 
            this.lblColdCases.AutoSize = true;
            this.lblColdCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColdCases.Location = new System.Drawing.Point(522, 0);
            this.lblColdCases.Name = "lblColdCases";
            this.lblColdCases.Size = new System.Drawing.Size(176, 29);
            this.lblColdCases.TabIndex = 5;
            this.lblColdCases.Text = "Cold Cases: 0";
            // 
            // lblOpenCases
            // 
            this.lblOpenCases.AutoSize = true;
            this.lblOpenCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCases.Location = new System.Drawing.Point(262, 0);
            this.lblOpenCases.Name = "lblOpenCases";
            this.lblOpenCases.Size = new System.Drawing.Size(185, 29);
            this.lblOpenCases.TabIndex = 4;
            this.lblOpenCases.Text = "Open Cases: 0";
            // 
            // lblTotalCases
            // 
            this.lblTotalCases.AutoSize = true;
            this.lblTotalCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCases.Location = new System.Drawing.Point(3, 0);
            this.lblTotalCases.Name = "lblTotalCases";
            this.lblTotalCases.Size = new System.Drawing.Size(181, 29);
            this.lblTotalCases.TabIndex = 3;
            this.lblTotalCases.Text = "Total Cases: 0";
            // 
            // dgvAllCases
            // 
            this.dgvAllCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCases.Location = new System.Drawing.Point(35, 425);
            this.dgvAllCases.Name = "dgvAllCases";
            this.dgvAllCases.RowHeadersWidth = 72;
            this.dgvAllCases.RowTemplate.Height = 31;
            this.dgvAllCases.Size = new System.Drawing.Size(780, 369);
            this.dgvAllCases.TabIndex = 3;
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefreshDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDashboard.Location = new System.Drawing.Point(77, 832);
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Size = new System.Drawing.Size(220, 74);
            this.btnRefreshDashboard.TabIndex = 9;
            this.btnRefreshDashboard.Text = "Refresh";
            this.btnRefreshDashboard.UseVisualStyleBackColor = false;
            this.btnRefreshDashboard.Click += new System.EventHandler(this.btnRefreshDashboard_Click);
            // 
            // buttonReassignDetective
            // 
            this.buttonReassignDetective.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonReassignDetective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReassignDetective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonReassignDetective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReassignDetective.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReassignDetective.Location = new System.Drawing.Point(388, 832);
            this.buttonReassignDetective.Name = "buttonReassignDetective";
            this.buttonReassignDetective.Size = new System.Drawing.Size(369, 74);
            this.buttonReassignDetective.TabIndex = 10;
            this.buttonReassignDetective.Text = "Reassign Detective";
            this.buttonReassignDetective.UseVisualStyleBackColor = false;
            this.buttonReassignDetective.Click += new System.EventHandler(this.buttonReassignDetective_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(723, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 62);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(30, 65);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(78, 25);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "UserID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // ChiefInvestigatorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 952);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.buttonReassignDetective);
            this.Controls.Add(this.btnRefreshDashboard);
            this.Controls.Add(this.dgvAllCases);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDICPS);
            this.Name = "ChiefInvestigatorDashboardForm";
            this.Text = "ChiefInvestigatorDashboardForm";
            this.Load += new System.EventHandler(this.ChiefInvestigatorDashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalProfilingReports;
        private System.Windows.Forms.Label lblUnlinkedEvidence;
        private System.Windows.Forms.Label lblPendingEvidence;
        private System.Windows.Forms.Label lblTotalWitnesses;
        private System.Windows.Forms.Label lblTotalSuspects;
        private System.Windows.Forms.Label lblClosedCases;
        private System.Windows.Forms.Label lblColdCases;
        private System.Windows.Forms.Label lblOpenCases;
        private System.Windows.Forms.Label lblTotalCases;
        private System.Windows.Forms.DataGridView dgvAllCases;
        private System.Windows.Forms.Button btnRefreshDashboard;
        private System.Windows.Forms.Button buttonReassignDetective;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
    }
}