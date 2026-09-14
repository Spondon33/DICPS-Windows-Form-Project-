namespace DICPS.Forms.Evidence
{
    partial class AddEvidenceForm
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
            this.lblAddEvidenceForm = new System.Windows.Forms.Label();
            this.lblEvidenceType = new System.Windows.Forms.Label();
            this.cmbEvidenceType = new System.Windows.Forms.ComboBox();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.txtCaseID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateCollected = new System.Windows.Forms.DateTimePicker();
            this.lblHashValue = new System.Windows.Forms.Label();
            this.txtHashValue = new System.Windows.Forms.TextBox();
            this.btnSaveEvidence = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvidenceIdToVerify = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblVerifyResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddEvidenceForm
            // 
            this.lblAddEvidenceForm.AutoSize = true;
            this.lblAddEvidenceForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddEvidenceForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddEvidenceForm.Location = new System.Drawing.Point(26, 21);
            this.lblAddEvidenceForm.Name = "lblAddEvidenceForm";
            this.lblAddEvidenceForm.Size = new System.Drawing.Size(321, 38);
            this.lblAddEvidenceForm.TabIndex = 15;
            this.lblAddEvidenceForm.Text = "Add Evidence Form";
            // 
            // lblEvidenceType
            // 
            this.lblEvidenceType.AutoSize = true;
            this.lblEvidenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvidenceType.Location = new System.Drawing.Point(62, 124);
            this.lblEvidenceType.Name = "lblEvidenceType";
            this.lblEvidenceType.Size = new System.Drawing.Size(224, 32);
            this.lblEvidenceType.TabIndex = 20;
            this.lblEvidenceType.Text = "Evidence Type:";
            this.lblEvidenceType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEvidenceType
            // 
            this.cmbEvidenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvidenceType.FormattingEnabled = true;
            this.cmbEvidenceType.Location = new System.Drawing.Point(305, 124);
            this.cmbEvidenceType.Name = "cmbEvidenceType";
            this.cmbEvidenceType.Size = new System.Drawing.Size(361, 32);
            this.cmbEvidenceType.TabIndex = 21;
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseID.Location = new System.Drawing.Point(62, 188);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(130, 32);
            this.lblCaseID.TabIndex = 22;
            this.lblCaseID.Text = "Case ID:";
            this.lblCaseID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCaseID
            // 
            this.txtCaseID.Location = new System.Drawing.Point(305, 190);
            this.txtCaseID.Name = "txtCaseID";
            this.txtCaseID.Size = new System.Drawing.Size(361, 29);
            this.txtCaseID.TabIndex = 23;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(62, 254);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(177, 32);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(305, 258);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 126);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date Collected:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDateCollected
            // 
            this.dtpDateCollected.Location = new System.Drawing.Point(305, 438);
            this.dtpDateCollected.Name = "dtpDateCollected";
            this.dtpDateCollected.Size = new System.Drawing.Size(200, 29);
            this.dtpDateCollected.TabIndex = 27;
            // 
            // lblHashValue
            // 
            this.lblHashValue.AutoSize = true;
            this.lblHashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashValue.Location = new System.Drawing.Point(62, 505);
            this.lblHashValue.Name = "lblHashValue";
            this.lblHashValue.Size = new System.Drawing.Size(180, 32);
            this.lblHashValue.TabIndex = 28;
            this.lblHashValue.Text = "Hash Value:";
            this.lblHashValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHashValue
            // 
            this.txtHashValue.Location = new System.Drawing.Point(305, 509);
            this.txtHashValue.Name = "txtHashValue";
            this.txtHashValue.Size = new System.Drawing.Size(361, 29);
            this.txtHashValue.TabIndex = 29;
            // 
            // btnSaveEvidence
            // 
            this.btnSaveEvidence.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaveEvidence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveEvidence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveEvidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveEvidence.Location = new System.Drawing.Point(241, 619);
            this.btnSaveEvidence.Name = "btnSaveEvidence";
            this.btnSaveEvidence.Size = new System.Drawing.Size(244, 43);
            this.btnSaveEvidence.TabIndex = 30;
            this.btnSaveEvidence.Text = "Save Evidence";
            this.btnSaveEvidence.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 500);
            this.label2.TabIndex = 31;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(797, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Evidence ID to Verify:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEvidenceIdToVerify
            // 
            this.txtEvidenceIdToVerify.Location = new System.Drawing.Point(1128, 245);
            this.txtEvidenceIdToVerify.Name = "txtEvidenceIdToVerify";
            this.txtEvidenceIdToVerify.Size = new System.Drawing.Size(238, 29);
            this.txtEvidenceIdToVerify.TabIndex = 33;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerify.Location = new System.Drawing.Point(969, 341);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(244, 43);
            this.btnVerify.TabIndex = 34;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // lblVerifyResult
            // 
            this.lblVerifyResult.AutoSize = true;
            this.lblVerifyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyResult.Location = new System.Drawing.Point(840, 435);
            this.lblVerifyResult.Name = "lblVerifyResult";
            this.lblVerifyResult.Size = new System.Drawing.Size(197, 32);
            this.lblVerifyResult.TabIndex = 35;
            this.lblVerifyResult.Text = "Verify Result:";
            this.lblVerifyResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddEvidenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 812);
            this.Controls.Add(this.lblVerifyResult);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtEvidenceIdToVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveEvidence);
            this.Controls.Add(this.txtHashValue);
            this.Controls.Add(this.lblHashValue);
            this.Controls.Add(this.dtpDateCollected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCaseID);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.cmbEvidenceType);
            this.Controls.Add(this.lblEvidenceType);
            this.Controls.Add(this.lblAddEvidenceForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEvidenceForm";
            this.Text = "AddEvidenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEvidenceForm;
        private System.Windows.Forms.Label lblEvidenceType;
        private System.Windows.Forms.ComboBox cmbEvidenceType;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.TextBox txtCaseID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateCollected;
        private System.Windows.Forms.Label lblHashValue;
        private System.Windows.Forms.TextBox txtHashValue;
        private System.Windows.Forms.Button btnSaveEvidence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvidenceIdToVerify;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblVerifyResult;
    }
}