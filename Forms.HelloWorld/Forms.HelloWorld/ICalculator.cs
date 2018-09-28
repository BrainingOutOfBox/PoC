using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.HelloWorld
{
    public interface ICalculator
    {
        int Add(int augend, int addend);
        int Subtract(int minuend, int subtrahend);
    }
}
