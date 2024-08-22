using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_A {
        DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\ADMIN\Microsoft VS Code");
        string msg = "";
        public void ShowDI() {
            msg += "Create time: " + directoryInfo.CreationTime + "\n" +
                "Last time write: " + directoryInfo.LastAccessTime + "\n" +
                "Directory Name: " + directoryInfo.FullName + "\n";

            DirectoryInfo[] childDirs = directoryInfo.GetDirectories();

            FileInfo[] childFiles = directoryInfo.GetFiles();

            foreach(DirectoryInfo childDir in childDirs) {
                msg += " - Directory: " + childDir.FullName + "\n" +
                    " - Created at: " + childDir.CreationTime + "\n";

            }

            foreach(FileInfo childFile in childFiles) {
                msg += " - File: " + childFile.FullName + "\n" +
                    " - Created at: " + childFile.CreationTime;
            }
            MessageBox.Show(msg);
        }
    }

}
