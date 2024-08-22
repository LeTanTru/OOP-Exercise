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
    public partial class lamVoiFile_yc2 : Form {
        public lamVoiFile_yc2() {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e) {
            FileInfo testFile = new FileInfo(@"C:\Users\ADMIN\Documents\CODE\Languages Learning\C#\Winforms\ComplexNumber\Program.cs");
            if(rdbFileInfo.Checked == true) {
                if(testFile.Exists) {
                    rtShow.Text = testFile.FullName + " exist.\n" +
                            "Creation time: " + testFile.CreationTime + "\n" +
                            "Last Write Time: " + testFile.LastWriteTime + "\n" +
                            "Directory Name: " + testFile.DirectoryName + "\n";

                } else {
                    rtShow.Text = testFile.FullName + " does not exist.";
                }
            }
            if(rdbNewFolder.Checked == true) {
                String dirPath = @"C:\test";

                bool exist = Directory.Exists(dirPath); 
                if(!exist) {
                    rtShow.Text = dirPath + " doesn't exist." + "\n" +
                        "Create directory: " + dirPath + "\n" +
                        "Nhấn thêm một lần nữa để hiển thị thông tin thư mục vừa tạo";

                    Directory.CreateDirectory(dirPath);
                } else {
                    DirectoryInfo parentInfo = Directory.GetParent(dirPath);
                    rtShow.Text = "Directory Information " + dirPath + "\n" +
                                    "Creation time: " + Directory.GetCreationTime(dirPath) + "\n" +
                                    "Last write time: " + Directory.GetLastAccessTime(dirPath) + "\n" +
                                    "Parent directory: " + parentInfo.FullName;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            rtShow.Text = "";
        }

        private void lamVoiFile_yc2_Load(object sender, EventArgs e) {
            rtShow.Text = "";
        }
    }
}
