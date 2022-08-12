using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1_1
{
    public interface ICalculator
    {
        decimal? FirstValue { get; set; }
        decimal? SecondValue { get; set; }
        public decimal? AdditionMethod();// { return FirstValue + SecondValue; }
        public decimal? SubtractionMethod();// { return FirstValue - SecondValue; }
        public decimal? MultiplicationMethod();// { return FirstValue * SecondValue; }
        public decimal? DivisionMethod();// { return FirstValue / SecondValue; }
    }
}
