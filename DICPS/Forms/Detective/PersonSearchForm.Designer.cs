namespace DICPS.Forms.Detective
{
    partial class PersonSearchForm
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
            this.lblpname = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.dgvsresult = new System.Windows.Forms.DataGridView();
            this.lblsresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsresult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDICPS
            // 
            this.lblDICPS.AutoSize = true;
            this.lblDICPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDICPS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDICPS.Location = new System.Drawing.Point(250, 31);
            this.lblDICPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDICPS.Name = "lblDICPS";
            this.lblDICPS.Size = new System.Drawing.Size(433, 72);
            this.lblDICPS.TabIndex = 4;
            this.lblDICPS.Text = "Detective Investigation \r\nand Criminal Profiling System";
            this.lblDICPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.Location = new System.Drawing.Point(100, 227);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(124, 24);
            this.lblpname.TabIndex = 5;
            this.lblpname.Text = "Person Name";
            this.lblpname.Click += new System.EventHandler(this.lblpname_Click);
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(271, 227);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(199, 22);
            this.txtpname.TabIndex = 6;
            this.txtpname.TextChanged += new System.EventHandler(this.txtpname_TextChanged);
            // 
            // dgvsresult
            // 
            this.dgvsresult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsresult.Location = new System.Drawing.Point(271, 289);
            this.dgvsresult.Name = "dgvsresult";
            this.dgvsresult.RowHeadersWidth = 51;
            this.dgvsresult.RowTemplate.Height = 24;
            this.dgvsresult.Size = new System.Drawing.Size(351, 219);
            this.dgvsresult.TabIndex = 7;
            this.dgvsresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsresult_CellContentClick);
            // 
            // lblsresult
            // 
            this.lblsresult.AutoSize = true;
            this.lblsresult.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsresult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblsresult.Location = new System.Drawing.Point(101, 289);
            this.lblsresult.Name = "lblsresult";
            this.lblsresult.Size = new System.Drawing.Size(125, 24);
            this.lblsresult.TabIndex = 8;
            this.lblsresult.Text = "Search Result";
            this.lblsresult.Click += new System.EventHandler(this.lblsresult_Click);
            // 
            // PersonSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 571);
            this.Controls.Add(this.lblsresult);
            this.Controls.Add(this.dgvsresult);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lblDICPS);
            this.Name = "PersonSearchForm";
            this.Text = "PersonSearchForm";
            this.Load += new System.EventHandler(this.PersonSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDICPS;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.DataGridView dgvsresult;
        private System.Windows.Forms.Label lblsresult;
    }
}