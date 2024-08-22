using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc3_B {
        string msg = "";
        public void ReadFile() {
            msg += "Doc noi dung trong file C#" + "\n" + "-------------------------" + "\n";

            try {
                using(StreamReader sr = new StreamReader(@"C:\test\test.txt")) {
                    string line;
                    while((line = sr.ReadLine()) != null) {
                        msg += line + "\n";
                    }

                }
            } catch(Exception e) {
                msg += "Không thể đọc dữ liệu từ file đã cho !!!" + "\n";
                msg += e.Message;
            }
            MessageBox.Show(msg);
        }
    }
}
