using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    delegate void delegateForSum(int x,int y);
    internal class DelegateEx
    {
        public DelegateEx(int x,int y) {
            delegateForSum d1=sumTest;
            d1(1, 2);
            d1.Invoke(3, 5);

        }
        public void sumTest(int x,int y) { 
        Console.WriteLine(x+y);
        }
    }
}
