using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LabApprox
{
    internal class NewtonTable
    {
        internal int n;
        double[][] table;

        internal NewtonTable(List<(double x, double y)> points)
        {
            n = points.Count();
            table = new double[n][];
            for (int i = 0; i < n; i++)
            {
                table[i] = new double[n - i + 1];
                table[i][0] = points[i].x;
                table[i][1] = points[i].y;
            }
        }

        internal void Fill()
        {
            for (int j = 2; j < n + 1; j++)
                for (int i = 0; i < n - j + 1; i++)
                    table[i][j] = (table[i + 1][j - 1] - table[i][j - 1]) / (table[i + j - 1][0] - table[i][0]);
        }

        internal double[][] AddPoint(double x, double y)
        {
            foreach (var j in table)
                if (j[0] == x)
                    return table;
            int newN = n + 1;
            double[][] newTable = new double[newN][];
            for (int i = 0; i < n; i++)
            {
                newTable[i] = new double[newN - i + 1];
                for (int j = 0; j < table[i].Length; j++)
                    newTable[i][j] = table[i][j];

            }
            newTable[n] = new double[2];
            newTable[n][0] = x;
            newTable[n][1] = y;
            for (int j = 2; j < newN + 1; j++) // column
                newTable[newN - j][j] = (newTable[newN - j + 1][j - 1] - newTable[newN - j][j - 1]) / (newTable[newN - 1][0] - newTable[newN - j][0]);
            table = newTable;
            n = newN;
            return table;
        }

        internal double this[int row, int column] {
            get
            {
                return table[row][column];
            }
        }
    }

    public class Newton
    {
        NewtonTable table;


        public Newton(List<(double, double)> points)
        {
            table = new NewtonTable(points);
        }

        public double FuncValue(double x)
        {
            double sum = table[0, 1];//f(x0)
            for (int j = 2; j <= table.n; j++)//column
            {
                double mult = table[0, j];
                for (int i = 0; i < j - 1; i++)
                    mult *= x - table[i, 0];
                sum += mult;
            }
            return sum;
        }

        public void CalculateTable()
        {
            table.Fill();
        }

        public void AddToTable(double x, double y)
        {
            table.AddPoint(x, y);
        }
    }
}
