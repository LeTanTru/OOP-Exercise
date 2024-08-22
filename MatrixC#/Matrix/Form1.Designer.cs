namespace Matrix {
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
            this.lblStatusMatr2 = new System.Windows.Forms.Label();
            this.lblStatusMatr1 = new System.Windows.Forms.Label();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInputMatr2 = new System.Windows.Forms.Button();
            this.btnInputMatr1 = new System.Windows.Forms.Button();
            this.txtInputRow = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInputCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusMatr2
            // 
            this.lblStatusMatr2.AllowDrop = true;
            this.lblStatusMatr2.AutoSize = true;
            this.lblStatusMatr2.Location = new System.Drawing.Point(325, 111);
            this.lblStatusMatr2.Name = "lblStatusMatr2";
            this.lblStatusMatr2.Size = new System.Drawing.Size(35, 13);
            this.lblStatusMatr2.TabIndex = 15;
            this.lblStatusMatr2.Text = "label3";
            // 
            // lblStatusMatr1
            // 
            this.lblStatusMatr1.AllowDrop = true;
            this.lblStatusMatr1.AutoSize = true;
            this.lblStatusMatr1.Location = new System.Drawing.Point(325, 77);
            this.lblStatusMatr1.Name = "lblStatusMatr1";
            this.lblStatusMatr1.Size = new System.Drawing.Size(35, 13);
            this.lblStatusMatr1.TabIndex = 14;
            this.lblStatusMatr1.Text = "label2";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.AllowDrop = true;
            this.btnSaveResult.Location = new System.Drawing.Point(71, 170);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(304, 23);
            this.btnSaveResult.TabIndex = 7;
            this.btnSaveResult.Text = "Save to file \"Res_Matr.txt\"";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.Location = new System.Drawing.Point(71, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInputMatr2
            // 
            this.btnInputMatr2.AllowDrop = true;
            this.btnInputMatr2.Location = new System.Drawing.Point(135, 101);
            this.btnInputMatr2.Name = "btnInputMatr2";
            this.btnInputMatr2.Size = new System.Drawing.Size(179, 23);
            this.btnInputMatr2.TabIndex = 3;
            this.btnInputMatr2.Text = "Input of matrix 2";
            this.btnInputMatr2.UseVisualStyleBackColor = true;
            this.btnInputMatr2.Click += new System.EventHandler(this.btnInputMatr2_Click);
            // 
            // btnInputMatr1
            // 
            this.btnInputMatr1.AllowDrop = true;
            this.btnInputMatr1.Location = new System.Drawing.Point(135, 72);
            this.btnInputMatr1.Name = "btnInputMatr1";
            this.btnInputMatr1.Size = new System.Drawing.Size(179, 23);
            this.btnInputMatr1.TabIndex = 2;
            this.btnInputMatr1.Text = "Input of matrix 1";
            this.btnInputMatr1.UseVisualStyleBackColor = true;
            this.btnInputMatr1.Click += new System.EventHandler(this.btnInputMatr1_Click);
            // 
            // txtInputRow
            // 
            this.txtInputRow.AllowDrop = true;
            this.txtInputRow.Location = new System.Drawing.Point(270, 31);
            this.txtInputRow.Name = "txtInputRow";
            this.txtInputRow.Size = new System.Drawing.Size(90, 20);
            this.txtInputRow.TabIndex = 1;
            this.txtInputRow.TextChanged += new System.EventHandler(this.txtInputRow_TextChanged);
            this.txtInputRow.Leave += new System.EventHandler(this.txtInputRow_Leave);
            // 
            // lblInput
            // 
            this.lblInput.AllowDrop = true;
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(239, 35);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(30, 13);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "col =";
            // 
            // txtInputCol
            // 
            this.txtInputCol.AllowDrop = true;
            this.txtInputCol.Location = new System.Drawing.Point(135, 31);
            this.txtInputCol.Name = "txtInputCol";
            this.txtInputCol.Size = new System.Drawing.Size(90, 20);
            this.txtInputCol.TabIndex = 0;
            this.txtInputCol.TextChanged += new System.EventHandler(this.txtInputCol_TextChanged);
            this.txtInputCol.Leave += new System.EventHandler(this.txtInputCol_Leave);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "row = ";
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(179, 141);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 23);
            this.btnSubstract.TabIndex = 5;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(285, 141);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnMultiple.TabIndex = 6;
            this.btnMultiple.Text = "Multiple";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 302);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.txtInputCol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusMatr2);
            this.Controls.Add(this.lblStatusMatr1);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnInputMatr2);
            this.Controls.Add(this.btnInputMatr1);
            this.Controls.Add(this.txtInputRow);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The product of Matrices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusMatr2;
        private System.Windows.Forms.Label lblStatusMatr1;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInputMatr2;
        private System.Windows.Forms.Button btnInputMatr1;
        private System.Windows.Forms.TextBox txtInputRow;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInputCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiple;
    }
}

