using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Book {
    public class Book {
        private string bookName;
        private string bookAuthor;
        private string producer;
        private int yearPublishing;
        private float price;

        public Book() {}
        public Book(string bookName, string bookAuthor, string producer,  int yearPublishing, float price) {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.producer = producer;
            this.yearPublishing = yearPublishing;
            this.price = price;
        }

        public string _bookName {
            get { return this.bookName; }
            set { this.bookName = value; }
        }
        public string _bookAuthor {
            get { return this.bookAuthor; }
            set { this.bookAuthor = value; }
        }
        public string _producer {
            get { return this.producer; }
            set { this.producer = value; }
        }
        public int _yearPublishing {
            get { return this.yearPublishing; }
            set { this.yearPublishing = value; }
        }
        public float _price {
            get { return this.price; }
            set { this.price = value; }
        }

        public virtual void input() {
            Console.Write("Enter book name: ");
            this.bookName = Console.ReadLine();
            Console.Write("Enter book author: ");
            this.bookAuthor = Console.ReadLine();
            Console.Write("Enter producer: ");
            this.producer = Console.ReadLine();
            Console.Write("Enter year publishing: ");
            this.yearPublishing = int.Parse(Console.ReadLine());
            Console.Write("Enter price: ");
            this.price = float.Parse(Console.ReadLine());
        }

        public virtual void display() {
            Console.WriteLine("{0} {1} {2} {3} {4}", this.bookName, this.bookAuthor,
                            this.producer, this.yearPublishing, this.price);
        }
    }
}



