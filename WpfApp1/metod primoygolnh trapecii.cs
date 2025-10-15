using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TrapezoidalIntegralCalculator : IIntegralCalculator
    {
        private Func<double, double> _function;
        public TrapezoidalIntegralCalculator(Func<double, double> function)
        {
            _function = function;
        }

        public double Calculate(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = (_function(a) + _function(b)) / 2.0;
            for (int i = 1; i < n; i++)
            {
                sum += _function(a + i * h);
            }
            return sum * h;
        }
    }
}
