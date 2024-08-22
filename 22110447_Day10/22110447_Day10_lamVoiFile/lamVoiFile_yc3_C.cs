using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc3_C {
        public void waf() {
            string fileLPath = @"C:\test\fileLPath.txt";
            string fileSPath = @"C:\test\fileSPath.txt";

            string[] lines = new string[2];
            lines[0] = "Ghi theo dong C#.";
            lines[1] = "Dong thu 1";
            File.WriteAllLines(fileLPath, lines);
            string str;
            str = "Ghi toàn bộ lines";
            File.WriteAllText(fileSPath, str);
        }
    }
}
