using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class UseddefEx:Exception
    {
        public UseddefEx(string message) : base(message) { 
        
        }
    }
    public class AgeLimitCheck
    {
        public AgeLimitCheck(int age) {
            if (age < 0) throw new UseddefEx("age cannot be less than 0");
        }
    }
}
