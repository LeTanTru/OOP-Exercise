using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_FileWrite {
    class Program {
        static void Main(string[] args) {

            Directory.CreateDirectory(@"C:\files\males");
            string file = @"C:\files\males\Names.txt";
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine("Lê Tấn");
            sw.WriteLine("Trụ");

            sw.Close();
        }
    }
}
