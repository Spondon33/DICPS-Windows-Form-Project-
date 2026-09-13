namespace DICPS.Forms.Detective
{
    partial class btncaseloadform
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
            this.lbldateadd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblnotetext = new System.Windows.Forms.Label();
            this.richtxtnotetext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(228, 9);
            this.lblDICPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(433, 72);
            this.lblDICPS.TabIndex = 2;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Case Note";
            // 
            // lbldateadd
            // 
            this.lbldateadd.AutoSize = true;
            this.lbldateadd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateadd.Location = new System.Drawing.Point(139, 493);
            this.lbldateadd.Name = "lbldateadd";
            this.lbldateadd.Size = new System.Drawing.Size(126, 27);
            this.lbldateadd.TabIndex = 6;
            this.lbldateadd.Text = "DateAdded";
            this.lbldateadd.Click += new System.EventHandler(this.lbldateadd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 493);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblnotetext
            // 
            this.lblnotetext.AutoSize = true;
            this.lblnotetext.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotetext.Location = new System.Drawing.Point(152, 238);
            this.lblnotetext.Name = "lblnotetext";
            this.lblnotetext.Size = new System.Drawing.Size(113, 27);
            this.lblnotetext.TabIndex = 8;
            this.lblnotetext.Text = "Note Text";
            this.lblnotetext.Click += new System.EventHandler(this.lblnotetext_Click);
            // 
            // richtxtnotetext
            // 
            this.richtxtnotetext.Location = new System.Drawing.Point(326, 238);
            this.richtxtnotetext.Name = "richtxtnotetext";
            this.richtxtnotetext.Size = new System.Drawing.Size(349, 118);
            this.richtxtnotetext.TabIndex = 9;
            this.richtxtnotetext.Text = "";
            this.richtxtnotetext.TextChanged += new System.EventHandler(this.richtxtnotetext_TextChanged);
            // 
            // btncaseloadform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 730);
            this.Controls.Add(this.richtxtnotetext);
            this.Controls.Add(this.lblnotetext);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldateadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDICPS);
            this.Name = "btncaseloadform";
            this.Text = "CaseLoadForm";
            this.Load += new System.EventHandler(this.btncaseloadform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldateadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblnotetext;
        private System.Windows.Forms.RichTextBox richtxtnotetext;
    }
}