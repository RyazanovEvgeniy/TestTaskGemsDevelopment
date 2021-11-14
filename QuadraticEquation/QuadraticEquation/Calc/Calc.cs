using System;
using System.Collections.Generic;

namespace QuadraticEquation
{
    // Статический класс Calc с методами решения математических задач проекта
    public static class Calc
    {
        // Статический метод решения квадратного уровнения
        // Возвращающий массив ответов
        public static bool SolveQuadraticEquation(double a, double b, double c, out List<double> result)
        {
            // Объявляем лист куда будем записывать результат
            result = new List<double>();

            // Ищем дискременант уравнения
            double D = Math.Pow(b, 2) - 4 * a * c;
            
            // Если он не отрицательный
            if (D >= 0.0)
            {
                // И больше нуля
                if (D > 0.0)
                {
                    // Тогда добавляем два ответа
                    result.Add((-b + Math.Sqrt(D)) / (2 * a));
                    result.Add((-b - Math.Sqrt(D)) / (2 * a));
                }
                // Иначе один
                else
                    result.Add(-b / (2 * a));
                // Возвращаем единицу, так как уравнение имеет решение
                return true;
            }
            // Иначе возвращаем ноль, так как уравнение не имеет решения 
            else
                return false;
        }

    }
}