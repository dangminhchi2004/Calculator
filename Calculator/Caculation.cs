using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Caculation
    {
        private int  a, b;
        public Caculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Exectute(string operation)
        {
            int result = 0;
            switch(operation)
            {
                case "+":
                    result = a+b;
                    break;
                case "-":
                    result = a-b;
                    break;
                case "*":
                    result = a*b;
                    break;
                case "/":
                    result = a/b;
                    break;

            }
            return result;
        }

        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if(n>0)
                return n * Power(x, n - 1);
            else
                return Power(x, n+1) / x;
        }
    }
}
