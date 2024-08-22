using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance {
    internal class Program {
        public static void Main(string[] args) {
            Boss boss = new Boss("John", "Smith", 11, 2, 1995, 13, 7, 2010, 800) ;

            CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jones", 17, 3, 1997, 15, 9, 2012, 400, 3, 150);

            PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", 25, 6, 1999, 23, 7, 2013,Convert.ToDecimal(2.5), 200);
            
            HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price", 10, 4, 2000, 28, 2, 2015,Convert.ToDecimal(13.75), 50);

            Employee employee = boss;

            //string output = GetString(employee) + boss + "Earned " + boss.Earnings().ToString("C") + "\n\n";
            string output = GetString(employee) + "\n\n";

            employee = commissionWorker;

            //output += GetString(employee) + commissionWorker + "Earned " + commissionWorker.Earnings().ToString("C") + "\n\n";
            output += GetString(employee) + "\n\n";

            employee = pieceWorker;

            //output += GetString(employee) + pieceWorker + "Earned " + pieceWorker.Earnings().ToString("C") + "\n\n";
            output += GetString(employee) + "\n\n";

            employee = hourlyWorker;

            //output += GetString(employee) + hourlyWorker + "Earned " + hourlyWorker.Earnings().ToString("C") + "\n\n";

            output += GetString(employee) + "\n\n";

            MessageBox.Show(output, "Demonstrating Polymorphism", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Form1 f = new Form1();
            //f.ShowDialog();
        }

        public static string GetString(Employee worker) {
            return worker.ToString() + "Earned " + worker.Earnings().ToString("C") + "\n";
        }
    }
}
