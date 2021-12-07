using System;
using System.Collections.Generic;

namespace Test
{
    // Класс Квадратного уравнения
    public struct QuadraticEquation
    {
        // Свойства уравнения формата: a*x^2 + b*x + c = 0
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        // Конструктор с задачей всех параметров
        public QuadraticEquation(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Solve(out List<double> result)
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