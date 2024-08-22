using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Book {
   public class Aptech : Book {
        private string language;
        private int semester;
        public Aptech() {}
        public Aptech(string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, string semester)
                     : base(bookName, bookAuthor, producer, yearPublishing, price) {
            this.language = language;
            this.semester = semester;
        }
        public string _language {
            get { return language; }
            set { language = value; }
        }
        public string _semester {
            get { return semester; }
            set { semester = value; }
        }
        public virtual void input() {
            base.input();
            Console.Write("Enter language: ");
            this.language = Console.ReadLine();
            Console.Write("Enter semester: ");
            this.semester = Console.ReadLine();
        }

        public virtual void display() {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", this.bookName, this.bookAuthor,
                            this.producer, this.yearPublishing, this.price, this.language, this.semester);
        }
    }
}