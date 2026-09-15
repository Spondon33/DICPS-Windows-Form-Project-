namespace DICPS.Forms.CaseRecords
{
    partial class ColdCaseForm
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
            this.grpReopenClosedCase = new System.Windows.Forms.GroupBox();
            this.lblColdCase = new System.Windows.Forms.Label();
            this.lblCaseId = new System.Windows.Forms.Label();
            this.txtCaseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReopenCase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpColdCases = new System.Windows.Forms.GroupBox();
            this.dgvColdCases = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNewLeadsSummary = new System.Windows.Forms.RichTextBox();
            this.grpReopenClosedCase.SuspendLayout();
            this.grpColdCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColdCases)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReopenClosedCase
            // 
            this.grpReopenClosedCase.Controls.Add(this.txtNewLeadsSummary);
            this.grpReopenClosedCase.Controls.Add(this.btnClear);
            this.grpReopenClosedCase.Controls.Add(this.btnReopenCase);
            this.grpReopenClosedCase.Controls.Add(this.dateTimePicker1);
            this.grpReopenClosedCase.Controls.Add(this.label2);
            this.grpReopenClosedCase.Controls.Add(this.label1);
            this.grpReopenClosedCase.Controls.Add(this.lblCaseId);
            this.grpReopenClosedCase.Controls.Add(this.txtCaseId);
            this.grpReopenClosedCase.Location = new System.Drawing.Point(19, 79);
            this.grpReopenClosedCase.Name = "grpReopenClosedCase";
            this.grpReopenClosedCase.Size = new System.Drawing.Size(756, 494);
            this.grpReopenClosedCase.TabIndex = 0;
            this.grpReopenClosedCase.TabStop = false;
            this.grpReopenClosedCase.Text = "Reopen Closed Case";
            // 
            // lblColdCase
            // 
            this.lblColdCase.AutoSize = true;
            this.lblColdCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblColdCase.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblColdCase.Location = new System.Drawing.Point(12, 19);
            this.lblColdCase.Name = "lblColdCase";
            this.lblColdCase.Size = new System.Drawing.Size(179, 38);
            this.lblColdCase.TabIndex = 21;
            this.lblColdCase.Text = "Cold Case";
            // 
            // lblCaseId
            // 
            this.lblCaseId.AutoSize = true;
            this.lblCaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCaseId.Location = new System.Drawing.Point(25, 45);
            this.lblCaseId.Name = "lblCaseId";
            this.lblCaseId.Size = new System.Drawing.Size(120, 30);
            this.lblCaseId.TabIndex = 8;
            this.lblCaseId.Text = "Case ID:";
            // 
            // txtCaseId
            // 
            this.txtCaseId.Location = new System.Drawing.Point(151, 46);
            this.txtCaseId.Name = "txtCaseId";
            this.txtCaseId.Size = new System.Drawing.Size(289, 29);
            this.txtCaseId.TabIndex = 9;
            this.txtCaseId.TextChanged += new System.EventHandler(this.txtCaseId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Leads Summary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date Reopened:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 29);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnReopenCase
            // 
            this.btnReopenCase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReopenCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReopenCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReopenCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReopenCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReopenCase.Location = new System.Drawing.Point(61, 403);
            this.btnReopenCase.Name = "btnReopenCase";
            this.btnReopenCase.Size = new System.Drawing.Size(221, 59);
            this.btnReopenCase.TabIndex = 24;
            this.btnReopenCase.Text = "Reopen Case";
            this.btnReopenCase.UseVisualStyleBackColor = false;
            this.btnReopenCase.Click += new System.EventHandler(this.btnReopenCase_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(446, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 59);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpColdCases
            // 
            this.grpColdCases.Controls.Add(this.dgvColdCases);
            this.grpColdCases.Controls.Add(this.btnRefresh);
            this.grpColdCases.Location = new System.Drawing.Point(19, 579);
            this.grpColdCases.Name = "grpColdCases";
            this.grpColdCases.Size = new System.Drawing.Size(756, 340);
            this.grpColdCases.TabIndex = 29;
            this.grpColdCases.TabStop = false;
            this.grpColdCases.Text = "Cold Cases";
            // 
            // dgvColdCases
            // 
            this.dgvColdCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColdCases.Location = new System.Drawing.Point(20, 50);
            this.dgvColdCases.Name = "dgvColdCases";
            this.dgvColdCases.RowHeadersWidth = 72;
            this.dgvColdCases.RowTemplate.Height = 31;
            this.dgvColdCases.Size = new System.Drawing.Size(711, 184);
            this.dgvColdCases.TabIndex = 23;
            this.dgvColdCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColdCases_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(253, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 59);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNewLeadsSummary
            // 
            this.txtNewLeadsSummary.Location = new System.Drawing.Point(61, 168);
            this.txtNewLeadsSummary.Name = "txtNewLeadsSummary";
            this.txtNewLeadsSummary.Size = new System.Drawing.Size(379, 134);
            this.txtNewLeadsSummary.TabIndex = 26;
            this.txtNewLeadsSummary.Text = "";
            this.txtNewLeadsSummary.TextChanged += new System.EventHandler(this.txtNewLeadsSummary_TextChanged);
            // 
            // ColdCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 931);
            this.Controls.Add(this.grpColdCases);
            this.Controls.Add(this.lblColdCase);
            this.Controls.Add(this.grpReopenClosedCase);
            this.Name = "ColdCaseForm";
            this.Text = "ColdCaseForm";
            this.Load += new System.EventHandler(this.ColdCaseForm_Load);
            this.grpReopenClosedCase.ResumeLayout(false);
            this.grpReopenClosedCase.PerformLayout();
            this.grpColdCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColdCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReopenClosedCase;
        private System.Windows.Forms.Label lblColdCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaseId;
        private System.Windows.Forms.TextBox txtCaseId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReopenCase;
        private System.Windows.Forms.GroupBox grpColdCases;
        private System.Windows.Forms.DataGridView dgvColdCases;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RichTextBox txtNewLeadsSummary;
    }
}