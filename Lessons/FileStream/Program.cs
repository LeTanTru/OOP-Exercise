using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamTest {

    internal class Program {
        static void Main(string[] args) {
            //DriveInfo drive = new DriveInfo(@"C");
            //var drives = DriveInfo.GetDrives();

            //foreach(var drive in drives) {
            //    Console.WriteLine($"Drive: {drive.Name}");
            //    Console.WriteLine($"Drive type: {drive.DriveType}");
            //    Console.WriteLine($"Drive label: {drive.VolumeLabel}");
            //    Console.WriteLine($"Drive format: {drive.DriveFormat}");
            //    Console.WriteLine($"Drive size: {drive.TotalSize / (Math.Pow(2, 30))}GB");
            //    Console.WriteLine($"Drive freespace: {drive.TotalFreeSpace / (Math.Pow(2, 30))}GB");
            //}

            //FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);
            //StreamWriter streamWriter = new StreamWriter(fs);
            //streamWriter.Write("This is a string.");
            //streamWriter.Flush();
            //streamWriter.Close();

            //fs = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite);
            //StreamReader streamReader = new StreamReader(fs);
            //var str = streamReader.ReadToEnd();

            //Console.WriteLine(str);

            //streamReader.Close();

            //FileStream fs2 = new FileStream("test1.txt", FileMode.Create, FileAccess.ReadWrite);
            //BinaryWriter binaryWriter = new BinaryWriter(fs2);

            //binaryWriter.Write(325245435);

            //fs2.Close();

            //fs2 = new FileStream("test1.txt", FileMode.Open, FileAccess.ReadWrite);

            //BinaryReader binaryReader = new BinaryReader(fs2);
            //var n = binaryReader.ReadInt32();

            //Console.WriteLine(n);

            //fs2.Close();

            //using(FileStream fs = new FileStream("test2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)) {
            //    BinaryWriter binaryWriter = new BinaryWriter(fs);
            //    binaryWriter.Write(19241321);
            //    StreamWriter streamWriter = new StreamWriter(fs);
            //    streamWriter.Write("new text");
            //    streamWriter.Flush();
            //}

            //using(var fs = new FileStream("test2.txt", FileMode.Open, FileAccess.Read)) {
            //    BinaryReader binaryReader = new BinaryReader(fs);
            //    var n = binaryReader.ReadInt32();
            //    Console.Write(n);

            //    StreamReader streamReader = new StreamReader(fs);

            //    var str = streamReader.ReadToEnd();
            //    Console.Write(str);
            //}

            //string fileName = "test.txt";
            //int i = (new Random()).Next(50);
            //File.Delete(fileName);
            //string content = "";
            //    content += $"This is a new string {i++}.\n";

            //File.WriteAllText(fileName, content);

            Product product = new Product();

            string filePath = "test.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);

            product.Restore(fs);

            Console.WriteLine($"{product.ID} - {product.Price} - {product.Name}");

            fs.Close();
        }
    }
}
