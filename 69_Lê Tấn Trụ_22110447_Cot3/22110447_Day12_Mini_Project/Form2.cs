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

namespace _22110447_Day12_Mini_Project {
    public partial class Form2 : Form {
        string connectionString = @"Data Source=DELL\TANTRUSQL;Initial Catalog=QLNV;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form2() {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e) {
            dtgvInfo.ClearSelection();
        }

        private void radBtnIT_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void radBtnHR_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void radBtnBA_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void btnShow_Click(object sender, EventArgs e) {
            DataTable table = new DataTable();
            if(radBtnIT.Checked) {
                string room = "IT";
                string query = "SELECT * FROM NVTable WHERE Phong = '" + room + "'";
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();
                    adapter = new SqlDataAdapter(command);
                    table.Clear();
                    adapter.Fill(table);
                    connection.Close();
                }
            }

            if(radBtnHR.Checked) {
                string room = "HR";
                string query = "SELECT * FROM NVTable WHERE Phong = '" + room + "'";
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();
                    adapter = new SqlDataAdapter(command);
                    table.Clear();
                    adapter.Fill(table);
                    connection.Close();
                }
                
            }

            if(radBtnBA.Checked) {
                string room = "BA";
                string query = "SELECT * FROM NVTable WHERE Phong = '" + room + "'";
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();
                    adapter = new SqlDataAdapter(command);
                    table.Clear();
                    adapter.Fill(table);
                    connection.Close();
                }
            }
            dtgvInfo.DataSource = table;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if(txtSearch.Text.Trim() == "") {
                dtgvInfo.DataSource = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                int salary = Convert.ToInt32(txtSearch.Text);
                string query = "SELECT * FROM NVTable";
                DataTable table = new DataTable();
                using(command = new SqlCommand(query, connection)) {
                    connection.Open();
                    adapter = new SqlDataAdapter(command);
                    table.Clear();
                    adapter.Fill(table);
                    
                }
                DataTable result = new DataTable();
                result = table.Clone();
                foreach(DataRow row in table.Rows) {
                    if(Convert.ToInt32(row["Luong"]) >= salary) {
                        DataRow _row = row;
                        result.ImportRow(_row);
                    }
                }
                
                dtgvInfo.DataSource = result;
            } catch(SqlException sql) {
                MessageBox.Show(sql.Message);
                dtgvInfo.DataSource = null;
            } catch {
                MessageBox.Show("Input must be an integer !");
                dtgvInfo.DataSource = null;
            } finally {
                connection.Close();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e) {
            try {
                using(StreamWriter writer = new StreamWriter("result.text")) {
                    writer.WriteLine("ID\t\tName\t\tDepartment\t\tSalary\t\tAge");
                    foreach(DataGridViewRow row in dtgvInfo.Rows) {
                        foreach(DataGridViewCell cell in row.Cells) {
                            writer.Write($"{cell.Value}\t\t|");
                        }
                        writer.WriteLine();
                    }
                    writer.Close();
                }
                MessageBox.Show("Save successfully !", "Save to file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
