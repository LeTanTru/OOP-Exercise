namespace SortingVisualization_1_ {
    partial class frmMain {
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
            this.ptrbVisualArea = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbxAlgortihms = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Label();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbVisualArea)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbVisualArea
            // 
            this.ptrbVisualArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptrbVisualArea.Location = new System.Drawing.Point(212, 12);
            this.ptrbVisualArea.Name = "ptrbVisualArea";
            this.ptrbVisualArea.Size = new System.Drawing.Size(1051, 636);
            this.ptrbVisualArea.TabIndex = 0;
            this.ptrbVisualArea.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(188, 47);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbxAlgortihms
            // 
            this.cbxAlgortihms.FormattingEnabled = true;
            this.cbxAlgortihms.Location = new System.Drawing.Point(12, 147);
            this.cbxAlgortihms.Name = "cbxAlgortihms";
            this.cbxAlgortihms.Size = new System.Drawing.Size(188, 21);
            this.cbxAlgortihms.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 227);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(188, 47);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 303);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(188, 47);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.Location = new System.Drawing.Point(37, 417);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(42, 13);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Recent";
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.Location = new System.Drawing.Point(12, 443);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(188, 95);
            this.listHistory.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(241, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(333, 36);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 660);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbxAlgortihms);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.ptrbVisualArea);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Visualization";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbVisualArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrbVisualArea;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbxAlgortihms;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label btnHistory;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInfo;
    }
}

