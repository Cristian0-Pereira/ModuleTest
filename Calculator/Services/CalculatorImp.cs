using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorImp
    {
        public int Add(int n1, int n2) => n1 + n2;
        
        public bool IsPair(int num) => num % 2 == 0;
    }
}