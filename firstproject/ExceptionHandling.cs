﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class ExceptionHandling
    {
        int a = 10;
        int b = 0;
        public ExceptionHandling() {
            try
            {
                int c = a / b;
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("Dividing by zero");
            }
            catch(Exception e) {
                Console.WriteLine("General exception called");
            }
            finally {
                Console.WriteLine("finally called");
            }
        }
    }
}
