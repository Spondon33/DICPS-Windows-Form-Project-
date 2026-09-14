using System;

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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaseNumber = new System.Windows.Forms.Label();
            this.lblNewLeadsSummary = new System.Windows.Forms.Label();
            this.lblDateReopened = new System.Windows.Forms.Label();
            this.btnReopendCase = new System.Windows.Forms.Button();
            this.lblSelectCase = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSelectCase = new System.Windows.Forms.ComboBox();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.dtpDataReopened = new System.Windows.Forms.DateTimePicker();
            this.textNewLeadsSummary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(203, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(339, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Cold Case Management";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentStatus.Location = new System.Drawing.Point(188, 290);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(165, 25);
            this.lblCurrentStatus.TabIndex = 3;
            this.lblCurrentStatus.Text = "Current Status: ";
            this.lblCurrentStatus.Click += new System.EventHandler(this.lblCurrentStatus_Click);
            // 
            // lblCaseNumber
            // 
            this.lblCaseNumber.AutoSize = true;
            this.lblCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCaseNumber.Location = new System.Drawing.Point(196, 235);
            this.lblCaseNumber.Name = "lblCaseNumber";
            this.lblCaseNumber.Size = new System.Drawing.Size(157, 25);
            this.lblCaseNumber.TabIndex = 2;
            this.lblCaseNumber.Text = "Case Number: ";
            this.lblCaseNumber.Click += new System.EventHandler(this.lblCaseNumber_Click);
            // 
            // lblNewLeadsSummary
            // 
            this.lblNewLeadsSummary.AutoSize = true;
            this.lblNewLeadsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLeadsSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewLeadsSummary.Location = new System.Drawing.Point(157, 389);
            this.lblNewLeadsSummary.Name = "lblNewLeadsSummary";
            this.lblNewLeadsSummary.Size = new System.Drawing.Size(223, 25);
            this.lblNewLeadsSummary.TabIndex = 5;
            this.lblNewLeadsSummary.Text = "New Leads Summary:";
            this.lblNewLeadsSummary.Click += new System.EventHandler(this.lblNewLeadsSummary_Click);
            // 
            // lblDateReopened
            // 
            this.lblDateReopened.AutoSize = true;
            this.lblDateReopened.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReopened.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateReopened.Location = new System.Drawing.Point(188, 348);
            this.lblDateReopened.Name = "lblDateReopened";
            this.lblDateReopened.Size = new System.Drawing.Size(174, 25);
            this.lblDateReopened.TabIndex = 4;
            this.lblDateReopened.Text = "Date Reopened: ";
            this.lblDateReopened.Click += new System.EventHandler(this.lblDateReopened_Click);
            // 
            // btnReopendCase
            // 
            this.btnReopendCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReopendCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReopendCase.Location = new System.Drawing.Point(650, 140);
            this.btnReopendCase.Name = "btnReopendCase";
            this.btnReopendCase.Size = new System.Drawing.Size(157, 35);
            this.btnReopendCase.TabIndex = 6;
            this.btnReopendCase.Text = "Reopen Case";
            this.btnReopendCase.UseVisualStyleBackColor = true;
            this.btnReopendCase.Click += new System.EventHandler(this.btnReopenCase_Click);
            // 
            // lblSelectCase
            // 
            this.lblSelectCase.AutoSize = true;
            this.lblSelectCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectCase.Location = new System.Drawing.Point(204, 144);
            this.lblSelectCase.Name = "lblSelectCase";
            this.lblSelectCase.Size = new System.Drawing.Size(137, 25);
            this.lblSelectCase.TabIndex = 7;
            this.lblSelectCase.Text = "Select Case:";
            this.lblSelectCase.Click += new System.EventHandler(this.lblSelectCase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(650, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbSelectCase
            // 
            this.cmbSelectCase.FormattingEnabled = true;
            this.cmbSelectCase.Location = new System.Drawing.Point(350, 140);
            this.cmbSelectCase.Name = "cmbSelectCase";
            this.cmbSelectCase.Size = new System.Drawing.Size(250, 24);
            this.cmbSelectCase.TabIndex = 9;
            this.cmbSelectCase.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCase_SelectedIndexChanged);
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Location = new System.Drawing.Point(360, 232);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.ReadOnly = true;
            this.txtCaseNumber.Size = new System.Drawing.Size(200, 22);
            this.txtCaseNumber.TabIndex = 10;
            this.txtCaseNumber.TextChanged += new System.EventHandler(this.txtCaseNumber_TextChanged);
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Location = new System.Drawing.Point(360, 287);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(200, 22);
            this.txtCurrentStatus.TabIndex = 11;
            this.txtCurrentStatus.TextChanged += new System.EventHandler(this.txtCurrentStatus_TextChanged);
            // 
            // dtpDataReopened
            // 
            this.dtpDataReopened.Location = new System.Drawing.Point(370, 345);
            this.dtpDataReopened.Name = "dtpDataReopened";
            this.dtpDataReopened.Size = new System.Drawing.Size(200, 22);
            this.dtpDataReopened.TabIndex = 12;
            // 
            // textNewLeadsSummary
            // 
            this.textNewLeadsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewLeadsSummary.Location = new System.Drawing.Point(337, 435);
            this.textNewLeadsSummary.Multiline = true;
            this.textNewLeadsSummary.Name = "textNewLeadsSummary";
            this.textNewLeadsSummary.Size = new System.Drawing.Size(350, 100);
            this.textNewLeadsSummary.TabIndex = 13;
            // 
            // ColdCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.textNewLeadsSummary);
            this.Controls.Add(this.dtpDataReopened);
            this.Controls.Add(this.txtCurrentStatus);
            this.Controls.Add(this.txtCaseNumber);
            this.Controls.Add(this.cmbSelectCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelectCase);
            this.Controls.Add(this.btnReopendCase);
            this.Controls.Add(this.lblNewLeadsSummary);
            this.Controls.Add(this.lblDateReopened);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblCaseNumber);
            this.Controls.Add(this.lblHeading);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "ColdCaseForm";
            this.Text = "ColdCaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblCaseNumber;
        private System.Windows.Forms.Label lblNewLeadsSummary;
        private System.Windows.Forms.Label lblDateReopened;
        private System.Windows.Forms.Button btnReopendCase;
        private System.Windows.Forms.Label lblSelectCase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbSelectCase;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.DateTimePicker dtpDataReopened;
        private System.Windows.Forms.TextBox textNewLeadsSummary;
    }
}