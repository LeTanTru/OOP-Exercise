using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_D {


        FileInfo testFile = new FileInfo(@"C:/test/test.txt");
        string msg = "";
        public void ShowFileInfo() {
            if(testFile.Exists) {
                msg += testFile.FullName + "exist." + "\n";
                msg += "Creation time: " + testFile.CreationTime + "\n";
                msg += "Last Write Time" + testFile.LastWriteTime + "\n";
                msg += "Directory Name: " + testFile.DirectoryName + "\n";
            } else {
                msg += testFile.FullName + " does not exist." + "\n";
            }
            MessageBox.Show(msg);
        }
    }
}
