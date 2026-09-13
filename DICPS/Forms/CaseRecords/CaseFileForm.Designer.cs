namespace DICPS.Forms.CaseRecords
{
    partial class CaseFileForm
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
            this.lblCreatType = new System.Windows.Forms.Label();
            this.lblcasestatus = new System.Windows.Forms.Label();
            this.lblcaseno = new System.Windows.Forms.Label();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.textCaseNo = new System.Windows.Forms.TextBox();
            this.textCaseType = new System.Windows.Forms.TextBox();
            this.cmbCaseStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.textPriority = new System.Windows.Forms.TextBox();
            this.lblCaseFileM = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateCase = new System.Windows.Forms.Button();
            this.btnCloseCase = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnExportRepor = new System.Windows.Forms.Button();
            this.lblAssignedDetective = new System.Windows.Forms.Label();
            this.cmbAssignedDetective = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCreatType
            // 
            this.lblCreatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatType.Location = new System.Drawing.Point(79, 142);
            this.lblCreatType.Name = "lblCreatType";
            this.lblCreatType.Size = new System.Drawing.Size(130, 31);
            this.lblCreatType.TabIndex = 0;
            this.lblCreatType.Text = "Case Type:";
            this.lblCreatType.Click += new System.EventHandler(this.lblCreatCase_Click);
            // 
            // lblcasestatus
            // 
            this.lblcasestatus.AutoSize = true;
            this.lblcasestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcasestatus.Location = new System.Drawing.Point(71, 180);
            this.lblcasestatus.Name = "lblcasestatus";
            this.lblcasestatus.Size = new System.Drawing.Size(138, 25);
            this.lblcasestatus.TabIndex = 3;
            this.lblcasestatus.Text = "Case Status:";
            // 
            // lblcaseno
            // 
            this.lblcaseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaseno.Location = new System.Drawing.Point(103, 106);
            this.lblcaseno.Name = "lblcaseno";
            this.lblcaseno.Size = new System.Drawing.Size(106, 36);
            this.lblcaseno.TabIndex = 2;
            this.lblcaseno.Text = "Case No:";
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOpened.Location = new System.Drawing.Point(53, 293);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(168, 41);
            this.lblDateOpened.TabIndex = 4;
            this.lblDateOpened.Text = "Date Opened:";
            this.lblDateOpened.Click += new System.EventHandler(this.lblincidentdate_Click);
            // 
            // textCaseNo
            // 
            this.textCaseNo.Location = new System.Drawing.Point(225, 106);
            this.textCaseNo.Name = "textCaseNo";
            this.textCaseNo.Size = new System.Drawing.Size(136, 22);
            this.textCaseNo.TabIndex = 5;
            // 
            // textCaseType
            // 
            this.textCaseType.Location = new System.Drawing.Point(225, 146);
            this.textCaseType.Name = "textCaseType";
            this.textCaseType.Size = new System.Drawing.Size(136, 22);
            this.textCaseType.TabIndex = 6;
            // 
            // cmbCaseStatus
            // 
            this.cmbCaseStatus.FormattingEnabled = true;
            this.cmbCaseStatus.Items.AddRange(new object[] {
            "Open",
            "",
            "Under Investigation",
            "",
            "Closed",
            "",
            "Cold",
            "Reopened"});
            this.cmbCaseStatus.Location = new System.Drawing.Point(225, 184);
            this.cmbCaseStatus.Name = "cmbCaseStatus";
            this.cmbCaseStatus.Size = new System.Drawing.Size(184, 24);
            this.cmbCaseStatus.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(114, 253);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(86, 25);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Priority:";
            // 
            // textPriority
            // 
            this.textPriority.Location = new System.Drawing.Point(227, 257);
            this.textPriority.Name = "textPriority";
            this.textPriority.Size = new System.Drawing.Size(105, 22);
            this.textPriority.TabIndex = 10;
            // 
            // lblCaseFileM
            // 
            this.lblCaseFileM.AutoSize = true;
            this.lblCaseFileM.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaseFileM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseFileM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaseFileM.Location = new System.Drawing.Point(227, 34);
            this.lblCaseFileM.Name = "lblCaseFileM";
            this.lblCaseFileM.Size = new System.Drawing.Size(282, 29);
            this.lblCaseFileM.TabIndex = 11;
            this.lblCaseFileM.Text = "Case File Management";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(103, 217);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(101, 25);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 13;
            // 
            // btnCreateCase
            // 
            this.btnCreateCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCase.Location = new System.Drawing.Point(470, 160);
            this.btnCreateCase.Name = "btnCreateCase";
            this.btnCreateCase.Size = new System.Drawing.Size(131, 35);
            this.btnCreateCase.TabIndex = 14;
            this.btnCreateCase.Text = "Create Case";
            this.btnCreateCase.UseVisualStyleBackColor = true;
            // 
            // btnCloseCase
            // 
            this.btnCloseCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCase.Location = new System.Drawing.Point(470, 210);
            this.btnCloseCase.Name = "btnCloseCase";
            this.btnCloseCase.Size = new System.Drawing.Size(130, 30);
            this.btnCloseCase.TabIndex = 15;
            this.btnCloseCase.Text = "Close Case";
            this.btnCloseCase.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(620, 160);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(130, 35);
            this.btnUpdateStatus.TabIndex = 16;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnExportRepor
            // 
            this.btnExportRepor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportRepor.Location = new System.Drawing.Point(620, 210);
            this.btnExportRepor.Name = "btnExportRepor";
            this.btnExportRepor.Size = new System.Drawing.Size(130, 35);
            this.btnExportRepor.TabIndex = 17;
            this.btnExportRepor.Text = "Export Repor";
            this.btnExportRepor.UseVisualStyleBackColor = true;
            // 
            // lblAssignedDetective
            // 
            this.lblAssignedDetective.AutoSize = true;
            this.lblAssignedDetective.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedDetective.Location = new System.Drawing.Point(-2, 334);
            this.lblAssignedDetective.Name = "lblAssignedDetective";
            this.lblAssignedDetective.Size = new System.Drawing.Size(211, 25);
            this.lblAssignedDetective.TabIndex = 18;
            this.lblAssignedDetective.Text = "Assigned Detective: ";
            // 
            // cmbAssignedDetective
            // 
            this.cmbAssignedDetective.FormattingEnabled = true;
            this.cmbAssignedDetective.Location = new System.Drawing.Point(227, 335);
            this.cmbAssignedDetective.Name = "cmbAssignedDetective";
            this.cmbAssignedDetective.Size = new System.Drawing.Size(158, 24);
            this.cmbAssignedDetective.TabIndex = 19;
            // 
            // CaseFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.cmbAssignedDetective);
            this.Controls.Add(this.lblAssignedDetective);
            this.Controls.Add(this.btnExportRepor);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnCloseCase);
            this.Controls.Add(this.btnCreateCase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCaseFileM);
            this.Controls.Add(this.textPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCaseStatus);
            this.Controls.Add(this.textCaseType);
            this.Controls.Add(this.textCaseNo);
            this.Controls.Add(this.lblDateOpened);
            this.Controls.Add(this.lblcasestatus);
            this.Controls.Add(this.lblcaseno);
            this.Controls.Add(this.lblCreatType);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "CaseFileForm";
            this.Text = "CaseFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatType;
        private System.Windows.Forms.Label lblcasestatus;
        private System.Windows.Forms.Label lblcaseno;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.TextBox textCaseNo;
        private System.Windows.Forms.TextBox textCaseType;
        private System.Windows.Forms.ComboBox cmbCaseStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox textPriority;
        private System.Windows.Forms.Label lblCaseFileM;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateCase;
        private System.Windows.Forms.Button btnCloseCase;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnExportRepor;
        private System.Windows.Forms.Label lblAssignedDetective;
        private System.Windows.Forms.ComboBox cmbAssignedDetective;
    }
}