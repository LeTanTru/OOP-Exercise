namespace _22110447_Day11 {
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
            this.components = new System.ComponentModel.Container();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.dtgvInformation = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbxFindSelection = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.infomationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infomationTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.txtDept);
            this.grbInformation.Controls.Add(this.txtName);
            this.grbInformation.Controls.Add(this.txtEmpId);
            this.grbInformation.Controls.Add(this.lblDept);
            this.grbInformation.Controls.Add(this.lblName);
            this.grbInformation.Controls.Add(this.lblEmpId);
            this.grbInformation.Location = new System.Drawing.Point(66, 34);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(354, 158);
            this.grbInformation.TabIndex = 0;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Information";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(104, 127);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(244, 20);
            this.txtDept.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(104, 19);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(244, 20);
            this.txtEmpId.TabIndex = 1;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(16, 131);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(33, 13);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Dept:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(16, 23);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(46, 13);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "Emp Id: ";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(66, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(203, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(340, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(317, 273);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(117, 20);
            this.txtValue.TabIndex = 5;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(86, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // dtgvInformation
            // 
            this.dtgvInformation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInformation.Location = new System.Drawing.Point(81, 358);
            this.dtgvInformation.Name = "dtgvInformation";
            this.dtgvInformation.ReadOnly = true;
            this.dtgvInformation.RowHeadersVisible = false;
            this.dtgvInformation.Size = new System.Drawing.Size(320, 150);
            this.dtgvInformation.TabIndex = 7;
            this.dtgvInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvInfomation_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Location = new System.Drawing.Point(65, 272);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find By";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbxFindSelection
            // 
            this.cbxFindSelection.FormattingEnabled = true;
            this.cbxFindSelection.Items.AddRange(new object[] {
            "EmpID",
            "Name",
            "Dept"});
            this.cbxFindSelection.Location = new System.Drawing.Point(154, 273);
            this.cbxFindSelection.Name = "cbxFindSelection";
            this.cbxFindSelection.Size = new System.Drawing.Size(92, 21);
            this.cbxFindSelection.TabIndex = 9;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(264, 277);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Value";
            // 
            // infomationTableBindingSource
            // 
            this.infomationTableBindingSource.DataMember = "InfomationTable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 574);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.cbxFindSelection);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dtgvInformation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInformation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infomationTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dtgvInformation;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbxFindSelection;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.BindingSource infomationTableBindingSource;
    }
}

