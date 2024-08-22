using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day03_OperatorOvrldDemo {
    internal class OperatorOvrldDemo {
        private int intX;
        private int intY;
        public OperatorOvrldDemo() { }
        public OperatorOvrldDemo(int intI, int intJ) {
            intX = intI;
            intY = intJ;
        }

        public void ShowXY() {
            Console.WriteLine(intX + " " + intY);
        }

        public static OperatorOvrldDemo operator +(OperatorOvrldDemo objCom1, OperatorOvrldDemo objCom2) {
            OperatorOvrldDemo objCom = new OperatorOvrldDemo();
            objCom.intX = objCom1.intX + objCom2.intX;
            objCom.intY = objCom1.intY + objCom2.intY;
            return objCom;
        }

    }
}
