using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        double CheckIsNumber(in string row);
        void CheckIsOperation(in string row);
        double Addition(in double numberFirst, in double numberSecond);
        double Subtraction(in double numberFirst, in double numberSecond);
        double Multiplication(in double numberFirst, in double numberSecond);
        double Division(in double numberFirst, in double numberSecond);
        double Exponentiation(in double numberFirst, in double numberSecond);
        void PrintResult(in double result);
    }
}
