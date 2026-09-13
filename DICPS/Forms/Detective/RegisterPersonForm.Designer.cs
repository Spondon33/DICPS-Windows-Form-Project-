namespace DICPS.Forms.Detective
{
    partial class RegisterPersonForm
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
            this.lblpersontype = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnsuspect = new System.Windows.Forms.RadioButton();
            this.btnwitness = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcinfo = new System.Windows.Forms.Label();
            this.lblpdes = new System.Windows.Forms.Label();
            this.lblstatement = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.richTxtcontactinfo = new System.Windows.Forms.RichTextBox();
            this.richTxtphydes = new System.Windows.Forms.RichTextBox();
            this.richTxtstatement = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(188, 9);
            this.lblDICPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(433, 72);
            this.lblDICPS.TabIndex = 3;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpersontype
            // 
            this.lblpersontype.AutoSize = true;
            this.lblpersontype.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersontype.Location = new System.Drawing.Point(130, 134);
            this.lblpersontype.Name = "lblpersontype";
            this.lblpersontype.Size = new System.Drawing.Size(115, 24);
            this.lblpersontype.TabIndex = 4;
            this.lblpersontype.Text = "Person Type";
            this.lblpersontype.Click += new System.EventHandler(this.lblpersontype_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnsuspect
            // 
            this.btnsuspect.AutoSize = true;
            this.btnsuspect.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuspect.Location = new System.Drawing.Point(278, 132);
            this.btnsuspect.Name = "btnsuspect";
            this.btnsuspect.Size = new System.Drawing.Size(97, 28);
            this.btnsuspect.TabIndex = 6;
            this.btnsuspect.TabStop = true;
            this.btnsuspect.Text = "Suspect";
            this.btnsuspect.UseVisualStyleBackColor = true;
            this.btnsuspect.CheckedChanged += new System.EventHandler(this.btnsuspect_CheckedChanged);
            // 
            // btnwitness
            // 
            this.btnwitness.AutoSize = true;
            this.btnwitness.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwitness.Location = new System.Drawing.Point(414, 132);
            this.btnwitness.Name = "btnwitness";
            this.btnwitness.Size = new System.Drawing.Size(98, 28);
            this.btnwitness.TabIndex = 7;
            this.btnwitness.TabStop = true;
            this.btnwitness.Text = "Witness";
            this.btnwitness.UseVisualStyleBackColor = true;
            this.btnwitness.CheckedChanged += new System.EventHandler(this.btnwitness_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(372, 207);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(268, 22);
            this.txtname.TabIndex = 9;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblcinfo
            // 
            this.lblcinfo.AutoSize = true;
            this.lblcinfo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcinfo.Location = new System.Drawing.Point(124, 270);
            this.lblcinfo.Name = "lblcinfo";
            this.lblcinfo.Size = new System.Drawing.Size(184, 24);
            this.lblcinfo.TabIndex = 10;
            this.lblcinfo.Text = "Contact Information";
            this.lblcinfo.Click += new System.EventHandler(this.lblcinfo_Click);
            // 
            // lblpdes
            // 
            this.lblpdes.AutoSize = true;
            this.lblpdes.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdes.Location = new System.Drawing.Point(124, 405);
            this.lblpdes.Name = "lblpdes";
            this.lblpdes.Size = new System.Drawing.Size(181, 24);
            this.lblpdes.TabIndex = 12;
            this.lblpdes.Text = "Physical Description";
            this.lblpdes.Click += new System.EventHandler(this.lblpdes_Click);
            // 
            // lblstatement
            // 
            this.lblstatement.AutoSize = true;
            this.lblstatement.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatement.Location = new System.Drawing.Point(130, 524);
            this.lblstatement.Name = "lblstatement";
            this.lblstatement.Size = new System.Drawing.Size(99, 24);
            this.lblstatement.TabIndex = 16;
            this.lblstatement.Text = "Statement";
            this.lblstatement.Click += new System.EventHandler(this.lblstatement_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(127, 207);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 24);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // richTxtcontactinfo
            // 
            this.richTxtcontactinfo.Location = new System.Drawing.Point(372, 270);
            this.richTxtcontactinfo.Name = "richTxtcontactinfo";
            this.richTxtcontactinfo.Size = new System.Drawing.Size(271, 96);
            this.richTxtcontactinfo.TabIndex = 19;
            this.richTxtcontactinfo.Text = "";
            this.richTxtcontactinfo.TextChanged += new System.EventHandler(this.richTxtcontactinfo_TextChanged);
            // 
            // richTxtphydes
            // 
            this.richTxtphydes.Location = new System.Drawing.Point(372, 405);
            this.richTxtphydes.Name = "richTxtphydes";
            this.richTxtphydes.Size = new System.Drawing.Size(268, 96);
            this.richTxtphydes.TabIndex = 20;
            this.richTxtphydes.Text = "";
            this.richTxtphydes.TextChanged += new System.EventHandler(this.richTxtphydes_TextChanged);
            // 
            // richTxtstatement
            // 
            this.richTxtstatement.Location = new System.Drawing.Point(372, 524);
            this.richTxtstatement.Name = "richTxtstatement";
            this.richTxtstatement.Size = new System.Drawing.Size(271, 96);
            this.richTxtstatement.TabIndex = 21;
            this.richTxtstatement.Text = "";
            this.richTxtstatement.TextChanged += new System.EventHandler(this.richTxtstatement_TextChanged);
            // 
            // RegisterPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 659);
            this.Controls.Add(this.richTxtstatement);
            this.Controls.Add(this.richTxtphydes);
            this.Controls.Add(this.richTxtcontactinfo);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblstatement);
            this.Controls.Add(this.lblpdes);
            this.Controls.Add(this.lblcinfo);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnwitness);
            this.Controls.Add(this.btnsuspect);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblpersontype);
            this.Controls.Add(this.lblDICPS);
            this.Name = "RegisterPersonForm";
            this.Text = "RegisterPersonForm";
            this.Load += new System.EventHandler(this.RegisterPersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Label lblpersontype;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnsuspect;
        private System.Windows.Forms.RadioButton btnwitness;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcinfo;
        private System.Windows.Forms.Label lblpdes;
        private System.Windows.Forms.Label lblstatement;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RichTextBox richTxtcontactinfo;
        private System.Windows.Forms.RichTextBox richTxtphydes;
        private System.Windows.Forms.RichTextBox richTxtstatement;
    }
}