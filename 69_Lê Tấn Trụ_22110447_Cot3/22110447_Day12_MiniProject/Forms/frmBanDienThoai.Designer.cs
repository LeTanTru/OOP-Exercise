namespace _22110447_Day12_MiniProject.Forms {
    partial class frmBanDienThoai {
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
            this.dtgvBanDienThoai = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanDienThoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBanDienThoai
            // 
            this.dtgvBanDienThoai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvBanDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanDienThoai.Location = new System.Drawing.Point(165, 65);
            this.dtgvBanDienThoai.Name = "dtgvBanDienThoai";
            this.dtgvBanDienThoai.Size = new System.Drawing.Size(610, 353);
            this.dtgvBanDienThoai.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(452, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu vào file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBanDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 551);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgvBanDienThoai);
            this.Name = "frmBanDienThoai";
            this.Text = "frmBanDienThoai";
            this.Load += new System.EventHandler(this.frmBanDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanDienThoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBanDienThoai;
        private System.Windows.Forms.Button btnSave;
    }
}