namespace Inheritance {
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
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dtpkBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblCoefficientsSalary = new System.Windows.Forms.Label();
            this.txtCoefficientsSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(199, 30);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(43, 13);
            this.lblChoice.TabIndex = 0;
            this.lblChoice.Text = "Choose";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(199, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(199, 128);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // dtpkBirthDate
            // 
            this.dtpkBirthDate.Location = new System.Drawing.Point(299, 184);
            this.dtpkBirthDate.Name = "dtpkBirthDate";
            this.dtpkBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkBirthDate.TabIndex = 3;
            // 
            // dtpkHireDate
            // 
            this.dtpkHireDate.Location = new System.Drawing.Point(299, 242);
            this.dtpkHireDate.Name = "dtpkHireDate";
            this.dtpkHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkHireDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(299, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(299, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(200, 188);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(203, 246);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 8;
            this.lblHireDate.Text = "Hire Date";
            // 
            // lblCoefficientsSalary
            // 
            this.lblCoefficientsSalary.AutoSize = true;
            this.lblCoefficientsSalary.Location = new System.Drawing.Point(203, 294);
            this.lblCoefficientsSalary.Name = "lblCoefficientsSalary";
            this.lblCoefficientsSalary.Size = new System.Drawing.Size(94, 13);
            this.lblCoefficientsSalary.TabIndex = 9;
            this.lblCoefficientsSalary.Text = "Coefficients Salary";
            // 
            // txtCoefficientsSalary
            // 
            this.txtCoefficientsSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoefficientsSalary.Location = new System.Drawing.Point(299, 290);
            this.txtCoefficientsSalary.Name = "txtCoefficientsSalary";
            this.txtCoefficientsSalary.Size = new System.Drawing.Size(200, 20);
            this.txtCoefficientsSalary.TabIndex = 10;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(203, 345);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 11;
            this.Salary.Text = "Salary";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(299, 341);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boss",
            "Commission Woker",
            "Piece Worker",
            "Hourly Worker"});
            this.comboBox1.Location = new System.Drawing.Point(299, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(203, 393);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 14;
            this.lblBonus.Text = "Bonus";
            // 
            // txtBonus
            // 
            this.txtBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonus.Location = new System.Drawing.Point(299, 389);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(200, 20);
            this.txtBonus.TabIndex = 15;
            this.txtBonus.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.txtCoefficientsSalary);
            this.Controls.Add(this.lblCoefficientsSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dtpkHireDate);
            this.Controls.Add(this.dtpkBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblChoice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dtpkBirthDate;
        private System.Windows.Forms.DateTimePicker dtpkHireDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblCoefficientsSalary;
        private System.Windows.Forms.TextBox txtCoefficientsSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtBonus;
    }
}