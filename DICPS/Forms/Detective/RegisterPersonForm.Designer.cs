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
            this.lblRegisterPerson = new System.Windows.Forms.Label();
            this.grpPersonInformation = new System.Windows.Forms.GroupBox();
            this.txtPhysicalDescription = new System.Windows.Forms.RichTextBox();
            this.lblPhysicalDescription = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.grpPersonInformation.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisterPerson
            // 
            this.lblRegisterPerson.AutoSize = true;
            this.lblRegisterPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegisterPerson.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRegisterPerson.Location = new System.Drawing.Point(25, 22);
            this.lblRegisterPerson.Name = "lblRegisterPerson";
            this.lblRegisterPerson.Size = new System.Drawing.Size(267, 38);
            this.lblRegisterPerson.TabIndex = 4;
            this.lblRegisterPerson.Text = "Register Person";
            // 
            // grpPersonInformation
            // 
            this.grpPersonInformation.Controls.Add(this.txtContactInfo);
            this.grpPersonInformation.Controls.Add(this.txtPhysicalDescription);
            this.grpPersonInformation.Controls.Add(this.lblPhysicalDescription);
            this.grpPersonInformation.Controls.Add(this.lblContactInfo);
            this.grpPersonInformation.Controls.Add(this.lblName);
            this.grpPersonInformation.Controls.Add(this.txtName);
            this.grpPersonInformation.Controls.Add(this.lblPersonType);
            this.grpPersonInformation.Controls.Add(this.cmbPersonType);
            this.grpPersonInformation.Location = new System.Drawing.Point(32, 101);
            this.grpPersonInformation.Name = "grpPersonInformation";
            this.grpPersonInformation.Size = new System.Drawing.Size(818, 345);
            this.grpPersonInformation.TabIndex = 15;
            this.grpPersonInformation.TabStop = false;
            this.grpPersonInformation.Text = "Person Information";
            // 
            // txtPhysicalDescription
            // 
            this.txtPhysicalDescription.Location = new System.Drawing.Point(306, 223);
            this.txtPhysicalDescription.Name = "txtPhysicalDescription";
            this.txtPhysicalDescription.Size = new System.Drawing.Size(344, 96);
            this.txtPhysicalDescription.TabIndex = 11;
            this.txtPhysicalDescription.Text = "";
            this.txtPhysicalDescription.TextChanged += new System.EventHandler(this.txtPhysicalDescription_TextChanged);
            // 
            // lblPhysicalDescription
            // 
            this.lblPhysicalDescription.AutoSize = true;
            this.lblPhysicalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhysicalDescription.Location = new System.Drawing.Point(27, 220);
            this.lblPhysicalDescription.Name = "lblPhysicalDescription";
            this.lblPhysicalDescription.Size = new System.Drawing.Size(273, 30);
            this.lblPhysicalDescription.TabIndex = 10;
            this.lblPhysicalDescription.Text = "Physical Description:";
            this.lblPhysicalDescription.Click += new System.EventHandler(this.lblPhysicalDescription_Click);
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblContactInfo.Location = new System.Drawing.Point(27, 162);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(169, 30);
            this.lblContactInfo.TabIndex = 8;
            this.lblContactInfo.Text = "Contact Info:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(27, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 30);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonType.Location = new System.Drawing.Point(27, 44);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(177, 30);
            this.lblPersonType.TabIndex = 6;
            this.lblPersonType.Text = "Person Type:";
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Items.AddRange(new object[] {
            "All",
            "Suspect",
            "Witness"});
            this.cmbPersonType.Location = new System.Drawing.Point(208, 47);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(216, 32);
            this.cmbPersonType.TabIndex = 7;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.cmbPersonType_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(251, 733);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 59);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(64, 733);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 59);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(438, 733);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 59);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(622, 733);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 59);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(208, 165);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(358, 29);
            this.txtContactInfo.TabIndex = 12;
            this.txtContactInfo.TextChanged += new System.EventHandler(this.txtContactInfo_TextChanged);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.dgvPersons);
            this.grpSearchResults.Location = new System.Drawing.Point(32, 452);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(818, 247);
            this.grpSearchResults.TabIndex = 18;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Persons";
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(19, 41);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 72;
            this.dgvPersons.RowTemplate.Height = 31;
            this.dgvPersons.Size = new System.Drawing.Size(778, 187);
            this.dgvPersons.TabIndex = 12;
            this.dgvPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellContentClick);
            // 
            // RegisterPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 873);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpPersonInformation);
            this.Controls.Add(this.lblRegisterPerson);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegisterPersonForm";
            this.Text = "RegisterPersonForm";
            this.Load += new System.EventHandler(this.RegisterPersonForm_Load);
            this.grpPersonInformation.ResumeLayout(false);
            this.grpPersonInformation.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterPerson;
        private System.Windows.Forms.GroupBox grpPersonInformation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.RichTextBox txtPhysicalDescription;
        private System.Windows.Forms.Label lblPhysicalDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.DataGridView dgvPersons;
    }
}