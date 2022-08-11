using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    public interface ICalculator
    {
        int FirstValue { get; }
        int SecondValue { get; }
        int? ThirdValue { get; }
        int? FourthValue { get; }
        int ResultValue { set; }
        public int AddFunction()
        {
            return FirstValue;
        }

    }
}
