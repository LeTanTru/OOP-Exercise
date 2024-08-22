using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_B {
        String dirPath = @"C:/test/CSharp";
        string str = "";
        public void ShowDI() {
            // Kiểm tra xem đường dẫn thư mục tồn tại không.
            string msg = "";
            bool exist = Directory.Exists(dirPath);
            // Nếu không tồn tại, tạo thư mục này.
            if(!exist) {
                msg += dirPath + " does not exist." + "\n" + "Create directory: " + dirPath + "\n";
                // Tạo thư mục.
                Directory.CreateDirectory(dirPath);
            }
            msg += "Directory Information: " + dirPath + "\n";
            // In ra các thông tin thư mục trên.
            // Thời điểm tạo thư mục.
            msg += "Creation time: " + Directory.GetCreationTime(dirPath) + "\n";
            // Thời điểm cuối cùng thư mục có sự thay đổi.
            // Thư mục cha.
            DirectoryInfo parentInfo = Directory.GetParent(dirPath);
            msg += "Parent directory:" + parentInfo.FullName + "\n";
            MessageBox.Show(msg);
        }
    }
}
