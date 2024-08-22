namespace _22110447_Day10_lamVoiFile {
    partial class lamVoiFile_yc2 {
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
            this.rdbFileInfo = new System.Windows.Forms.RadioButton();
            this.rdbNewFolder = new System.Windows.Forms.RadioButton();
            this.rtShow = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbFileInfo
            // 
            this.rdbFileInfo.AutoSize = true;
            this.rdbFileInfo.Location = new System.Drawing.Point(13, 80);
            this.rdbFileInfo.Name = "rdbFileInfo";
            this.rdbFileInfo.Size = new System.Drawing.Size(62, 17);
            this.rdbFileInfo.TabIndex = 0;
            this.rdbFileInfo.TabStop = true;
            this.rdbFileInfo.Text = "File Info";
            this.rdbFileInfo.UseVisualStyleBackColor = true;
            // 
            // rdbNewFolder
            // 
            this.rdbNewFolder.AutoSize = true;
            this.rdbNewFolder.Location = new System.Drawing.Point(13, 123);
            this.rdbNewFolder.Name = "rdbNewFolder";
            this.rdbNewFolder.Size = new System.Drawing.Size(79, 17);
            this.rdbNewFolder.TabIndex = 1;
            this.rdbNewFolder.TabStop = true;
            this.rdbNewFolder.Text = "New Folder";
            this.rdbNewFolder.UseVisualStyleBackColor = true;
            // 
            // rtShow
            // 
            this.rtShow.Location = new System.Drawing.Point(232, 21);
            this.rtShow.Name = "rtShow";
            this.rtShow.Size = new System.Drawing.Size(478, 346);
            this.rtShow.TabIndex = 2;
            this.rtShow.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(248, 399);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 25);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lamVoiFile_yc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rtShow);
            this.Controls.Add(this.rdbNewFolder);
            this.Controls.Add(this.rdbFileInfo);
            this.Name = "lamVoiFile_yc2";
            this.Text = "lamVoiFile_yc2";
            this.Load += new System.EventHandler(this.lamVoiFile_yc2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFileInfo;
        private System.Windows.Forms.RadioButton rdbNewFolder;
        private System.Windows.Forms.RichTextBox rtShow;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
    }
}