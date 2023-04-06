using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace firstproject
{
    internal class NicoCipher
    {
        
        public NicoCipher() {
            string message = "mubashirhassan";
            string key = "crazy";
           Console.WriteLine( NicoCipherFunc(key,message));
        }
        private List<string> splitString(string str,int length) {
            List<string> result = new List<string>();
            int strLength = str.Length;
            int index = 0;
            while (true)
            {
                // can use minimum function to emulate the same without if-else
                if (strLength - index > length)
                {
                   string subStringGroup = str.Substring(index, length); 
                    result.Add(subStringGroup);
                    index = (length) + index;
                }
                else
                {
                    result.Add(str.Substring(index));
                    break;
                }
            }
            return result;
        }
        private List<int> findNumFromKey(string key)
        {
            List<int> result = new List<int>();
            List<char> sortedKey = key.OrderBy(c => c).ToList();
            foreach (var item in sortedKey)
            {
                result.Add(key.IndexOf(item)+1);
            }
            return result;
        }
        private string ciperAWord(string word,List<int> ciperKey)
        {
            string ciperWord = "";
            foreach (var item in ciperKey)
            {
                if (word.Count()>=item)ciperWord += word[item-1];
                else ciperWord += " ";
            }
            return ciperWord;
        }
        private string NicoCipherFunc(string key,string message)
        {
            string result = "";
            List<string> groupedString = splitString(message, key.Length);
            List<int> ciperKey = findNumFromKey(key);
            foreach (var item in groupedString)
            {
                string ciperedWord = ciperAWord(item, ciperKey);
                result += ciperedWord;
            }
            return result;
        }
    }
    
}
