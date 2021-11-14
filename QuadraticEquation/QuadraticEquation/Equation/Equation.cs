using System;

namespace QuadraticEquation
{
    // Класс Квадратного уравнения
    public class Equation
    {
        // Свойства уравнения формата: a*x^2 + b*x + c = 0
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        // Простой конструктор
        public Equation() { }

        // Конструктор с задачей всех параметров
        public Equation(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Перегрузка Equals, для сравнения идентичности уравнений в тестах
        public override bool Equals(object obj)
        {
            return obj is Equation equation &&
                   a == equation.a &&
                   b == equation.b &&
                   c == equation.c;
        }

        // Так же для тестов, вдруг пригодится
        public override int GetHashCode()
        {
            return HashCode.Combine(a, b, c);
        }
    }
}