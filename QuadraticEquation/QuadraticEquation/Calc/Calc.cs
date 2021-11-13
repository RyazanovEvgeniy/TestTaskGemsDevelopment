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
        public bool SolveQuadraticEquation(double a, double b, double c, out double[] result)
        {
            result = new double[2];

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D >= 0)
            {
                result[0] = (-b + Math.Sqrt(D)) / (2 * a);
                result[1] = (-b - Math.Sqrt(D)) / (2 * a);
                return true;
            }
            else
                return false;
        }

    }
}