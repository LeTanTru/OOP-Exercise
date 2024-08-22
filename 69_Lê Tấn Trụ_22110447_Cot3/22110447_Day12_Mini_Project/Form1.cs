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

namespace _22110447_Day12_Mini_Project {
    public partial class Form1 : Form {
        string connectionString = @"Data Source=DELL\TANTRUSQL;Initial Catalog=QLNV;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1() {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dtgvInfo.ClearSelection();
            LoadData();
        }

        private void CloseConnection() {
            if(connection.State == ConnectionState.Open) {
                connection.Close();
            }
        }

        private void LoadData() {
            CloseConnection();
            string query = "SELECT * FROM NVTable";
            DataTable table = new DataTable();
            using(command = new SqlCommand(query, connection)) {
                connection.Open();
                adapter = new SqlDataAdapter(command);
                table.Clear();
                adapter.Fill(table);
                connection.Close();
            }
            dtgvInfo.DataSource = table;
        }

        private bool CheckEmpty() {
            if(txtID.Text.Trim() == "" || txtName.Text.Trim() == "" || txtRoom.Text.Trim() == "" || txtSalary.Text.Trim() == "" || txtAge.Text.Trim() == "") {
                MessageBox.Show("Please input enough information !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            CloseConnection();
            try {
                if(!CheckEmpty())
                    return;
                string ID = txtID.Text;
                string name = txtName.Text;
                string room = txtRoom.Text;
                string salary = txtSalary.Text;
                string age = txtAge.Text;
                try {
                    int _age = int.Parse(age);
                } catch {
                    MessageBox.Show("Age must be an integer !", "Age", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string query = "INSERT INTO NVTable VALUES( @ID, @Ten,  @Phong,  @Luong,  @Tuoi)";
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@ID", ID),
                    new SqlParameter("@Ten", name),
                    new SqlParameter("@Phong", room),
                    new SqlParameter("@Luong", salary),
                    new SqlParameter("@Tuoi", age),
                };
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();


                    foreach(SqlParameter sqlParameter in sqlParameters) {
                        command.Parameters.Add(sqlParameter);
                    }
                    command.ExecuteNonQuery();
                }
                ResetInput();
                LoadData();
            } catch(SqlException sql) {
                //MessageBox.Show(sql.Message);
                MessageBox.Show("This is used !\nTry another !", "ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } finally {
                connection.Close();
            }
                

        }

        private void btnEdit_Click(object sender, EventArgs e) {
            CloseConnection();
            try {
                string ID = txtID.Text;
                string name = txtName.Text;
                string room = txtRoom.Text;
                string salary = txtSalary.Text;
                string age = txtAge.Text;
                string query = "UPDATE NVTable SET Ten = @Ten, Phong = @Phong, Luong = @Luong, Tuoi = @Tuoi WHERE ID = @ID";
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@ID", ID),
                    new SqlParameter("@Ten", name),
                    new SqlParameter("@Phong", room),
                    new SqlParameter("@Luong", salary),
                    new SqlParameter("@Tuoi", age),
                };
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();


                    foreach(SqlParameter sqlParameter in sqlParameters) {
                        command.Parameters.Add(sqlParameter);
                    }
                    command.ExecuteNonQuery();
                    
                }
                ResetInput();
                LoadData();
            } catch(SqlException sql) {
                MessageBox.Show(sql.Message);
            } finally {
                connection.Close();
            }
        }

        private void dtgvInfo_CellClick(object sender, DataGridViewCellEventArgs e) {
            CloseConnection();
            if(e.RowIndex >= 0) {
                txtID.Text = dtgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgvInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dtgvInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSalary.Text = dtgvInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAge.Text = dtgvInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            CloseConnection();
            try {
                string ID = txtID.Text;
                string query = "DELETE FROM NVTable WHERE ID = @ID";
                SqlParameter[] sqlParameters = {
                    new SqlParameter("@ID", ID),
                };
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();


                    foreach(SqlParameter sqlParameter in sqlParameters) {
                        command.Parameters.Add(sqlParameter);
                    }
                    command.ExecuteNonQuery();
                    
                }
                ResetInput();
                LoadData();
            } catch(SqlException sql) {
                MessageBox.Show(sql.Message);
            } finally {
                connection.Close();
            }
        }

        private void ResetInput() {
            dtgvInfo.ClearSelection();
            txtID.Text = "";
            txtName.Text = "";
            txtRoom.Text = "";
            txtSalary.Text = "";
            txtAge.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
