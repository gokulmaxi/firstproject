using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class SplitEvenOdd
    {
        int[] arr;
        public List<int> evenList = new List<int>();
        public List<int> oddList = new List<int>();
        public SplitEvenOdd(int[] arr){
            this.arr = arr;
        }
        public void SplitArray()
        {
            foreach(int i in this.arr)
            {
                if (i % 2 == 0)
                    evenList.Add(i);
                else
                    oddList.Add(i); 
            }
        }
    }
}
