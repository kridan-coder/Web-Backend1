using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public class CalculationService : ICalculationService
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int? Division(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch
            {
                return null;
            }
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
