namespace DICPS.Forms.Evidence
{
    partial class EvidenceReportForm
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
            this.lblEvidenceReport = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.txtCaseId = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvidenceReport
            // 
            this.lblEvidenceReport.AutoSize = true;
            this.lblEvidenceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblEvidenceReport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEvidenceReport.Location = new System.Drawing.Point(32, 26);
            this.lblEvidenceReport.Name = "lblEvidenceReport";
            this.lblEvidenceReport.Size = new System.Drawing.Size(274, 38);
            this.lblEvidenceReport.TabIndex = 23;
            this.lblEvidenceReport.Text = "Evidence Report";
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseID.Location = new System.Drawing.Point(231, 124);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(130, 32);
            this.lblCaseID.TabIndex = 24;
            this.lblCaseID.Text = "Case ID:";
            this.lblCaseID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCaseId
            // 
            this.txtCaseId.Location = new System.Drawing.Point(380, 126);
            this.txtCaseId.Name = "txtCaseId";
            this.txtCaseId.Size = new System.Drawing.Size(324, 29);
            this.txtCaseId.TabIndex = 25;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.Location = new System.Drawing.Point(299, 204);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(340, 43);
            this.btnGenerateReport.TabIndex = 36;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;

            // EVENT
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(231, 290);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(182, 32);
            this.lblReportTitle.TabIndex = 37;
            this.lblReportTitle.Text = "Report Title:";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(94, 349);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 72;
            this.dgvReport.RowTemplate.Height = 31;
            this.dgvReport.Size = new System.Drawing.Size(755, 345);
            this.dgvReport.TabIndex = 38;
            // 
            // EvidenceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 778);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.txtCaseId);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.lblEvidenceReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EvidenceReportForm";
            this.Text = "EvidenceReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvidenceReport;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.TextBox txtCaseId;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}