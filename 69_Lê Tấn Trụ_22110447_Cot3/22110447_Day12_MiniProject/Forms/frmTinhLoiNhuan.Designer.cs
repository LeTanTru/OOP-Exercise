namespace _22110447_Day12_MiniProject.Forms {
    partial class frmTinhLoiNhuan {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dtgvProfit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnSave.Location = new System.Drawing.Point(590, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu vào file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgvProfit
            // 
            this.dtgvProfit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProfit.Location = new System.Drawing.Point(141, 62);
            this.dtgvProfit.Name = "dtgvProfit";
            this.dtgvProfit.Size = new System.Drawing.Size(522, 268);
            this.dtgvProfit.TabIndex = 1;
            // 
            // frmTinhLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvProfit);
            this.Controls.Add(this.btnSave);
            this.Name = "frmTinhLoiNhuan";
            this.Text = "frmTinhLoiNhuan";
            this.Load += new System.EventHandler(this.frmTinhLoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgvProfit;
    }
}