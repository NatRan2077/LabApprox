using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LabApprox
{
    public class Lagranz
    {
        internal int n;
        private List<double> _x;
        private List<double> _y;
        public Lagranz(List<(double x, double y)> points)
        {
            n = points.Count;
            _x = new List<double>(n);
            _y = new List<double>(n);

            for (int i = 0; i < n; i++)
            {
                _x.Add(points[i].x);
                _y.Add(points[i].y);
            }
        }

        public void AddPoint(double x, double y)
        {
            _x.Add(x);
            _y.Add(y);
        }

        public double FuncValue(double x)
        {
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                double numerator = 1.0;
                double denominator = 1.0;

                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        numerator *= (x - _x[j]);
                        denominator *= (_x[i] - _x[j]);
                    }
                }

                double omega = numerator / denominator;
                result += _y[i] * omega;
            }

            return result;
        }

    }
}
