using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Services
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException();

            return x / y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
