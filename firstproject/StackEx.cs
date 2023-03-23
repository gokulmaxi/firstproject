using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class StackEx
    {
        public StackEx() { 
        Stack<string> stack1= new Stack<string>();
        stack1.Push("A");
        stack1.Push("B");
        stack1.Push("C");
        foreach (string s in stack1)
        {
            Console.WriteLine(s);
        }
        stack1.Pop();
        Console.WriteLine("after pop");
        foreach (string s in stack1)
        {
            Console.WriteLine(s);
        }
        }
    }
}
