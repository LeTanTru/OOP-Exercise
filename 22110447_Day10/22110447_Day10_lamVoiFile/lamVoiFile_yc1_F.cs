using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_F {
        string msg = "";

        public void PrintDirectory(string dirPath) {
            try {
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                // Nếu bạn không có quyền truy cập thư mục 'dirPath'
                // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                List<string> dirs = new List<string>(enums);
                foreach(var dir in dirs) {
                    msg += dir + "\n";
                    PrintDirectory(dir);
                }
                // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền. catch (UnauthorizedAccessException e)
            } catch(UnauthorizedAccessException e) {
                msg += "Can not access directory: " + dirPath + "\n" + e.Message;
            }
        }

        public void run(string dirPath) {
            PrintDirectory(dirPath);
            MessageBox.Show(msg);
        }
    }
}

