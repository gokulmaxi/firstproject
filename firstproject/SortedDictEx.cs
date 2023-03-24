using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class SortedDictEx

    {
        public SortedDictEx() { 
        SortedDictionary<string,string> Sd = new SortedDictionary<string,string>();
            Sd.Add("a", "apple");
            Sd.Add("b", "ball");
            Sd.Add("c", "cat");
            Sd.Add("d", "dog");
            Sd.Add("1", "one");
            Sd.Add("2", "");
            foreach (var key in Sd)
            {
                Console.WriteLine(key.Key+":"+key.Value);
            }
            foreach(var item in Sd.OrderBy(x => x.Value))
            {
                if(item.Value == "one")
                {
                    Sd.Remove(item.Key);
                }
            }
            foreach (var key in Sd)
            {
                Console.WriteLine(key.Key+":"+key.Value);
            }
        }
    }
}
