using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day12_MiniProject {
    public partial class frmNhanVien : Form {
        public frmNhanVien() {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DELL\TANTRUSQL;InitialCatalog=qlyNhanVien;Integrated Security=True;TrustServerCertificate=True";

        private void frmCuaHang_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            try {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM InformationTable";
                DataTable table = new DataTable();
                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    table.Clear();
                    adapter.Fill(table);

                    connection.Close();
                }

                dtgvInformation.DataSource = table;
            } catch(SqlException sql) {
                MessageBox.Show("Lỗi truy vấn!\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            dtgvInformation.ClearSelection();
        }

        private void ResetTextBox() {
            txtEmpId.Text = "";
            txtName.Text = "";
            txtDept.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(txtEmpId.Text.Trim() == string.Empty) {
                MessageBox.Show("Emp Id không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(txtName.Text.Trim() == string.Empty) {
                MessageBox.Show("Name không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(txtDept.Text.Trim() == string.Empty) {
                MessageBox.Show("Dept không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try {
                string query = "INSERT INTO InformationTable VALUES('" + txtEmpId.Text + "', N'" + txtName.Text + "',N'" + txtDept.Text + "')";

                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    int k = sqlCommand.ExecuteNonQuery();
                    if(k > 0) {
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    }
                }
                LoadData();
            } catch {
                MessageBox.Show("Mã nhân viên đã tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection(connectionString);

            try {
                string query = "UPDATE InformationTable SET Name = N'" + txtName.Text + "', Dept = N'" + txtDept.Text + "' WHERE EmpID = '" + txtEmpId.Text + "'";

                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    int k = sqlCommand.ExecuteNonQuery();
                    if(k > 0) {
                        MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    } else {
                        MessageBox.Show("Vui lòng chọn dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadData();
            } catch(SqlException sql) {
                MessageBox.Show("Lỗi truy vấn !\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if(dtgvInformation.Rows.Count == 1) {
                MessageBox.Show("Danh sách nhân viên đang trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtEmpId.Text.Trim() == string.Empty) {
                MessageBox.Show("EmpId không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try {
                string query = "DELETE FROM InformationTable WHERE EmpID = '" + txtEmpId.Text + "'";

                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    int k = sqlCommand.ExecuteNonQuery();
                    if(k > 0) {
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    } else {
                        MessageBox.Show("Vui lòng chọn dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadData();
            } catch(SqlException sql) {
                MessageBox.Show("Lỗi truy vấn !\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();

            }
        }

        private void btnFind_Click(object sender, EventArgs e) {
            LoadData();
            if(dtgvInformation.Rows.Count == 1) {
                MessageBox.Show("Danh sách nhân viên đang trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = cbxFindSelection.SelectedIndex;
            if(selectedIndex < 0) {
                MessageBox.Show("Vui lòng chọn trường để tìm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtValue.Text.Trim() == "") {
                MessageBox.Show("Vui lòng nhập dữ liệu để tìm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try {
                string query = $"SELECT * FROM InformationTable WHERE {cbxFindSelection.Items[selectedIndex].ToString()} LIKE '%" + txtValue.Text + "%'";
                SqlConnection connection = new SqlConnection(connectionString);
                DataTable table = new DataTable();
                using(SqlCommand sqlCommand = new SqlCommand(query, connection)) {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    table.Clear();
                    adapter.Fill(table);

                    connection.Close();
                }
                dtgvInformation.DataSource = table;
            } catch(SqlException sql) {
                MessageBox.Show("Lỗi truy vấn !\n" + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtgvInformation.ClearSelection();
        }

        private void txtValue_TextChanged(object sender, EventArgs e) {
            if(txtValue.Text.Trim() == "") {
                LoadData();
            }
        }

        private void dtgvInformation_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex >= 0) {
                txtEmpId.Text = dtgvInformation.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgvInformation.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDept.Text = dtgvInformation.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
