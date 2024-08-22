namespace _22110447_Day08_Inheritance {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.cbxRoleInput = new System.Windows.Forms.ComboBox();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.txtCoefficientsSalary = new System.Windows.Forms.TextBox();
            this.lblCoefficientsSalary = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpkHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.cbxGentle = new System.Windows.Forms.ComboBox();
            this.lblGentle = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBonus
            // 
            this.txtBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonus.Location = new System.Drawing.Point(518, 306);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(83, 20);
            this.txtBonus.TabIndex = 31;
            this.txtBonus.Text = "0";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(418, 313);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 30;
            this.lblBonus.Text = "Bonus";
            // 
            // cbxRoleInput
            // 
            this.cbxRoleInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxRoleInput.FormattingEnabled = true;
            this.cbxRoleInput.Items.AddRange(new object[] {
            "Boss",
            "Commission Worker",
            "Piece Worker",
            "Hourly Worker"});
            this.cbxRoleInput.Location = new System.Drawing.Point(136, 12);
            this.cbxRoleInput.Name = "cbxRoleInput";
            this.cbxRoleInput.Size = new System.Drawing.Size(200, 21);
            this.cbxRoleInput.TabIndex = 29;
            this.cbxRoleInput.DropDownClosed += new System.EventHandler(this.cbxRoleInput_DropDownClosed);
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaseSalary.Location = new System.Drawing.Point(518, 207);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(83, 20);
            this.txtBaseSalary.TabIndex = 28;
            // 
            // lblBaseSalary
            // 
            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Location = new System.Drawing.Point(418, 211);
            this.lblBaseSalary.Name = "lblBaseSalary";
            this.lblBaseSalary.Size = new System.Drawing.Size(63, 13);
            this.lblBaseSalary.TabIndex = 27;
            this.lblBaseSalary.Text = "Base Salary";
            // 
            // txtCoefficientsSalary
            // 
            this.txtCoefficientsSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoefficientsSalary.Location = new System.Drawing.Point(518, 156);
            this.txtCoefficientsSalary.Name = "txtCoefficientsSalary";
            this.txtCoefficientsSalary.Size = new System.Drawing.Size(83, 20);
            this.txtCoefficientsSalary.TabIndex = 26;
            // 
            // lblCoefficientsSalary
            // 
            this.lblCoefficientsSalary.AutoSize = true;
            this.lblCoefficientsSalary.Location = new System.Drawing.Point(418, 160);
            this.lblCoefficientsSalary.Name = "lblCoefficientsSalary";
            this.lblCoefficientsSalary.Size = new System.Drawing.Size(94, 13);
            this.lblCoefficientsSalary.TabIndex = 25;
            this.lblCoefficientsSalary.Text = "Coefficients Salary";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(418, 117);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 24;
            this.lblHireDate.Text = "Hire Date";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(418, 59);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 23;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(136, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 22;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(136, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // dtpkHireDate
            // 
            this.dtpkHireDate.Location = new System.Drawing.Point(518, 113);
            this.dtpkHireDate.Name = "dtpkHireDate";
            this.dtpkHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkHireDate.TabIndex = 20;
            // 
            // dtpkBirthDate
            // 
            this.dtpkBirthDate.Location = new System.Drawing.Point(518, 53);
            this.dtpkBirthDate.Name = "dtpkBirthDate";
            this.dtpkBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkBirthDate.TabIndex = 19;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(36, 114);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(36, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(36, 16);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(43, 13);
            this.lblChoice.TabIndex = 16;
            this.lblChoice.Text = "Choose";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(623, 397);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 32;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // cbxGentle
            // 
            this.cbxGentle.FormattingEnabled = true;
            this.cbxGentle.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGentle.Location = new System.Drawing.Point(136, 174);
            this.cbxGentle.Name = "cbxGentle";
            this.cbxGentle.Size = new System.Drawing.Size(140, 21);
            this.cbxGentle.TabIndex = 33;
            // 
            // lblGentle
            // 
            this.lblGentle.AutoSize = true;
            this.lblGentle.Location = new System.Drawing.Point(41, 178);
            this.lblGentle.Name = "lblGentle";
            this.lblGentle.Size = new System.Drawing.Size(38, 13);
            this.lblGentle.TabIndex = 34;
            this.lblGentle.Text = "Gentle";
            // 
            // txtCommission
            // 
            this.txtCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommission.Location = new System.Drawing.Point(518, 257);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(83, 20);
            this.txtCommission.TabIndex = 36;
            this.txtCommission.Text = "0";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(418, 259);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(62, 13);
            this.lblCommission.TabIndex = 35;
            this.lblCommission.Text = "Commission";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblGentle);
            this.Controls.Add(this.cbxGentle);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.cbxRoleInput);
            this.Controls.Add(this.txtBaseSalary);
            this.Controls.Add(this.lblBaseSalary);
            this.Controls.Add(this.txtCoefficientsSalary);
            this.Controls.Add(this.lblCoefficientsSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dtpkHireDate);
            this.Controls.Add(this.dtpkBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblChoice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.ComboBox cbxRoleInput;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.Label lblBaseSalary;
        private System.Windows.Forms.TextBox txtCoefficientsSalary;
        private System.Windows.Forms.Label lblCoefficientsSalary;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dtpkHireDate;
        private System.Windows.Forms.DateTimePicker dtpkBirthDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.ComboBox cbxGentle;
        private System.Windows.Forms.Label lblGentle;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblCommission;
    }
}

