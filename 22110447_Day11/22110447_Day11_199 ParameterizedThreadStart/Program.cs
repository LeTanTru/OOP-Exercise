using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22110447_Day11_ParameterizedThreadStart {
    internal class Program {
        static void Main(string[] args) {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(500);
        }
    }
    class Helper {
        public void Loop(object number) {
            for(int i = 0; i < int.Parse(number.ToString()); i++) {
                Console.WriteLine(i);
            }
        }
    }

}
