using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc3_D {
        string msg = "";
        public void Write() {
            msg += "\n Vi du minh hoa doc va ghi File trong C#" + "\n" + "------------------------------------" + "\n";

            string[] names = new string[] { "Boss", "Hourly Worker", "Commission Worker", "Part time"};
            StreamWriter sw = new StreamWriter(@"C:\test\test.txt");
            foreach(string s in names) {
                sw.WriteLine(s);
            }

            sw.Close();

            string line = "";
            StreamReader sr = new StreamReader(@"C:\test\test.txt");

            while((line =  sr.ReadLine()) != null) {
                msg += line + "\n";
            }
            MessageBox.Show(msg);
        }
    }

}
