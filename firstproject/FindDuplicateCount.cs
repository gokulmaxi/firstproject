using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class FindDuplicateCount<T>
    {
        T[] arr;
        public FindDuplicateCount(T[] arr)
        {
            this.arr = arr;
        }
        public int GetCount()
        {
            int dupCount = 0;
            Hashtable hashtable = new Hashtable();
            foreach (var item in arr)
            {
                if (hashtable.ContainsKey(item))
                {
                    hashtable[item] = (int)hashtable[item]+1;
                }
                else
                {
                    hashtable.Add(item, 0);
                }
            }
            foreach (var item in hashtable.Keys)
            {
                dupCount = (int)hashtable[item] + dupCount;
            }
            return dupCount;
        }
    }
}
