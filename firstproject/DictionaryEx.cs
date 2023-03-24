using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class DictionaryEx
    {
        public DictionaryEx() { 
        Dictionary<int,string > keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1, "prabhu");
            keyValuePairs.Add(2, "asd");
            keyValuePairs.Add(3, "dsf");
            keyValuePairs.Add(4, "hid");
            keyValuePairs.Add(5, "gist");
         keyValuePairs.Remove(1);
            keyValuePairs[5] = "NOt";
            foreach(KeyValuePair<int,string> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key +":" +pair.Value);
            }
        }
    }
}
