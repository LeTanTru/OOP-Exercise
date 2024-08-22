namespace PictureBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.picSiu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSiu)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.Location = new System.Drawing.Point(322, 34);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(156, 29);
            this.chkMusic.TabIndex = 0;
            this.chkMusic.Text = "Siuuuuuuuuu";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // picNormal
            // 
            this.picNormal.Image = ((System.Drawing.Image)(resources.GetObject("picNormal.Image")));
            this.picNormal.Location = new System.Drawing.Point(212, 90);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(405, 234);
            this.picNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNormal.TabIndex = 1;
            this.picNormal.TabStop = false;
            // 
            // picSiu
            // 
            this.picSiu.Image = ((System.Drawing.Image)(resources.GetObject("picSiu.Image")));
            this.picSiu.Location = new System.Drawing.Point(212, 90);
            this.picSiu.Name = "picSiu";
            this.picSiu.Size = new System.Drawing.Size(405, 234);
            this.picSiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSiu.TabIndex = 2;
            this.picSiu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSiu);
            this.Controls.Add(this.picNormal);
            this.Controls.Add(this.chkMusic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siuuuu";
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSiu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.PictureBox picSiu;
    }
}

