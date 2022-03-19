using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator: ICalculator
    {
        public double CheckIsNumber(in string row)
        {
            double number;
            bool success = double.TryParse(row, out number);
            if (!success)
            {
                Console.WriteLine("Вы ввели некорректное значение. Введите число.");
                Environment.Exit(0);
            }
            return number;
        }

        public void CheckIsOperation(in string row)
        {
            string multipleOperations = "+-*/^";
            int operation = multipleOperations.IndexOf(row);
            if (operation == -1)
            {
                Console.WriteLine("Вы ввели некорректное значение. Введите допустимую операцию.");
                Environment.Exit(0);
            }
        }

        public double Addition(in double numberFirst, in double numberSecond)
        {
            return numberFirst + numberSecond;
        }

        public double Subtraction(in double numberFirst, in double numberSecond)
        {
            return numberFirst - numberSecond;
        }

        public double Multiplication(in double numberFirst, in double numberSecond)
        {
            return numberFirst * numberSecond;
        }

        public double Division(in double numberFirst, in double numberSecond)
        {
            return numberFirst / numberSecond;
        }

        public double Exponentiation(in double numberFirst, in double numberSecond)
        {
            return Math.Pow(numberFirst, numberSecond);
        }

        public void PrintResult(in double result)
        {
            Console.WriteLine($"Ваш результат равен: {Math.Round(result, 2)}");
        }
    }
}
