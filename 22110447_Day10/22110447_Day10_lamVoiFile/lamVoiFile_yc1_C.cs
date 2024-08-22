using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22110447_Day10_lamVoiFile {
    internal class lamVoiFile_yc1_C {


        public void ShowDriver() {
            string msg = "";
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives) {
                msg += " ============================= " + "\n";
                // Tên của ổ đĩa (C, D, ..)
                msg += "Drive: " + drive.Name + "\n";
                // Loại ổ đĩa (Removable,..)
                msg += " Drive type: " + drive.DriveType + "\n";
                // Nếu ổ đĩa sẵn sàng.
                if(drive.IsReady) {
                    msg += " Volume label: " + drive.VolumeLabel + "\n";
                    msg += " File system: " + drive.DriveFormat + "\n";
                    msg += " Available space to current user: " + drive.AvailableFreeSpace + "\n";
                    msg += " Total available space: " + drive.TotalFreeSpace + "\n";
                    msg += " Total size of drive: " + drive.TotalSize + "\n";


                }
            }
            MessageBox.Show(msg);
        }

    }
}

