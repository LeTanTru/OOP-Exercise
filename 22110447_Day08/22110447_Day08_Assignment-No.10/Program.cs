using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day08_Assignment_No._10 {
    class Program {
        static void Main(string[] args) {
            string plainText = string.Empty;
            int shift;
            Console.WriteLine("Enter a string: ");
            plainText = Console.ReadLine();
            shift = Convert.ToInt32(Console.ReadLine());
            Console.Write("After encrypting: ");
            char[] result = Encrypt(plainText, shift);
            for(int i =0; i < Encrypt(plainText, shift).Length; i++) {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }

        // Auto generated method to perform caesar cipher encryption
        public static char[] Encrypt(string plainText, int shift) {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for(int i = 0; i < plainArray.Length; i++) {
                char letter = plainArray[i];
                if(letter != ' ') {
                    letter = (char)(letter + shift);
                    if(letter > 'z') {
                        letter = (char)(letter - 26);
                    } else if(letter < 'a') {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }
    }
}
