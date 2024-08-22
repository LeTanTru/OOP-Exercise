using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_lamVoiFile {
        public class FileHelper {

        public  string GetFileContent(string filePath) {
            string content = "";
            using(FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read)) {
                using(StreamReader reader = new StreamReader(stream)) {
                    string line;
                    while(reader.Peek() >= 0) {
                        line = reader.ReadLine() + "\r\n";
                        content += line;

                    }
                }
            }
            return content;
        }
    }
}
