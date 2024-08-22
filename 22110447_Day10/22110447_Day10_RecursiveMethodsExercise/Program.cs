using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_RecursiveMethodsExercise {
    internal class Program {
        static void Main(string[] args) {
            string path = string.Empty;
            path = @"C:\Languages";
            Console.WriteLine(path);
            DisplayFolders(path, 0);

        }
        public static void DisplayFolders(string path, int indent) {
            foreach(var folder in Directory.GetDirectories(path)) {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder, indent + 2);
            }
        }

    }
}
