using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWindowsChas
{
    public class Operation_Units
    {
        public static decimal Add(decimal firstnNumber, decimal secondNumber)
        {
            return firstnNumber + secondNumber;
        }
        public static decimal Substract(decimal firstnNumber, decimal secondNumber)
        {
            return firstnNumber - secondNumber;
        }
        public static decimal Multiply(decimal firstnNumber, decimal secondNumber)
        {
            return firstnNumber * secondNumber;
        }
        public static decimal Divide(decimal firstnNumber, decimal secondNumber)
        {
            return firstnNumber / secondNumber;
        }
        public static decimal Square(decimal number)
        {
            return number * number;
        }
        public static decimal SquareRoot(decimal number)
        {
            return (decimal)Math.Sqrt((double)number);
        }
        public static decimal Reciprocal(decimal number)
        {
            return 1 / number;
        }

    }
}
