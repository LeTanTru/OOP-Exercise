using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_I {


        String dirPath = "C:/test/CSharp";
        string msg = "";
        public void reD() {
            // Nếu đường dẫn này tồn tại.
            if(!Directory.Exists(dirPath)) {
                msg += dirPath + " does not exist.";
                return;
            }
            msg += dirPath + " exist" + "\n";
            // String mà người dùng nhập vào.
            // Ví dụ: C:/test2/Java
            string newDirname = "C:/test/newFolderCSharp";
            if(newDirname == String.Empty) {
                return;
            }
            // Nếu đường dẫn mà người dùng nhập vào là tồn tại.
            if(Directory.Exists(newDirname)) {
                msg += "Cannot rename directory. New directory already exist." + "\n";
                return;
            }
            // Thư mục cha.
            DirectoryInfo parentInfo = Directory.GetParent(newDirname);
            // Tạo thư mục cha của thư mục mà người dùng nhập vào.
            Directory.CreateDirectory(parentInfo.FullName);
            // có thể đổi đường dẫn(path) của một thư mục.
            Directory.Move(dirPath, newDirname);
            // nhưng phải đảm bảo đường dẫn cha của đường dẫn mới phải tồn tại. 1/ (Nếu không ngoại lệ DirectoryNotFoundException sẽ được ném ra). Directory.Move (dirPath, newDirname);
            if(Directory.Exists(newDirname)) {
                msg += "The directory was renamed to " + newDirname;
            }
            MessageBox.Show(msg);
        }
    }
}
