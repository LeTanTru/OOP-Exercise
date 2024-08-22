using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamTest {
    public class Product {
        public int ID { get; set; }
        public double Price { get; set; }

        public string Name { get; set; }

        public void Save(Stream stream) {
            var bytesID = BitConverter.GetBytes(ID);
            stream.Write(bytesID, 0, 4);

            var bytesPrice = BitConverter.GetBytes(Price);
            stream.Write(bytesPrice, 0, 8);

            var bytesName = Encoding.UTF8.GetBytes(Name);
            var bytesLength = BitConverter.GetBytes(bytesName.Length);
            stream.Write(bytesLength, 0, 4);
            stream.Write(bytesName, 0, bytesName.Length);

        }


        public void Restore(Stream stream) {
            var bytesID = new byte[4];
            stream.Read(bytesID, 0, 4);
            ID = BitConverter.ToInt32(bytesID, 0);

            var bytesPrice = new byte[8];
            stream.Read(bytesPrice, 0, 8);
            Price = BitConverter.ToDouble(bytesPrice, 0);

            var bytesLength = new byte[4];
            stream.Read(bytesLength, 0, 4);
            int length = BitConverter.ToInt32(bytesLength, 0);

            var bytesName = new byte[length];

            stream.Read(bytesName, 0, length);

            Name =Encoding.UTF8.GetString(bytesName, 0, length);
        }
    }
}
