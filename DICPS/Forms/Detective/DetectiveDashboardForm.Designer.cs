namespace DICPS.Forms.Detective
{
    partial class DetectiveDashboardForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btncaseload = new System.Windows.Forms.Button();
            this.btnsperson = new System.Windows.Forms.Button();
            this.btnrgperson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(351, 9);
            this.lblDICPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(433, 72);
            this.lblDICPS.TabIndex = 1;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detective Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome, Detective";
            // 
            // btncaseload
            // 
            this.btncaseload.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaseload.Location = new System.Drawing.Point(60, 271);
            this.btncaseload.Name = "btncaseload";
            this.btncaseload.Size = new System.Drawing.Size(217, 94);
            this.btncaseload.TabIndex = 4;
            this.btncaseload.Text = "CaseLoad";
            this.btncaseload.UseVisualStyleBackColor = true;
            this.btncaseload.Click += new System.EventHandler(this.btncaseload_Click);
            // 
            // btnsperson
            // 
            this.btnsperson.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsperson.Location = new System.Drawing.Point(430, 273);
            this.btnsperson.Name = "btnsperson";
            this.btnsperson.Size = new System.Drawing.Size(217, 92);
            this.btnsperson.TabIndex = 7;
            this.btnsperson.Text = " Search Person";
            this.btnsperson.UseVisualStyleBackColor = true;
            this.btnsperson.Click += new System.EventHandler(this.btnsperson_Click);
            // 
            // btnrgperson
            // 
            this.btnrgperson.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrgperson.Location = new System.Drawing.Point(810, 274);
            this.btnrgperson.Name = "btnrgperson";
            this.btnrgperson.Size = new System.Drawing.Size(217, 91);
            this.btnrgperson.TabIndex = 8;
            this.btnrgperson.Text = "Register Person";
            this.btnrgperson.UseVisualStyleBackColor = true;
            this.btnrgperson.Click += new System.EventHandler(this.btnrgperson_Click);
            // 
            // DetectiveDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 714);
            this.Controls.Add(this.btnrgperson);
            this.Controls.Add(this.btnsperson);
            this.Controls.Add(this.btncaseload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDICPS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetectiveDashboardForm";
            this.Text = "DetectiveDashboardForm";
            this.Load += new System.EventHandler(this.DetectiveDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncaseload;
        private System.Windows.Forms.Button btnsperson;
        private System.Windows.Forms.Button btnrgperson;
    }
}