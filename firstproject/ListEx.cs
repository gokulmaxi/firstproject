using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class ListEx
    {
        public ListEx() {
            var ListDemo = new List<string>();
            ListDemo.Add("Hello");
            ListDemo.Add("Hello1");
            ListDemo.Add("Hello2");
            ListDemo.Add("Hello3");
            ListDemo.Add("Hello4");
            foreach (var item in ListDemo)
            {
                Console.WriteLine(item);
            }
            ListDemo.Remove("Hello4");
            foreach (var item in ListDemo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
