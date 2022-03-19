using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа - калькулятор.");
            Console.WriteLine("Основыне дейтвия: +, -, *, /, ^");
            Console.WriteLine("'+' - сложение,");
            Console.WriteLine("'-' - вычитание,");
            Console.WriteLine("'*' - умножение,");
            Console.WriteLine("'/' - деление,");
            Console.WriteLine("'^' - возведение в степень.");
            Console.WriteLine("Числа с плавающей запятой вводятся через ','.");
            Console.WriteLine();

            ICalculator calc = new Calculator();

            string inputValue;
            Console.Write("Введите первое число: ");
            inputValue = Console.ReadLine();
            double numberFirst = calc.CheckIsNumber(inputValue);

            Console.Write("Введите второе число: ");
            inputValue = Console.ReadLine();
            double numberSecond = calc.CheckIsNumber(inputValue);

            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();
            calc.CheckIsOperation(operation);
            switch (operation)
            {
                case "+":
                    {
                        calc.PrintResult(calc.Addition(numberFirst, numberSecond));
                        break;
                    }

                case "-":
                    {
                        calc.PrintResult(calc.Subtraction(numberFirst, numberSecond));
                        break;
                    }

                case "*":
                    {
                        calc.PrintResult(calc.Multiplication(numberFirst, numberSecond));
                        break;
                    }

                case "/":
                    {
                        calc.PrintResult(calc.Division(numberFirst, numberSecond));
                        break;
                    }

                case "^":
                    {
                        calc.PrintResult(calc.Exponentiation(numberFirst, numberSecond));
                        break;
                    }
            }
        }
    }
}
