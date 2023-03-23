using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class SortedSetEx
    {
        public SortedSetEx() { 
        var sortedSet = new SortedSet<int>() { 5,6,7,4,3,2};
        var exampleSorted = new SortedSet<char>() { 'B', 'L' };
            foreach (var item in sortedSet)
            {
                Console.WriteLine("Int sorted"+item);
            }
            foreach (var item in exampleSorted)
            {
                Console.WriteLine("Char sorted" + item);
            }
        }
    }
}
