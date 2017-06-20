using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B;
using C;

namespace A
{
    public static class ClassA
    {
        public static void Main()
        {
            Console.WriteLine("Hello, this is A");
            Console.WriteLine("It also use:");
            new ClassB().Run();
            new ClassC().Run();
        }
    }
}
