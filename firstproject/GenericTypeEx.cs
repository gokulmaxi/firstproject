using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class GenericTypeEx<T>
    {
        public GenericTypeEx(T t) { 
        Console.WriteLine(t);
        }
    }
}
