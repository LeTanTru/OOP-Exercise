namespace _22110447_Day06_ThuaKe_Form {
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
            this.ptrBDrawing = new System.Windows.Forms.PictureBox();
            this.btnTamGiac = new System.Windows.Forms.Button();
            this.btnDoanThang = new System.Windows.Forms.Button();
            this.btnTuGiac = new System.Windows.Forms.Button();
            this.btnHinhVuong = new System.Windows.Forms.Button();
            this.btnHinhTron = new System.Windows.Forms.Button();
            this.lblPictureBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrBDrawing
            // 
            this.ptrBDrawing.BackColor = System.Drawing.Color.White;
            this.ptrBDrawing.Location = new System.Drawing.Point(12, 82);
            this.ptrBDrawing.Name = "ptrBDrawing";
            this.ptrBDrawing.Size = new System.Drawing.Size(776, 356);
            this.ptrBDrawing.TabIndex = 0;
            this.ptrBDrawing.TabStop = false;
            // 
            // btnTamGiac
            // 
            this.btnTamGiac.Location = new System.Drawing.Point(67, 31);
            this.btnTamGiac.Name = "btnTamGiac";
            this.btnTamGiac.Size = new System.Drawing.Size(75, 23);
            this.btnTamGiac.TabIndex = 1;
            this.btnTamGiac.Text = "Tam giác";
            this.btnTamGiac.UseVisualStyleBackColor = true;
            this.btnTamGiac.Click += new System.EventHandler(this.btnTamGiac_Click);
            // 
            // btnDoanThang
            // 
            this.btnDoanThang.Location = new System.Drawing.Point(215, 31);
            this.btnDoanThang.Name = "btnDoanThang";
            this.btnDoanThang.Size = new System.Drawing.Size(75, 23);
            this.btnDoanThang.TabIndex = 2;
            this.btnDoanThang.Text = "Đoạn thẳng";
            this.btnDoanThang.UseVisualStyleBackColor = true;
            this.btnDoanThang.Click += new System.EventHandler(this.btnDoanThang_Click);
            // 
            // btnTuGiac
            // 
            this.btnTuGiac.Location = new System.Drawing.Point(363, 31);
            this.btnTuGiac.Name = "btnTuGiac";
            this.btnTuGiac.Size = new System.Drawing.Size(75, 23);
            this.btnTuGiac.TabIndex = 3;
            this.btnTuGiac.Text = "Tứ giác";
            this.btnTuGiac.UseVisualStyleBackColor = true;
            this.btnTuGiac.Click += new System.EventHandler(this.btnTuGiac_Click);
            // 
            // btnHinhVuong
            // 
            this.btnHinhVuong.Location = new System.Drawing.Point(511, 31);
            this.btnHinhVuong.Name = "btnHinhVuong";
            this.btnHinhVuong.Size = new System.Drawing.Size(75, 23);
            this.btnHinhVuong.TabIndex = 4;
            this.btnHinhVuong.Text = "Hình vuông";
            this.btnHinhVuong.UseVisualStyleBackColor = true;
            this.btnHinhVuong.Click += new System.EventHandler(this.btnHinhVuong_Click);
            // 
            // btnHinhTron
            // 
            this.btnHinhTron.Location = new System.Drawing.Point(659, 31);
            this.btnHinhTron.Name = "btnHinhTron";
            this.btnHinhTron.Size = new System.Drawing.Size(75, 23);
            this.btnHinhTron.TabIndex = 5;
            this.btnHinhTron.Text = "Hình tròn";
            this.btnHinhTron.UseVisualStyleBackColor = true;
            this.btnHinhTron.Click += new System.EventHandler(this.btnHinhTron_Click);
            // 
            // lblPictureBox
            // 
            this.lblPictureBox.AutoSize = true;
            this.lblPictureBox.Location = new System.Drawing.Point(13, 63);
            this.lblPictureBox.Name = "lblPictureBox";
            this.lblPictureBox.Size = new System.Drawing.Size(58, 13);
            this.lblPictureBox.TabIndex = 6;
            this.lblPictureBox.Text = "PictureBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPictureBox);
            this.Controls.Add(this.btnHinhTron);
            this.Controls.Add(this.btnHinhVuong);
            this.Controls.Add(this.btnTuGiac);
            this.Controls.Add(this.btnDoanThang);
            this.Controls.Add(this.btnTamGiac);
            this.Controls.Add(this.ptrBDrawing);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptrBDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrBDrawing;
        private System.Windows.Forms.Button btnTamGiac;
        private System.Windows.Forms.Button btnDoanThang;
        private System.Windows.Forms.Button btnTuGiac;
        private System.Windows.Forms.Button btnHinhVuong;
        private System.Windows.Forms.Button btnHinhTron;
        private System.Windows.Forms.Label lblPictureBox;
    }
}

