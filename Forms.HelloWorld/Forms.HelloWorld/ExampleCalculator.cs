using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.HelloWorld
{
    public class ExampleCalculator : ICalculator
    {
        public int Add(int augend, int addend)
        {
            return augend + addend;
        }

        public int Subtract(int minuend, int subtrahend)
        {   
            return minuend - subtrahend;
        }
    }
}
