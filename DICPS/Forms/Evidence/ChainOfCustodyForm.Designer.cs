namespace DICPS.Forms.Evidence
{
    partial class ChainOfCustodyForm
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
            this.lblEvidenceId = new System.Windows.Forms.Label();
            this.lblChainOfCustody = new System.Windows.Forms.Label();
            this.dgvCustodyLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.btnAddLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustodyLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvidenceId
            // 
            this.lblEvidenceId.AutoSize = true;
            this.lblEvidenceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvidenceId.Location = new System.Drawing.Point(64, 120);
            this.lblEvidenceId.Name = "lblEvidenceId";
            this.lblEvidenceId.Size = new System.Drawing.Size(186, 32);
            this.lblEvidenceId.TabIndex = 21;
            this.lblEvidenceId.Text = "Evidence ID:";
            this.lblEvidenceId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChainOfCustody
            // 
            this.lblChainOfCustody.AutoSize = true;
            this.lblChainOfCustody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblChainOfCustody.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChainOfCustody.Location = new System.Drawing.Point(22, 22);
            this.lblChainOfCustody.Name = "lblChainOfCustody";
            this.lblChainOfCustody.Size = new System.Drawing.Size(292, 38);
            this.lblChainOfCustody.TabIndex = 22;
            this.lblChainOfCustody.Text = "Chain Of Custody";
            // 
            // dgvCustodyLog
            // 
            this.dgvCustodyLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustodyLog.Location = new System.Drawing.Point(70, 185);
            this.dgvCustodyLog.Name = "dgvCustodyLog";
            this.dgvCustodyLog.RowHeadersWidth = 72;
            this.dgvCustodyLog.RowTemplate.Height = 31;
            this.dgvCustodyLog.Size = new System.Drawing.Size(639, 233);
            this.dgvCustodyLog.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Notes:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(190, 468);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(421, 109);
            this.txtNotes.TabIndex = 25;
            this.txtNotes.Text = "";
            // 
            // btnAddLog
            // 
            this.btnAddLog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddLog.Location = new System.Drawing.Point(226, 631);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(340, 59);
            this.btnAddLog.TabIndex = 35;
            this.btnAddLog.Text = "Add Custody Entry";
            this.btnAddLog.UseVisualStyleBackColor = false;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // ChainOfCustodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 760);
            this.Controls.Add(this.btnAddLog);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustodyLog);
            this.Controls.Add(this.lblChainOfCustody);
            this.Controls.Add(this.lblEvidenceId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChainOfCustodyForm";
            this.Text = "ChainOfCustodyForm";
            this.Load += new System.EventHandler(this.ChainOfCustodyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustodyLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvidenceId;
        private System.Windows.Forms.Label lblChainOfCustody;
        private System.Windows.Forms.DataGridView dgvCustodyLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Button btnAddLog;
    }
}