using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface IIntegralCalculator
    {
        double Calculate(double a, double b, int n);
    }
}
