using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class InbuiltDelegates
    {
        delegate void printSomeStuff();
        public InbuiltDelegates() {
            printSomeStuff d= HelloWorld;
            d.Invoke();
            Action<string> s2=(msg) => Console.WriteLine(msg);
        }
        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }

}
