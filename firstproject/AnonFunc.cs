using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class AnonFunc
    {
        public AnonFunc()
        {

            List<int> li1 = new List<int>() { 1, 2, 3, 4, 5, 6, 10 };
            List<int> numbersDivisibleByFive = li1.FindAll(n => n % 5 == 0);

            foreach (var item in numbersDivisibleByFive)
            {
                Console.WriteLine(item);
            }

            List<string> lisStr = new List<string>() { "apple", "ball", "cat" };
            List<string> ascOrder = lisStr.OrderBy(x => x).ToList();

            List<string> containsl = lisStr.FindAll(str => str.Contains("l"));
            foreach (var item in containsl)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(5, "zapple");
            dict.Add(4, "dball");
            dict.Add(3, "wcat");

            foreach (var item in dict.OrderBy(x => x.Value).ToList())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (var item in dict.OrderBy(x => x.Key * -1).ToList())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
