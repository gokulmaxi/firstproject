using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class QueueEx
    {
        public QueueEx() { 
        Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Deque");
            ints.Dequeue();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
