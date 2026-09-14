namespace DICPS.Forms.ChiefInvestigator
{
    partial class ProfilingReportForm
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
            this.lblPR = new System.Windows.Forms.Label();
            this.lblSuspect = new System.Windows.Forms.Label();
            this.cmbSuspect = new System.Windows.Forms.ComboBox();
            this.cmbCase = new System.Windows.Forms.ComboBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.btnGenerateScore = new System.Windows.Forms.Button();
            this.lblScoreResult = new System.Windows.Forms.Label();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPR.Location = new System.Drawing.Point(256, 24);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(257, 38);
            this.lblPR.TabIndex = 2;
            this.lblPR.Text = "Profiling Report";
            // 
            // lblSuspect
            // 
            this.lblSuspect.AutoSize = true;
            this.lblSuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspect.Location = new System.Drawing.Point(62, 116);
            this.lblSuspect.Name = "lblSuspect";
            this.lblSuspect.Size = new System.Drawing.Size(133, 32);
            this.lblSuspect.TabIndex = 4;
            this.lblSuspect.Text = "Suspect:";
            this.lblSuspect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSuspect
            // 
            this.cmbSuspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuspect.FormattingEnabled = true;
            this.cmbSuspect.Location = new System.Drawing.Point(220, 114);
            this.cmbSuspect.Name = "cmbSuspect";
            this.cmbSuspect.Size = new System.Drawing.Size(334, 32);
            this.cmbSuspect.TabIndex = 5;
            // 
            // cmbCase
            // 
            this.cmbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCase.FormattingEnabled = true;
            this.cmbCase.Location = new System.Drawing.Point(220, 177);
            this.cmbCase.Name = "cmbCase";
            this.cmbCase.Size = new System.Drawing.Size(334, 32);
            this.cmbCase.TabIndex = 7;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(62, 179);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(93, 32);
            this.lblCase.TabIndex = 6;
            this.lblCase.Text = "Case:";
            this.lblCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerateScore
            // 
            this.btnGenerateScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerateScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerateScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateScore.Location = new System.Drawing.Point(216, 261);
            this.btnGenerateScore.Name = "btnGenerateScore";
            this.btnGenerateScore.Size = new System.Drawing.Size(350, 69);
            this.btnGenerateScore.TabIndex = 9;
            this.btnGenerateScore.Text = "Generate Score";
            this.btnGenerateScore.UseVisualStyleBackColor = false;
            this.btnGenerateScore.Click += new System.EventHandler(this.btnGenerateScore_Click);
            // 
            // lblScoreResult
            // 
            this.lblScoreResult.AutoSize = true;
            this.lblScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreResult.Location = new System.Drawing.Point(194, 373);
            this.lblScoreResult.Name = "lblScoreResult";
            this.lblScoreResult.Size = new System.Drawing.Size(197, 32);
            this.lblScoreResult.TabIndex = 10;
            this.lblScoreResult.Text = "Score Result:";
            this.lblScoreResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnViewReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(216, 446);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(350, 69);
            this.btnViewReports.TabIndex = 11;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(12, 539);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 72;
            this.dgvReports.RowTemplate.Height = 31;
            this.dgvReports.Size = new System.Drawing.Size(776, 378);
            this.dgvReports.TabIndex = 12;
            // 
            // ProfilingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1068);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.lblScoreResult);
            this.Controls.Add(this.btnGenerateScore);
            this.Controls.Add(this.cmbCase);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.cmbSuspect);
            this.Controls.Add(this.lblSuspect);
            this.Controls.Add(this.lblPR);
            this.Name = "ProfilingReportForm";
            this.Text = "ProfilingReportForm";
            this.Load += new System.EventHandler(this.ProfilingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label lblSuspect;
        private System.Windows.Forms.ComboBox cmbSuspect;
        private System.Windows.Forms.ComboBox cmbCase;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Button btnGenerateScore;
        private System.Windows.Forms.Label lblScoreResult;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}