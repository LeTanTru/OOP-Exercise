using System;
using first_namespace;
using first_namespace.second_namespace;
namespace first_namespace {
    class abc {
        public void func() {
            Console.WriteLine("Ben trong namespace thu nhat!");
        }
    }
    namespace second_namespace {
        class def {
            public void func() {
                Console.WriteLine("Ben trong namespace thu hai!");
            }
        }
    }
}
