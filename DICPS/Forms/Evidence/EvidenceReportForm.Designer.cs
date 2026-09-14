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
            this.lblDICPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EvidenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvidenceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(175, 25);
            this.lblDICPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(433, 72);
            this.lblDICPS.TabIndex = 2;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDICPS.Click += new System.EventHandler(this.lblDICPS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "  EVIDENCE REPORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = " Case ID :";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Evidence Type :";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Physical",
            "Digital",
            "Document",
            "Biological",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(267, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvidenceId,
            this.CaseId,
            this.EvidenceType,
            this.Description,
            this.EvidenceDate,
            this.CollectedBy,
            this.Location});
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 88);
            this.dataGridView1.TabIndex = 8;
            // 
            // EvidenceId
            // 
            this.EvidenceId.HeaderText = "Evidence ID";
            this.EvidenceId.MinimumWidth = 6;
            this.EvidenceId.Name = "EvidenceId";
            this.EvidenceId.Width = 125;
            // 
            // CaseId
            // 
            this.CaseId.HeaderText = "Case ID";
            this.CaseId.MinimumWidth = 6;
            this.CaseId.Name = "CaseId";
            this.CaseId.Width = 125;
            // 
            // EvidenceType
            // 
            this.EvidenceType.HeaderText = " Evidence Type";
            this.EvidenceType.MinimumWidth = 6;
            this.EvidenceType.Name = "EvidenceType";
            this.EvidenceType.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = " Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // EvidenceDate
            // 
            this.EvidenceDate.HeaderText = "Date";
            this.EvidenceDate.MinimumWidth = 6;
            this.EvidenceDate.Name = "EvidenceDate";
            this.EvidenceDate.Width = 125;
            // 
            // CollectedBy
            // 
            this.CollectedBy.HeaderText = " Collected By";
            this.CollectedBy.MinimumWidth = 6;
            this.CollectedBy.Name = "CollectedBy";
            this.CollectedBy.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // EvidenceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDICPS);
            this.Name = "EvidenceReportForm";
            this.Text = "EvidenceReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}