using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1_1
{
    internal interface ICalculator
    {
        double FirstValue { get; set; }
        double SecondValue { get; set; }
        internal double AdditionMethod() { return FirstValue + SecondValue; }
        internal double SubtractionMethod() { return FirstValue - SecondValue; }
        internal double MultiplicationMethod() { return FirstValue * SecondValue; }
        internal double DivisionMethod() { return FirstValue / SecondValue; }
    }
}
