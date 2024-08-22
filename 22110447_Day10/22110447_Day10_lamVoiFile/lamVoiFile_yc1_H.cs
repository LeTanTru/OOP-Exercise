using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_H {


        FileInfo fileInfo = new FileInfo("C:/test/test.txt");
        string msg = "";
        public void renameInfo() {
            if(!fileInfo.Exists) {
                msg += fileInfo.FullName + " does not exist.";
                return;
            }
            msg += fileInfo.FullName + " exist" + "\n";

            string newFilename = @"C:\test\new_name.txt";
            FileInfo newFileInfo = new FileInfo(newFilename);
            // Nếu 'newFileInfo' tồn tại(Không thể đổi tên).
            if(newFileInfo.Exists) {
                msg += "Can not rename file to " + newFileInfo.FullName + ". File already exist." + "\n";
                return;
            }
            // Tạo thư mục cha của 'newFileInfo".
            newFileInfo.Directory.Create(); // Đổi tên file.
            fileInfo.MoveTo(newFileInfo.FullName);
            // Refresh.
            newFileInfo.Refresh();
            if(newFileInfo.Exists) {
                msg += "The file was renamed to " + newFileInfo.FullName;
            }
            MessageBox.Show(msg);
        }
    }
}
