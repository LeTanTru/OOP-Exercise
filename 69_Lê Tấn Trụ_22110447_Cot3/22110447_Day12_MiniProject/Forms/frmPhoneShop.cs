using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _22110447_Day12_MiniProject.Forms {
    public partial class frmPhoneShop : Form {

        string connectionString = @"Data Source=DELL\TANTRUSQL;Initial Catalog=qlyDienThoai;Integrated Security=True;TrustServerCertificate=True";

        public frmPhoneShop() {
            InitializeComponent();
            LoadData();
        }


        private void LoadData() {
            try {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM PhoneTable";
                DataTable table = new DataTable();
                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    table.Clear();
                    adapter.Fill(table);

                    connection.Close();
                }

                dtgvPhoneInfo.DataSource = table;
            } catch(SqlException sql) {
                MessageBox.Show("Lỗi truy vấn!\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            dtgvPhoneInfo.ClearSelection();
        }

        public DataTable ReadTextFile(string filepath, int numberOfColumns) {
            DataTable dtTextFile = new DataTable();

            for(int col = 0; col < numberOfColumns; col++)
                dtTextFile.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] readTextfile = File.ReadAllLines(filepath);


            foreach(string line in readTextfile) {
                var cols = line.Split('\t');
                DataRow dtrow = dtTextFile.NewRow();

                for(int cIndex = 0; cIndex < 8; cIndex++) {
                    dtrow[cIndex] = cols[cIndex];
                }

                dtTextFile.Rows.Add(dtrow);

            }

            return dtTextFile;

        }

        private void frmPhoneShop_Load(object sender, EventArgs e) {
            LoadData();
            dtgvPhoneInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPhoneInfo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            try {
                string deviceName = cbxDeviceNames.Items[cbxDeviceNames.SelectedIndex].ToString().Trim() + " " + txtDeviceName.Text;
                string manufacturesYear = txtManufactureYear.Text;
                string color = txtColor.Text;
                string producer = txtProducer.Text;
                string serieNo = txtSerieNo.Text;
                string price = txtPrice.Text;
                string address = txtAddress.Text;
                string contactNumber = txtContactNumber.Text;


                string query = @"INSERT INTO PhoneTable VALUES(@DeviceName, @ManufactureYear, @Color, @SerieNo, @Producer, @Price, @Address, @ContactNumber)";
                SqlConnection connection = new SqlConnection(connectionString);

                try {
                    SqlParameter[] sqlParameters = {
                        new SqlParameter("@DeviceName", deviceName),
                        new SqlParameter("@ManufactureYear", manufacturesYear),
                        new SqlParameter("@Color", color),
                        new SqlParameter("@SerieNo", serieNo),
                        new SqlParameter("@Producer", producer),
                        new SqlParameter("@Price", price),
                        new SqlParameter("@Address", address),
                        new SqlParameter("@ContactNumber", contactNumber),
                    };
                    using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                        connection.Open();
                        foreach(SqlParameter sqlParameter in sqlParameters) {
                            sqlCommand.Parameters.Add(sqlParameter);
                        }
                        int k = sqlCommand.ExecuteNonQuery();
                        if(k > 0) {
                            MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                } catch(SqlException sql) {
                    MessageBox.Show(sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally {
                    connection.Close();

                }

                dtgvPhoneInfo.Refresh();
            } catch(Exception ex) {
                MessageBox.Show("All fields mustn't be empty !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e) {
            //try {
            //    string sortItem = cbxSortItem.Items[cbxSortItem.SelectedIndex].ToString().Trim();
            //    string sortOrder = cbxSortOrder.Items[cbxSortOrder.SelectedIndex].ToString().Trim();
            //    if(sortItem == "Manufacture Year") {
            //        if(sortOrder == "Ascending") {
            //            DataColumn sortColumn = dataTable.Columns["Manufacture Year"];
            //            int rowCount = dataTable.Rows.Count;

            //            for(int i = 0; i < rowCount - 1; i++) {
            //                for(int j = 0; j < rowCount - i - 1; j++) {
            //                    int value1 = Convert.ToInt32(dataTable.Rows[j][sortColumn]);
            //                    int value2 = Convert.ToInt32(dataTable.Rows[j + 1][sortColumn]);

            //                    if(value1 > value2) {
            //                        // Hoán đổi dữ liệu giữa hai dòng
            //                        for(int k = 0; k < dataTable.Columns.Count; k++) {
            //                            object temp = dataTable.Rows[j][k];
            //                            dataTable.Rows[j][k] = dataTable.Rows[j + 1][k];
            //                            dataTable.Rows[j + 1][k] = temp;
            //                        }
            //                    }
            //                }
            //            }
            //        } else {
            //            DataColumn sortColumn = dataTable.Columns["Manufacture Year"];
            //            int rowCount = dataTable.Rows.Count;

            //            for(int i = 0; i < rowCount - 1; i++) {
            //                for(int j = 0; j < rowCount - i - 1; j++) {
            //                    int value1 = Convert.ToInt32(dataTable.Rows[j][sortColumn]);
            //                    int value2 = Convert.ToInt32(dataTable.Rows[j + 1][sortColumn]);

            //                    if(value1 < value2) {
            //                        // Hoán đổi dữ liệu giữa hai dòng
            //                        for(int k = 0; k < dataTable.Columns.Count; k++) {
            //                            object temp = dataTable.Rows[j][k];
            //                            dataTable.Rows[j][k] = dataTable.Rows[j + 1][k];
            //                            dataTable.Rows[j + 1][k] = temp;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    } else if(sortItem == "Price") {
            //        if(sortOrder == "Ascending") {
            //            DataColumn sortColumn = dataTable.Columns["Price"];
            //            int rowCount = dataTable.Rows.Count;

            //            for(int i = 0; i < rowCount - 1; i++) {
            //                for(int j = 0; j < rowCount - i - 1; j++) {
            //                    int value1 = Convert.ToInt32(dataTable.Rows[j][sortColumn]);
            //                    int value2 = Convert.ToInt32(dataTable.Rows[j + 1][sortColumn]);

            //                    if(value1 > value2) {
            //                        // Hoán đổi dữ liệu giữa hai dòng
            //                        for(int k = 0; k < dataTable.Columns.Count; k++) {
            //                            object temp = dataTable.Rows[j][k];
            //                            dataTable.Rows[j][k] = dataTable.Rows[j + 1][k];
            //                            dataTable.Rows[j + 1][k] = temp;
            //                        }
            //                    }
            //                }
            //            }
            //        } else {
            //            DataColumn sortColumn = dataTable.Columns["Price"];
            //            int rowCount = dataTable.Rows.Count;

            //            for(int i = 0; i < rowCount - 1; i++) {
            //                for(int j = 0; j < rowCount - i - 1; j++) {
            //                    int value1 = Convert.ToInt32(dataTable.Rows[j][sortColumn]);
            //                    int value2 = Convert.ToInt32(dataTable.Rows[j + 1][sortColumn]);

            //                    if(value1 < value2) {

            //                        for(int k = 0; k < dataTable.Columns.Count; k++) {
            //                            object temp = dataTable.Rows[j][k];
            //                            dataTable.Rows[j][k] = dataTable.Rows[j + 1][k];
            //                            dataTable.Rows[j + 1][k] = temp;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    dtgvPhoneInfo.DataSource = dataTable;
            //    dtgvPhoneInfo.Refresh();
            //    MessageBox.Show("Sort successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //} catch {
            //    MessageBox.Show("Please surely that you chose enough options to sort !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            //try {
            //    string searchColumn = cbxSearchItem.Items[cbxSearchItem.SelectedIndex].ToString();
            //    string searchInfo = txtSearch.Text;


            //    DataTable searchResult = new DataTable();
            //    searchResult = dataTable.Clone();
            //    foreach(DataRow row in dataTable.Rows) {
            //        if(row.Field<string>(searchColumn).Contains(searchInfo.ToString())) {
            //            searchResult.ImportRow(row);
            //        }
            //    }

            //    if(searchResult.Rows.Count > 0)
            //        dtgvPhoneInfo.DataSource = searchResult;
            //    else
            //        dtgvPhoneInfo.DataSource = dataTable;
            //    dtgvPhoneInfo.Refresh();


            //} catch {
            //    MessageBox.Show("Please surely that you chose enough field to search !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            //if(txtSearch.Text == string.Empty) {
            //    dataTable = ReadTextFile("phones.txt", dataTable.Columns.Count);
            //    for(int i = 0; i < dataTable.Columns.Count; i++) {
            //        if(dataTable.Columns.Contains("Column" + (i + 1).ToString())) {
            //            dataTable.Columns["Column" + (i + 1).ToString()].ColumnName = columnTitles[i];
            //        }
            //    }
            //    dtgvPhoneInfo.DataSource = dataTable;
            //}
        }

        private void btnLoadData_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            cbxDeviceNames.SelectedIndex = -1;
            txtDeviceName.Text = string.Empty;
            txtManufactureYear.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtSerieNo.Text = string.Empty;
            txtProducer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            //FileStream fs = new FileStream("phones.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter streamWriter = new StreamWriter(fs);
            //if(dataTable.Rows.Count == 0) {
            //    MessageBox.Show("No data to save !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //foreach(DataRow row in dataTable.Rows) {
            //    foreach(DataColumn col in dataTable.Columns) {
            //        streamWriter.Write(row[col].ToString() + "\t");
            //    }
            //    streamWriter.WriteLine();
            //}
            //streamWriter.Flush();
            //fs.Close();
            //MessageBox.Show("Saved !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
