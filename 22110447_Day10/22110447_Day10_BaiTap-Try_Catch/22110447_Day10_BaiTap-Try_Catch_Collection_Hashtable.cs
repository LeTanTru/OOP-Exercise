using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22110447_Day10_BaiTap_Try_Catch {
    internal class _22110447_Day10_BaiTap_Try_Catch_Collection_Hashtable {

        public void Run() {


            Hashtable hst = new Hashtable(); hst.Add(981, "Cuong"); hst.Add(002, "Minh");
            hst.Add(003, "Khoi");
            Console.WriteLine("So luong thanh phan trong hash tbl" + hst.Count); ICollection obClec = hst.Keys;
            Console.WriteLine("Gia tri ban dau: ");
            foreach(int i in obClec) {
                Console.WriteLine(i + ": " + hst[i]);
            }
            if(hst.ContainsKey(002)) { hst[802] = "Thanh"; }
            Console.WriteLine("Gia tri moi:");
            foreach(int i in obClec) {
                Console.WriteLine(i + " : " + hst[i]);


                Console.ReadKey();
            }
        }

    }
}
