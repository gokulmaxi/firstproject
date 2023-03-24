using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class AddFAndB
    {
        string str;
        public AddFAndB(string str)
        {
            this.str = str;
        }
        public string addFandB()
        {
            if(str.Length <= 1)return str;
            return str[str.Length - 1] + str + str[str.Length-1] ;
        }
    }
}
