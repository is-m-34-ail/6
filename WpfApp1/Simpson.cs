using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class SimpsonIntegralCalculator : IIntegralCalculator
    {
        private Func<double, double> _function;

        public SimpsonIntegralCalculator(Func<double, double> function)
        {
            _function = function;
        }

        public double Calculate(double a, double b, int n)
        {
            if (n % 2 != 0) n++; // n должно быть чётным для Симпсона
            double h = (b - a) / n;
            double sum = _function(a) + _function(b);
            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += (i % 2 == 0 ? 2 : 4) * _function(x);
            }
            return sum * h / 3.0;
        }
    }
}
