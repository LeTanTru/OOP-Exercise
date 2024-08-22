using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    public partial class lamVoiFile_XuLyFile : Form {
        public lamVoiFile_XuLyFile() {
            InitializeComponent();
        }

        DataTable dt;


        private void btnOpen_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK) {
                    if(Path.GetExtension(openFileDialog.FileName) == ".txt") {
                        string fileName = openFileDialog.FileName;
                        //MessageBox.Show(fileName);
                        textBox1.Text = fileName;
                        dt = new DataTable();

                        dt.Columns.Add("Cot 1");
                        dt.Columns.Add("Cot 2");
                        dt.Columns.Add("Cot 3");
                        dt.Columns.Add("Cot 4");
                        FileHelper fh = new FileHelper();
                        string content = fh.GetFileContent(fileName);
                        string[] strContent = content.Split('\n');
                        foreach(string dong in strContent) {
                            if(string.IsNullOrEmpty(dong))
                                break;
                            string[] _dong = dong.Split(',');
                            DataRow dr = dt.NewRow();
                            dr["Cot 1"] = _dong[0];
                            dr["Cot 2"] = _dong[1];
                            dr["Cot 3"] = _dong[2];
                            dr["Cot 4"] = _dong[3];

                            dt.Rows.Add(dr);
                        }

    
                    }
                }
                dgvData.DataSource = null;
                dgvData.Refresh();
                dgvData.DataSource = dt;
            } catch {
                textBox1.Text = "";
                MessageBox.Show("Data doesn't have true format\nData must be seperate by a comma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lamVoiFile_XuLyFile_Load(object sender, EventArgs e) {

        }
    }
}
