using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApprox
{
    /// <summary>
    /// класс для сглаживания методом наименьших квадратов
    /// </summary>
    public class LeastSquares
    {
        /// <summary>
        /// подсчёт коэффициентов многочлена
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="polynomialDegree"></param>
        /// <returns></returns>
        public float[] CalculateCoeff(double[,] numbers, int polynomialDegree)
        {
            double[] c = new double[polynomialDegree * 2 + 1];
            double[] d = new double[polynomialDegree + 1];

            for (int m = 0; m < c.Length; m++)
                for (int i = 0; i < numbers.GetLength(1); i++)
                    c[m] += Math.Pow(numbers[0, i], m);

            for (int j = 0; j < d.Length; j++)
                for (int i = 0; i < numbers.GetLength(1); i++)
                    d[j] += numbers[1, i] * Math.Pow(numbers[0, i], j);

            float[,] newNumbers = new float[polynomialDegree + 1, polynomialDegree + 2];

            for (int k = 0; k < d.Length; k++)
                newNumbers[k, polynomialDegree + 1] = (float)d[k];


            int indexC;
            for (int k = 0; k < newNumbers.GetLength(1) - 1; k++)
            {
                indexC = k;
                for (int j = 0; j < newNumbers.GetLength(1) - 1; j++)
                {
                    newNumbers[k, j] = (float)c[indexC];
                    indexC++;
                }
            }


            Matrix matrix = new Matrix(newNumbers);
            GausMethod gausMethod = new GausMethod();
            return gausMethod.GetResultMainElement(matrix);

        }

        /// <summary>
        /// выполнение смещения, возвращает новые значения f(x)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="polynomialDegree"></param>
        /// <returns></returns>
        public double[] ApplySmoothing(double[,] numbers, int polynomialDegree)
        {
            double[] smoothingY = new double[numbers.GetLength(1)];
            float[] a = CalculateCoeff(numbers, polynomialDegree);
            double newY = 0;
            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                newY = 0;
                for (int k = polynomialDegree; k >= 0; k--)
                    newY += a[k] * Math.Pow(numbers[0, i], k);
                smoothingY[i] = newY;
            }
            return smoothingY;
        }
        public double[] ApplySmoothing(double[,] numbers, int polynomialDegree, double[] coeffOfPolynomial)
        {
            double[] smoothingY = new double[numbers.GetLength(1)];

            double newY = 0;
            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                newY = 0;
                for (int k = 0; k < polynomialDegree + 1; k++)
                    newY += coeffOfPolynomial[k] * Math.Pow(numbers[0, i], polynomialDegree - k);
                smoothingY[i] = newY;
            }
            return smoothingY;
        }
    }
}
