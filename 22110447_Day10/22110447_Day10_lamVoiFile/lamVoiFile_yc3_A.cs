using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc3_A {
        string filePath = @"C:\test\test.txt";
        string[] lines;
        string str;
        string msg = "";
       public void ReadFile() {
            if(File.Exists(filePath)) {
                msg += "Đọc theo dòng: \n";

                lines = File.ReadAllLines(filePath);
                for(int i =0; i < lines.Length; i++) {
                    msg += $"Line {i}:{lines[i]}\n";
                }

                msg += "Đọc hết văn bản: \n";
                str = File.ReadAllText(filePath);
                msg += str;
                msg += $"Chuỗi cần đọc: {str} ";
            } else {
                msg += "File doesn't exist !";
            }
            MessageBox.Show(msg);
        } 
       
    }
}
