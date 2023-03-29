using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class AsyncEx
    {
        public static async Task<int> Method1()
        {
            Console.WriteLine("Method one started");
            await Task.Delay(1000);
            Console.WriteLine("Method one ");
            return 1;
        }
        public static async Task<int> Method2()
        {
            Console.WriteLine("Method two started");
            await Task.Delay(1000);
            Console.WriteLine("Method two");
            return 2;
        }
    }
}
