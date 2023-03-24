using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class StringOk
    {
        string str;
        public StringOk(string str) {
            this.str = str;
        }
        public string findAndRemoveOK()
        {
            findAndRemoveOK:
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str.Substring(i, 2) == "ok")
                {
                    str =str.Substring(0,i) +
                        str.Substring(i+2,str.Length-(i+2));
                }
            }
            if (str.Contains("ok")) goto findAndRemoveOK;
            return str;
        }
    }
}
