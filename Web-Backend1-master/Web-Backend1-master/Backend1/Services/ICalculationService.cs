using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public interface ICalculationService
    {
        int Addition(int num1, int num2);

        int Substraction(int num1, int num2);

        int? Division(int num1, int num2);

        int Multiplication(int num1, int num2);
    }
}
