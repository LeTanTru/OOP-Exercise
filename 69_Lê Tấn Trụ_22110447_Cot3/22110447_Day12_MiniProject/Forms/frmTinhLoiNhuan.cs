using _22110447_Day12_MiniProject.Class;
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

namespace _22110447_Day12_MiniProject.Forms {
    public partial class frmTinhLoiNhuan : Form {
        string connectionString = "Data Source=DELL\\TANTRUSQL;Initial Catalog=RevenueDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        public frmTinhLoiNhuan() {
            InitializeComponent();
        }

        private void frmTinhLoiNhuan_Load(object sender, EventArgs e) {
            InsertToProfitTable();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter("Profit.txt");

            foreach(DataColumn col in dt.Columns) {
                sw.Write(col.ColumnName + "\t");
            }

            sw.WriteLine();
            foreach(DataRow row in dt.Rows) {
                foreach(DataColumn col in dt.Columns) {
                    sw.Write(row[col].ToString() + "\t");   
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Lưu thành công !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InsertToProfitTable() {
            connection = new SqlConnection(connectionString);
            string query = "DELETE FROM ProfitTable";
            using(command = new SqlCommand(query, connection)) {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            DataTable luongNV = new DataTable();
            DataTable doanhThuDT = new DataTable();
            string query1 = "SELECT Thang1, Thang2, Thang3, Thang4, Thang5, Thang6, Thang7, Thang8, Thang9, Thang10, Thang11, Thang12 FROM staffSalaryTable";
            string query2 = "SELECT Thang1, Thang2, Thang3, Thang4, Thang5, Thang6, Thang7, Thang8, Thang9, Thang10, Thang11, Thang12 FROM SellPhoneTable";
            connection = new SqlConnection(connectionString);
            using(command = new SqlCommand(query1, connection)) {
                connection.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(luongNV);
                connection.Close();
            }

            using(command = new SqlCommand(query2, connection)) {
                connection.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(doanhThuDT);
                connection.Close();
            }

            List<int> luongNVTrong1Thang = new List<int>();
            List<int> tongDoanhThuDTTrong1Thang = new List<int>();

            for(int i =0; i < luongNV.Columns.Count; i++) {
                int sum = 0;
                for(int j = 0; j < luongNV.Rows.Count; j++) {
                    sum += Convert.ToInt32(luongNV.Rows[j][i]);
                }
                luongNVTrong1Thang.Add(sum);
            }

            for(int i = 0; i < doanhThuDT.Columns.Count; i++) {
                int sum = 0;
                for(int j = 0; j < doanhThuDT.Rows.Count; j++) {
                    sum += Convert.ToInt32(doanhThuDT.Rows[j][i]);
                }
                tongDoanhThuDTTrong1Thang.Add(sum);
            }
            string query3 = "INSERT INTO ProfitTable VALUES(@Month, @Income, @Outcome, @Profit)";

            for(int i = 0; i < tongDoanhThuDTTrong1Thang.Count; i++) {
                using(command = new SqlCommand(query3, connection)) {
                    connection.Open();

                    command.Parameters.AddWithValue("@Month", i + 1);
                    command.Parameters.AddWithValue("@Income", luongNVTrong1Thang[i]);
                    command.Parameters.AddWithValue("@Outcome", tongDoanhThuDTTrong1Thang[i]);
                    command.Parameters.AddWithValue("@Profit", tongDoanhThuDTTrong1Thang[i] - luongNVTrong1Thang[i]);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            dt = new DataTable();

            string query4 = "SELECT * FROM ProfitTable";
            using(command = new SqlCommand(query4, connection)) {
                connection.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
            }
            dtgvProfit.DataSource = dt;
        }
    }
}
