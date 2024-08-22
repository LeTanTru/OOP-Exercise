namespace _22110447_Day09_PhoneShop {
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.cbxDeviceNames = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbxSortItem = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbxSortOrder = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxSearchItem = new System.Windows.Forms.ComboBox();
            this.lblManufactureYear = new System.Windows.Forms.Label();
            this.txtManufactureYear = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblSerieNo = new System.Windows.Forms.Label();
            this.txtSerieNo = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtgvPhoneInfo = new System.Windows.Forms.DataGridView();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(12, 11);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(35, 13);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Brand";
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
            this.cbxDeviceNames.Location = new System.Drawing.Point(101, 7);
            this.cbxDeviceNames.Name = "cbxDeviceNames";
            this.cbxDeviceNames.Size = new System.Drawing.Size(121, 21);
            this.cbxDeviceNames.TabIndex = 0;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(355, 18);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(26, 13);
            this.lblSort.TabIndex = 3;
            this.lblSort.Text = "Sort";
            // 
            // cbxSortItem
            // 
            this.cbxSortItem.FormattingEnabled = true;
            this.cbxSortItem.Items.AddRange(new object[] {
            "Manufacture Year",
            "Price"});
            this.cbxSortItem.Location = new System.Drawing.Point(389, 15);
            this.cbxSortItem.Name = "cbxSortItem";
            this.cbxSortItem.Size = new System.Drawing.Size(115, 21);
            this.cbxSortItem.TabIndex = 11;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(355, 55);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(19, 13);
            this.lblSortBy.TabIndex = 5;
            this.lblSortBy.Text = "By";
            // 
            // cbxSortOrder
            // 
            this.cbxSortOrder.FormattingEnabled = true;
            this.cbxSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbxSortOrder.Location = new System.Drawing.Point(389, 52);
            this.cbxSortOrder.Name = "cbxSortOrder";
            this.cbxSortOrder.Size = new System.Drawing.Size(115, 21);
            this.cbxSortOrder.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(589, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // cbxSearchItem
            // 
            this.cbxSearchItem.FormattingEnabled = true;
            this.cbxSearchItem.Items.AddRange(new object[] {
            "Device Name",
            "Price",
            "Producer"});
            this.cbxSearchItem.Location = new System.Drawing.Point(643, 15);
            this.cbxSearchItem.Name = "cbxSearchItem";
            this.cbxSearchItem.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchItem.TabIndex = 14;
            // 
            // lblManufactureYear
            // 
            this.lblManufactureYear.AutoSize = true;
            this.lblManufactureYear.Location = new System.Drawing.Point(11, 64);
            this.lblManufactureYear.Name = "lblManufactureYear";
            this.lblManufactureYear.Size = new System.Drawing.Size(92, 13);
            this.lblManufactureYear.TabIndex = 11;
            this.lblManufactureYear.Text = "Manufacture Year";
            // 
            // txtManufactureYear
            // 
            this.txtManufactureYear.Location = new System.Drawing.Point(101, 60);
            this.txtManufactureYear.Name = "txtManufactureYear";
            this.txtManufactureYear.Size = new System.Drawing.Size(121, 20);
            this.txtManufactureYear.TabIndex = 2;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(11, 90);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(101, 86);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(121, 20);
            this.txtColor.TabIndex = 3;
            // 
            // lblSerieNo
            // 
            this.lblSerieNo.AutoSize = true;
            this.lblSerieNo.Location = new System.Drawing.Point(11, 116);
            this.lblSerieNo.Name = "lblSerieNo";
            this.lblSerieNo.Size = new System.Drawing.Size(51, 13);
            this.lblSerieNo.TabIndex = 11;
            this.lblSerieNo.Text = "Serie No.";
            // 
            // txtSerieNo
            // 
            this.txtSerieNo.Location = new System.Drawing.Point(101, 112);
            this.txtSerieNo.Name = "txtSerieNo";
            this.txtSerieNo.Size = new System.Drawing.Size(121, 20);
            this.txtSerieNo.TabIndex = 4;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(11, 142);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(50, 13);
            this.lblProducer.TabIndex = 11;
            this.lblProducer.Text = "Producer";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(101, 138);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(121, 20);
            this.txtProducer.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(101, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 194);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            this.lblAddress.UseWaitCursor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(11, 220);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 11;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(101, 216);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(121, 20);
            this.txtContactNumber.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(118, 242);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(409, 94);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(661, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(807, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgvPhoneInfo
            // 
            this.dtgvPhoneInfo.AllowUserToOrderColumns = true;
            this.dtgvPhoneInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvPhoneInfo.Location = new System.Drawing.Point(14, 268);
            this.dtgvPhoneInfo.Name = "dtgvPhoneInfo";
            this.dtgvPhoneInfo.ReadOnly = true;
            this.dtgvPhoneInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvPhoneInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvPhoneInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvPhoneInfo.Size = new System.Drawing.Size(868, 247);
            this.dtgvPhoneInfo.TabIndex = 17;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(589, 56);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(19, 13);
            this.lblSearchBy.TabIndex = 18;
            this.lblSearchBy.Text = "By";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(643, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(11, 38);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(72, 13);
            this.lblBrand.TabIndex = 20;
            this.lblBrand.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(101, 34);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(121, 20);
            this.txtDeviceName.TabIndex = 1;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(245, 216);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(245, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 527);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhoneInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDeviceNames;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbxSortItem;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbxSortOrder;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxSearchItem;
        private System.Windows.Forms.Label lblManufactureYear;
        private System.Windows.Forms.TextBox txtManufactureYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblSerieNo;
        private System.Windows.Forms.TextBox txtSerieNo;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgvPhoneInfo;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblBrand;
        protected System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnReset;
    }
}

