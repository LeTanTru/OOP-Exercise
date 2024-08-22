namespace _22110447_Day12_MiniProject {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.cácCửaHàngToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.calculateSalaryToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.staffToolStripMenuItem.Text = "Nhân viên";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // calculateSalaryToolStripMenuItem
            // 
            this.calculateSalaryToolStripMenuItem.Name = "calculateSalaryToolStripMenuItem";
            this.calculateSalaryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.calculateSalaryToolStripMenuItem.Text = "Tính lương";
            this.calculateSalaryToolStripMenuItem.Click += new System.EventHandler(this.calculateSalaryToolStripMenuItem_Click);
            // 
            // cácCửaHàngToolStripMenuItem
            // 
            this.cácCửaHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstShopToolStripMenuItem,
            this.secondShopToolStripMenuItem});
            this.cácCửaHàngToolStripMenuItem.Name = "cácCửaHàngToolStripMenuItem";
            this.cácCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cácCửaHàngToolStripMenuItem.Text = "Các cửa hàng";
            // 
            // firstShopToolStripMenuItem
            // 
            this.firstShopToolStripMenuItem.Name = "firstShopToolStripMenuItem";
            this.firstShopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.firstShopToolStripMenuItem.Text = "Cửa hàng 1";
            this.firstShopToolStripMenuItem.Click += new System.EventHandler(this.firstShopToolStripMenuItem_Click);
            // 
            // secondShopToolStripMenuItem
            // 
            this.secondShopToolStripMenuItem.Name = "secondShopToolStripMenuItem";
            this.secondShopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.secondShopToolStripMenuItem.Text = "Cửa hàng 2";
            this.secondShopToolStripMenuItem.Click += new System.EventHandler(this.secondShopToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffSalaryToolStripMenuItem,
            this.tínhLươngBánHàngToolStripMenuItem,
            this.getProfitToolStripMenuItem});
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.revenueToolStripMenuItem.Text = "Quản lý doanh thu";
            // 
            // staffSalaryToolStripMenuItem
            // 
            this.staffSalaryToolStripMenuItem.Name = "staffSalaryToolStripMenuItem";
            this.staffSalaryToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.staffSalaryToolStripMenuItem.Text = "Tính lương nhân viên";
            this.staffSalaryToolStripMenuItem.Click += new System.EventHandler(this.staffSalaryToolStripMenuItem_Click);
            // 
            // tínhLươngBánHàngToolStripMenuItem
            // 
            this.tínhLươngBánHàngToolStripMenuItem.Name = "tínhLươngBánHàngToolStripMenuItem";
            this.tínhLươngBánHàngToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tínhLươngBánHàngToolStripMenuItem.Text = "Tính doanh thu điện thoại";
            this.tínhLươngBánHàngToolStripMenuItem.Click += new System.EventHandler(this.tínhLươngBánHàngToolStripMenuItem_Click);
            // 
            // getProfitToolStripMenuItem
            // 
            this.getProfitToolStripMenuItem.Name = "getProfitToolStripMenuItem";
            this.getProfitToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.getProfitToolStripMenuItem.Text = "Tính lợi nhuận";
            this.getProfitToolStripMenuItem.Click += new System.EventHandler(this.getProfitToolStripMenuItem_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktopPane.Location = new System.Drawing.Point(53, 44);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(912, 688);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 744);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácCửaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondShopToolStripMenuItem;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhLươngBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProfitToolStripMenuItem;
    }
}

