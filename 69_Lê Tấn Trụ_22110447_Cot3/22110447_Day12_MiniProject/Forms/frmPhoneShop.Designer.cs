namespace _22110447_Day12_MiniProject.Forms {
    partial class frmPhoneShop {
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dtgvPhoneInfo = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.txtSerieNo = new System.Windows.Forms.TextBox();
            this.lblSerieNo = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtManufactureYear = new System.Windows.Forms.TextBox();
            this.lblManufactureYear = new System.Windows.Forms.Label();
            this.cbxSearchItem = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxSortOrder = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbxSortItem = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbxDeviceNames = new System.Windows.Forms.ComboBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(257, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(257, 298);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 36;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(113, 116);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(121, 20);
            this.txtDeviceName.TabIndex = 24;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(23, 120);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(72, 13);
            this.lblBrand.TabIndex = 53;
            this.lblBrand.Text = "Device Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(655, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(601, 138);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(19, 13);
            this.lblSearchBy.TabIndex = 52;
            this.lblSearchBy.Text = "By";
            // 
            // dtgvPhoneInfo
            // 
            this.dtgvPhoneInfo.AllowUserToOrderColumns = true;
            this.dtgvPhoneInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvPhoneInfo.Location = new System.Drawing.Point(26, 350);
            this.dtgvPhoneInfo.Name = "dtgvPhoneInfo";
            this.dtgvPhoneInfo.ReadOnly = true;
            this.dtgvPhoneInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvPhoneInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvPhoneInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvPhoneInfo.Size = new System.Drawing.Size(868, 247);
            this.dtgvPhoneInfo.TabIndex = 51;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(819, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(673, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(421, 176);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 46;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(130, 324);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(113, 298);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(121, 20);
            this.txtContactNumber.TabIndex = 34;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(23, 302);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 43;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 272);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 32;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 276);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 42;
            this.lblAddress.Text = "Address";
            this.lblAddress.UseWaitCursor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 246);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 31;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 41;
            this.lblPrice.Text = "Price";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(113, 220);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(121, 20);
            this.txtProducer.TabIndex = 30;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(23, 224);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(50, 13);
            this.lblProducer.TabIndex = 44;
            this.lblProducer.Text = "Producer";
            // 
            // txtSerieNo
            // 
            this.txtSerieNo.Location = new System.Drawing.Point(113, 194);
            this.txtSerieNo.Name = "txtSerieNo";
            this.txtSerieNo.Size = new System.Drawing.Size(121, 20);
            this.txtSerieNo.TabIndex = 28;
            // 
            // lblSerieNo
            // 
            this.lblSerieNo.AutoSize = true;
            this.lblSerieNo.Location = new System.Drawing.Point(23, 198);
            this.lblSerieNo.Name = "lblSerieNo";
            this.lblSerieNo.Size = new System.Drawing.Size(51, 13);
            this.lblSerieNo.TabIndex = 39;
            this.lblSerieNo.Text = "Serie No.";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(113, 168);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(121, 20);
            this.txtColor.TabIndex = 27;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(23, 172);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 40;
            this.lblColor.Text = "Color";
            // 
            // txtManufactureYear
            // 
            this.txtManufactureYear.Location = new System.Drawing.Point(113, 142);
            this.txtManufactureYear.Name = "txtManufactureYear";
            this.txtManufactureYear.Size = new System.Drawing.Size(121, 20);
            this.txtManufactureYear.TabIndex = 25;
            // 
            // lblManufactureYear
            // 
            this.lblManufactureYear.AutoSize = true;
            this.lblManufactureYear.Location = new System.Drawing.Point(23, 146);
            this.lblManufactureYear.Name = "lblManufactureYear";
            this.lblManufactureYear.Size = new System.Drawing.Size(92, 13);
            this.lblManufactureYear.TabIndex = 37;
            this.lblManufactureYear.Text = "Manufacture Year";
            // 
            // cbxSearchItem
            // 
            this.cbxSearchItem.FormattingEnabled = true;
            this.cbxSearchItem.Items.AddRange(new object[] {
            "Device Name",
            "Price",
            "Producer"});
            this.cbxSearchItem.Location = new System.Drawing.Point(655, 97);
            this.cbxSearchItem.Name = "cbxSearchItem";
            this.cbxSearchItem.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchItem.TabIndex = 47;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(601, 100);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search";
            // 
            // cbxSortOrder
            // 
            this.cbxSortOrder.FormattingEnabled = true;
            this.cbxSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbxSortOrder.Location = new System.Drawing.Point(401, 134);
            this.cbxSortOrder.Name = "cbxSortOrder";
            this.cbxSortOrder.Size = new System.Drawing.Size(115, 21);
            this.cbxSortOrder.TabIndex = 45;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(367, 137);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(19, 13);
            this.lblSortBy.TabIndex = 29;
            this.lblSortBy.Text = "By";
            // 
            // cbxSortItem
            // 
            this.cbxSortItem.FormattingEnabled = true;
            this.cbxSortItem.Items.AddRange(new object[] {
            "Manufacture Year",
            "Price"});
            this.cbxSortItem.Location = new System.Drawing.Point(401, 97);
            this.cbxSortItem.Name = "cbxSortItem";
            this.cbxSortItem.Size = new System.Drawing.Size(115, 21);
            this.cbxSortItem.TabIndex = 38;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(367, 100);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(26, 13);
            this.lblSort.TabIndex = 26;
            this.lblSort.Text = "Sort";
            // 
            // cbxDeviceNames
            // 
            this.cbxDeviceNames.FormattingEnabled = true;
            this.cbxDeviceNames.Items.AddRange(new object[] {
            "Iphone",
            "Samsung",
            "LG",
            "Xiaomi",
            "Samsung",
            "Vivo"});
            this.cbxDeviceNames.Location = new System.Drawing.Point(113, 89);
            this.cbxDeviceNames.Name = "cbxDeviceNames";
            this.cbxDeviceNames.Size = new System.Drawing.Size(121, 21);
            this.cbxDeviceNames.TabIndex = 23;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(24, 93);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(35, 13);
            this.lblDeviceName.TabIndex = 22;
            this.lblDeviceName.Text = "Brand";
            // 
            // frmPhoneShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 715);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.dtgvPhoneInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.txtSerieNo);
            this.Controls.Add(this.lblSerieNo);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtManufactureYear);
            this.Controls.Add(this.lblManufactureYear);
            this.Controls.Add(this.cbxSearchItem);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbxSortOrder);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cbxSortItem);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbxDeviceNames);
            this.Controls.Add(this.lblDeviceName);
            this.Name = "frmPhoneShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhoneShop";
            this.Load += new System.EventHandler(this.frmPhoneShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dtgvPhoneInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtSerieNo;
        private System.Windows.Forms.Label lblSerieNo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtManufactureYear;
        private System.Windows.Forms.Label lblManufactureYear;
        private System.Windows.Forms.ComboBox cbxSearchItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxSortOrder;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbxSortItem;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbxDeviceNames;
        protected System.Windows.Forms.Label lblDeviceName;
    }
}