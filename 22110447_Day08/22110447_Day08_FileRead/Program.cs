using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_FileRead {
    class Program {
        static void Main(string[] args) {
            string file = @"C:\files\males\Names.txt";
            Console.OutputEncoding = Encoding.UTF8;
            System.IO.StreamReader sr = new System.IO.StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File ended");
            sr.Close();
        }
    }
}
