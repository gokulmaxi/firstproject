using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class AssesHero
    {
        string name;
        int bulletCount;
        int bulletDecrement;
        public AssesHero(string name,int bulletCount,int bulletDecrement) {
            this.name = name;
            this.bulletCount = bulletCount;
            this.bulletDecrement = bulletDecrement;
        }
        public bool shoot()
        {
            if (this.bulletCount > this.bulletDecrement)
            {
                this.bulletCount = this.bulletCount - this.bulletDecrement;
                Console.WriteLine(name + " has shot with " + bulletDecrement + " bullets");
                Console.WriteLine("Now " + name + " has " + bulletCount + " left");
                Console.WriteLine("=====>");
                return false;
            }
            else
            {
                Console.WriteLine(name+" has no more bullets to shoot");
                return true;
            }
        }
    }
}
