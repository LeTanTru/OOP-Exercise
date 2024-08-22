namespace ComplexNumber {
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
            this.lblReal = new System.Windows.Forms.Label();
            this.lblImaginary = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtImaginary = new System.Windows.Forms.TextBox();
            this.btnSetNo1 = new System.Windows.Forms.Button();
            this.btnSetNo2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(192, 72);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(29, 13);
            this.lblReal.TabIndex = 0;
            this.lblReal.Text = "Real";
            // 
            // lblImaginary
            // 
            this.lblImaginary.AutoSize = true;
            this.lblImaginary.Location = new System.Drawing.Point(192, 118);
            this.lblImaginary.Name = "lblImaginary";
            this.lblImaginary.Size = new System.Drawing.Size(52, 13);
            this.lblImaginary.TabIndex = 1;
            this.lblImaginary.Text = "Imaginary";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(340, 68);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 2;
            // 
            // txtImaginary
            // 
            this.txtImaginary.Location = new System.Drawing.Point(340, 114);
            this.txtImaginary.Name = "txtImaginary";
            this.txtImaginary.Size = new System.Drawing.Size(100, 20);
            this.txtImaginary.TabIndex = 3;
            // 
            // btnSetNo1
            // 
            this.btnSetNo1.Location = new System.Drawing.Point(558, 67);
            this.btnSetNo1.Name = "btnSetNo1";
            this.btnSetNo1.Size = new System.Drawing.Size(75, 23);
            this.btnSetNo1.TabIndex = 4;
            this.btnSetNo1.Text = "Set No 1";
            this.btnSetNo1.UseVisualStyleBackColor = true;
            this.btnSetNo1.Click += new System.EventHandler(this.btnSetNo1_Click);
            // 
            // btnSetNo2
            // 
            this.btnSetNo2.Location = new System.Drawing.Point(558, 113);
            this.btnSetNo2.Name = "btnSetNo2";
            this.btnSetNo2.Size = new System.Drawing.Size(75, 23);
            this.btnSetNo2.TabIndex = 5;
            this.btnSetNo2.Text = "Set No 2";
            this.btnSetNo2.UseVisualStyleBackColor = true;
            this.btnSetNo2.Click += new System.EventHandler(this.btnSetNo2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(350, 165);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 23);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(558, 165);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(268, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 19);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSetNo2);
            this.Controls.Add(this.btnSetNo1);
            this.Controls.Add(this.txtImaginary);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.lblImaginary);
            this.Controls.Add(this.lblReal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblImaginary;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtImaginary;
        private System.Windows.Forms.Button btnSetNo1;
        private System.Windows.Forms.Button btnSetNo2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Label lblResult;
    }
}

