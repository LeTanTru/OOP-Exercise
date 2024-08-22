using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_G {
        String filePath = @"C:/test/test.txt";
        string msg;
        public void rn() {
            if(File.Exists(filePath)) {
                msg += filePath + " exist" + "\n";

                Console.WriteLine();

                string newFilename = "new_test";
                if(newFilename != string.Empty) {
                    File.Move(filePath, newFilename);

                    if(File.Exists(newFilename)) {
                        msg += "The file was renamed to " + newFilename + "\n";
                        Console.WriteLine();
                    }
                }
            } else {
                msg += "Path " + filePath + " does not exist.";
            }
            MessageBox.Show(msg);
        }
    }
}
