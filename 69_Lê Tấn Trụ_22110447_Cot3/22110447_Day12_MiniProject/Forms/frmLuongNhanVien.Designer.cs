namespace _22110447_Day12_MiniProject.Forms {
    partial class frmLuongNhanVien {
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
            this.dtgvLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLuongNhanVien
            // 
            this.dtgvLuongNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuongNhanVien.Location = new System.Drawing.Point(90, 138);
            this.dtgvLuongNhanVien.Name = "dtgvLuongNhanVien";
            this.dtgvLuongNhanVien.Size = new System.Drawing.Size(672, 257);
            this.dtgvLuongNhanVien.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(389, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu vào file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 526);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgvLuongNhanVien);
            this.Name = "frmLuongNhanVien";
            this.Text = "frmLuongNhanVien";
            this.Load += new System.EventHandler(this.frmLuongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuongNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLuongNhanVien;
        private System.Windows.Forms.Button btnSave;
    }
}