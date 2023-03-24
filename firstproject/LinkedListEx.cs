using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class LinkedListEx
    {
        public LinkedListEx()
        {
            LinkedList<int> ints = new LinkedList<int>();
            ints.AddLast(0);
            ints.AddLast(1);
            ints.AddLast(2);
            ints.AddLast(3);
            ints.AddLast(2);
            ints.AddLast(5);
            ints.AddAfter(ints.Find(4), 6);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
