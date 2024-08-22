using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_OperatorOvrldDemo {
    internal class Program {

        static void Main(string[] args) {
            OperatorOvrldDemo objCom1 = new OperatorOvrldDemo(10, 20);

            objCom1.ShowXY();
            OperatorOvrldDemo objCom2 = new OperatorOvrldDemo(30, 40);
            objCom2.ShowXY();
            OperatorOvrldDemo objCom3 = new OperatorOvrldDemo();
            objCom3 = objCom1 + objCom2;
            objCom3.ShowXY();
        }
    }
}
