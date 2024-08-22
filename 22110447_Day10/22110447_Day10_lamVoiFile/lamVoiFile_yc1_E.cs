using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_E {


        string filePath = "C:/test/test.txt";
        string msg = "";
        public void ktFile() {
            // Kiểm tra đường dẫn này có tồn tại hay không?
            if(File.Exists(filePath)) {
                // Xóa file
                File.Delete(filePath);
                // Kiểm tra lại xem file còn tồn tại không.
                if(!File.Exists(filePath)) {
                    msg = "File deleted...";
                }
            } else {
                msg = "File test.txt does not yet exist!";
            }
            MessageBox.Show(msg);
        }
    }
}
