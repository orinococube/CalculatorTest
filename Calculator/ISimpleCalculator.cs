using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public  interface ISimpleCalculator
    {
        public int Add(int start, int amount);
        public int Subtract(int start, int amount);
        public int Multiply(int start, int by);
        public float Divide(int start, int by);
    }
}
