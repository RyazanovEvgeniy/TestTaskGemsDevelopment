using System;

namespace QuadraticEquation
{
    public class Calc
    {
        public Calc()
        {

        }

        // Метод решения квадратного уровнения
        // Возвращающий массив ответов
        public double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
                return null;
            else
            {
                double[] result = new double[2];

                result[0] = (-b + Math.Sqrt(D)) / (2 * a);
                result[1] = (-b - Math.Sqrt(D)) / (2 * a);

                return result;
            }
        }

    }
}