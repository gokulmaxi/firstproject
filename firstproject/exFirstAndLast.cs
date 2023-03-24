using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class exFirstAndLast
    {
        string str;
        public exFirstAndLast(string str)
        {
            this.str = str;
        }
        public string exchange()
        {
            return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0] ;
        }
    }
}
