namespace DICPS.Forms.CaseRecords
{
    partial class CaseRecordsDashboardForm
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
            this.btnColdCase = new System.Windows.Forms.Button();
            this.btnCaseSearch = new System.Windows.Forms.Button();
            this.btnNewCase = new System.Windows.Forms.Button();
            this.lblcrd = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(191, 9);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(527, 80);
            this.lblDICPS.TabIndex = 5;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.Click += new System.EventHandler(this.lblDICPS_Click);
            // 
            // btnColdCase
            // 
            this.btnColdCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColdCase.Location = new System.Drawing.Point(412, 189);
            this.btnColdCase.Name = "btnColdCase";
            this.btnColdCase.Size = new System.Drawing.Size(130, 35);
            this.btnColdCase.TabIndex = 7;
            this.btnColdCase.Text = "Cold Case";
            this.btnColdCase.UseVisualStyleBackColor = true;
            this.btnColdCase.Click += new System.EventHandler(this.btnColdCase_Click);
            // 
            // btnCaseSearch
            // 
            this.btnCaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseSearch.Location = new System.Drawing.Point(173, 256);
            this.btnCaseSearch.Name = "btnCaseSearch";
            this.btnCaseSearch.Size = new System.Drawing.Size(130, 35);
            this.btnCaseSearch.TabIndex = 8;
            this.btnCaseSearch.Text = "CaseSearch";
            this.btnCaseSearch.UseVisualStyleBackColor = true;
            this.btnCaseSearch.Click += new System.EventHandler(this.btnCaseSearch_Click);
            // 
            // btnNewCase
            // 
            this.btnNewCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCase.Location = new System.Drawing.Point(173, 189);
            this.btnNewCase.Name = "btnNewCase";
            this.btnNewCase.Size = new System.Drawing.Size(130, 35);
            this.btnNewCase.TabIndex = 9;
            this.btnNewCase.Text = "New Case";
            this.btnNewCase.UseVisualStyleBackColor = true;
            this.btnNewCase.Click += new System.EventHandler(this.btnNewCase_Click);
            // 
            // lblcrd
            // 
            this.lblcrd.AutoSize = true;
            this.lblcrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrd.Location = new System.Drawing.Point(167, 105);
            this.lblcrd.Name = "lblcrd";
            this.lblcrd.Size = new System.Drawing.Size(480, 32);
            this.lblcrd.TabIndex = 10;
            this.lblcrd.Text = "Welcome to CaseRecordsDashboard";
            this.lblcrd.Click += new System.EventHandler(this.lblcrd_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(412, 256);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(130, 35);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // CaseRecordsDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblcrd);
            this.Controls.Add(this.btnNewCase);
            this.Controls.Add(this.btnCaseSearch);
            this.Controls.Add(this.btnColdCase);
            this.Controls.Add(this.lblDICPS);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "CaseRecordsDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaseRecordsDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Button btnColdCase;
        private System.Windows.Forms.Button btnCaseSearch;
        private System.Windows.Forms.Button btnNewCase;
        private System.Windows.Forms.Label lblcrd;
        private System.Windows.Forms.Button btnlogout;
    }
}