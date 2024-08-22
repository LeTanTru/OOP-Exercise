namespace _22110447_Day12_Mini_Project {
    partial class Form2 {
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
            this.radBtnIT = new System.Windows.Forms.RadioButton();
            this.radBtnHR = new System.Windows.Forms.RadioButton();
            this.radBtnBA = new System.Windows.Forms.RadioButton();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnIT
            // 
            this.radBtnIT.AutoSize = true;
            this.radBtnIT.Checked = true;
            this.radBtnIT.Location = new System.Drawing.Point(40, 105);
            this.radBtnIT.Name = "radBtnIT";
            this.radBtnIT.Size = new System.Drawing.Size(35, 17);
            this.radBtnIT.TabIndex = 0;
            this.radBtnIT.TabStop = true;
            this.radBtnIT.Text = "IT";
            this.radBtnIT.UseVisualStyleBackColor = true;
            this.radBtnIT.CheckedChanged += new System.EventHandler(this.radBtnIT_CheckedChanged);
            // 
            // radBtnHR
            // 
            this.radBtnHR.AutoSize = true;
            this.radBtnHR.Location = new System.Drawing.Point(40, 150);
            this.radBtnHR.Name = "radBtnHR";
            this.radBtnHR.Size = new System.Drawing.Size(41, 17);
            this.radBtnHR.TabIndex = 0;
            this.radBtnHR.Text = "HR";
            this.radBtnHR.UseVisualStyleBackColor = true;
            this.radBtnHR.CheckedChanged += new System.EventHandler(this.radBtnHR_CheckedChanged);
            // 
            // radBtnBA
            // 
            this.radBtnBA.AutoSize = true;
            this.radBtnBA.Location = new System.Drawing.Point(40, 199);
            this.radBtnBA.Name = "radBtnBA";
            this.radBtnBA.Size = new System.Drawing.Size(39, 17);
            this.radBtnBA.TabIndex = 0;
            this.radBtnBA.Text = "BA";
            this.radBtnBA.UseVisualStyleBackColor = true;
            this.radBtnBA.CheckedChanged += new System.EventHandler(this.radBtnBA_CheckedChanged);
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.AllowUserToAddRows = false;
            this.dtgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(103, 83);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(685, 150);
            this.dtgvInfo.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(257, 256);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(376, 256);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(490, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(606, 257);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.radBtnBA);
            this.Controls.Add(this.radBtnHR);
            this.Controls.Add(this.radBtnIT);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnIT;
        private System.Windows.Forms.RadioButton radBtnHR;
        private System.Windows.Forms.RadioButton radBtnBA;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}