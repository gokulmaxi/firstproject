using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class GenericMethodEx
    {
        public void TestFunction<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}
