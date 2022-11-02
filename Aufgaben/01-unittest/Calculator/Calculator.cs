using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }


        public int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
        }



        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                throw new ArgumentException();
            }

            return dividend / divisor;
        }



    }
}

