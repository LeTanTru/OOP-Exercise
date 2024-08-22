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
    public partial class frmBanDienThoai : Form {
        string connectionString = @"Data Source=DELL\TANTRUSQL;Initial Catalog=RevenueDB;Integrated Security=True;TrustServerCertificate=True";
        string connectionString2 = @"Data Source=DELL\TANTRUSQL;Initial Catalog=qlyDienThoai;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        public frmBanDienThoai() {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        private void frmBanDienThoai_Load(object sender, EventArgs e) {
            InsertToSellPhone();
            LoadData();
        }
        private void LoadData() {
            string query = "SELECT * FROM sellPhoneTable";
            connection = new SqlConnection(connectionString);
            using(command = new SqlCommand(query, connection)) {
                connection.Open();
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);

                dtgvBanDienThoai.DataSource = dt;
            }
            connection.Close();
        }

        private void InsertToSellPhone() {
            Random rand = new Random();
            string query3 = "DELETE FROM sellPhoneTable";
            using(command = new SqlCommand(query3, connection)) {
                connection.Open();
                command.ExecuteNonQuery();
            }
            connection.Close();
            string query = "SELECT * FROM PhoneTable";
            connection = new SqlConnection(connectionString2);
            using(command = new SqlCommand(query, connection)) {
                connection.Open();
                var reader = command.ExecuteReader();
                if(reader.HasRows) {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query2 = "INSERT INTO sellPhoneTable VALUES(@DeviceName, @Color, @Producer, @Thang1, @Thang2, @Thang3, @Thang4, @Thang5, @Thang6, @Thang7, @Thang8, @Thang9, @Thang10, @Thang11, @Thang12)";

                    while(reader.Read()) {
                        int sold = rand.Next(20, 40);
                        SqlParameter[] sqlParameters = {
                        new SqlParameter("@DeviceName", reader.GetString(0)),
                        new SqlParameter("@Color", reader.GetString(2)),
                        new SqlParameter("@Producer", reader.GetString(4)),
                        new SqlParameter("@Thang1", reader.GetInt32(5)),
                        new SqlParameter("@Thang2", reader.GetInt32(5)),
                        new SqlParameter("@Thang3", reader.GetInt32(5)),
                        new SqlParameter("@Thang4", reader.GetInt32(5)),
                        new SqlParameter("@Thang5", reader.GetInt32(5)),
                        new SqlParameter("@Thang6", reader.GetInt32(5)),
                        new SqlParameter("@Thang7", reader.GetInt32(5)),
                        new SqlParameter("@Thang8", reader.GetInt32(5)),
                        new SqlParameter("@Thang9", reader.GetInt32(5)),
                        new SqlParameter("@Thang10", reader.GetInt32(5)),
                        new SqlParameter("@Thang11", reader.GetInt32(5)),
                        new SqlParameter("@Thang12", reader.GetInt32(5)),
                    };
                        SqlCommand command2 = new SqlCommand(query2, connection);
                        foreach(SqlParameter sqlParameter in sqlParameters) {
                            command2.Parameters.Add(sqlParameter);
                        }
                        command2.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter("doanhThuBanDienThoai.txt");
            foreach(DataColumn col in dt.Columns) {
                sw.Write(col.ColumnName.ToString() + "\t");
            }
            sw.Write('\n');
            foreach(DataRow row in dt.Rows) {
                foreach(DataColumn col in dt.Columns) {
                    sw.Write(row[col].ToString() + "\t");
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Lưu thành công !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information );  
        }
    }
}
